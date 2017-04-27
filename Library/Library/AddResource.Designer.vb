<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddResource
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
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.btnAddResource = New System.Windows.Forms.Button()
        Me.comboSubject = New System.Windows.Forms.ComboBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthorFirstName = New System.Windows.Forms.TextBox()
        Me.txtAuthorLastName = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthorFirstName = New System.Windows.Forms.Label()
        Me.lblAuthorLastName = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblPublicationDate = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblBookInfo = New System.Windows.Forms.Label()
        Me.txtBookInfo = New System.Windows.Forms.TextBox()
        Me.comboPublicationDate = New System.Windows.Forms.ComboBox()
        Me.LibraryDataSet = New Library.LibraryDataSet()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckoutTableAdapter = New Library.LibraryDataSetTableAdapters.CheckoutTableAdapter()
        Me.TableAdapterManager = New Library.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourcesTableAdapter = New Library.LibraryDataSetTableAdapters.ResourcesTableAdapter()
        Me.lblCheckoutPeriod = New System.Windows.Forms.Label()
        Me.comboCheckoutPeriod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboSeries = New System.Windows.Forms.ComboBox()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTitle.Location = New System.Drawing.Point(271, 66)
        Me.lblPageTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(515, 55)
        Me.lblPageTitle.TabIndex = 27
        Me.lblPageTitle.Text = "Add a Resource Page"
        Me.lblPageTitle.UseMnemonic = False
        '
        'btnAddResource
        '
        Me.btnAddResource.Location = New System.Drawing.Point(947, 420)
        Me.btnAddResource.Name = "btnAddResource"
        Me.btnAddResource.Size = New System.Drawing.Size(157, 95)
        Me.btnAddResource.TabIndex = 30
        Me.btnAddResource.Text = "Add Resource"
        Me.btnAddResource.UseVisualStyleBackColor = True
        '
        'comboSubject
        '
        Me.comboSubject.FormattingEnabled = True
        Me.comboSubject.Location = New System.Drawing.Point(713, 254)
        Me.comboSubject.Name = "comboSubject"
        Me.comboSubject.Size = New System.Drawing.Size(157, 28)
        Me.comboSubject.TabIndex = 0
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(244, 184)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(252, 26)
        Me.txtTitle.TabIndex = 31
        '
        'txtAuthorFirstName
        '
        Me.txtAuthorFirstName.Location = New System.Drawing.Point(244, 256)
        Me.txtAuthorFirstName.Name = "txtAuthorFirstName"
        Me.txtAuthorFirstName.Size = New System.Drawing.Size(252, 26)
        Me.txtAuthorFirstName.TabIndex = 32
        '
        'txtAuthorLastName
        '
        Me.txtAuthorLastName.Location = New System.Drawing.Point(244, 332)
        Me.txtAuthorLastName.Name = "txtAuthorLastName"
        Me.txtAuthorLastName.Size = New System.Drawing.Size(252, 26)
        Me.txtAuthorLastName.TabIndex = 33
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(244, 407)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(252, 26)
        Me.txtISBN.TabIndex = 34
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(69, 192)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 20)
        Me.lblTitle.TabIndex = 37
        Me.lblTitle.Text = "Title"
        '
        'lblAuthorFirstName
        '
        Me.lblAuthorFirstName.AutoSize = True
        Me.lblAuthorFirstName.Location = New System.Drawing.Point(69, 264)
        Me.lblAuthorFirstName.Name = "lblAuthorFirstName"
        Me.lblAuthorFirstName.Size = New System.Drawing.Size(138, 20)
        Me.lblAuthorFirstName.TabIndex = 38
        Me.lblAuthorFirstName.Text = "Author First Name"
        '
        'lblAuthorLastName
        '
        Me.lblAuthorLastName.AutoSize = True
        Me.lblAuthorLastName.Location = New System.Drawing.Point(69, 338)
        Me.lblAuthorLastName.Name = "lblAuthorLastName"
        Me.lblAuthorLastName.Size = New System.Drawing.Size(138, 20)
        Me.lblAuthorLastName.TabIndex = 39
        Me.lblAuthorLastName.Text = "Author Last Name"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(563, 259)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(63, 20)
        Me.lblSubject.TabIndex = 40
        Me.lblSubject.Text = "Subject"
        '
        'lblPublicationDate
        '
        Me.lblPublicationDate.AutoSize = True
        Me.lblPublicationDate.Location = New System.Drawing.Point(563, 185)
        Me.lblPublicationDate.Name = "lblPublicationDate"
        Me.lblPublicationDate.Size = New System.Drawing.Size(125, 20)
        Me.lblPublicationDate.TabIndex = 42
        Me.lblPublicationDate.Text = "Publication Date"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(69, 420)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(47, 20)
        Me.lblISBN.TabIndex = 43
        Me.lblISBN.Text = "ISBN"
        '
        'lblBookInfo
        '
        Me.lblBookInfo.AutoSize = True
        Me.lblBookInfo.Location = New System.Drawing.Point(69, 489)
        Me.lblBookInfo.Name = "lblBookInfo"
        Me.lblBookInfo.Size = New System.Drawing.Size(78, 20)
        Me.lblBookInfo.TabIndex = 45
        Me.lblBookInfo.Text = "Book Info"
        '
        'txtBookInfo
        '
        Me.txtBookInfo.Location = New System.Drawing.Point(244, 489)
        Me.txtBookInfo.Name = "txtBookInfo"
        Me.txtBookInfo.Size = New System.Drawing.Size(252, 26)
        Me.txtBookInfo.TabIndex = 46
        '
        'comboPublicationDate
        '
        Me.comboPublicationDate.FormattingEnabled = True
        Me.comboPublicationDate.Location = New System.Drawing.Point(713, 182)
        Me.comboPublicationDate.Name = "comboPublicationDate"
        Me.comboPublicationDate.Size = New System.Drawing.Size(157, 28)
        Me.comboPublicationDate.TabIndex = 1
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Me.CheckoutTableAdapter
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
        'lblCheckoutPeriod
        '
        Me.lblCheckoutPeriod.AutoSize = True
        Me.lblCheckoutPeriod.Location = New System.Drawing.Point(563, 338)
        Me.lblCheckoutPeriod.Name = "lblCheckoutPeriod"
        Me.lblCheckoutPeriod.Size = New System.Drawing.Size(126, 20)
        Me.lblCheckoutPeriod.TabIndex = 47
        Me.lblCheckoutPeriod.Text = "Checkout Period"
        '
        'comboCheckoutPeriod
        '
        Me.comboCheckoutPeriod.FormattingEnabled = True
        Me.comboCheckoutPeriod.Location = New System.Drawing.Point(713, 330)
        Me.comboCheckoutPeriod.Name = "comboCheckoutPeriod"
        Me.comboCheckoutPeriod.Size = New System.Drawing.Size(157, 28)
        Me.comboCheckoutPeriod.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(563, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Series"
        '
        'comboSeries
        '
        Me.comboSeries.FormattingEnabled = True
        Me.comboSeries.Location = New System.Drawing.Point(713, 410)
        Me.comboSeries.Name = "comboSeries"
        Me.comboSeries.Size = New System.Drawing.Size(157, 28)
        Me.comboSeries.TabIndex = 50
        '
        'AddResource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 629)
        Me.Controls.Add(Me.comboSeries)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboCheckoutPeriod)
        Me.Controls.Add(Me.lblCheckoutPeriod)
        Me.Controls.Add(Me.txtBookInfo)
        Me.Controls.Add(Me.lblBookInfo)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.lblPublicationDate)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblAuthorLastName)
        Me.Controls.Add(Me.lblAuthorFirstName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.txtAuthorLastName)
        Me.Controls.Add(Me.txtAuthorFirstName)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnAddResource)
        Me.Controls.Add(Me.lblPageTitle)
        Me.Controls.Add(Me.comboPublicationDate)
        Me.Controls.Add(Me.comboSubject)
        Me.Name = "AddResource"
        Me.Text = "AddResource"
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents CheckoutTableAdapter As LibraryDataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents TableAdapterManager As LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents btnAddResource As Button
    Friend WithEvents comboSubject As ComboBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthorFirstName As TextBox
    Friend WithEvents txtAuthorLastName As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthorFirstName As Label
    Friend WithEvents lblAuthorLastName As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblPublicationDate As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblBookInfo As Label
    Friend WithEvents txtBookInfo As TextBox
    Friend WithEvents comboPublicationDate As ComboBox
    Friend WithEvents ResourcesBindingSource As BindingSource
    Friend WithEvents ResourcesTableAdapter As LibraryDataSetTableAdapters.ResourcesTableAdapter
    Friend WithEvents lblCheckoutPeriod As Label
    Friend WithEvents comboCheckoutPeriod As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboSeries As ComboBox
End Class
