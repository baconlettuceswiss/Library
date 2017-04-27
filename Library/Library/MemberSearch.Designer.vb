<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AuthorSearch = New System.Windows.Forms.Button()
        Me.TitleSearch = New System.Windows.Forms.Button()
        Me.AuthorTB = New System.Windows.Forms.TextBox()
        Me.TitleTB = New System.Windows.Forms.TextBox()
        Me.SearchResults = New System.Windows.Forms.DataGridView()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoreInfo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Checkout = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LibraryDataSet = New Library.LibraryDataSet()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourcesTableAdapter = New Library.LibraryDataSetTableAdapters.ResourcesTableAdapter()
        Me.TableAdapterManager = New Library.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckoutTableAdapter = New Library.LibraryDataSetTableAdapters.CheckoutTableAdapter()
        CType(Me.SearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuthorSearch
        '
        Me.AuthorSearch.Location = New System.Drawing.Point(765, 137)
        Me.AuthorSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AuthorSearch.Name = "AuthorSearch"
        Me.AuthorSearch.Size = New System.Drawing.Size(112, 35)
        Me.AuthorSearch.TabIndex = 9
        Me.AuthorSearch.Text = "Search"
        Me.AuthorSearch.UseVisualStyleBackColor = True
        '
        'TitleSearch
        '
        Me.TitleSearch.Location = New System.Drawing.Point(362, 137)
        Me.TitleSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleSearch.Name = "TitleSearch"
        Me.TitleSearch.Size = New System.Drawing.Size(112, 35)
        Me.TitleSearch.TabIndex = 8
        Me.TitleSearch.Text = "Search"
        Me.TitleSearch.UseVisualStyleBackColor = True
        '
        'AuthorTB
        '
        Me.AuthorTB.Location = New System.Drawing.Point(559, 137)
        Me.AuthorTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AuthorTB.Name = "AuthorTB"
        Me.AuthorTB.Size = New System.Drawing.Size(148, 26)
        Me.AuthorTB.TabIndex = 7
        Me.AuthorTB.Text = "Author Last Name..."
        '
        'TitleTB
        '
        Me.TitleTB.Location = New System.Drawing.Point(140, 137)
        Me.TitleTB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleTB.Name = "TitleTB"
        Me.TitleTB.Size = New System.Drawing.Size(148, 26)
        Me.TitleTB.TabIndex = 6
        Me.TitleTB.Text = "Book Title..."
        '
        'SearchResults
        '
        Me.SearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.SearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.CheckoutLength, Me.Title, Me.Author, Me.Genre, Me.ISBN, Me.MoreInfo, Me.Checkout})
        Me.SearchResults.Location = New System.Drawing.Point(140, 213)
        Me.SearchResults.Name = "SearchResults"
        Me.SearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.SearchResults.RowTemplate.Height = 28
        Me.SearchResults.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchResults.Size = New System.Drawing.Size(737, 350)
        Me.SearchResults.TabIndex = 10
        Me.SearchResults.Visible = False
        '
        'BookID
        '
        Me.BookID.HeaderText = "Resource ID"
        Me.BookID.Name = "BookID"
        Me.BookID.Visible = False
        Me.BookID.Width = 135
        '
        'CheckoutLength
        '
        Me.CheckoutLength.HeaderText = "Checkout Period"
        Me.CheckoutLength.Name = "CheckoutLength"
        Me.CheckoutLength.Visible = False
        Me.CheckoutLength.Width = 162
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.Width = 74
        '
        'Author
        '
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        Me.Author.Width = 93
        '
        'Genre
        '
        Me.Genre.HeaderText = "Genre"
        Me.Genre.Name = "Genre"
        Me.Genre.Width = 90
        '
        'ISBN
        '
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Width = 83
        '
        'MoreInfo
        '
        Me.MoreInfo.HeaderText = "More Info"
        Me.MoreInfo.Name = "MoreInfo"
        Me.MoreInfo.Text = "More Info"
        Me.MoreInfo.Width = 83
        '
        'Checkout
        '
        Me.Checkout.HeaderText = "Checkout"
        Me.Checkout.Name = "Checkout"
        Me.Checkout.Text = "Checkout"
        Me.Checkout.Width = 83
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResourcesBindingSource
        '
        Me.ResourcesBindingSource.DataMember = "Resources"
        Me.ResourcesBindingSource.DataSource = Me.LibraryDataSet
        '
        'ResourcesTableAdapter
        '
        Me.ResourcesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Me.CheckoutTableAdapter
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.MembersTableAdapter = Nothing
        Me.TableAdapterManager.ResourcesTableAdapter = Me.ResourcesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me.LibraryDataSet
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
        '
        'MemberSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 791)
        Me.Controls.Add(Me.SearchResults)
        Me.Controls.Add(Me.AuthorSearch)
        Me.Controls.Add(Me.TitleSearch)
        Me.Controls.Add(Me.AuthorTB)
        Me.Controls.Add(Me.TitleTB)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MemberSearch"
        Me.Text = "MemberSearch"
        CType(Me.SearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AuthorSearch As Button
    Friend WithEvents TitleSearch As Button
    Friend WithEvents AuthorTB As TextBox
    Friend WithEvents TitleTB As TextBox
    Friend WithEvents SearchResults As DataGridView
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutLength As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Genre As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents MoreInfo As DataGridViewButtonColumn
    Friend WithEvents Checkout As DataGridViewButtonColumn
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents ResourcesBindingSource As BindingSource
    Friend WithEvents ResourcesTableAdapter As LibraryDataSetTableAdapters.ResourcesTableAdapter
    Friend WithEvents TableAdapterManager As LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckoutTableAdapter As LibraryDataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents CheckoutBindingSource As BindingSource
End Class
