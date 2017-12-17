Public Class AppForm
    Private AppCore As New AppCore
    Dim ColorObject, ColorBackground, ColorErase As Color
    Dim Speed, Fuel, Temp, MaxSpeed, MaxFuel, MaxTemp, SpdImpCountOverTime As Integer
    Dim FuelRateMlS, FuelRateL100km, FuelRateLH As Double
    Dim InjSumHighLev, InjWidthHLev, InjWidthLLev As Double
    Dim SpdWidthHLev, SpdWidthLLev, SpdSumPeriod As Double

    Private Sub btLEDoff_Click(sender As Object, e As EventArgs) Handles btLEDoff.Click
        Dim result = AppCore.SimplSerial.Request(0, 5, {})
    End Sub

    Private Sub btLEDon_Click(sender As Object, e As EventArgs) Handles btLEDon.Click
        Dim result = AppCore.SimplSerial.Request(0, 4, {})
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetData()
    End Sub

    Private Sub SetColor()
        ColorObject = Color.FromArgb(255, 165, 0)
        ColorBackground = Color.FromArgb(64, 64, 64)
        ColorErase = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub GetData()
        TextBox2.Text = ""
        TextBox3.Text = ""
        Try
            'Получаем ширину импулься форсунки
            Dim result = AppCore.SimplSerial.Request(0, 1, {})
            'Делим на 10 для получения одного знака после запятой
            InjWidthHLev = result.Data(0) / 10
            InjWidthLLev = result.Data(1)
            'Складываем высокий и низкий уровни, получаем период, делим 1000 млс на кол-во периодов, умножаем на высокий уровень, получаем время открытия за 1с
            InjSumHighLev = (1000 / (InjWidthLLev + InjWidthHLev)) * InjWidthHLev
            'Получаем ширину импульса скорости
            result = AppCore.SimplSerial.Request(0, 2, {})
            SpdWidthHLev = result.Data(0)
            SpdWidthLLev = result.Data(1)
            'Если получили ноль, то будет ошибка при делнии на ноль, устанавливаем макс. значение
            If SpdWidthHLev = 0 Then SpdWidthHLev = 500
            'Ширина импульса при котором уже можно считать - 40мс
            'Высокий и низкий уровни одинаковой ширины, меняется только частота
            SpdImpCountOverTime = 1000 / (SpdWidthHLev * 2)
            TextBox4.Text = SpdWidthHLev.ToString + " " + SpdWidthLLev.ToString + " " + SpdImpCountOverTime.ToString
            ProcessData()
            ShowSpeed()
            ShowFuelRate()
        Catch ex As Exception
            TextBox2.Text = ex.Message.ToString
            If ex.Message.ToString = "Specified port is not open." Or ex.Message.ToString = "Порт закрыт." Then
                SimplSerialConnect()
            End If
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetData()
    End Sub

    Private Sub ProcessData()
        '130 производительность в мл/мин, делим на 60, получаем в мл/сек, умножаем на кол-во форсунок
        Dim InJCapacity As Double = 130 / 60 * 3
        Dim SpeedCorrection As Integer = 13
        '0.025м в дюйме
        '13 радиус колеса в дюймах
        '2*3.14 - пи*2*радиус - длина окружности (колеса)
        'Примерно 2 м
        Dim LenghWheel As Double = 0.025 * 13 * 2 * 3.14
        'ВЫЧИСЛЯЕМ СКОРОСТЬ
        '3.6 км/ч в 1 м/с
        SpdImpCountOverTime = SpdImpCountOverTime / SpeedCorrection

        Speed = SpdImpCountOverTime * LenghWheel * 3.6
        If SpdImpCountOverTime < 2 Then Speed = 0
        'ВЫЧИСЛЯЕМ РАСХОД
        'Расход в мл/с, время открытия в мс, делим на 1000, получаем в сек
        FuelRateMlS = InjSumHighLev / 1000 * InJCapacity
        'Если скорость меньше 1 (холостой ход), считаем л/ч
        '3600 делим сразу на 1000 получаем 3.6
        FuelRateLH = FuelRateMlS * 3.6
        'Расход в л/100км
        'Делим путь на скорость, получаем время в часах, умножаем на 3600, получаем в секундах
        'Умножаем на расход в мл/с, делим на 1000 для результата в литрах
        '3600 делим сразу на 1000 получаем 3.6
        FuelRateL100km = 100 / Speed * FuelRateMlS * 3.6
        TextBox3.Text = InjSumHighLev.ToString("0.00") + " " + FuelRateLH.ToString("0.00") + " " + InjWidthHLev.ToString + " " + InjWidthLLev.ToString
    End Sub

    Private Sub ShowFuelRate()
        Dim GraphicFuelRate As Graphics = PicFuelRate.CreateGraphics
        Dim MaxFuelRate As Integer = 50
        Dim x0, y0, x1, y1 As Integer
        Dim brush1 As New SolidBrush(ColorObject)
        x0 = 0
        y0 = 0
        y1 = PicFuelRate.Height
        If Speed < 1 Then
            x1 = PicFuelRate.Width / 5 * FuelRateLH
            LbFuelRate.Text = FuelRateLH.ToString("0.00") + " л/ч"
        Else
            x1 = PicFuelRate.Width / MaxFuelRate * FuelRateL100km
            LbFuelRate.Text = FuelRateL100km.ToString("0.00") + " л/100 км"
        End If
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

    Private Sub ShowSpeed()
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
        'FuelRate = FuelRate + 5
        ShowSpeed()
        UpdateFuel()
        UpdateTemp()
        ShowFuelRate()
    End Sub

    Private Sub btRev_Click(sender As Object, e As EventArgs) Handles btRev.Click
        Speed = Speed - 5
        Fuel = Fuel - 5
        Temp = Temp - 5
        'FuelRate = FuelRate - 5
        ShowSpeed()
        UpdateFuel()
        UpdateTemp()
        ShowFuelRate()
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
        SimplSerialConnect()
        Timer1.Interval = 500
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
