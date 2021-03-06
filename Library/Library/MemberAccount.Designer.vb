﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemberAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Results = New System.Windows.Forms.DataGridView()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.btn_Renew = New System.Windows.Forms.Button()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New Library.LibraryDataSet()
        Me.CheckoutTableAdapter = New Library.LibraryDataSetTableAdapters.CheckoutTableAdapter()
        Me.TableAdapterManager = New Library.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourcesTableAdapter = New Library.LibraryDataSetTableAdapters.ResourcesTableAdapter()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Renew = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ReturnResource = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Results
        '
        Me.Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Results.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.CheckoutLength, Me.Title, Me.Author, Me.Genre, Me.CheckoutDate, Me.ReturnDate, Me.Renew, Me.ReturnResource})
        Me.Results.Location = New System.Drawing.Point(77, 47)
        Me.Results.Name = "Results"
        Me.Results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.Results.RowTemplate.Height = 28
        Me.Results.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Results.Size = New System.Drawing.Size(737, 350)
        Me.Results.TabIndex = 0
        Me.Results.Visible = False
        '
        'btn_Return
        '
        Me.btn_Return.Location = New System.Drawing.Point(862, 205)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(98, 56)
        Me.btn_Return.TabIndex = 1
        Me.btn_Return.Text = "Return"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'btn_Renew
        '
        Me.btn_Renew.Location = New System.Drawing.Point(862, 305)
        Me.btn_Renew.Name = "btn_Renew"
        Me.btn_Renew.Size = New System.Drawing.Size(98, 56)
        Me.btn_Renew.TabIndex = 2
        Me.btn_Renew.Text = "Renew"
        Me.btn_Renew.UseVisualStyleBackColor = True
        '
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.MembersTableAdapter = Nothing
        Me.TableAdapterManager.ResourcesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(862, 101)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(98, 56)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
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
        'CheckoutDate
        '
        Me.CheckoutDate.HeaderText = "Checkout Date"
        Me.CheckoutDate.Name = "CheckoutDate"
        Me.CheckoutDate.Width = 152
        '
        'ReturnDate
        '
        Me.ReturnDate.HeaderText = "Return Date"
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Width = 133
        '
        'Renew
        '
        Me.Renew.HeaderText = "Renew"
        Me.Renew.Name = "Renew"
        Me.Renew.Text = "Renew"
        Me.Renew.UseColumnTextForButtonValue = True
        Me.Renew.Width = 65
        '
        'ReturnResource
        '
        Me.ReturnResource.HeaderText = "Return"
        Me.ReturnResource.Name = "ReturnResource"
        Me.ReturnResource.Text = "Return"
        Me.ReturnResource.UseColumnTextForButtonValue = True
        Me.ReturnResource.Width = 64
        '
        'MemberAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 773)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_Renew)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.Results)
        Me.Name = "MemberAccount"
        Me.Text = "MemberAccount"
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Results As DataGridView
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents CheckoutTableAdapter As LibraryDataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents TableAdapterManager As LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckoutBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CheckoutBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ResourcesBindingSource As BindingSource
    Friend WithEvents ResourcesTableAdapter As LibraryDataSetTableAdapters.ResourcesTableAdapter
    Friend WithEvents btn_Return As Button
    Friend WithEvents btn_Renew As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutLength As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Genre As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutDate As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDate As DataGridViewTextBoxColumn
    Friend WithEvents Renew As DataGridViewButtonColumn
    Friend WithEvents ReturnResource As DataGridViewButtonColumn
End Class
