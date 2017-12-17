Public Class AppCore
    'Private FilePath As String = My.Resources.data
    Private DevName As String = "Dashboard"
    Private DevSpeed As Integer = 9600
    Public SimplSerial As New SimplSerialBus
    Public PortName As String
    Public Property DeviceName As String = ""

    Public Sub FindPort()
        Dim devices = System.IO.Ports.SerialPort.GetPortNames
        For Each PortName In devices
            If PortName.ToLower.Contains("com") Or PortName.ToLower.Contains("ttyusb") Then
                Dim testSS As New SimplSerialBus(PortName)
                Dim result = ""
                testSS.SerialDevice.DeviceSpeed = DevSpeed
                Try
                    testSS.Connect()
                    DeviceName = testSS.RequestDeviceInfo(0).DeviceName
                    If DeviceName.Contains(DevName) Then SimplSerial = testSS
                Catch ex As Exception
                End Try
            End If
        Next
        Threading.Thread.Sleep(500)
    End Sub
    Public Function ReadDataFromFile()
        Dim currentRow As String() = {"test"}
        Using MyReader As New FileIO.TextFieldParser(My.Resources.MyCat)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                currentRow = MyReader.ReadFields()
            End While
        End Using
        Return currentRow
    End Function
End Class
