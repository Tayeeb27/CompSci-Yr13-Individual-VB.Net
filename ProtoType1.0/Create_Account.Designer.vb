<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create_Account))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.TxtRePassword = New System.Windows.Forms.MaskedTextBox()
        Me.TxtAddress = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPostCode = New System.Windows.Forms.MaskedTextBox()
        Me.BtnComplete = New System.Windows.Forms.Button()
        Me.Btni = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PbShow = New System.Windows.Forms.PictureBox()
        Me.PbHide = New System.Windows.Forms.PictureBox()
        Me.DGVNewAccount = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbHide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVNewAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-11, 123)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 57)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Create Your Account Here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 221)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(18, 261)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(19, 304)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Email Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(18, 346)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(11, 382)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 29)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Re-enter Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(18, 468)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 29)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(18, 508)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 29)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Postcode:"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.ForeColor = System.Drawing.Color.White
        Me.TxtName.Location = New System.Drawing.Point(197, 218)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(202, 26)
        Me.TxtName.TabIndex = 17
        '
        'TxtPhoneNumber
        '
        Me.TxtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPhoneNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNumber.ForeColor = System.Drawing.Color.White
        Me.TxtPhoneNumber.Location = New System.Drawing.Point(197, 258)
        Me.TxtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhoneNumber.Name = "TxtPhoneNumber"
        Me.TxtPhoneNumber.Size = New System.Drawing.Size(202, 26)
        Me.TxtPhoneNumber.TabIndex = 18
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.White
        Me.TxtEmail.Location = New System.Drawing.Point(197, 301)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(202, 26)
        Me.TxtEmail.TabIndex = 19
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.White
        Me.TxtPassword.Location = New System.Drawing.Point(197, 346)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(202, 26)
        Me.TxtPassword.TabIndex = 20
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtRePassword
        '
        Me.TxtRePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtRePassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRePassword.ForeColor = System.Drawing.Color.White
        Me.TxtRePassword.Location = New System.Drawing.Point(197, 385)
        Me.TxtRePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRePassword.Name = "TxtRePassword"
        Me.TxtRePassword.Size = New System.Drawing.Size(202, 26)
        Me.TxtRePassword.TabIndex = 21
        Me.TxtRePassword.UseSystemPasswordChar = True
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.ForeColor = System.Drawing.Color.White
        Me.TxtAddress.Location = New System.Drawing.Point(197, 508)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(202, 26)
        Me.TxtAddress.TabIndex = 22
        '
        'TxtPostCode
        '
        Me.TxtPostCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPostCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPostCode.ForeColor = System.Drawing.Color.White
        Me.TxtPostCode.Location = New System.Drawing.Point(197, 468)
        Me.TxtPostCode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPostCode.Name = "TxtPostCode"
        Me.TxtPostCode.Size = New System.Drawing.Size(202, 26)
        Me.TxtPostCode.TabIndex = 23
        '
        'BtnComplete
        '
        Me.BtnComplete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComplete.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.White
        Me.BtnComplete.Location = New System.Drawing.Point(298, 603)
        Me.BtnComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(142, 69)
        Me.BtnComplete.TabIndex = 24
        Me.BtnComplete.Text = "CREATE ACCOUNT"
        Me.BtnComplete.UseVisualStyleBackColor = False
        '
        'Btni
        '
        Me.Btni.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Btni.BackgroundImage = CType(resources.GetObject("Btni.BackgroundImage"), System.Drawing.Image)
        Me.Btni.CausesValidation = False
        Me.Btni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btni.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btni.ForeColor = System.Drawing.Color.White
        Me.Btni.Location = New System.Drawing.Point(121, 346)
        Me.Btni.Margin = New System.Windows.Forms.Padding(2)
        Me.Btni.Name = "Btni"
        Me.Btni.Size = New System.Drawing.Size(27, 26)
        Me.Btni.TabIndex = 25
        Me.Btni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btni.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-13, -1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(464, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PbShow
        '
        Me.PbShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbShow.Image = CType(resources.GetObject("PbShow.Image"), System.Drawing.Image)
        Me.PbShow.Location = New System.Drawing.Point(402, 364)
        Me.PbShow.Name = "PbShow"
        Me.PbShow.Size = New System.Drawing.Size(27, 26)
        Me.PbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbShow.TabIndex = 37
        Me.PbShow.TabStop = False
        '
        'PbHide
        '
        Me.PbHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbHide.Image = CType(resources.GetObject("PbHide.Image"), System.Drawing.Image)
        Me.PbHide.Location = New System.Drawing.Point(402, 365)
        Me.PbHide.Name = "PbHide"
        Me.PbHide.Size = New System.Drawing.Size(27, 25)
        Me.PbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbHide.TabIndex = 38
        Me.PbHide.TabStop = False
        '
        'DGVNewAccount
        '
        Me.DGVNewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNewAccount.Location = New System.Drawing.Point(82, 541)
        Me.DGVNewAccount.Name = "DGVNewAccount"
        Me.DGVNewAccount.Size = New System.Drawing.Size(292, 57)
        Me.DGVNewAccount.TabIndex = 39
        Me.DGVNewAccount.Visible = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(2, 618)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(82, 54)
        Me.BtnBack.TabIndex = 40
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Create_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DGVNewAccount)
        Me.Controls.Add(Me.PbShow)
        Me.Controls.Add(Me.PbHide)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btni)
        Me.Controls.Add(Me.BtnComplete)
        Me.Controls.Add(Me.TxtPostCode)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtRePassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPhoneNumber)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Create_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create_Account"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbHide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVNewAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtName As MaskedTextBox
    Friend WithEvents TxtPhoneNumber As MaskedTextBox
    Friend WithEvents TxtEmail As MaskedTextBox
    Friend WithEvents TxtPassword As MaskedTextBox
    Friend WithEvents TxtRePassword As MaskedTextBox
    Friend WithEvents TxtAddress As MaskedTextBox
    Friend WithEvents TxtPostCode As MaskedTextBox
    Friend WithEvents BtnComplete As Button
    Friend WithEvents Btni As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PbShow As PictureBox
    Friend WithEvents PbHide As PictureBox
    Friend WithEvents DGVNewAccount As DataGridView
    Friend WithEvents BtnBack As Button
End Class
