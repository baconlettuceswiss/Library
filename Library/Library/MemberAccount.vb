Public Class MemberAccount
    Private Sub MemberAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'LibraryDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.LibraryDataSet.Resources)
        'TODO: This line of code loads data into the 'LibraryDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.LibraryDataSet.Checkout)
        Dim CheckoutPeriod As Long
        Dim NumberOfRows As Integer
        Dim CheckedOutRecord As Integer
        Dim bookInfo As Object
        Dim resourceID As String
        Dim ResourceStatus As String
        Dim DueDate As Date
        Dim Checkoutdate As Date
        Dim MemberID As String = Login.memberID
        Dim RowData As Object

        'Results.Rows.Clear()
        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckout(LibraryDataSet.Checkout, MemberID)

        If NumberOfRows > 0 Then

            Results.Visible = True

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookInfo = CheckoutTableAdapter.GetDataByMemberCheckout(MemberID)(x)
                resourceID = bookInfo.resourceID

                RowData = ResourcesTableAdapter.GetDataByResourceID(resourceID)(0)
                'calculate the due date for a book based on the check out date and the book’s checkout period.
                Checkoutdate = bookInfo.checkoutdate
                CheckoutPeriod = RowData.checkoutperiod
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, Checkoutdate)
                'at “due” to the due date so that the member knows when the book is due
                ResourceStatus = "Due " & DueDate.Date

                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add title to the first column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Title
                dgvRow.Cells.Add(dgvCell)

                'add author’s last name to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.AuthorLastName
                dgvRow.Cells.Add(dgvCell)

                'add publication date to the 3rd  column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.PublicationDate
                dgvRow.Cells.Add(dgvCell)

                'add series to the 4th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Series
                dgvRow.Cells.Add(dgvCell)

                'add checkout data to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Checkoutdate.Date
                dgvRow.Cells.Add(dgvCell)

                'add resourcestatus, created above, to the 6th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = ResourceStatus
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)


                Results.Rows.Add(dgvRow)
                'Results is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        End If


    End Sub

    Private Sub CheckoutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CheckoutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class