<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Summary))
        Me.ItemsOrderedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.The_Curry_GardenDataSet = New ProtoType1._0.The_Curry_GardenDataSet()
        Me.ItemsOrderedTableAdapter = New ProtoType1._0.The_Curry_GardenDataSetTableAdapters.ItemsOrderedTableAdapter()
        Me.LblOverallTotal = New System.Windows.Forms.Label()
        Me.LblOrderDate = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.TxtChoice = New System.Windows.Forms.TextBox()
        Me.CmbChoice = New System.Windows.Forms.ComboBox()
        Me.LblChoice = New System.Windows.Forms.Label()
        Me.LblOrderTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LblDay = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DGVSummary = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtPC = New System.Windows.Forms.TextBox()
        Me.DGVA = New System.Windows.Forms.DataGridView()
        Me.CmbAddresses = New System.Windows.Forms.ComboBox()
        Me.DGVPC = New System.Windows.Forms.DataGridView()
        Me.LblNewAdd = New System.Windows.Forms.Label()
        Me.DGVT = New System.Windows.Forms.DataGridView()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DGVOrders = New System.Windows.Forms.DataGridView()
        CType(Me.ItemsOrderedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.The_Curry_GardenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemsOrderedBindingSource
        '
        Me.ItemsOrderedBindingSource.DataMember = "ItemsOrdered"
        Me.ItemsOrderedBindingSource.DataSource = Me.The_Curry_GardenDataSet
        '
        'The_Curry_GardenDataSet
        '
        Me.The_Curry_GardenDataSet.DataSetName = "The_Curry_GardenDataSet"
        Me.The_Curry_GardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsOrderedTableAdapter
        '
        Me.ItemsOrderedTableAdapter.ClearBeforeFill = True
        '
        'LblOverallTotal
        '
        Me.LblOverallTotal.AutoSize = True
        Me.LblOverallTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOverallTotal.Location = New System.Drawing.Point(243, 526)
        Me.LblOverallTotal.Name = "LblOverallTotal"
        Me.LblOverallTotal.Size = New System.Drawing.Size(0, 24)
        Me.LblOverallTotal.TabIndex = 1
        '
        'LblOrderDate
        '
        Me.LblOrderDate.AutoSize = True
        Me.LblOrderDate.Location = New System.Drawing.Point(109, 374)
        Me.LblOrderDate.Name = "LblOrderDate"
        Me.LblOrderDate.Size = New System.Drawing.Size(62, 13)
        Me.LblOrderDate.TabIndex = 2
        Me.LblOrderDate.Text = "Order Date:"
        Me.LblOrderDate.Visible = False
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfirm.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.Location = New System.Drawing.Point(259, 589)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(170, 72)
        Me.BtnConfirm.TabIndex = 5
        Me.BtnConfirm.Text = "CONFIRM ORDER"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'TxtChoice
        '
        Me.TxtChoice.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChoice.Location = New System.Drawing.Point(140, 244)
        Me.TxtChoice.Name = "TxtChoice"
        Me.TxtChoice.Size = New System.Drawing.Size(121, 29)
        Me.TxtChoice.TabIndex = 6
        Me.TxtChoice.Visible = False
        '
        'CmbChoice
        '
        Me.CmbChoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbChoice.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbChoice.ForeColor = System.Drawing.Color.White
        Me.CmbChoice.FormattingEnabled = True
        Me.CmbChoice.Items.AddRange(New Object() {"In House", "Takeaway", "Delivery"})
        Me.CmbChoice.Location = New System.Drawing.Point(140, 208)
        Me.CmbChoice.Name = "CmbChoice"
        Me.CmbChoice.Size = New System.Drawing.Size(121, 30)
        Me.CmbChoice.TabIndex = 7
        '
        'LblChoice
        '
        Me.LblChoice.AutoSize = True
        Me.LblChoice.BackColor = System.Drawing.Color.Transparent
        Me.LblChoice.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChoice.Location = New System.Drawing.Point(12, 250)
        Me.LblChoice.Name = "LblChoice"
        Me.LblChoice.Size = New System.Drawing.Size(0, 23)
        Me.LblChoice.TabIndex = 8
        '
        'LblOrderTime
        '
        Me.LblOrderTime.AutoSize = True
        Me.LblOrderTime.Location = New System.Drawing.Point(244, 374)
        Me.LblOrderTime.Name = "LblOrderTime"
        Me.LblOrderTime.Size = New System.Drawing.Size(62, 13)
        Me.LblOrderTime.TabIndex = 13
        Me.LblOrderTime.Text = "OrderTime: "
        Me.LblOrderTime.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Type Of Order"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 505)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(197, 96)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = ""
        '
        'LblDay
        '
        Me.LblDay.AutoSize = True
        Me.LblDay.Location = New System.Drawing.Point(177, 374)
        Me.LblDay.Name = "LblDay"
        Me.LblDay.Size = New System.Drawing.Size(58, 13)
        Me.LblDay.TabIndex = 17
        Me.LblDay.Text = "Order Day:"
        Me.LblDay.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Additional Requirements"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-13, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 114)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Here's What You " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ordered"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(0, 613)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(91, 60)
        Me.BtnBack.TabIndex = 41
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'DGVSummary
        '
        Me.DGVSummary.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DGVSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSummary.Location = New System.Drawing.Point(12, 307)
        Me.DGVSummary.Name = "DGVSummary"
        Me.DGVSummary.Size = New System.Drawing.Size(417, 169)
        Me.DGVSummary.TabIndex = 43
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(283, 209)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(72, 29)
        Me.BtnAdd.TabIndex = 44
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.UseVisualStyleBackColor = False
        Me.BtnAdd.Visible = False
        '
        'TxtPC
        '
        Me.TxtPC.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TxtPC.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPC.Location = New System.Drawing.Point(333, 244)
        Me.TxtPC.Name = "TxtPC"
        Me.TxtPC.Size = New System.Drawing.Size(96, 29)
        Me.TxtPC.TabIndex = 45
        Me.TxtPC.Visible = False
        '
        'DGVA
        '
        Me.DGVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVA.Location = New System.Drawing.Point(285, 619)
        Me.DGVA.Name = "DGVA"
        Me.DGVA.Size = New System.Drawing.Size(87, 42)
        Me.DGVA.TabIndex = 46
        Me.DGVA.Visible = False
        '
        'CmbAddresses
        '
        Me.CmbAddresses.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbAddresses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbAddresses.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAddresses.ForeColor = System.Drawing.Color.White
        Me.CmbAddresses.FormattingEnabled = True
        Me.CmbAddresses.Location = New System.Drawing.Point(140, 243)
        Me.CmbAddresses.Name = "CmbAddresses"
        Me.CmbAddresses.Size = New System.Drawing.Size(187, 30)
        Me.CmbAddresses.TabIndex = 47
        Me.CmbAddresses.Visible = False
        '
        'DGVPC
        '
        Me.DGVPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPC.Location = New System.Drawing.Point(283, 605)
        Me.DGVPC.Name = "DGVPC"
        Me.DGVPC.Size = New System.Drawing.Size(87, 42)
        Me.DGVPC.TabIndex = 48
        Me.DGVPC.Visible = False
        '
        'LblNewAdd
        '
        Me.LblNewAdd.AutoSize = True
        Me.LblNewAdd.BackColor = System.Drawing.Color.Transparent
        Me.LblNewAdd.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewAdd.Location = New System.Drawing.Point(12, 281)
        Me.LblNewAdd.Name = "LblNewAdd"
        Me.LblNewAdd.Size = New System.Drawing.Size(0, 23)
        Me.LblNewAdd.TabIndex = 49
        '
        'DGVT
        '
        Me.DGVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVT.Location = New System.Drawing.Point(316, 605)
        Me.DGVT.Name = "DGVT"
        Me.DGVT.Size = New System.Drawing.Size(84, 30)
        Me.DGVT.TabIndex = 50
        Me.DGVT.Visible = False
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTotal.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Black
        Me.LblTotal.Location = New System.Drawing.Point(227, 521)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(128, 29)
        Me.LblTotal.TabIndex = 51
        Me.LblTotal.Text = "Overall Total:"
        '
        'DGVOrders
        '
        Me.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrders.Location = New System.Drawing.Point(313, 605)
        Me.DGVOrders.Name = "DGVOrders"
        Me.DGVOrders.Size = New System.Drawing.Size(87, 42)
        Me.DGVOrders.TabIndex = 52
        Me.DGVOrders.Visible = False
        '
        'Order_Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.DGVOrders)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblNewAdd)
        Me.Controls.Add(Me.CmbAddresses)
        Me.Controls.Add(Me.TxtPC)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DGVSummary)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblDay)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblOrderTime)
        Me.Controls.Add(Me.LblChoice)
        Me.Controls.Add(Me.CmbChoice)
        Me.Controls.Add(Me.TxtChoice)
        Me.Controls.Add(Me.LblOrderDate)
        Me.Controls.Add(Me.LblOverallTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVA)
        Me.Controls.Add(Me.DGVPC)
        Me.Controls.Add(Me.DGVT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Order_Summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order_Summary"
        CType(Me.ItemsOrderedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.The_Curry_GardenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents The_Curry_GardenDataSet As The_Curry_GardenDataSet
    Friend WithEvents ItemsOrderedBindingSource As BindingSource
    Friend WithEvents ItemsOrderedTableAdapter As The_Curry_GardenDataSetTableAdapters.ItemsOrderedTableAdapter
    Friend WithEvents LblOverallTotal As Label
    Friend WithEvents LblOrderDate As Label
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents TxtChoice As TextBox
    Friend WithEvents CmbChoice As ComboBox
    Friend WithEvents LblChoice As Label
    Friend WithEvents LblOrderTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents LblDay As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents DGVSummary As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtPC As TextBox
    Friend WithEvents DGVA As DataGridView
    Friend WithEvents CmbAddresses As ComboBox
    Friend WithEvents DGVPC As DataGridView
    Friend WithEvents LblNewAdd As Label
    Friend WithEvents DGVT As DataGridView
    Friend WithEvents LblTotal As Label
    Friend WithEvents DGVOrders As DataGridView
End Class
