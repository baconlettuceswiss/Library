Public Class MemberSearch
    Dim CheckoutPeriod As Long
    Dim NumberOfRows As Integer
    Dim CheckedOutRecord As Integer
    Dim bookInfo As Object
    Dim resourceID As String
    Dim ResourceStatus As String
    Dim DueDate As Date
    Dim CheckoutDate As Date

    Dim MemberID As String = Login.memberID
    Dim RowData As Object
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub SearchResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchResults.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim grid = DirectCast(sender, DataGridView)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If grid.Columns(e.ColumnIndex).Name = "MoreInfo" Then
                resourceID = SearchResults.Rows(e.RowIndex).Cells(0).Value

                'ResourcesTableAdapter.RenewBookUpdateQuery(currentdate, resourceID)

                bookInfo = CheckoutTableAdapter.GetDataByMemberCheckout(MemberID)
                resourceID = bookInfo.resourceID

                'CheckoutPeriod = SearchResults.Rows(e.RowIndex).Cells(1).Value
                'DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, currentdate)
                'ResourceStatus = "Due " & DueDate.Date
                'SearchResults.Rows(e.RowIndex).Cells(6).Value = ResourceStatus
                'SearchResults.Rows(e.RowIndex).Cells(5).Value = currentdate

                MessageBox.Show("you have successfully renewed your book.", " Book Renewal Successful", MessageBoxButtons.OK)
            End If
        End If

        If grid.Columns(e.ColumnIndex).Name = "Checkout" Then
            'resourceID = SearchResults.Rows(e.RowIndex).Cells(0).Value
            'CheckoutTableAdapter.ReturnBookUpdateQuery(currentdate, resourceID)
            'SearchResults.Rows(e.RowIndex).Cells(6).Value = currentdate

            MessageBox.Show("you have successfully returned your book.", " Book Return Successful", MessageBoxButtons.OK)
        End If

        SearchResults.Rows.Clear()
        'LoadDataGrid()
    End Sub

    Private Sub ResourcesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ResourcesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub MemberSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.LibraryDataSet.Checkout)
        'TODO: This line of code loads data into the 'LibraryDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.LibraryDataSet.Resources)

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim WelcomeForm As WelcomePage
        WelcomeForm = New WelcomePage
        WelcomeForm.Show()
        Me.Visible = False
    End Sub
End Class