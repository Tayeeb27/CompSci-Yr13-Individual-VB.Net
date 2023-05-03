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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnCA = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnForgotPassword = New System.Windows.Forms.Button()
        Me.DGVAccount = New System.Windows.Forms.DataGridView()
        Me.PbShow = New System.Windows.Forms.PictureBox()
        Me.PbHide = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbHide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(103, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Here"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 195)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 307)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(256, 497)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(149, 60)
        Me.BtnLogin.TabIndex = 9
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnCA
        '
        Me.BtnCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnCA.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCA.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCA.ForeColor = System.Drawing.Color.White
        Me.BtnCA.Location = New System.Drawing.Point(110, 599)
        Me.BtnCA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCA.Name = "BtnCA"
        Me.BtnCA.Size = New System.Drawing.Size(239, 72)
        Me.BtnCA.TabIndex = 10
        Me.BtnCA.Text = "CREATE ACCOUNT"
        Me.BtnCA.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPassword.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.White
        Me.TxtPassword.Location = New System.Drawing.Point(73, 354)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(290, 32)
        Me.TxtPassword.TabIndex = 14
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.White
        Me.TxtEmail.Location = New System.Drawing.Point(73, 249)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(290, 32)
        Me.TxtEmail.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-14, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BtnForgotPassword
        '
        Me.BtnForgotPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnForgotPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnForgotPassword.ForeColor = System.Drawing.Color.White
        Me.BtnForgotPassword.Location = New System.Drawing.Point(28, 435)
        Me.BtnForgotPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnForgotPassword.Name = "BtnForgotPassword"
        Me.BtnForgotPassword.Size = New System.Drawing.Size(173, 44)
        Me.BtnForgotPassword.TabIndex = 17
        Me.BtnForgotPassword.Text = "Forgot Password?"
        Me.BtnForgotPassword.UseVisualStyleBackColor = False
        '
        'DGVAccount
        '
        Me.DGVAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAccount.Location = New System.Drawing.Point(113, 614)
        Me.DGVAccount.Name = "DGVAccount"
        Me.DGVAccount.Size = New System.Drawing.Size(292, 57)
        Me.DGVAccount.TabIndex = 33
        Me.DGVAccount.Visible = False
        '
        'PbShow
        '
        Me.PbShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbShow.Image = CType(resources.GetObject("PbShow.Image"), System.Drawing.Image)
        Me.PbShow.Location = New System.Drawing.Point(278, 307)
        Me.PbShow.Name = "PbShow"
        Me.PbShow.Size = New System.Drawing.Size(27, 26)
        Me.PbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbShow.TabIndex = 39
        Me.PbShow.TabStop = False
        '
        'PbHide
        '
        Me.PbHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbHide.Image = CType(resources.GetObject("PbHide.Image"), System.Drawing.Image)
        Me.PbHide.Location = New System.Drawing.Point(278, 307)
        Me.PbHide.Name = "PbHide"
        Me.PbHide.Size = New System.Drawing.Size(27, 26)
        Me.PbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbHide.TabIndex = 40
        Me.PbHide.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Location = New System.Drawing.Point(1, 617)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(82, 54)
        Me.BtnBack.TabIndex = 31
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.PbShow)
        Me.Controls.Add(Me.PbHide)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnForgotPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.BtnCA)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVAccount)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbHide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCA As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnForgotPassword As Button
    Friend WithEvents DGVAccount As DataGridView
    Friend WithEvents PbShow As PictureBox
    Friend WithEvents PbHide As PictureBox
    Friend WithEvents BtnBack As Button
End Class
