﻿Public Class Login
    Public Shared memberID As String
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim NumberOfRows As Integer
        Dim RowData As Object
        Dim Password As String = String.Empty
        If txtUsername.Text = String.Empty Or txtPW.Text = String.Empty Then
            MessageBox.Show("please enter your email and password")
        Else
            'how many records contain the email provided by the user?
            NumberOfRows = MembersTableAdapter.FillByEmail(LibraryDataSet.Members, txtUsername.Text)
            'if there is one existing record with the email then get the user's record with the getdataby method
            'and put the record (really point to the record) in the object "RowData" then get the email from the object.
            'The dataset's index names will match the names of the columns in the table. 
            'Thus RowData.Password points to the user's password
            If NumberOfRows = 1 Then

                RowData = MembersTableAdapter.GetDataByEmail(txtUsername.Text)(0)
                Password = RowData.Password

                'entered password = DB PW
                If Password = txtPW.Text Then
                    'MessageBox.Show("Login successful")

                    memberID = RowData.MemberID

                    Dim WelcomeForm As WelcomePage
                    WelcomeForm = New WelcomePage
                    WelcomeForm.Show()
                    Me.Visible = False
                    'txtbox PW != DB PW
                Else
                    MessageBox.Show("Login unsuccessful")
                    txtPW.Clear()
                End If

                'empty txtbox
            Else
                If txtUsername.Text = String.Empty Or txtPW.Text = String.Empty Then
                    MessageBox.Show("please enter your email and password")
                Else
                    'how many records contain the email provided by the user?
                    NumberOfRows = EmployeesTableAdapter.FillByEmployeeEmail(LibraryDataSet.Employees, txtUsername.Text)
                    'if there is one existing record with the email then get the user's record with the getdataby method
                    'and put the record (really point to the record) in the object "RowData" then get the email from the object.
                    'The dataset's index names will match the names of the columns in the table. 
                    'Thus RowData.Password points to the user's password
                    If NumberOfRows = 1 Then

                        RowData = EmployeesTableAdapter.GetDataByEmployeeEmail(txtUsername.Text)(0)
                        Password = RowData.Password

                        If Password = txtPW.Text Then
                            'MessageBox.Show("Login successful")

                            memberID = RowData.EmployeeID

                            Dim EmployeeWelcomeForm As EmployeeWelcome
                            EmployeeWelcomeForm = New EmployeeWelcome
                            EmployeeWelcomeForm.Show()
                            Me.Visible = False
                        Else
                            MessageBox.Show("Login unsuccessful")
                            txtPW.Clear()
                        End If

                    Else
                        MessageBox.Show("No user has registered with this email, please try a different email or register as a new user")
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Label1.Left = (Label1.Parent.Width \ 2) - (Label1.Width \ 2)
    'BtnLogin.Left = (BtnLogin.Parent.Width \ 2) - (BtnLogin.Width \ 2)
    'txtUsername.Left = (txtUsername.Parent.Width \ 2) - (txtUsername.Width \ 2)
    'txtPW.Left = (txtPW.Parent.Width \ 2) - (txtPW.Width \ 2)
    'End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
        Dim CreateAccountForm As CreateAccount
        CreateAccountForm = New CreateAccount
        CreateAccount.Show()
        Me.Visible = False
    End Sub
End Class


