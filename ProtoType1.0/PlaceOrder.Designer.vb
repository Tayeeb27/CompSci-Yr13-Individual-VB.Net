<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaceOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaceOrder))
        Me.CmbFilter = New System.Windows.Forms.ComboBox()
        Me.DGVMenu = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblOverallTotal = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnSub = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DGVCurrentOrder = New System.Windows.Forms.DataGridView()
        Me.CmbAllergy = New System.Windows.Forms.ComboBox()
        Me.DGVOID = New System.Windows.Forms.DataGridView()
        Me.ChckVegan = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCurrentOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbFilter
        '
        Me.CmbFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbFilter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbFilter.FormattingEnabled = True
        Me.CmbFilter.Items.AddRange(New Object() {"Starter", "Main", "Dessert", "Drink", "Alcohol", "Sundries", "Rice"})
        Me.CmbFilter.Location = New System.Drawing.Point(12, 158)
        Me.CmbFilter.Name = "CmbFilter"
        Me.CmbFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbFilter.Size = New System.Drawing.Size(121, 27)
        Me.CmbFilter.TabIndex = 55
        '
        'DGVMenu
        '
        Me.DGVMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVMenu.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DGVMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMenu.Location = New System.Drawing.Point(12, 191)
        Me.DGVMenu.Name = "DGVMenu"
        Me.DGVMenu.Size = New System.Drawing.Size(235, 280)
        Me.DGVMenu.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(11, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(404, 57)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Order Your Food Here"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblOverallTotal
        '
        Me.LblOverallTotal.AutoSize = True
        Me.LblOverallTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblOverallTotal.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOverallTotal.ForeColor = System.Drawing.Color.Black
        Me.LblOverallTotal.Location = New System.Drawing.Point(207, 631)
        Me.LblOverallTotal.Name = "LblOverallTotal"
        Me.LblOverallTotal.Size = New System.Drawing.Size(0, 29)
        Me.LblOverallTotal.TabIndex = 49
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfirm.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.Location = New System.Drawing.Point(322, 616)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(120, 57)
        Me.BtnConfirm.TabIndex = 47
        Me.BtnConfirm.Text = "CONFIRM ORDER"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        '
        'BtnSub
        '
        Me.BtnSub.BackColor = System.Drawing.Color.Transparent
        Me.BtnSub.BackgroundImage = CType(resources.GetObject("BtnSub.BackgroundImage"), System.Drawing.Image)
        Me.BtnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSub.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSub.ForeColor = System.Drawing.Color.White
        Me.BtnSub.Location = New System.Drawing.Point(343, 227)
        Me.BtnSub.Name = "BtnSub"
        Me.BtnSub.Size = New System.Drawing.Size(86, 73)
        Me.BtnSub.TabIndex = 57
        Me.BtnSub.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BackgroundImage = CType(resources.GetObject("BtnAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(254, 227)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(83, 73)
        Me.BtnAdd.TabIndex = 56
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.BackgroundImage = CType(resources.GetObject("BtnBack.BackgroundImage"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(0, 622)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(79, 51)
        Me.BtnBack.TabIndex = 53
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-9, -1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(467, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'DGVCurrentOrder
        '
        Me.DGVCurrentOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVCurrentOrder.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DGVCurrentOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCurrentOrder.Location = New System.Drawing.Point(12, 477)
        Me.DGVCurrentOrder.Name = "DGVCurrentOrder"
        Me.DGVCurrentOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCurrentOrder.Size = New System.Drawing.Size(403, 133)
        Me.DGVCurrentOrder.TabIndex = 58
        '
        'CmbAllergy
        '
        Me.CmbAllergy.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CmbAllergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbAllergy.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAllergy.FormattingEnabled = True
        Me.CmbAllergy.Items.AddRange(New Object() {"Nuts", "Milk", "Fish"})
        Me.CmbAllergy.Location = New System.Drawing.Point(139, 158)
        Me.CmbAllergy.Name = "CmbAllergy"
        Me.CmbAllergy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbAllergy.Size = New System.Drawing.Size(121, 27)
        Me.CmbAllergy.TabIndex = 59
        '
        'DGVOID
        '
        Me.DGVOID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVOID.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DGVOID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVOID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOID.Location = New System.Drawing.Point(282, 489)
        Me.DGVOID.Name = "DGVOID"
        Me.DGVOID.Size = New System.Drawing.Size(55, 40)
        Me.DGVOID.TabIndex = 60
        '
        'ChckVegan
        '
        Me.ChckVegan.AutoSize = True
        Me.ChckVegan.BackColor = System.Drawing.Color.Transparent
        Me.ChckVegan.Font = New System.Drawing.Font("Edwardian Script ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckVegan.Location = New System.Drawing.Point(282, 158)
        Me.ChckVegan.Name = "ChckVegan"
        Me.ChckVegan.Size = New System.Drawing.Size(79, 29)
        Me.ChckVegan.TabIndex = 61
        Me.ChckVegan.Text = "Vegan"
        Me.ChckVegan.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(343, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 33)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Edwardian Script ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(73, 635)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Overall Total:"
        '
        'PlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChckVegan)
        Me.Controls.Add(Me.CmbAllergy)
        Me.Controls.Add(Me.DGVCurrentOrder)
        Me.Controls.Add(Me.BtnSub)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.CmbFilter)
        Me.Controls.Add(Me.DGVMenu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblOverallTotal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.DGVOID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PlaceOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlaceOrder"
        CType(Me.DGVMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCurrentOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSub As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents CmbFilter As ComboBox
    Friend WithEvents DGVMenu As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents LblOverallTotal As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents DGVCurrentOrder As DataGridView
    Friend WithEvents CmbAllergy As ComboBox
    Friend WithEvents DGVOID As DataGridView
    Friend WithEvents ChckVegan As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
