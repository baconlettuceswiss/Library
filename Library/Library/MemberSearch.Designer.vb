﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.AuthorSearch = New System.Windows.Forms.Button()
        Me.TitleSearch = New System.Windows.Forms.Button()
        Me.AuthorTB = New System.Windows.Forms.TextBox()
        Me.TitleTB = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Available = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuthorSearch
        '
        Me.AuthorSearch.Location = New System.Drawing.Point(565, 86)
        Me.AuthorSearch.Name = "AuthorSearch"
        Me.AuthorSearch.Size = New System.Drawing.Size(75, 23)
        Me.AuthorSearch.TabIndex = 9
        Me.AuthorSearch.Text = "Search"
        Me.AuthorSearch.UseVisualStyleBackColor = True
        '
        'TitleSearch
        '
        Me.TitleSearch.Location = New System.Drawing.Point(260, 89)
        Me.TitleSearch.Name = "TitleSearch"
        Me.TitleSearch.Size = New System.Drawing.Size(75, 23)
        Me.TitleSearch.TabIndex = 8
        Me.TitleSearch.Text = "Search"
        Me.TitleSearch.UseVisualStyleBackColor = True
        '
        'AuthorTB
        '
        Me.AuthorTB.Location = New System.Drawing.Point(387, 89)
        Me.AuthorTB.Name = "AuthorTB"
        Me.AuthorTB.Size = New System.Drawing.Size(100, 20)
        Me.AuthorTB.TabIndex = 7
        Me.AuthorTB.Text = "Author Last Name..."
        '
        'TitleTB
        '
        Me.TitleTB.Location = New System.Drawing.Point(93, 89)
        Me.TitleTB.Name = "TitleTB"
        Me.TitleTB.Size = New System.Drawing.Size(100, 20)
        Me.TitleTB.TabIndex = 6
        Me.TitleTB.Text = "Book Title..."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Author, Me.Genre, Me.CheckoutPeriod, Me.Available})
        Me.DataGridView1.Location = New System.Drawing.Point(93, 155)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 274)
        Me.DataGridView1.TabIndex = 5
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        '
        'Author
        '
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        '
        'Genre
        '
        Me.Genre.HeaderText = "Genre"
        Me.Genre.Name = "Genre"
        '
        'CheckoutPeriod
        '
        Me.CheckoutPeriod.HeaderText = "Checkout Period"
        Me.CheckoutPeriod.Name = "CheckoutPeriod"
        '
        'Available
        '
        Me.Available.HeaderText = "Available?"
        Me.Available.Name = "Available"
        '
        'MemberSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 514)
        Me.Controls.Add(Me.AuthorSearch)
        Me.Controls.Add(Me.TitleSearch)
        Me.Controls.Add(Me.AuthorTB)
        Me.Controls.Add(Me.TitleTB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MemberSearch"
        Me.Text = "MemberSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AuthorSearch As Button
    Friend WithEvents TitleSearch As Button
    Friend WithEvents AuthorTB As TextBox
    Friend WithEvents TitleTB As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents Genre As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutPeriod As DataGridViewTextBoxColumn
    Friend WithEvents Available As DataGridViewTextBoxColumn
End Class