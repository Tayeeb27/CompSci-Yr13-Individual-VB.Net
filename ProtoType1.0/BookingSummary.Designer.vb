<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingSummary))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnComplete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNOP = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblBD = New System.Windows.Forms.Label()
        Me.LblBT = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblAI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-19, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(470, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Location = New System.Drawing.Point(1, 620)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(79, 51)
        Me.BtnBack.TabIndex = 39
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnComplete
        '
        Me.BtnComplete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComplete.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.White
        Me.BtnComplete.Location = New System.Drawing.Point(270, 599)
        Me.BtnComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(170, 72)
        Me.BtnComplete.TabIndex = 38
        Me.BtnComplete.Text = "COMPLETE BOOKING"
        Me.BtnComplete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 35)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Booking Name:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(224, 212)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(0, 35)
        Me.LblName.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 35)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Number of people attending:"
        '
        'LblNOP
        '
        Me.LblNOP.AutoSize = True
        Me.LblNOP.BackColor = System.Drawing.Color.Transparent
        Me.LblNOP.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNOP.Location = New System.Drawing.Point(308, 263)
        Me.LblNOP.Name = "LblNOP"
        Me.LblNOP.Size = New System.Drawing.Size(0, 35)
        Me.LblNOP.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 35)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Booking Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 35)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Booking Time:"
        '
        'LblBD
        '
        Me.LblBD.AutoSize = True
        Me.LblBD.BackColor = System.Drawing.Color.Transparent
        Me.LblBD.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBD.Location = New System.Drawing.Point(202, 322)
        Me.LblBD.Name = "LblBD"
        Me.LblBD.Size = New System.Drawing.Size(0, 35)
        Me.LblBD.TabIndex = 46
        '
        'LblBT
        '
        Me.LblBT.AutoSize = True
        Me.LblBT.BackColor = System.Drawing.Color.Transparent
        Me.LblBT.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBT.Location = New System.Drawing.Point(202, 377)
        Me.LblBT.Name = "LblBT"
        Me.LblBT.Size = New System.Drawing.Size(0, 35)
        Me.LblBT.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 35)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Additional Information:"
        '
        'LblAI
        '
        Me.LblAI.AutoSize = True
        Me.LblAI.BackColor = System.Drawing.Color.Transparent
        Me.LblAI.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAI.Location = New System.Drawing.Point(39, 470)
        Me.LblAI.Name = "LblAI"
        Me.LblAI.Size = New System.Drawing.Size(0, 35)
        Me.LblAI.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 57)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Booking Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BookingSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblBT)
        Me.Controls.Add(Me.LblBD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblNOP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnComplete)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BookingSummary"
        Me.Text = "BookingSummary"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnComplete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNOP As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblBD As Label
    Friend WithEvents LblBT As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblAI As Label
    Friend WithEvents Label1 As Label
End Class
