<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreateNew = New System.Windows.Forms.Button()
        Me.MembersTableAdapter = New Library.LibraryDataSetTableAdapters.MembersTableAdapter()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New Library.LibraryDataSet()
        Me.TableAdapterManager = New Library.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.EmployeesTableAdapter = New Library.LibraryDataSetTableAdapters.EmployeesTableAdapter()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        PasswordLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(146, 136)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 24
        PasswordLabel.Text = "Password:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(167, 114)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "Email:"
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(128, 175)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(118, 23)
        Me.BtnLogin.TabIndex = 25
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(214, 110)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 26
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(214, 136)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(100, 20)
        Me.txtPW.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(433, 37)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Welcome To The E-Library!"
        '
        'btnCreateNew
        '
        Me.btnCreateNew.Location = New System.Drawing.Point(279, 175)
        Me.btnCreateNew.Name = "btnCreateNew"
        Me.btnCreateNew.Size = New System.Drawing.Size(126, 23)
        Me.btnCreateNew.TabIndex = 29
        Me.btnCreateNew.Text = "Create Account"
        Me.btnCreateNew.UseVisualStyleBackColor = True
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.ResourcesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.LibraryDataSet
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 250)
        Me.Controls.Add(Me.btnCreateNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(PasswordLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.Text = "Form1"
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MembersTableAdapter As LibraryDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents TableAdapterManager As LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesTableAdapter As LibraryDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents btnCreateNew As Button
End Class
