Public Class AppForm
    Dim ColorObject, ColorBackground, ColorErase As Color
    Dim Speed, Fuel, Temp, FuelRate, MaxSpeed, MaxFuel, MaxTemp, CurState As Integer
    Private AppCore As New AppCore

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim result = AppCore.SimplSerial.Request(0, 1, {})
            Speed = result.Data(0)
            UpdateSpeed()
        Catch ex As Exception
            TextBox2.Text = ex.Message.ToString
            If ex.Message.ToString = "Specified port is not open." Or ex.Message.ToString = "Порт закрыт." Then
                SimplSerialConnect()
            End If
        End Try
    End Sub

    Private Sub SetColor()
        ColorObject = Color.FromArgb(255, 165, 0)
        ColorBackground = Color.FromArgb(64, 64, 64)
        ColorErase = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub UpdateFuelRate()
        Dim GraphicFuelRate As Graphics
        Dim MaxFuelRate As Integer
        GraphicFuelRate = PicFuelRate.CreateGraphics
        MaxFuelRate = 50
        If FuelRate < 0 Then FuelRate = 0
        If FuelRate > MaxFuelRate Then FuelRate = MaxFuelRate
        Dim x0, y0, x1, y1 As Integer
        Dim brush1 As New SolidBrush(ColorObject)
        x0 = 0
        y0 = 0
        x1 = PicFuelRate.Width / MaxFuelRate * FuelRate
        y1 = PicFuelRate.Height
        GraphicFuelRate.Clear(ColorBackground)
        GraphicFuelRate.FillRectangle(brush1, x0, y0, x1, y1)
    End Sub

    Private Sub UpdateTemp()
        Dim GraphicTemp As Graphics
        GraphicTemp = PicTemp.CreateGraphics
        MaxTemp = 100
        If Temp < 0 Then Temp = 0
        If Temp > MaxTemp Then Temp = MaxTemp
        Dim x0, y0, x1, y1 As Integer
        Dim brush1 As New SolidBrush(ColorObject)
        x0 = 0
        y0 = PicTemp.Height - (PicTemp.Height / MaxTemp * Temp)
        x1 = PicTemp.Width
        y1 = PicTemp.Height
        GraphicTemp.Clear(ColorBackground)
        GraphicTemp.FillRectangle(brush1, x0, y0, x1, y1)
    End Sub

    Private Sub UpdateFuel()
        Dim GraphicFuel As Graphics
        GraphicFuel = PicFuel.CreateGraphics
        MaxFuel = 36
        If Fuel < 0 Then Fuel = 0
        If Fuel > MaxFuel Then Fuel = MaxFuel
        Dim x0, y0, x1, y1 As Integer
        Dim brush1 As New SolidBrush(ColorObject)
        x0 = 0
        y0 = PicFuel.Height - (PicFuel.Height / MaxFuel * Fuel)
        x1 = PicFuel.Width
        y1 = PicFuel.Height
        GraphicFuel.Clear(ColorBackground)
        GraphicFuel.FillRectangle(brush1, x0, y0, x1, y1)
    End Sub

    Private Sub UpdateSpeed()
        Dim GraphicSpeed As Graphics
        GraphicSpeed = PicSpeed.CreateGraphics
        Dim Radius, AngleStart, AngleSweep As Integer
        Dim Xarc, Yarc, angle1, angle2, AngleStep As Single
        Dim PenDrawing As New Pen(ColorObject, 20)
        Dim PenErase As New Pen(ColorErase, 20)
        Radius = 590
        AngleStart = 300
        AngleSweep = 60
        MaxSpeed = 180
        AngleStep = 0.333
        Xarc = -246.5
        Yarc = 19.5
        If Speed < 0 Then Speed = 0
        If Speed > 180 Then Speed = 180
        lbSpeed.Text = Speed
        angle1 = AngleStart - (MaxSpeed - Speed) * AngleStep
        angle2 = -(AngleSweep - (MaxSpeed - Speed) * AngleStep)
        GraphicSpeed.DrawArc(PenErase, Xarc, Yarc, Radius * 2, Radius * 2, 300, -60)
        GraphicSpeed.DrawArc(PenDrawing, Xarc, Yarc, Radius * 2, Radius * 2, angle1, angle2)
    End Sub
    'GraphicSpeed.Clear(ColorBackground)
    'GraphicSpeed.DrawImage(My.Resources.SpeedScale, 0, 0)
    'Graph1.DrawArc(Pen1, x0, y0, radius * 2, radius * 2, 300, -60)

    Private Sub btForw_Click(sender As Object, e As EventArgs) Handles btForw.Click
        Speed = Speed + 5
        Fuel = Fuel + 5
        Temp = Temp + 5
        FuelRate = FuelRate + 5
        UpdateSpeed()
        UpdateFuel()
        UpdateTemp()
        UpdateFuelRate()
    End Sub

    Private Sub btRev_Click(sender As Object, e As EventArgs) Handles btRev.Click
        Speed = Speed - 5
        Fuel = Fuel - 5
        Temp = Temp - 5
        FuelRate = FuelRate - 5
        UpdateSpeed()
        UpdateFuel()
        UpdateTemp()
        UpdateFuelRate()
    End Sub

    Private Sub AppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetColor()
    End Sub

    Private Sub SimplSerialConnect()
        AppCore.FindPort()
        If AppCore.SimplSerial.IsConnected = True Then
            TextBox1.Text = AppCore.PortName + " " + AppCore.DeviceName
            TextBox2.Text = ""
        Else
            TextBox1.Text = "No found"
        End If
    End Sub

    Private Sub AppForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'SimplSerialConnect()
        Timer1.Enabled = True
    End Sub
End Class

'Движение стрелки по кругу
'Const radian = (22 / 7) / 180
'Dim a, b
'a = radius * Math.Cos(angle * radian)
'b = radius * Math.Sin(angle * radian)
'x = x0 + b
'y = y0 - a
'Graph1.DrawLine(Pen1, x0, y0, x, y)
