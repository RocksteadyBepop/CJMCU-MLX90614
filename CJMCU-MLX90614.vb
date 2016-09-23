    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        btr = SerialPort1.BytesToRead

        Dim byData(9) As Byte

        SerialPort1.Read(byData, 0, SerialPort1.BytesToRead)

        Debug.WriteLine(byData(2))

        If byData(0) = 102 AndAlso byData(1) = 102 Then

           TargetTemp = Convert.ToDecimal(Convert.ToInt16(Hex(byData(4)) & Hex(byData(5)), 16) / 100)
            AmbientTemp = Convert.ToDecimal(Convert.ToInt16(Hex(byData(6)) & Hex(byData(7)), 16) / 100)

            Debug.WriteLine("Target Temp: " & TargetTemp & " | Ambient Temp: " & AmbientTemp)

        End If

        SerialPort1.DiscardInBuffer()

    End Sub