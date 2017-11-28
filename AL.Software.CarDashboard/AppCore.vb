Public Class AppCore
    Private _deviceName As String = "Dashboard"
    Private _deviceSpeed As Integer = 9600
    Public SimplSerial As New SimplSerialBus
    Public PortName As String
    Public DeviceName

    'Public Sub New(ss As SimplSerialBus)
    '    Dim th = New Threading.Thread(AddressOf FindPort)
    '    th.IsBackground = True
    '    th.Start()
    'End Sub

    Public Sub FindPort()
        Dim devices = System.IO.Ports.SerialPort.GetPortNames
        For Each PortName In devices
            If PortName.ToLower.Contains("com") Or PortName.ToLower.Contains("ttyusb") Then
                Dim testSS As New SimplSerialBus(PortName)
                Dim result = ""
                testSS.SerialDevice.DeviceSpeed = _deviceSpeed
                Try
                    testSS.Connect()
                    DeviceName = testSS.RequestDeviceInfo(0)
                    If DeviceName.DeviceName.Contains(_deviceName) Then SimplSerial = testSS
                Catch ex As Exception
                End Try
            End If
        Next
        Threading.Thread.Sleep(500)
    End Sub
End Class
