Public Class CreateAccount

    Dim MemberID As String
    Dim FirstName As String
    Dim LastName As String
    Dim Address As String
    Dim City As String
    Dim State As String
    Dim Zip As Integer
    Dim Email As String
    Dim Password As String
    Dim BookInfo As String



    Private Sub CheckoutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub AddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.LibraryDataSet.Members)
        'TODO: This line of code loads data into the 'LibraryDataSet.Resources' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.LibraryDataSet.Members)
        'TODO: This line of code loads data into the 'LibraryDataSet.Checkout' table. You can move, or remove it, as needed.




    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtFirstName.Text = String.Empty Or txtLastName.Text = String.Empty Or txtAddress.Text = String.Empty Or
            txtCity.Text = String.Empty Or txtZipcode.Text = String.Empty Or
            txtState.Text = String.Empty Or txtEmail.Text = String.Empty Or txtPassword.Text = String.Empty Then
            MessageBox.Show("Please Enter All the Required Information")
        Else
            FirstName = txtFirstName.Text
            LastName = txtLastName.Text
            Address = txtAddress.Text
            City = txtCity.Text
            State = txtState.Text
            Zip = txtZipcode.Text
            Email = txtEmail.Text
            Password = txtPassword.Text


            'random number between 200 and 300
            Dim LRandomNumber As Integer
            LRandomNumber = Int((100000 - 100000 + 1) * Rnd() + 100000)

            MemberID = "PLIV" & LRandomNumber.ToString

            MembersTableAdapter.InsertNewMember(MemberID, FirstName, LastName, Address, City, State, Zip, Email, Password)

            MessageBox.Show("Successfully Created Account")

            emptyBoxes()
        End If


    End Sub

    Private Sub emptyBoxes()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZipcode.Clear()
        txtEmail.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim LoginForm As Login
        LoginForm = New Login
        LoginForm.Show()
        Me.Visible = False
    End Sub

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub
End Class