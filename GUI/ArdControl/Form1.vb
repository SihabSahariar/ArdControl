Imports System
Imports System.IO.Ports

Public Class Form1
    Dim vpb_sy, vpb_ly As Integer
    Dim TempL, HumL As Integer
    Dim Temp, Hum, TempResult, HumResult As String
    Dim TempToProgressBar As Single
    Dim ChartLimit As Integer = 30
    Dim StrSerialIn, StrSerialInRam As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PanelConnection.Focus()
        CircularProgressBarHumidity.Value = 0
        ComboBoxBaudRate.SelectedIndex = 0

        For i = 0 To 30 Step 1
            Chart1.Series("Humidity").Points.AddY(0)
            If Chart1.Series(0).Points.Count = ChartLimit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart2.Series("Temperature").Points.AddY(0)
            If Chart2.Series(0).Points.Count = ChartLimit Then
                Chart2.Series(0).Points.RemoveAt(0)
            End If
        Next

        Chart1.ChartAreas(0).AxisY.Maximum = 180
        Chart1.ChartAreas(0).AxisY.Minimum = -20
        Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False
        Chart2.ChartAreas(0).AxisY.Maximum = 70
        Chart2.ChartAreas(0).AxisY.Minimum = -30
        Chart2.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

        tmp.Value = 0
    End Sub

    Private Sub ComboBoxPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPort.SelectedIndexChanged
        PanelConnection.Focus()
    End Sub

    Private Sub ComboBoxPort_DropDown(sender As Object, e As EventArgs) Handles ComboBoxPort.DropDown
        PanelConnection.Focus()
    End Sub

    Private Sub ComboBoxPort_Click(sender As Object, e As EventArgs) Handles ComboBoxPort.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to change COM.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub

    Private Sub ComboBoxBaudRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.SelectedIndexChanged
        PanelConnection.Focus()
    End Sub

    Private Sub ComboBoxBaudRate_DropDown(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.DropDown
        PanelConnection.Focus()
    End Sub

    Private Sub ButtonConnect_Click_1(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        PanelConnection.Focus()
        Try
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            SerialPort1.Open()
            TimerSerial.Start()

            LabelStatus.Text = "Status : Connected"
            ButtonConnect.SendToBack()
            ButtonDisconnect.BringToFront()
            PictureBoxStatusConnection.BackColor = Color.Green
        Catch ex As Exception
            MsgBox("Please check the Hardware, COM, Baud Rate and try again.", MsgBoxStyle.Critical, "Connection failed !!!")
        End Try
    End Sub

    Private Sub PanelConnection_Paint(sender As Object, e As PaintEventArgs) Handles PanelConnection.Paint

    End Sub

    Private Sub ComboBoxBaudRate_Click(sender As Object, e As EventArgs) Handles ComboBoxBaudRate.Click
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to change Baud Rate.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        PanelConnection.Focus()
        If LabelStatus.Text = "Status : Connected" Then
            MsgBox("Conncetion in progress, please Disconnect to scan the new port.", MsgBoxStyle.Critical, "Warning !!!")
            Return
        End If
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs)
        PanelConnection.Focus()
        TimerSerial.Stop()
        SerialPort1.Close()
        ButtonDisconnect.SendToBack()
        ButtonConnect.BringToFront()
        LabelStatus.Text = "Status : Disconnect"
        PictureBoxStatusConnection.Visible = True
        PictureBoxStatusConnection.BackColor = Color.Red
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        PanelConnection.Focus()
        TimerSerial.Stop()
        SerialPort1.Close()
        ButtonDisconnect.SendToBack()
        ButtonConnect.BringToFront()
        LabelStatus.Text = "Status : Disconnect"
        PictureBoxStatusConnection.Visible = True
        PictureBoxStatusConnection.BackColor = Color.Red
    End Sub



    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting  '--> Read incoming serial data

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn   '--> Enter serial data into the textbox

            If TB.Lines.Count > 0 Then
                If TB.Lines(0) = "Failed to read from DHT sensor!" Then '--> Check Arduino if it fails to read the DHT sensor, if this happens the connection is disconnected
                    TimerSerial.Stop()
                    SerialPort1.Close()
                    LabelStatus.Text = "Status : Disconnect"
                    ButtonDisconnect.SendToBack()
                    ButtonConnect.BringToFront()
                    PictureBoxStatusConnection.Visible = True
                    PictureBoxStatusConnection.BackColor = Color.Red
                    MsgBox("Failed to read from DHT sensor !!!, Please check the Hardware and Please connect again.", MsgBoxStyle.Critical, "Connection failed !!!")
                    Return
                End If



                StrSerialInRam = TB.Lines(0).Substring(0, 1)
                If StrSerialInRam = "H" Then
                    Hum = TB.Lines(0)
                    HumL = Hum.Length
                Else
                    Hum = Hum
                End If

                StrSerialInRam = TB.Lines(1).Substring(0, 1)
                If StrSerialInRam = "T" Then
                    Temp = TB.Lines(1)
                    TempL = Temp.Length
                Else
                    Temp = Temp
                End If

                HumResult = Mid(Hum, 2, HumL)
                TempResult = Mid(Temp, 2, TempL)
                TempToProgressBar = TempResult

                CircularProgressBarHumidity.Value = Int(HumResult)
                LabelHumidity.Text = CircularProgressBarHumidity.Value & " %"


                LabelTemperature.Text = TempResult & " °C"

                tmp.Value = Int(TempResult)
                '------------------------------------------------------------------------------------------------------

                '-----------Enter the temperature and humidity values into the chart-----------------------------------
                Chart1.Series("Humidity").Points.AddY(HumResult)
                If Chart1.Series(0).Points.Count = ChartLimit Then
                    Chart1.Series(0).Points.RemoveAt(0)
                End If

                Chart2.Series("Temperature").Points.AddY(TempResult)
                If Chart2.Series(0).Points.Count = ChartLimit Then
                    Chart2.Series(0).Points.RemoveAt(0)
                End If
                '------------------------------------------------------------------------------------------------------

                '-----------If the Then connection Is successful And running, PictureBoxStatusConnection will blink----
                If PictureBoxStatusConnection.Visible = True Then
                    PictureBoxStatusConnection.Visible = False
                ElseIf PictureBoxStatusConnection.Visible = False Then
                    PictureBoxStatusConnection.Visible = True
                End If
                '------------------------------------------------------------------------------------------------------
            End If
        Catch ex As Exception
            TimerSerial.Stop()
            SerialPort1.Close()
            LabelStatus.Text = "Status : Disconnect"
            ButtonDisconnect.SendToBack()
            ButtonConnect.BringToFront()
            PictureBoxStatusConnection.BackColor = Color.Red
            MsgBox("Please check the Hardware and Please connect again." & ex.Message, MsgBoxStyle.Critical, "Connection failed !!!")
            Return
        End Try
    End Sub


End Class
