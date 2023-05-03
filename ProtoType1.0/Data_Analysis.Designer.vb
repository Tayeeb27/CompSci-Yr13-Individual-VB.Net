<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Analysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Analysis))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.LblTotalCustomer = New System.Windows.Forms.Label()
        Me.LblDWLC = New System.Windows.Forms.Label()
        Me.LblToDWLC = New System.Windows.Forms.Label()
        Me.LblMPD = New System.Windows.Forms.Label()
        Me.DGVOrders = New System.Windows.Forms.DataGridView()
        Me.DGVMPD = New System.Windows.Forms.DataGridView()
        Me.DGVDay = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ChartMPD = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnHideMPD = New System.Windows.Forms.Button()
        Me.BtnShowMPD = New System.Windows.Forms.Button()
        Me.ChartCTD = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DGVAnalysis = New System.Windows.Forms.DataGridView()
        Me.BtnChartShow = New System.Windows.Forms.Button()
        Me.BtnChartHide = New System.Windows.Forms.Button()
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMPD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartMPD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartCTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTotalCustomer
        '
        Me.LblTotalCustomer.AutoSize = True
        Me.LblTotalCustomer.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalCustomer.Font = New System.Drawing.Font("Edwardian Script ITC", 20.0!)
        Me.LblTotalCustomer.Location = New System.Drawing.Point(12, 168)
        Me.LblTotalCustomer.Name = "LblTotalCustomer"
        Me.LblTotalCustomer.Size = New System.Drawing.Size(223, 33)
        Me.LblTotalCustomer.TabIndex = 0
        Me.LblTotalCustomer.Text = "Total Customers Entered:"
        '
        'LblDWLC
        '
        Me.LblDWLC.AutoSize = True
        Me.LblDWLC.BackColor = System.Drawing.Color.Transparent
        Me.LblDWLC.Font = New System.Drawing.Font("Edwardian Script ITC", 20.0!)
        Me.LblDWLC.Location = New System.Drawing.Point(12, 206)
        Me.LblDWLC.Name = "LblDWLC"
        Me.LblDWLC.Size = New System.Drawing.Size(245, 33)
        Me.LblDWLC.TabIndex = 1
        Me.LblDWLC.Text = "Day With Least Customers:"
        '
        'LblToDWLC
        '
        Me.LblToDWLC.AutoSize = True
        Me.LblToDWLC.BackColor = System.Drawing.Color.Transparent
        Me.LblToDWLC.Font = New System.Drawing.Font("Edwardian Script ITC", 20.0!)
        Me.LblToDWLC.Location = New System.Drawing.Point(13, 278)
        Me.LblToDWLC.Name = "LblToDWLC"
        Me.LblToDWLC.Size = New System.Drawing.Size(309, 33)
        Me.LblToDWLC.TabIndex = 2
        Me.LblToDWLC.Text = "Time Of Day with Least Customers:"
        '
        'LblMPD
        '
        Me.LblMPD.AutoSize = True
        Me.LblMPD.BackColor = System.Drawing.Color.Transparent
        Me.LblMPD.Font = New System.Drawing.Font("Edwardian Script ITC", 20.0!)
        Me.LblMPD.Location = New System.Drawing.Point(12, 242)
        Me.LblMPD.Name = "LblMPD"
        Me.LblMPD.Size = New System.Drawing.Size(180, 33)
        Me.LblMPD.TabIndex = 4
        Me.LblMPD.Text = "Most Popular Dish:"
        '
        'DGVOrders
        '
        Me.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrders.Location = New System.Drawing.Point(203, 369)
        Me.DGVOrders.Name = "DGVOrders"
        Me.DGVOrders.Size = New System.Drawing.Size(143, 69)
        Me.DGVOrders.TabIndex = 7
        Me.DGVOrders.Visible = False
        '
        'DGVMPD
        '
        Me.DGVMPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMPD.Location = New System.Drawing.Point(203, 369)
        Me.DGVMPD.Name = "DGVMPD"
        Me.DGVMPD.Size = New System.Drawing.Size(129, 51)
        Me.DGVMPD.TabIndex = 8
        Me.DGVMPD.Visible = False
        '
        'DGVDay
        '
        Me.DGVDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDay.Location = New System.Drawing.Point(203, 369)
        Me.DGVDay.Name = "DGVDay"
        Me.DGVDay.Size = New System.Drawing.Size(143, 69)
        Me.DGVDay.TabIndex = 35
        Me.DGVDay.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-13, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(0, 613)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(91, 60)
        Me.BtnBack.TabIndex = 39
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'ChartMPD
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartMPD.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartMPD.Legends.Add(Legend1)
        Me.ChartMPD.Location = New System.Drawing.Point(97, 364)
        Me.ChartMPD.Name = "ChartMPD"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.CustomProperties = "PieLineColor=White, PieDrawingStyle=Concave, PieLabelStyle=Disabled"
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Dish"
        Me.ChartMPD.Series.Add(Series1)
        Me.ChartMPD.Size = New System.Drawing.Size(344, 309)
        Me.ChartMPD.TabIndex = 40
        Me.ChartMPD.Text = "Most Popular Dish"
        Title1.Font = New System.Drawing.Font("Edwardian Script ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Most Popular Dish"
        Title1.Text = "Most Popular Dish"
        Me.ChartMPD.Titles.Add(Title1)
        Me.ChartMPD.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Edwardian Script ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 57)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Data Analysis"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHideMPD
        '
        Me.BtnHideMPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnHideMPD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHideMPD.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHideMPD.ForeColor = System.Drawing.Color.White
        Me.BtnHideMPD.Location = New System.Drawing.Point(221, 324)
        Me.BtnHideMPD.Name = "BtnHideMPD"
        Me.BtnHideMPD.Size = New System.Drawing.Size(161, 34)
        Me.BtnHideMPD.TabIndex = 42
        Me.BtnHideMPD.Text = "Hide Chart"
        Me.BtnHideMPD.UseVisualStyleBackColor = False
        '
        'BtnShowMPD
        '
        Me.BtnShowMPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnShowMPD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShowMPD.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowMPD.ForeColor = System.Drawing.Color.White
        Me.BtnShowMPD.Location = New System.Drawing.Point(221, 324)
        Me.BtnShowMPD.Name = "BtnShowMPD"
        Me.BtnShowMPD.Size = New System.Drawing.Size(161, 34)
        Me.BtnShowMPD.TabIndex = 43
        Me.BtnShowMPD.Text = "View Chart"
        Me.BtnShowMPD.UseVisualStyleBackColor = False
        '
        'ChartCTD
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartCTD.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartCTD.Legends.Add(Legend2)
        Me.ChartCTD.Location = New System.Drawing.Point(92, 361)
        Me.ChartCTD.Name = "ChartCTD"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartCTD.Series.Add(Series2)
        Me.ChartCTD.Size = New System.Drawing.Size(349, 312)
        Me.ChartCTD.TabIndex = 44
        Me.ChartCTD.Text = "Chart1"
        '
        'DGVAnalysis
        '
        Me.DGVAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAnalysis.Location = New System.Drawing.Point(203, 385)
        Me.DGVAnalysis.Name = "DGVAnalysis"
        Me.DGVAnalysis.Size = New System.Drawing.Size(143, 69)
        Me.DGVAnalysis.TabIndex = 45
        Me.DGVAnalysis.Visible = False
        '
        'BtnChartShow
        '
        Me.BtnChartShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnChartShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnChartShow.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChartShow.ForeColor = System.Drawing.Color.White
        Me.BtnChartShow.Location = New System.Drawing.Point(31, 324)
        Me.BtnChartShow.Name = "BtnChartShow"
        Me.BtnChartShow.Size = New System.Drawing.Size(161, 34)
        Me.BtnChartShow.TabIndex = 46
        Me.BtnChartShow.Text = "View Chart"
        Me.BtnChartShow.UseVisualStyleBackColor = False
        '
        'BtnChartHide
        '
        Me.BtnChartHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnChartHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnChartHide.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChartHide.ForeColor = System.Drawing.Color.White
        Me.BtnChartHide.Location = New System.Drawing.Point(31, 324)
        Me.BtnChartHide.Name = "BtnChartHide"
        Me.BtnChartHide.Size = New System.Drawing.Size(161, 34)
        Me.BtnChartHide.TabIndex = 47
        Me.BtnChartHide.Text = "Hide Chart"
        Me.BtnChartHide.UseVisualStyleBackColor = False
        '
        'Data_Analysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(441, 673)
        Me.Controls.Add(Me.BtnChartShow)
        Me.Controls.Add(Me.ChartCTD)
        Me.Controls.Add(Me.BtnShowMPD)
        Me.Controls.Add(Me.BtnHideMPD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChartMPD)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGVDay)
        Me.Controls.Add(Me.DGVMPD)
        Me.Controls.Add(Me.DGVOrders)
        Me.Controls.Add(Me.LblMPD)
        Me.Controls.Add(Me.LblToDWLC)
        Me.Controls.Add(Me.LblDWLC)
        Me.Controls.Add(Me.LblTotalCustomer)
        Me.Controls.Add(Me.DGVAnalysis)
        Me.Controls.Add(Me.BtnChartHide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Data_Analysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data_Analysis"
        CType(Me.DGVOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMPD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartMPD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTotalCustomer As Label
    Friend WithEvents LblDWLC As Label
    Friend WithEvents LblToDWLC As Label
    Friend WithEvents LblMPD As Label
    Friend WithEvents DGVOrders As DataGridView
    Friend WithEvents DGVMPD As DataGridView
    Friend WithEvents DGVDay As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents ChartMPD As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnHideMPD As Button
    Friend WithEvents BtnShowMPD As Button
    Friend WithEvents ChartCTD As DataVisualization.Charting.Chart
    Friend WithEvents DGVAnalysis As DataGridView
    Friend WithEvents BtnChartShow As Button
    Friend WithEvents BtnChartHide As Button
End Class
