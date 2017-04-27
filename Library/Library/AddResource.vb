Public Class AddResource

    Dim ResourceID As String
    Dim BookTitle As String
    Dim AuthorFirstName As String
    Dim AuthorLastName As String
    Dim ISBN As String
    Dim CheckoutPeriod As Integer
    Dim PublicationDate As Integer
    Dim Series As String
    Dim Subject As String
    Dim BookInfo As String

    Dim MemberID As String = Login.memberID

    Private Sub CheckoutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CheckoutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub AddResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.LibraryDataSet.Resources)
        'TODO: This line of code loads data into the 'LibraryDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.LibraryDataSet.Checkout)
        lblPageTitle.Left = (lblPageTitle.Parent.Width \ 2) - (lblPageTitle.Width \ 2)

        For x = 1 To 30 Step 1
            comboCheckoutPeriod.Items.Add(x)
        Next

        For x = 1900 To 2016 Step 1
            comboPublicationDate.Items.Add(x)
        Next

        comboSubject.Items.Add("Fiction")
        comboSubject.Items.Add("Non-Fiction")
        comboSubject.Items.Add("ScienceFiction")
        comboSubject.Items.Add("Fantasy")
        comboSubject.Items.Add("Mystery/Thriller")
        comboSubject.Items.Add("Crime")
        comboSubject.Items.Add("YouthFiction")



    End Sub

    Private Sub btnAddResource_Click(sender As Object, e As EventArgs) Handles btnAddResource.Click
        If txtTitle.Text = String.Empty Or txtAuthorLastName.Text = String.Empty Or txtAuthorFirstName.Text = String.Empty Or
            txtBookInfo.Text = String.Empty Or txtISBN.Text = String.Empty Or
            comboPublicationDate.Text = String.Empty Or comboSubject.Text = String.Empty Then
            MessageBox.Show("Please Enter All the Required Information")
        Else
            BookTitle = txtTitle.Text
            AuthorFirstName = txtAuthorFirstName.Text
            AuthorLastName = txtAuthorLastName.Text
            ISBN = txtISBN.Text
            CheckoutPeriod = comboCheckoutPeriod.Text
            PublicationDate = comboPublicationDate.Text
            Series = comboSeries.Text
            Subject = comboSubject.Text
            BookInfo = txtBookInfo.Text

            'random number between 200 and 300
            Dim LRandomNumber As Integer
            LRandomNumber = Int((2099999 - 2090000 + 1) * Rnd() + 2090000)

            ResourceID = "b" & LRandomNumber.ToString

            ResourcesTableAdapter.InsertNewResource(ResourceID, BookTitle, AuthorLastName, AuthorFirstName, "", PublicationDate, Series, ISBN, CheckoutPeriod, Subject, "", BookInfo)

            MessageBox.Show("Successfully Added New Resource")

            emptyBoxes()
        End If


    End Sub

    Private Sub emptyBoxes()
        txtTitle.Clear()
        txtAuthorFirstName.Clear()
        txtAuthorLastName.Clear()
        txtISBN.Clear()
        comboCheckoutPeriod.Text = String.Empty
        comboPublicationDate.Text = String.Empty
        comboSeries.Text = String.Empty
        comboSubject.Text = String.Empty
        txtBookInfo.Clear()
    End Sub
End Class