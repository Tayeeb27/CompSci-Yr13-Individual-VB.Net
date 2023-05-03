<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Startup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbNewImage = New System.Windows.Forms.PictureBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblOffer = New System.Windows.Forms.Label()
        Me.DGVMPD = New System.Windows.Forms.DataGridView()
        Me.DGVDay = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMPD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(140, 582)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(136, 80)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 505)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 70)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Monday - Sunday" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5:00pm - 12:00pm"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 35)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Special Offers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 114)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(319, 114)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Welcome To " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Curry Garden"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbNewImage
        '
        Me.pbNewImage.ErrorImage = Global.ProtoType1._0.My.Resources.Resources.IMG1
        Me.pbNewImage.Location = New System.Drawing.Point(71, 220)
        Me.pbNewImage.Name = "pbNewImage"
        Me.pbNewImage.Size = New System.Drawing.Size(295, 127)
        Me.pbNewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNewImage.TabIndex = 37
        Me.pbNewImage.TabStop = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Auto"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "NonAutp"
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.White
        Me.BtnNext.Location = New System.Drawing.Point(372, 256)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 41)
        Me.BtnNext.TabIndex = 38
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.ForeColor = System.Drawing.Color.White
        Me.BtnPrev.Location = New System.Drawing.Point(34, 256)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(31, 41)
        Me.BtnPrev.TabIndex = 39
        Me.BtnPrev.Text = "<"
        Me.BtnPrev.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "IMG1.PNG")
        Me.ImageList1.Images.SetKeyName(1, "IMG2.PNG")
        Me.ImageList1.Images.SetKeyName(2, "IMG3.PNG")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(224, 470)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 35)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Opening Times "
        '
        'LblOffer
        '
        Me.LblOffer.AutoSize = True
        Me.LblOffer.BackColor = System.Drawing.Color.Transparent
        Me.LblOffer.Font = New System.Drawing.Font("Edwardian Script ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOffer.Location = New System.Drawing.Point(12, 520)
        Me.LblOffer.Name = "LblOffer"
        Me.LblOffer.Size = New System.Drawing.Size(0, 35)
        Me.LblOffer.TabIndex = 42
        Me.LblOffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGVMPD
        '
        Me.DGVMPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMPD.Location = New System.Drawing.Point(295, 601)
        Me.DGVMPD.Name = "DGVMPD"
        Me.DGVMPD.Size = New System.Drawing.Size(134, 60)
        Me.DGVMPD.TabIndex = 43
        Me.DGVMPD.Visible = False
        '
        'DGVDay
        '
        Me.DGVDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDay.Location = New System.Drawing.Point(295, 601)
        Me.DGVDay.Name = "DGVDay"
        Me.DGVDay.Size = New System.Drawing.Size(134, 60)
        Me.DGVDay.TabIndex = 44
        Me.DGVDay.Visible = False
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.DGVDay)
        Me.Controls.Add(Me.DGVMPD)
        Me.Controls.Add(Me.LblOffer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.pbNewImage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Startup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMPD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pbNewImage As PictureBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrev As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label6 As Label
    Friend WithEvents LblOffer As Label
    Friend WithEvents DGVMPD As DataGridView
    Friend WithEvents DGVDay As DataGridView
End Class
