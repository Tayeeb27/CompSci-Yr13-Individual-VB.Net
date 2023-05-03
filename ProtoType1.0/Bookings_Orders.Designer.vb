<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bookings_Orders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bookings_Orders))
        Me.The_Curry_GardenDataSet = New ProtoType1._0.The_Curry_GardenDataSet()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New ProtoType1._0.The_Curry_GardenDataSetTableAdapters.BookingTableAdapter()
        Me.DGVBooking = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DGVOrders = New System.Windows.Forms.DataGridView()
        Me.CmbChoice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderComplete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BookingComplete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.The_Curry_GardenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'The_Curry_GardenDataSet
        '
        Me.The_Curry_GardenDataSet.DataSetName = "The_Curry_GardenDataSet"
        Me.The_Curry_GardenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "Booking"
        Me.BookingBindingSource.DataSource = Me.The_Curry_GardenDataSet
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'DGVBooking
        '
        Me.DGVBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVBooking.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DGVBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBooking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingComplete})
        Me.DGVBooking.Location = New System.Drawing.Point(2, 255)
        Me.DGVBooking.Name = "DGVBooking"
        Me.DGVBooking.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVBooking.Size = New System.Drawing.Size(419, 256)
        Me.DGVBooking.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBack.Location = New System.Drawing.Point(2, 582)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(79, 51)
        Me.BtnBack.TabIndex = 38
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'DGVOrders
        '
        Me.DGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderComplete})
        Me.DGVOrders.Location = New System.Drawing.Point(-75, -297)
        Me.DGVOrders.Name = "DGVOrders"
        Me.DGVOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVOrders.Size = New System.Drawing.Size(419, 256)
        Me.DGVOrders.TabIndex = 39
        '
        'CmbChoice
        '
        Me.CmbChoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbChoice.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbChoice.ForeColor = System.Drawing.Color.White
        Me.CmbChoice.FormattingEnabled = True
        Me.CmbChoice.Items.AddRange(New Object() {"Bookings", "Orders"})
        Me.CmbChoice.Location = New System.Drawing.Point(116, 171)
        Me.CmbChoice.Name = "CmbChoice"
        Me.CmbChoice.Size = New System.Drawing.Size(173, 30)
        Me.CmbChoice.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 57)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Bookings And Orders"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderComplete
        '
        Me.OrderComplete.HeaderText = "Finished"
        Me.OrderComplete.Name = "OrderComplete"
        '
        'BookingComplete
        '
        Me.BookingComplete.HeaderText = "Finished"
        Me.BookingComplete.Name = "BookingComplete"
        '
        'Bookings_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(425, 634)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbChoice)
        Me.Controls.Add(Me.DGVOrders)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGVBooking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bookings_Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookings"
        CType(Me.The_Curry_GardenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents The_Curry_GardenDataSet As The_Curry_GardenDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As The_Curry_GardenDataSetTableAdapters.BookingTableAdapter
    Friend WithEvents DGVBooking As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents DGVOrders As DataGridView
    Friend WithEvents CmbChoice As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BookingComplete As DataGridViewCheckBoxColumn
    Friend WithEvents OrderComplete As DataGridViewCheckBoxColumn
End Class
