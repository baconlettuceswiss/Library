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
        Me.btnAuthorSearch = New System.Windows.Forms.Button()
        Me.btnTitleSearch = New System.Windows.Forms.Button()
        Me.tbAuthorSearch = New System.Windows.Forms.TextBox()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.SearchResults = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.LibraryDataSet = New Library.LibraryDataSet()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourcesTableAdapter = New Library.LibraryDataSetTableAdapters.ResourcesTableAdapter()
        Me.TableAdapterManager = New Library.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.CheckoutTableAdapter = New Library.LibraryDataSetTableAdapters.CheckoutTableAdapter()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Availability = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BookInformation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoreInfo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Checkout = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.SearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAuthorSearch
        '
        Me.btnAuthorSearch.Location = New System.Drawing.Point(765, 137)
        Me.btnAuthorSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAuthorSearch.Name = "btnAuthorSearch"
        Me.btnAuthorSearch.Size = New System.Drawing.Size(112, 35)
        Me.btnAuthorSearch.TabIndex = 9
        Me.btnAuthorSearch.Text = "Search"
        Me.btnAuthorSearch.UseVisualStyleBackColor = True
        '
        'btnTitleSearch
        '
        Me.btnTitleSearch.Location = New System.Drawing.Point(362, 137)
        Me.btnTitleSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTitleSearch.Name = "btnTitleSearch"
        Me.btnTitleSearch.Size = New System.Drawing.Size(112, 35)
        Me.btnTitleSearch.TabIndex = 8
        Me.btnTitleSearch.Text = "Search"
        Me.btnTitleSearch.UseVisualStyleBackColor = True
        '
        'tbAuthorSearch
        '
        Me.tbAuthorSearch.Location = New System.Drawing.Point(560, 137)
        Me.tbAuthorSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbAuthorSearch.Name = "tbAuthorSearch"
        Me.tbAuthorSearch.Size = New System.Drawing.Size(148, 26)
        Me.tbAuthorSearch.TabIndex = 7
        Me.tbAuthorSearch.Text = "Author Last Name..."
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(140, 137)
        Me.tbTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(148, 26)
        Me.tbTitle.TabIndex = 6
        Me.tbTitle.Text = "Book Title..."
        '
        'SearchResults
        '
        Me.SearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.SearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.CheckoutLength, Me.Availability, Me.BookInformation, Me.Title, Me.Author, Me.Genre, Me.ISBN, Me.MoreInfo, Me.Checkout})
        Me.SearchResults.Location = New System.Drawing.Point(34, 193)
        Me.SearchResults.Name = "SearchResults"
        Me.SearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.SearchResults.RowTemplate.Height = 28
        Me.SearchResults.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchResults.Size = New System.Drawing.Size(1022, 401)
        Me.SearchResults.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(945, 123)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 55)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
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
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me.LibraryDataSet
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
        'Availability
        '
        Me.Availability.HeaderText = "Availability"
        Me.Availability.Name = "Availability"
        Me.Availability.Visible = False
        Me.Availability.Width = 87
        '
        'BookInformation
        '
        Me.BookInformation.HeaderText = "BookInfo"
        Me.BookInformation.Name = "BookInformation"
        Me.BookInformation.Visible = False
        Me.BookInformation.Width = 110
        '
        'Title
        '
        Me.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.Width = 27
        '
        'Author
        '
        Me.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        Me.Author.Width = 27
        '
        'Genre
        '
        Me.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Genre.HeaderText = "Genre"
        Me.Genre.Name = "Genre"
        Me.Genre.Width = 27
        '
        'ISBN
        '
        Me.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Width = 27
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
        'MemberSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 742)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.SearchResults)
        Me.Controls.Add(Me.btnAuthorSearch)
        Me.Controls.Add(Me.btnTitleSearch)
        Me.Controls.Add(Me.tbAuthorSearch)
        Me.Controls.Add(Me.tbTitle)
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

    Friend WithEvents btnAuthorSearch As Button
    Friend WithEvents btnTitleSearch As Button
    Friend WithEvents tbAuthorSearch As TextBox
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents SearchResults As DataGridView
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents ResourcesBindingSource As BindingSource
    Friend WithEvents ResourcesTableAdapter As LibraryDataSetTableAdapters.ResourcesTableAdapter
    Friend WithEvents TableAdapterManager As LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckoutTableAdapter As LibraryDataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents btnBack As Button
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutLength As DataGridViewTextBoxColumn
    Friend WithEvents Availability As DataGridViewCheckBoxColumn
    Friend WithEvents BookInformation As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Genre As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents MoreInfo As DataGridViewButtonColumn
    Friend WithEvents Checkout As DataGridViewButtonColumn
End Class
