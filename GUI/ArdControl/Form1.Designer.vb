<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PanelConnection = New Guna.UI2.WinForms.Guna2Panel()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.LabelConnectionTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CircularProgressBarHumidity = New Guna.UI2.WinForms.Guna2RadialGauge()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelHumidity = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelHumidity = New System.Windows.Forms.Label()
        Me.tmp = New Guna.UI2.WinForms.Guna2VProgressBar()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelTemperature = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.PictureBoxStatusConnection = New System.Windows.Forms.PictureBox()
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.PanelConnection.SuspendLayout()
        Me.PanelHumidity.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxStatusConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelConnection
        '
        Me.PanelConnection.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.PanelConnection.Controls.Add(Me.ButtonConnect)
        Me.PanelConnection.Controls.Add(Me.ButtonDisconnect)
        Me.PanelConnection.Controls.Add(Me.ButtonScanPort)
        Me.PanelConnection.Controls.Add(Me.ComboBoxBaudRate)
        Me.PanelConnection.Controls.Add(Me.ComboBoxPort)
        Me.PanelConnection.Controls.Add(Me.LabelConnectionTitle)
        Me.PanelConnection.Controls.Add(Me.Label2)
        Me.PanelConnection.Controls.Add(Me.Label1)
        Me.PanelConnection.Location = New System.Drawing.Point(-6, 0)
        Me.PanelConnection.Name = "PanelConnection"
        Me.PanelConnection.ShadowDecoration.Parent = Me.PanelConnection
        Me.PanelConnection.Size = New System.Drawing.Size(1209, 123)
        Me.PanelConnection.TabIndex = 0
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDisconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDisconnect.Location = New System.Drawing.Point(755, 28)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(336, 53)
        Me.ButtonDisconnect.TabIndex = 2
        Me.ButtonDisconnect.Text = "DISCONNECT"
        Me.ButtonDisconnect.UseVisualStyleBackColor = False
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonScanPort.Location = New System.Drawing.Point(446, 28)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(255, 53)
        Me.ButtonScanPort.TabIndex = 2
        Me.ButtonScanPort.Text = "SCAN PORT"
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"9600", "14400", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(158, 57)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(240, 24)
        Me.ComboBoxBaudRate.TabIndex = 1
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(158, 28)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(240, 24)
        Me.ComboBoxPort.TabIndex = 1
        '
        'LabelConnectionTitle
        '
        Me.LabelConnectionTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelConnectionTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConnectionTitle.ForeColor = System.Drawing.Color.Transparent
        Me.LabelConnectionTitle.Location = New System.Drawing.Point(168, 0)
        Me.LabelConnectionTitle.Name = "LabelConnectionTitle"
        Me.LabelConnectionTitle.Size = New System.Drawing.Size(150, 30)
        Me.LabelConnectionTitle.TabIndex = 3
        Me.LabelConnectionTitle.Text = "CONNECTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BAUDRATE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port :"
        '
        'CircularProgressBarHumidity
        '
        Me.CircularProgressBarHumidity.ArrowColor = System.Drawing.Color.Teal
        Me.CircularProgressBarHumidity.FillColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CircularProgressBarHumidity.Font = New System.Drawing.Font("Verdana", 8.2!)
        Me.CircularProgressBarHumidity.ForeColor = System.Drawing.Color.White
        Me.CircularProgressBarHumidity.Location = New System.Drawing.Point(123, 3)
        Me.CircularProgressBarHumidity.MinimumSize = New System.Drawing.Size(30, 30)
        Me.CircularProgressBarHumidity.Name = "CircularProgressBarHumidity"
        Me.CircularProgressBarHumidity.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CircularProgressBarHumidity.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CircularProgressBarHumidity.ProgressThickness = 20
        Me.CircularProgressBarHumidity.Size = New System.Drawing.Size(255, 255)
        Me.CircularProgressBarHumidity.TabIndex = 1
        Me.CircularProgressBarHumidity.Value = 90
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-6, 774)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1153, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Copyright©2021,Sihab Sahariar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelHumidity
        '
        Me.PanelHumidity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelHumidity.Controls.Add(Me.LabelHumidity)
        Me.PanelHumidity.Controls.Add(Me.CircularProgressBarHumidity)
        Me.PanelHumidity.Location = New System.Drawing.Point(29, 157)
        Me.PanelHumidity.Name = "PanelHumidity"
        Me.PanelHumidity.ShadowDecoration.Parent = Me.PanelHumidity
        Me.PanelHumidity.Size = New System.Drawing.Size(513, 263)
        Me.PanelHumidity.TabIndex = 9
        '
        'LabelHumidity
        '
        Me.LabelHumidity.AutoSize = True
        Me.LabelHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHumidity.ForeColor = System.Drawing.Color.White
        Me.LabelHumidity.Location = New System.Drawing.Point(213, 213)
        Me.LabelHumidity.Name = "LabelHumidity"
        Me.LabelHumidity.Size = New System.Drawing.Size(79, 36)
        Me.LabelHumidity.TabIndex = 2
        Me.LabelHumidity.Text = "70%"
        '
        'tmp
        '
        Me.tmp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.tmp.Location = New System.Drawing.Point(254, 3)
        Me.tmp.Name = "tmp"
        Me.tmp.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid
        Me.tmp.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tmp.ShadowDecoration.Parent = Me.tmp
        Me.tmp.Size = New System.Drawing.Size(59, 207)
        Me.tmp.TabIndex = 10
        Me.tmp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.tmp.Value = 90
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.tmp)
        Me.Guna2Panel1.Controls.Add(Me.LabelTemperature)
        Me.Guna2Panel1.Location = New System.Drawing.Point(566, 157)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(519, 263)
        Me.Guna2Panel1.TabIndex = 9
        '
        'LabelTemperature
        '
        Me.LabelTemperature.AutoSize = True
        Me.LabelTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemperature.ForeColor = System.Drawing.Color.White
        Me.LabelTemperature.Location = New System.Drawing.Point(233, 213)
        Me.LabelTemperature.Name = "LabelTemperature"
        Me.LabelTemperature.Size = New System.Drawing.Size(104, 38)
        Me.LabelTemperature.TabIndex = 0
        Me.LabelTemperature.Text = "65 °C"
        '
        'Chart1
        '
        ChartArea11.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend11)
        Me.Chart1.Location = New System.Drawing.Point(36, 442)
        Me.Chart1.Name = "Chart1"
        Series11.BorderWidth = 5
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series11.Legend = "Legend1"
        Series11.Name = "Humidity"
        Me.Chart1.Series.Add(Series11)
        Me.Chart1.Size = New System.Drawing.Size(506, 300)
        Me.Chart1.TabIndex = 10
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea12.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea12)
        Legend12.BackColor = System.Drawing.Color.Transparent
        Legend12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Legend12.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend12)
        Me.Chart2.Location = New System.Drawing.Point(566, 442)
        Me.Chart2.Name = "Chart2"
        Series12.BorderColor = System.Drawing.Color.White
        Series12.BorderWidth = 4
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series12.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series12.Legend = "Legend1"
        Series12.Name = "Temperature"
        Me.Chart2.Series.Add(Series12)
        Me.Chart2.Size = New System.Drawing.Size(519, 300)
        Me.Chart2.TabIndex = 10
        Me.Chart2.Text = "Chart1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(244, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Humidity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(792, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Temperature"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelStatus.Location = New System.Drawing.Point(32, 754)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(170, 20)
        Me.LabelStatus.TabIndex = 0
        Me.LabelStatus.Text = "Status: Disconnect"
        '
        'PictureBoxStatusConnection
        '
        Me.PictureBoxStatusConnection.BackColor = System.Drawing.Color.Red
        Me.PictureBoxStatusConnection.Location = New System.Drawing.Point(208, 757)
        Me.PictureBoxStatusConnection.Name = "PictureBoxStatusConnection"
        Me.PictureBoxStatusConnection.Size = New System.Drawing.Size(16, 17)
        Me.PictureBoxStatusConnection.TabIndex = 11
        Me.PictureBoxStatusConnection.TabStop = False
        '
        'TimerSerial
        '
        Me.TimerSerial.Interval = 500
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonConnect.Location = New System.Drawing.Point(755, 29)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(336, 53)
        Me.ButtonConnect.TabIndex = 4
        Me.ButtonConnect.Text = "CONNECT"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 798)
        Me.Controls.Add(Me.PictureBoxStatusConnection)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.PanelHumidity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PanelConnection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArdControl GUI"
        Me.PanelConnection.ResumeLayout(False)
        Me.PanelConnection.PerformLayout()
        Me.PanelHumidity.ResumeLayout(False)
        Me.PanelHumidity.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxStatusConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelConnection As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents CircularProgressBarHumidity As Guna.UI2.WinForms.Guna2RadialGauge
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelConnectionTitle As Label
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents PanelHumidity As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tmp As Guna.UI2.WinForms.Guna2VProgressBar
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelTemperature As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelHumidity As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PictureBoxStatusConnection As PictureBox
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ButtonConnect As Button
End Class
