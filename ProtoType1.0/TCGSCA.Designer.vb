<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCGSCA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TCGSCA))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Btni = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPostCode = New System.Windows.Forms.MaskedTextBox()
        Me.TxtAddress = New System.Windows.Forms.MaskedTextBox()
        Me.TxtRePassword = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.TxtName = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbAccessLvl = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(0, 619)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(88, 54)
        Me.BtnBack.TabIndex = 63
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-40, -109)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(464, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(52, 426)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(125, 24)
        Me.RadioButton1.TabIndex = 61
        Me.RadioButton1.Text = "Show Password"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Btni
        '
        Me.Btni.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Btni.BackgroundImage = CType(resources.GetObject("Btni.BackgroundImage"), System.Drawing.Image)
        Me.Btni.CausesValidation = False
        Me.Btni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btni.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btni.ForeColor = System.Drawing.Color.White
        Me.Btni.Location = New System.Drawing.Point(150, 345)
        Me.Btni.Margin = New System.Windows.Forms.Padding(2)
        Me.Btni.Name = "Btni"
        Me.Btni.Size = New System.Drawing.Size(27, 26)
        Me.Btni.TabIndex = 60
        Me.Btni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btni.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(312, 619)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 52)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "CREATE ACCOUNT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtPostCode
        '
        Me.TxtPostCode.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPostCode.Location = New System.Drawing.Point(226, 467)
        Me.TxtPostCode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPostCode.Name = "TxtPostCode"
        Me.TxtPostCode.Size = New System.Drawing.Size(162, 29)
        Me.TxtPostCode.TabIndex = 58
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(226, 507)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(162, 29)
        Me.TxtAddress.TabIndex = 57
        '
        'TxtRePassword
        '
        Me.TxtRePassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRePassword.Location = New System.Drawing.Point(226, 384)
        Me.TxtRePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRePassword.Name = "TxtRePassword"
        Me.TxtRePassword.Size = New System.Drawing.Size(162, 29)
        Me.TxtRePassword.TabIndex = 56
        Me.TxtRePassword.UseSystemPasswordChar = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(226, 345)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(162, 29)
        Me.TxtPassword.TabIndex = 55
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(226, 300)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(162, 29)
        Me.TxtEmail.TabIndex = 54
        '
        'TxtPhoneNumber
        '
        Me.TxtPhoneNumber.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNumber.Location = New System.Drawing.Point(226, 257)
        Me.TxtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhoneNumber.Name = "TxtPhoneNumber"
        Me.TxtPhoneNumber.Size = New System.Drawing.Size(162, 29)
        Me.TxtPhoneNumber.TabIndex = 53
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(226, 217)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(162, 29)
        Me.TxtName.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 507)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 22)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Postcode:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 467)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 387)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 22)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Re-enter Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 345)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 303)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 22)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 260)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 22)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 220)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 22)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(356, 57)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Create Staff Account"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 22)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Job Title:"
        '
        'CmbAccessLvl
        '
        Me.CmbAccessLvl.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbAccessLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbAccessLvl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAccessLvl.ForeColor = System.Drawing.Color.White
        Me.CmbAccessLvl.FormattingEnabled = True
        Me.CmbAccessLvl.Items.AddRange(New Object() {"Waiter", "Cook", "Driver"})
        Me.CmbAccessLvl.Location = New System.Drawing.Point(226, 551)
        Me.CmbAccessLvl.Name = "CmbAccessLvl"
        Me.CmbAccessLvl.Size = New System.Drawing.Size(121, 30)
        Me.CmbAccessLvl.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-13, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(464, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'TCGSCA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbAccessLvl)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Btni)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtPostCode)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtRePassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPhoneNumber)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TCGSCA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TCGSCA"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Btni As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtPostCode As MaskedTextBox
    Friend WithEvents TxtAddress As MaskedTextBox
    Friend WithEvents TxtRePassword As MaskedTextBox
    Friend WithEvents TxtPassword As MaskedTextBox
    Friend WithEvents TxtEmail As MaskedTextBox
    Friend WithEvents TxtPhoneNumber As MaskedTextBox
    Friend WithEvents TxtName As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbAccessLvl As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
