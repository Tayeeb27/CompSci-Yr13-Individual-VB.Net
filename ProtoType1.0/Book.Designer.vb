<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NudNoOfPpl = New System.Windows.Forms.NumericUpDown()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.TxtTime = New System.Windows.Forms.TextBox()
        Me.TxtAddInfo = New System.Windows.Forms.RichTextBox()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TxtTableNeeded = New System.Windows.Forms.TextBox()
        Me.BtnComplete = New System.Windows.Forms.Button()
        Me.LblBI = New System.Windows.Forms.Label()
        Me.LblCID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVB = New System.Windows.Forms.DataGridView()
        Me.DGVT = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbTimeT = New System.Windows.Forms.ComboBox()
        Me.DGVBID = New System.Windows.Forms.DataGridView()
        Me.ChckRightNow = New System.Windows.Forms.CheckBox()
        CType(Me.NudNoOfPpl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Number Of People:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Edwardian Script ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 311)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(354, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Additional Information (disabilities / allergies):"
        '
        'NudNoOfPpl
        '
        Me.NudNoOfPpl.AllowDrop = True
        Me.NudNoOfPpl.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.NudNoOfPpl.CausesValidation = False
        Me.NudNoOfPpl.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NudNoOfPpl.ForeColor = System.Drawing.Color.White
        Me.NudNoOfPpl.Location = New System.Drawing.Point(181, 176)
        Me.NudNoOfPpl.Margin = New System.Windows.Forms.Padding(2)
        Me.NudNoOfPpl.Name = "NudNoOfPpl"
        Me.NudNoOfPpl.Size = New System.Drawing.Size(37, 29)
        Me.NudNoOfPpl.TabIndex = 19
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(73, 374)
        Me.TxtDate.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(76, 20)
        Me.TxtDate.TabIndex = 20
        Me.TxtDate.Visible = False
        '
        'TxtTime
        '
        Me.TxtTime.Location = New System.Drawing.Point(82, 374)
        Me.TxtTime.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.ReadOnly = True
        Me.TxtTime.Size = New System.Drawing.Size(76, 20)
        Me.TxtTime.TabIndex = 21
        Me.TxtTime.Visible = False
        '
        'TxtAddInfo
        '
        Me.TxtAddInfo.Location = New System.Drawing.Point(11, 336)
        Me.TxtAddInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAddInfo.Name = "TxtAddInfo"
        Me.TxtAddInfo.Size = New System.Drawing.Size(288, 79)
        Me.TxtAddInfo.TabIndex = 22
        Me.TxtAddInfo.Text = ""
        '
        'DtpDate
        '
        Me.DtpDate.CalendarFont = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDate.CalendarForeColor = System.Drawing.Color.White
        Me.DtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DtpDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DtpDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DtpDate.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.DtpDate.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.DtpDate.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDate.Location = New System.Drawing.Point(18, 220)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(200, 29)
        Me.DtpDate.TabIndex = 23
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 420000
        '
        'TxtTableNeeded
        '
        Me.TxtTableNeeded.Location = New System.Drawing.Point(119, 374)
        Me.TxtTableNeeded.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTableNeeded.Name = "TxtTableNeeded"
        Me.TxtTableNeeded.ReadOnly = True
        Me.TxtTableNeeded.Size = New System.Drawing.Size(30, 20)
        Me.TxtTableNeeded.TabIndex = 27
        Me.TxtTableNeeded.Visible = False
        '
        'BtnComplete
        '
        Me.BtnComplete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComplete.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplete.ForeColor = System.Drawing.Color.White
        Me.BtnComplete.Location = New System.Drawing.Point(260, 590)
        Me.BtnComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnComplete.Name = "BtnComplete"
        Me.BtnComplete.Size = New System.Drawing.Size(170, 72)
        Me.BtnComplete.TabIndex = 29
        Me.BtnComplete.Text = "COMPLETE BOOKING"
        Me.BtnComplete.UseVisualStyleBackColor = False
        '
        'LblBI
        '
        Me.LblBI.AutoSize = True
        Me.LblBI.Location = New System.Drawing.Point(24, 114)
        Me.LblBI.Name = "LblBI"
        Me.LblBI.Size = New System.Drawing.Size(0, 13)
        Me.LblBI.TabIndex = 30
        '
        'LblCID
        '
        Me.LblCID.AutoSize = True
        Me.LblCID.BackColor = System.Drawing.Color.Transparent
        Me.LblCID.Location = New System.Drawing.Point(9, 127)
        Me.LblCID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCID.Name = "LblCID"
        Me.LblCID.Size = New System.Drawing.Size(0, 13)
        Me.LblCID.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 32
        '
        'DGVB
        '
        Me.DGVB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVB.GridColor = System.Drawing.Color.White
        Me.DGVB.Location = New System.Drawing.Point(73, 363)
        Me.DGVB.Name = "DGVB"
        Me.DGVB.Size = New System.Drawing.Size(122, 52)
        Me.DGVB.TabIndex = 35
        Me.DGVB.Visible = False
        '
        'DGVT
        '
        Me.DGVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVT.GridColor = System.Drawing.Color.White
        Me.DGVT.Location = New System.Drawing.Point(106, 371)
        Me.DGVT.Name = "DGVT"
        Me.DGVT.Size = New System.Drawing.Size(31, 23)
        Me.DGVT.TabIndex = 36
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Location = New System.Drawing.Point(3, 621)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(79, 51)
        Me.BtnBack.TabIndex = 37
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-21, -5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(464, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(326, 57)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Book a Table Here"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbTimeT
        '
        Me.CmbTimeT.AutoCompleteCustomSource.AddRange(New String() {"5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00"})
        Me.CmbTimeT.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbTimeT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTimeT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTimeT.ForeColor = System.Drawing.Color.White
        Me.CmbTimeT.FormattingEnabled = True
        Me.CmbTimeT.Items.AddRange(New Object() {"17:00:00", "18:00:00", "19:00:00", "20:00:00", "21:00:00", "22:00:00", "23:00:00"})
        Me.CmbTimeT.Location = New System.Drawing.Point(18, 267)
        Me.CmbTimeT.Name = "CmbTimeT"
        Me.CmbTimeT.Size = New System.Drawing.Size(200, 30)
        Me.CmbTimeT.TabIndex = 40
        '
        'DGVBID
        '
        Me.DGVBID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBID.Location = New System.Drawing.Point(68, 481)
        Me.DGVBID.Name = "DGVBID"
        Me.DGVBID.Size = New System.Drawing.Size(219, 58)
        Me.DGVBID.TabIndex = 41
        Me.DGVBID.Visible = False
        '
        'ChckRightNow
        '
        Me.ChckRightNow.AutoSize = True
        Me.ChckRightNow.BackColor = System.Drawing.Color.Transparent
        Me.ChckRightNow.Font = New System.Drawing.Font("Edwardian Script ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckRightNow.Location = New System.Drawing.Point(260, 176)
        Me.ChckRightNow.Name = "ChckRightNow"
        Me.ChckRightNow.Size = New System.Drawing.Size(97, 23)
        Me.ChckRightNow.TabIndex = 42
        Me.ChckRightNow.Text = "Right Now"
        Me.ChckRightNow.UseVisualStyleBackColor = False
        '
        'Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.ChckRightNow)
        Me.Controls.Add(Me.CmbTimeT)
        Me.Controls.Add(Me.TxtAddInfo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DGVT)
        Me.Controls.Add(Me.DGVB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblCID)
        Me.Controls.Add(Me.LblBI)
        Me.Controls.Add(Me.BtnComplete)
        Me.Controls.Add(Me.TxtTableNeeded)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.TxtTime)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.NudNoOfPpl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVBID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book"
        CType(Me.NudNoOfPpl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NudNoOfPpl As NumericUpDown
    Friend WithEvents TxtDate As TextBox
    Friend WithEvents TxtTime As TextBox
    Friend WithEvents TxtAddInfo As RichTextBox
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TxtTableNeeded As TextBox
    Friend WithEvents BtnComplete As Button
    Friend WithEvents LblBI As Label
    Friend WithEvents LblCID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVB As DataGridView
    Friend WithEvents DGVT As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbTimeT As ComboBox
    Friend WithEvents DGVBID As DataGridView
    Friend WithEvents ChckRightNow As CheckBox
End Class
