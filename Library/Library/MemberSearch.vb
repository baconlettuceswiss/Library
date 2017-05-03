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

                MessageBox.Show(SearchResults.Rows(e.RowIndex).Cells(3).Value)
            End If
        End If

        If grid.Columns(e.ColumnIndex).Name = "Checkout" Then
            MessageBox.Show(SearchResults.Rows(e.RowIndex).Cells(2).Value)
        End If

        'SearchResults.Rows.Clear()
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

    Private Sub LoadDataGrid()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim EmployeeWelcomeForm As EmployeeWelcome
        EmployeeWelcomeForm = New EmployeeWelcome
        EmployeeWelcomeForm.Show()
        Me.Visible = False
    End Sub

    Private Sub btnTitleSearch_Click(sender As Object, e As EventArgs) Handles btnTitleSearch.Click
        SearchResults.Rows.Clear()
        Dim BookTitle As String = ("%" & tbTitle.Text & "%")
        'ResourcesTableAdapter.GetDataByTitle(BookTitle)

        'Results.Rows.Clear()
        NumberOfRows = ResourcesTableAdapter.FillByTitle(LibraryDataSet.Resources, BookTitle)

        If NumberOfRows > 0 Then

            SearchResults.Visible = True

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookInfo = ResourcesTableAdapter.GetDataByTitle(BookTitle)(x)
                resourceID = bookInfo.resourceID

                RowData = ResourcesTableAdapter.GetDataByResourceID(resourceID)(0)
                CheckoutPeriod = RowData.checkoutperiod

                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add ID to the 1st column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ResourceID
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                'add availability to the 3rd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "availability"
                Dim Availability As Boolean
                'CheckoutTableAdapter.Get
                dgvRow.Cells.Add(dgvCell)

                'add book info to the 4th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.BookInfo
                dgvRow.Cells.Add(dgvCell)

                'add Title to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Title
                dgvRow.Cells.Add(dgvCell)

                'add author to the 6th of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.AuthorFirstName & " " & RowData.AuthorLastName
                dgvRow.Cells.Add(dgvCell)

                'add Genre to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Subject1
                dgvRow.Cells.Add(dgvCell)

                'add ISBN to the 8th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ISBN
                dgvRow.Cells.Add(dgvCell)

                SearchResults.Rows.Add(dgvRow)
                'SearchResults is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("No items found using your search parameters")
        End If
    End Sub

    Private Sub btnAuthorSearch_Click(sender As Object, e As EventArgs) Handles btnAuthorSearch.Click
        SearchResults.Rows.Clear()
        'ResourcesTableAdapter.GetDataByAuthorLastName(tbAuthorSearch.Text)

        Dim AuthorLastName As String = ("%" & tbAuthorSearch.Text & "%")
        'ResourcesTableAdapter.GetDataByTitle(BookTitle)

        'Results.Rows.Clear()
        NumberOfRows = ResourcesTableAdapter.FillByAuthorLastName(LibraryDataSet.Resources, AuthorLastName)

        If NumberOfRows > 0 Then

            SearchResults.Visible = True

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookInfo = ResourcesTableAdapter.GetDataByAuthorLastName(AuthorLastName)(x)
                resourceID = bookInfo.resourceID

                RowData = ResourcesTableAdapter.GetDataByResourceID(resourceID)(0)
                CheckoutPeriod = RowData.checkoutperiod

                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add ID to the 1st column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ResourceID
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                'add availability to the 3rd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "availability"
                Dim Availability As Boolean
                'CheckoutTableAdapter.Get
                dgvRow.Cells.Add(dgvCell)

                'add book info to the 4th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.BookInfo
                dgvRow.Cells.Add(dgvCell)

                'add Title to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Title
                dgvRow.Cells.Add(dgvCell)

                'add author to the 6th of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.AuthorFirstName & " " & RowData.AuthorLastName
                dgvRow.Cells.Add(dgvCell)

                'add Genre to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Subject1
                dgvRow.Cells.Add(dgvCell)

                'add ISBN to the 8th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ISBN
                dgvRow.Cells.Add(dgvCell)

                SearchResults.Rows.Add(dgvRow)
                'SearchResults is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("No items found using your search parameters")
        End If
    End Sub
End Class