Public Class AppForm
    Private AppCore As New AppCore
    Dim Graph1 As Graphics
    Dim Pen1 As New Pen(Color.Orange, 20)
    Dim Xarc, Yarc, angle1, angle2, AngleStep As Single
    Dim Speed, Radius, AngleStart, AngleSweep, MaxSpeed As Integer

    Private Sub btLEDon_Click(sender As Object, e As EventArgs) Handles btLEDon.Click
        Dim result = AppCore.SimplSerial.Request(0, 4, {})
        If result.ResponseState = ResponseState.ok Then TextBox1.Text = "LED on"
    End Sub

    Private Sub btLEDoff_Click(sender As Object, e As EventArgs) Handles btLEDoff.Click
        Dim result = AppCore.SimplSerial.Request(0, 5, {})
        If result.ResponseState = ResponseState.ok Then TextBox1.Text = "LED off"
    End Sub

    Private Sub FormInit()
        Radius = 590
        AngleStart = 300
        AngleSweep = 60
        MaxSpeed = 180
        AngleStep = 0.333
        Xarc = -246.5
        Yarc = 19.5
    End Sub

    Private Sub UpdateData()
        PictureBoxReset()
        If Speed < 0 Then Speed = 0
        If Speed > 180 Then Speed = 180
        lbSpeed.Text = Speed
        DrawArc()
    End Sub

    Private Sub PictureBoxReset()
        Graph1.Clear(Color.FromArgb(64, 64, 64))
        Graph1.DrawImage(My.Resources.SpeedScale, 0, 0)
    End Sub

    Private Sub DrawArc()
        angle1 = AngleStart - (MaxSpeed - Speed) * AngleStep
        angle2 = -(AngleSweep - (MaxSpeed - Speed) * AngleStep)
        Graph1.DrawArc(Pen1, Xarc, Yarc, Radius * 2, Radius * 2, angle1, angle2)
        'Graph1.DrawArc(Pen1, x0, y0, radius * 2, radius * 2, 300, -60)
    End Sub

    Private Sub btForw_Click(sender As Object, e As EventArgs) Handles btForw.Click
        Speed = Speed + 5
        UpdateData()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim th = New Threading.Thread(AddressOf SimplSerialConnect)
        th.IsBackground = True
        th.Start()
        SimplSerialConnect()
        FormInit()
    End Sub

    Private Sub btRev_Click(sender As Object, e As EventArgs) Handles btRev.Click
        Speed = Speed - 5
        UpdateData()
    End Sub
    Private Sub SimplSerialConnect()
        AppCore.FindPort()
        If AppCore.SimplSerial.IsConnected = True Then
            TextBox1.Text = AppCore.PortName + " " + AppCore.DeviceName.DeviceName
        Else
            TextBox1.Text = "No found"
        End If
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Graph1 = PictureBox1.CreateGraphics()
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
