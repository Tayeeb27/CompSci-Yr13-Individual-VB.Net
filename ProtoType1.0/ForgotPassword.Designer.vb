<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnSendEmail = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVA = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-14, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(464, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Location = New System.Drawing.Point(1, 624)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(79, 51)
        Me.BtnBack.TabIndex = 41
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.ForeColor = System.Drawing.Color.White
        Me.TxtEmail.Location = New System.Drawing.Point(120, 280)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(196, 26)
        Me.TxtEmail.TabIndex = 42
        '
        'BtnSendEmail
        '
        Me.BtnSendEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSendEmail.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSendEmail.ForeColor = System.Drawing.Color.White
        Me.BtnSendEmail.Location = New System.Drawing.Point(38, 380)
        Me.BtnSendEmail.Name = "BtnSendEmail"
        Me.BtnSendEmail.Size = New System.Drawing.Size(178, 43)
        Me.BtnSendEmail.TabIndex = 43
        Me.BtnSendEmail.Text = "SEND EMAIL"
        Me.BtnSendEmail.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 57)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Forgot Your Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(20, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 29)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Enter the Email Address linked with your account "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVA
        '
        Me.DGVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVA.Location = New System.Drawing.Point(99, 496)
        Me.DGVA.Name = "DGVA"
        Me.DGVA.Size = New System.Drawing.Size(292, 57)
        Me.DGVA.TabIndex = 46
        Me.DGVA.Visible = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.DGVA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnSendEmail)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnSendEmail As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVA As DataGridView
End Class
