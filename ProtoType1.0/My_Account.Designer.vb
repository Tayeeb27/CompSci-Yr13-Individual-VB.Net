<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(My_Account))
        Me.BtnSaveChanges = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TxtPostcode = New System.Windows.Forms.MaskedTextBox()
        Me.TxtRePassword = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.TxtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.TxtName = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btni = New System.Windows.Forms.Button()
        Me.DGVAddress = New System.Windows.Forms.DataGridView()
        Me.CmbAddresses = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVPC = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSaveChanges
        '
        Me.BtnSaveChanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSaveChanges.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveChanges.ForeColor = System.Drawing.Color.White
        Me.BtnSaveChanges.Location = New System.Drawing.Point(245, 592)
        Me.BtnSaveChanges.Name = "BtnSaveChanges"
        Me.BtnSaveChanges.Size = New System.Drawing.Size(184, 69)
        Me.BtnSaveChanges.TabIndex = 43
        Me.BtnSaveChanges.Text = "SAVE CHANGES"
        Me.BtnSaveChanges.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(0, 609)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(86, 65)
        Me.BtnBack.TabIndex = 64
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(25, 408)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(125, 24)
        Me.RadioButton1.TabIndex = 63
        Me.RadioButton1.Text = "Show Password"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'TxtPostcode
        '
        Me.TxtPostcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPostcode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPostcode.ForeColor = System.Drawing.Color.White
        Me.TxtPostcode.Location = New System.Drawing.Point(204, 492)
        Me.TxtPostcode.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPostcode.Name = "TxtPostcode"
        Me.TxtPostcode.Size = New System.Drawing.Size(186, 26)
        Me.TxtPostcode.TabIndex = 60
        '
        'TxtRePassword
        '
        Me.TxtRePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtRePassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRePassword.ForeColor = System.Drawing.Color.White
        Me.TxtRePassword.Location = New System.Drawing.Point(204, 369)
        Me.TxtRePassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRePassword.Name = "TxtRePassword"
        Me.TxtRePassword.Size = New System.Drawing.Size(186, 26)
        Me.TxtRePassword.TabIndex = 59
        Me.TxtRePassword.UseSystemPasswordChar = True
        Me.TxtRePassword.Visible = False
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.White
        Me.TxtPassword.Location = New System.Drawing.Point(204, 330)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(186, 26)
        Me.TxtPassword.TabIndex = 58
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.White
        Me.TxtEmail.Location = New System.Drawing.Point(204, 285)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(186, 26)
        Me.TxtEmail.TabIndex = 57
        '
        'TxtPhoneNumber
        '
        Me.TxtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPhoneNumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPhoneNumber.ForeColor = System.Drawing.Color.White
        Me.TxtPhoneNumber.Location = New System.Drawing.Point(204, 242)
        Me.TxtPhoneNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPhoneNumber.Name = "TxtPhoneNumber"
        Me.TxtPhoneNumber.Size = New System.Drawing.Size(186, 26)
        Me.TxtPhoneNumber.TabIndex = 56
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.ForeColor = System.Drawing.Color.White
        Me.TxtName.Location = New System.Drawing.Point(204, 202)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(186, 26)
        Me.TxtName.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 489)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 22)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Postcode:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 449)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 22)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 369)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 22)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Re-enter Password:"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 327)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 285)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 22)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 22)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 202)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 22)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 57)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Account Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Btni
        '
        Me.Btni.BackColor = System.Drawing.Color.Transparent
        Me.Btni.BackgroundImage = CType(resources.GetObject("Btni.BackgroundImage"), System.Drawing.Image)
        Me.Btni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btni.CausesValidation = False
        Me.Btni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btni.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btni.ForeColor = System.Drawing.Color.White
        Me.Btni.Location = New System.Drawing.Point(146, 347)
        Me.Btni.Margin = New System.Windows.Forms.Padding(2)
        Me.Btni.Name = "Btni"
        Me.Btni.Size = New System.Drawing.Size(27, 22)
        Me.Btni.TabIndex = 62
        Me.Btni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btni.UseVisualStyleBackColor = False
        '
        'DGVAddress
        '
        Me.DGVAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAddress.Location = New System.Drawing.Point(85, 547)
        Me.DGVAddress.Name = "DGVAddress"
        Me.DGVAddress.Size = New System.Drawing.Size(55, 42)
        Me.DGVAddress.TabIndex = 66
        Me.DGVAddress.Visible = False
        '
        'CmbAddresses
        '
        Me.CmbAddresses.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbAddresses.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAddresses.ForeColor = System.Drawing.Color.White
        Me.CmbAddresses.FormattingEnabled = True
        Me.CmbAddresses.Location = New System.Drawing.Point(203, 449)
        Me.CmbAddresses.Name = "CmbAddresses"
        Me.CmbAddresses.Size = New System.Drawing.Size(187, 30)
        Me.CmbAddresses.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 547)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 22)
        Me.Label7.TabIndex = 68
        Me.Label7.Visible = False
        '
        'DGVPC
        '
        Me.DGVPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPC.Location = New System.Drawing.Point(146, 547)
        Me.DGVPC.Name = "DGVPC"
        Me.DGVPC.Size = New System.Drawing.Size(87, 42)
        Me.DGVPC.TabIndex = 69
        Me.DGVPC.Visible = False
        '
        'My_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.DGVPC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbAddresses)
        Me.Controls.Add(Me.DGVAddress)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Btni)
        Me.Controls.Add(Me.TxtPostcode)
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
        Me.Controls.Add(Me.BtnSaveChanges)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "My_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My_Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSaveChanges As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TxtPostcode As MaskedTextBox
    Friend WithEvents TxtRePassword As MaskedTextBox
    Friend WithEvents TxtPassword As MaskedTextBox
    Friend WithEvents TxtEmail As MaskedTextBox
    Friend WithEvents TxtPhoneNumber As MaskedTextBox
    Friend WithEvents TxtName As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btni As Button
    Friend WithEvents DGVAddress As DataGridView
    Friend WithEvents CmbAddresses As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVPC As DataGridView
End Class
