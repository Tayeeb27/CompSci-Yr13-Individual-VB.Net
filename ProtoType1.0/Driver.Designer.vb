<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Driver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Driver))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.BtnMyAcc = New System.Windows.Forms.Button()
        Me.DGVOrders = New System.Windows.Forms.DataGridView()
        Me.DeliveryFinished = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DeliveryStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGVOtherInfo = New System.Windows.Forms.DataGridView()
        Me.DGVOrder = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOtherInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'BtnSignOut
        '
        Me.BtnSignOut.BackColor = System.Drawing.Color.Transparent
        Me.BtnSignOut.BackgroundImage = CType(resources.GetObject("BtnSignOut.BackgroundImage"), System.Drawing.Image)
        Me.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignOut.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignOut.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSignOut.Location = New System.Drawing.Point(254, 620)
        Me.BtnSignOut.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(185, 53)
        Me.BtnSignOut.TabIndex = 67
        Me.BtnSignOut.UseVisualStyleBackColor = False
        '
        'BtnMyAcc
        '
        Me.BtnMyAcc.BackColor = System.Drawing.Color.Transparent
        Me.BtnMyAcc.BackgroundImage = CType(resources.GetObject("BtnMyAcc.BackgroundImage"), System.Drawing.Image)
        Me.BtnMyAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMyAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMyAcc.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMyAcc.ForeColor = System.Drawing.Color.White
        Me.BtnMyAcc.Location = New System.Drawing.Point(11, 591)
        Me.BtnMyAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMyAcc.Name = "BtnMyAcc"
        Me.BtnMyAcc.Size = New System.Drawing.Size(120, 71)
        Me.BtnMyAcc.TabIndex = 80
        Me.BtnMyAcc.UseVisualStyleBackColor = False
        '
        'DGVOrders
        '
        Me.DGVOrders.AllowUserToOrderColumns = True
        Me.DGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeliveryFinished, Me.DeliveryStatus})
        Me.DGVOrders.Location = New System.Drawing.Point(11, 102)
        Me.DGVOrders.Name = "DGVOrders"
        Me.DGVOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVOrders.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOrders.Size = New System.Drawing.Size(417, 185)
        Me.DGVOrders.TabIndex = 81
        '
        'DeliveryFinished
        '
        Me.DeliveryFinished.HeaderText = "Finished"
        Me.DeliveryFinished.Name = "DeliveryFinished"
        '
        'DeliveryStatus
        '
        Me.DeliveryStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DeliveryStatus.HeaderText = "Status"
        Me.DeliveryStatus.Items.AddRange(New Object() {"Haven't Left", "En Route", "Here"})
        Me.DeliveryStatus.Name = "DeliveryStatus"
        Me.DeliveryStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeliveryStatus.Width = 64
        '
        'DGVOtherInfo
        '
        Me.DGVOtherInfo.AllowUserToOrderColumns = True
        Me.DGVOtherInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVOtherInfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVOtherInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVOtherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOtherInfo.Location = New System.Drawing.Point(12, 293)
        Me.DGVOtherInfo.Name = "DGVOtherInfo"
        Me.DGVOtherInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVOtherInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVOtherInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOtherInfo.Size = New System.Drawing.Size(417, 88)
        Me.DGVOtherInfo.TabIndex = 82
        '
        'DGVOrder
        '
        Me.DGVOrder.AllowUserToOrderColumns = True
        Me.DGVOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVOrder.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrder.Location = New System.Drawing.Point(12, 387)
        Me.DGVOrder.Name = "DGVOrder"
        Me.DGVOrder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGVOrder.Size = New System.Drawing.Size(417, 113)
        Me.DGVOrder.TabIndex = 84
        '
        'Driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.DGVOrder)
        Me.Controls.Add(Me.DGVOtherInfo)
        Me.Controls.Add(Me.DGVOrders)
        Me.Controls.Add(Me.BtnMyAcc)
        Me.Controls.Add(Me.BtnSignOut)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Driver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driver"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOtherInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents BtnMyAcc As Button
    Friend WithEvents DGVOrders As DataGridView
    Friend WithEvents DGVOtherInfo As DataGridView
    Friend WithEvents DGVOrder As DataGridView
    Friend WithEvents DeliveryFinished As DataGridViewCheckBoxColumn
    Friend WithEvents DeliveryStatus As DataGridViewComboBoxColumn
End Class
