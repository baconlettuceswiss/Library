﻿Public Class WelcomePage
    Private Sub WelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Left = (lblWelcome.Parent.Width \ 2) - (lblWelcome.Width \ 2)
        btnLogout.Left = (btnLogout.Parent.Width \ 4) - (btnLogout.Width \ 4)
        btnReview.Left = ((btnReview.Parent.Width \ 4) * 3) - ((btnReview.Width \ 4) * 3)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim LoginPage As Login
        LoginPage = New Login
        LoginPage.Show()
        Me.Visible = False
    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        Dim MemberAccountForm As MemberAccount
        MemberAccountForm = New MemberAccount
        MemberAccountForm.Show()
        Me.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim MemberSearchForm As MemberSearch
        MemberSearchForm = New MemberSearch
        MemberSearchForm.Show()
        Me.Visible = False
    End Sub

End Class