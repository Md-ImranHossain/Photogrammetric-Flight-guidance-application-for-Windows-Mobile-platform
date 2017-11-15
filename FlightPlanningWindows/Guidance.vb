Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports CMT
Imports System
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Threading

Public Class Guidance

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim a As Graphics = PictureBox1.CreateGraphics

        'Drawing scale lines and axes
        '----------------------------
        Dim penScLine As Pen
        Dim VerAxLine As Pen
        penScLine = New Pen(System.Drawing.Color.Black, 1.5)
        VerAxLine = New Pen(System.Drawing.Color.Black, 1.75)

        'Drawing x and y axes 
        a.DrawLine(penScLine, 20, 10, 20, 138)
        a.DrawLine(penScLine, 20, 138, 148, 138)

        'Drawing scale lines on axes
        a.DrawLine(VerAxLine, 18, 10, 22, 10)
        a.DrawLine(VerAxLine, 18, 26, 22, 26)
        a.DrawLine(VerAxLine, 18, 42, 22, 42)
        a.DrawLine(VerAxLine, 18, 58, 22, 58)
        a.DrawLine(VerAxLine, 18, 74, 22, 74)
        a.DrawLine(VerAxLine, 18, 90, 22, 90)
        a.DrawLine(VerAxLine, 18, 106, 22, 106)
        a.DrawLine(VerAxLine, 18, 122, 22, 122)
        a.DrawLine(VerAxLine, 18, 138, 22, 138)

        a.DrawLine(VerAxLine, 20, 136, 20, 140)
        a.DrawLine(VerAxLine, 36, 136, 36, 140)
        a.DrawLine(VerAxLine, 52, 136, 52, 140)
        a.DrawLine(VerAxLine, 68, 136, 68, 140)
        a.DrawLine(VerAxLine, 84, 136, 84, 140)
        a.DrawLine(VerAxLine, 100, 136, 100, 140)
        a.DrawLine(VerAxLine, 116, 136, 116, 140)
        a.DrawLine(VerAxLine, 132, 136, 132, 140)
        a.DrawLine(VerAxLine, 148, 136, 148, 140)

        'Labeling scales
        '---------------
        'labeling Y axes
        Dim vertAxFont As New Font("Verdana", 7, FontStyle.Regular)
        Dim vertAxBrush As New SolidBrush(Color.Black)

        a.DrawString(FlightPlanning.MxVerDis.Text, vertAxFont, vertAxBrush, 1, 5)
        a.DrawString(FlightPlanning.MxVerDis.Text * 0.75, vertAxFont, vertAxBrush, 1, 21)
        a.DrawString(FlightPlanning.MxVerDis.Text * 0.5, vertAxFont, vertAxBrush, 1, 37)
        a.DrawString(FlightPlanning.MxVerDis.Text * 0.25, vertAxFont, vertAxBrush, 1, 53)
        a.DrawString("0", vertAxFont, vertAxBrush, 4, 69)
        a.DrawString(-FlightPlanning.MxVerDis.Text * 0.25, vertAxFont, vertAxBrush, -3, 85)
        a.DrawString(-FlightPlanning.MxVerDis.Text * 0.5, vertAxFont, vertAxBrush, -3, 101)
        a.DrawString(-FlightPlanning.MxVerDis.Text * 0.75, vertAxFont, vertAxBrush, -3, 117)
        a.DrawString(-FlightPlanning.MxVerDis.Text, vertAxFont, vertAxBrush, -3, 133)

        'labeling x axes
        a.DrawString(FlightPlanning.MxHorDis.Text, vertAxFont, vertAxBrush, 12, 142)
        a.DrawString(FlightPlanning.MxHorDis.Text * 0.75, vertAxFont, vertAxBrush, 28, 142)
        a.DrawString(FlightPlanning.MxHorDis.Text * 0.5, vertAxFont, vertAxBrush, 44, 142)
        a.DrawString(FlightPlanning.MxHorDis.Text * 0.25, vertAxFont, vertAxBrush, 60, 142)
        a.DrawString("0", vertAxFont, vertAxBrush, 80, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text * 0.25, vertAxFont, vertAxBrush, 88, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text * 0.5, vertAxFont, vertAxBrush, 105, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text * 0.75, vertAxFont, vertAxBrush, 121, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text, vertAxFont, vertAxBrush, 142, 142)

        a.Dispose()

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'Thread.ResetAbort()
        FlightPlanning.Close()
    End Sub
    '=================================================================
    '=================================================================
    'Getting the position and angular data from the device

    Private Sub RunDemo()

        'Dim pfOutputArray As Object
        Dim pfOutputArray() As Double
        Dim omega As Double
        Dim phi As Double
        Dim kappa As Double
        Dim lat As Double
        Dim lon As Double
        Dim alt As Double
        Dim DoDemo As Boolean

        On Error GoTo errLabel

        'Do Until Button2.BackColor = Color.Aqua
        Do Until MenuItem2.Checked = True
            'objMT.cmtGetNextDataBundle()                     ' Get next data bundle
            Dim yes As Long
            objMT.cmtDataContainsOriEuler(yes)              ' See if euler available
            If yes Then
                objMT.cmtDataGetOriEuler(pfOutputArray)

                omega = pfOutputArray(0)  ' Write Euler angles 
                phi = pfOutputArray(1)
                kappa = pfOutputArray(2)

            End If

            objMT.cmtDataContainsPositionLLA(yes)

            If yes Then
                objMT.cmtDataGetPositionLLA(pfOutputArray)

                lat = pfOutputArray(0)
                lon = pfOutputArray(1)
                alt = pfOutputArray(2)

            End If

            'Calculating minimum distance from the flight line and find out the line number
            '===============================================================================

            Dim pathe As String = "c:\FlightLineInfo.txt"
            Dim strLine As String
            Dim X1 As Double
            Dim Y1 As Double
            Dim X2 As Double
            Dim Y2 As Double
            Dim m As Double
            Dim b As Double
            Dim X As Double
            Dim Y As Double
            Dim d As Double
            Dim LineNo As Integer
            Dim AbsDist As Double
            Dim holdMin As Double
            Dim DistM As Double

            Dim dblArray As New ArrayList()
            Dim dblOrArray As New ArrayList()
            Dim LineNoArray As New ArrayList()
            Dim arrayindex As New ArrayList()

            Dim oRead As New System.IO.StreamReader(pathe)

            Do While oRead.Peek() <> -1

                strLine = oRead.ReadLine()
                X1 = CDbl(strLine.Substring(3, 10))
                Y1 = CDbl(strLine.Substring(13, 10))
                X2 = CDbl(strLine.Substring(23, 10))
                Y2 = CDbl(strLine.Substring(33, 10))
                LineNo = CDbl(strLine.Substring(0, 3))

                m = (Y2 - Y1) / (X2 - X1)
                b = Y1 - m * X1
                X = lat
                Y = lon

                d = (Y - m * X - b) / Math.Sqrt(m ^ 2 + 1)

                dblOrArray.Add(d)
                LineNoArray.Add(LineNo)

                AbsDist = Math.Abs(d)
                dblArray.Add(AbsDist)
                arrayindex.Add(AbsDist)

            Loop

            oRead.Close()

            dblArray.Sort()
            holdMin = dblArray.Item(0)
            DistM = holdMin * 111120 'conversion of distance from degree to meter
            Label13.Text = DistM

            Dim IndexofDist As Integer
            IndexofDist = arrayindex.IndexOf(dblArray.Item(0))
            Dim ActualDist As Double
            ActualDist = dblOrArray(IndexofDist)

            Dim LineNoMin As Integer
            LineNoMin = LineNoArray.Item(arrayindex.IndexOf(dblArray.Item(0)))
            Label25.Text = LineNoMin

            Dim diststring As String
            diststring = ActualDist.ToString()


            'Drawing the point for horizontal distance
            '===================================================================
            'PictureBox3.BackgroundImage.FromFile("D:\FlightGuidance\Project1\FlightPlanningWindows\Pics\10.png")
            PictureBox5.BackgroundImage.FromFile(My.Application.Info.DirectoryPath & "/10.png")
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
            'Dim point As Graphics = PictureBox1.CreateGraphics
            Dim point As Graphics = PictureBox3.CreateGraphics
            Dim PointPen As Pen
            PointPen = New Pen(System.Drawing.Color.Red, 4)
            'Dim eraser As New Pen(Brushes.White, 4)

            'Defining limit line for Horizontal difference
            Dim VertLimitL As Pen
            VertLimitL = New Pen(System.Drawing.Color.Green, 2)

            point.DrawLine(VertLimitL, CInt(64 - (FlightPlanning.MxHtDiff.Text * Hscale)), 59, CInt(64 - (FlightPlanning.MxHtDiff.Text * Hscale)), 69)
            point.DrawLine(VertLimitL, CInt(64 + (FlightPlanning.MxHtDiff.Text * Hscale)), 59, CInt(64 + (FlightPlanning.MxHtDiff.Text * Hscale)), 69)

            'Defining limit line for Vertical differecne
            point.DrawLine(VertLimitL, 59, CInt(64 - (FlightPlanning.TextBox4.Text * VScale)), 69, CInt(64 - (FlightPlanning.TextBox4.Text * VScale)))
            point.DrawLine(VertLimitL, 59, CInt(64 + (FlightPlanning.TextBox4.Text * VScale)), 69, CInt(64 + (FlightPlanning.TextBox4.Text * VScale)))

            If diststring.Substring(0, 1) = "-" Then
                'point.DrawLine(PointPen, CInt(84 + DistM * Hscale), 72, CInt(84 + DistM * Hscale), 76)
                point.DrawLine(PointPen, CInt(64 + DistM * Hscale), 62, CInt(64 + DistM * Hscale), 66)
                Label14.Text = "Left"
            Else
                point.DrawLine(PointPen, CInt(64 - DistM * Hscale), 62, CInt(64 - DistM * Hscale), 66)
                Label14.Text = "Right"
            End If

            'Calculating and drawing of vertical distance difference
            '========================================================

            Dim heightDiff As Double
            Dim heightFiffAbs As Double
            heightDiff = FlightPlanning.Flheight.Text - alt
            heightFiffAbs = Math.Abs(heightDiff)
            Label10.Text = heightFiffAbs

            heightDiff.ToString()
            If heightDiff.ToString.Substring(0, 1) = "-" Then
                point.DrawLine(PointPen, 62, CInt(64 - heightFiffAbs * VScale), 66, CInt(64 - heightFiffAbs * VScale))
                Label12.Text = "Down"
            Else
                point.DrawLine(PointPen, 62, CInt(64 + heightFiffAbs * VScale), 66, CInt(64 + heightFiffAbs * VScale))
                Label12.Text = "Up"
            End If

            Thread.Sleep(5)
            PictureBox3.BackColor = Color.Transparent
            PictureBox3.Refresh()

            objMT.cmtGetNextDataBundle()

        Loop      ' Loop until user wants to quit
errLabel:
        DoDemo = False

    End Sub

    'Creating an instance of the CMT object and configure the device
    '===============================================================
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If objMT Is Nothing Then
            objMT = CreateObject("MotionTracker.CMT")   ' Set reference to COM object
            objMT.cmtCreateInstance("55BF7-D71D0-13207-FA7F7")          ' Create a CMT instance

            Dim deviceId As Long
            Dim portNumbers() As Integer
            Dim portno As Integer
            objMT.cmtScanPorts(portNumbers, 0, 1000, 5)
            portno = portNumbers.First
            objMT.cmtOpenPort(portno, 0)                          ' Set COM port in COM object
            objMT.cmtGetDeviceId(deviceId)                   ' Get current device Id

            Dim a As Double
            a = deviceId

            objMT.cmtSetQueueMode(1)                       ' Setting queue mode so that we always get the latest data
            objMT.cmtGotoConfig()                             ' Put MotionTracker in config mode

            Dim isMtig As Boolean
            objMT.cmtIdIsMtig(isMtig, deviceId)

            If isMtig Then
                objMT.cmtSetDeviceMode(20, 5, 100, deviceId) ' Orientation outputmode with Position, sample counter + euler, 100Hz
            Else
                objMT.cmtSetDeviceMode(4, 5, 100, deviceId)  ' Orientation outputmode, sample counter+euler, 100 Hz
            End If

            objMT.cmtGotoMeasurement()                        ' Start again
        End If

        RunDemo()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False

    End Sub


    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Me.Hide()
        FlightPlanning.Show()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.Hide()
        Preview.Show()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If objMT Is Nothing Then
            objMT = CreateObject("MotionTracker.CMT")   ' Set reference to COM object
            objMT.cmtCreateInstance("55BF7-D71D0-13207-FA7F7")          ' Create a CMT instance

            Dim deviceId As Long
            Dim portNumbers() As Integer
            Dim portno As Integer
            objMT.cmtScanPorts(portNumbers, 0, 1000, 5)
            portno = portNumbers.First
            objMT.cmtOpenPort(portno, 0)                          ' Set COM port in COM object
            objMT.cmtGetDeviceId(deviceId)                   ' Get current device Id

            Dim a As Double
            a = deviceId

            objMT.cmtSetQueueMode(1)                       ' Setting queue mode so that we always get the latest data
            objMT.cmtGotoConfig()                             ' Put MotionTracker in config mode

            Dim isMtig As Boolean
            objMT.cmtIdIsMtig(isMtig, deviceId)

            If isMtig Then
                objMT.cmtSetDeviceMode(20, 5, 100, deviceId) ' Orientation outputmode with Position, sample counter + euler, 100Hz
            Else
                objMT.cmtSetDeviceMode(4, 5, 100, deviceId)  ' Orientation outputmode, sample counter+euler, 100 Hz
            End If

            objMT.cmtGotoMeasurement()                        ' Start again
        End If

        'objMT.cmtGetNextDataBundle()                     ' Get next data bundle
        Dim yes As Long
        Dim pfOutputArray() As Double
        Dim omega As Double
        objMT.cmtDataContainsOriEuler(yes)              ' See if euler available
        If yes Then
            objMT.cmtDataGetOriEuler(pfOutputArray)
            omega = pfOutputArray(0)  ' Write Euler angles 
        End If

        'Drawing the rotation line for WOMEGA
        '======================================
        Dim RotateLine As Pen 'pen for rotation line
        RotateLine = New Pen(System.Drawing.Color.Red, 2.5)

        'PictureBox5.BackgroundImage.FromFile("D:\FlightGuidance\Project1\FlightPlanningWindows\Pics\6.png")
        PictureBox5.BackgroundImage.FromFile(My.Application.Info.DirectoryPath & "/6.png")
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        Dim RotWomega As Graphics = PictureBox5.CreateGraphics

        'Drawing the rotating line
        RotWomega.DrawLine(RotateLine, 90, 90, CSng(90 + (90 * System.Math.Cos((270 + omega) * D_THETA))), CSng(90 + (90 * System.Math.Sin((270 + omega) * D_THETA))))
        Thread.Sleep(10)
        RotWomega.Dispose()
        PictureBox5.BackColor = Color.White
        PictureBox5.Refresh()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick

        If objMT Is Nothing Then
            objMT = CreateObject("MotionTracker.CMT")   ' Set reference to COM object
            objMT.cmtCreateInstance("55BF7-D71D0-13207-FA7F7")          ' Create a CMT instance

            Dim deviceId As Long
            Dim portNumbers() As Integer
            Dim portno As Integer
            objMT.cmtScanPorts(portNumbers, 0, 1000, 5)
            portno = portNumbers.First
            objMT.cmtOpenPort(portno, 0)                          ' Set COM port in COM object
            objMT.cmtGetDeviceId(deviceId)                   ' Get current device Id

            Dim a As Double
            a = deviceId

            objMT.cmtSetQueueMode(1)                       ' Setting queue mode so that we always get the latest data
            objMT.cmtGotoConfig()                             ' Put MotionTracker in config mode

            Dim isMtig As Boolean
            objMT.cmtIdIsMtig(isMtig, deviceId)

            If isMtig Then
                objMT.cmtSetDeviceMode(20, 5, 100, deviceId) ' Orientation outputmode with Position, sample counter + euler, 100Hz
            Else
                objMT.cmtSetDeviceMode(4, 5, 100, deviceId)  ' Orientation outputmode, sample counter+euler, 100 Hz
            End If

            objMT.cmtGotoMeasurement()                        ' Start again
        End If

        'objMT.cmtGetNextDataBundle()                     ' Get next data bundle
        Dim yes As Long
        Dim pfOutputArray() As Double
        Dim phi As Double
        objMT.cmtDataContainsOriEuler(yes)              ' See if euler available
        If yes Then
            objMT.cmtDataGetOriEuler(pfOutputArray)
            phi = pfOutputArray(1)  ' Write Euler angles 
        End If

        'Drawing the rotation line for Phi
        '======================================
        Dim RotateLine As Pen 'pen for rotation line
        RotateLine = New Pen(System.Drawing.Color.Red, 2.5)
        'PictureBox6.BackgroundImage.FromFile("D:\FlightGuidance\Project1\FlightPlanningWindows\Pics\7.png")
        PictureBox5.BackgroundImage.FromFile(My.Application.Info.DirectoryPath & "/7.png")
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        Dim RotPhi As Graphics = PictureBox6.CreateGraphics
        'Drawing the rotating line
        RotPhi.DrawLine(RotateLine, 90, 90, CSng(90 + (90 * System.Math.Cos((270 + phi) * D_THETA))), CSng(90 + (90 * System.Math.Sin((270 + phi) * D_THETA))))
        Thread.Sleep(10)
        RotPhi.Dispose()
        PictureBox6.BackColor = Color.White
        PictureBox6.Refresh()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        'Drawing the rotation line for Kappa
        '======================================

        If objMT Is Nothing Then
            objMT = CreateObject("MotionTracker.CMT")   ' Set reference to COM object
            objMT.cmtCreateInstance("55BF7-D71D0-13207-FA7F7")          ' Create a CMT instance

            Dim deviceId As Long
            Dim portNumbers() As Integer
            Dim portno As Integer
            objMT.cmtScanPorts(portNumbers, 0, 1000, 5)
            portno = portNumbers.First
            objMT.cmtOpenPort(portno, 0)                          ' Set COM port in COM object
            objMT.cmtGetDeviceId(deviceId)                   ' Get current device Id

            Dim a As Double
            a = deviceId

            objMT.cmtSetQueueMode(1)                       ' Setting queue mode so that we always get the latest data
            objMT.cmtGotoConfig()                             ' Put MotionTracker in config mode

            Dim isMtig As Boolean
            objMT.cmtIdIsMtig(isMtig, deviceId)

            If isMtig Then
                objMT.cmtSetDeviceMode(20, 5, 100, deviceId) ' Orientation outputmode with Position, sample counter + euler, 100Hz
            Else
                objMT.cmtSetDeviceMode(4, 5, 100, deviceId)  ' Orientation outputmode, sample counter+euler, 100 Hz
            End If

            objMT.cmtGotoMeasurement()                        ' Start again
        End If

        'objMT.cmtGetNextDataBundle()                     ' Get next data bundle
        Dim yes As Long
        Dim pfOutputArray() As Double
        Dim kappa As Double
        objMT.cmtDataContainsOriEuler(yes)              ' See if euler available
        If yes Then
            objMT.cmtDataGetOriEuler(pfOutputArray)
            kappa = pfOutputArray(2)  ' Write Euler angles 
        End If
        Dim RotateLine As Pen 'pen for rotation line
        RotateLine = New Pen(System.Drawing.Color.Red, 2.5)
        'PictureBox7.BackgroundImage.FromFile("D:\FlightGuidance\Project1\FlightPlanningWindows\Pics\8.png")
        PictureBox5.BackgroundImage.FromFile(My.Application.Info.DirectoryPath & "/8.png")
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        Dim RotKappa As Graphics = PictureBox7.CreateGraphics
        'Drawing the rotating line
        RotKappa.DrawLine(RotateLine, 90, 90, CSng(90 + (90 * System.Math.Cos((270 + kappa) * D_THETA))), CSng(90 + (90 * System.Math.Sin((270 + kappa) * D_THETA))))
        Thread.Sleep(10)
        RotKappa.Dispose()
        'PictureBox7.BackColor = Color.White
        PictureBox7.Refresh()

    End Sub

    Private Sub Guidance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim a As Graphics = PictureBox1.CreateGraphics

        'Drawing scale lines and axes
        '----------------------------
        Dim penScLine As Pen
        Dim VerAxLine As Pen
        penScLine = New Pen(System.Drawing.Color.Black, 1.5)
        VerAxLine = New Pen(System.Drawing.Color.Black, 1.75)

        'Drawing x and y axes 
        a.DrawLine(penScLine, 20, 10, 20, 138)
        a.DrawLine(penScLine, 20, 138, 148, 138)

        'Drawing scale lines on axes
        a.DrawLine(VerAxLine, 18, 10, 22, 10)
        a.DrawLine(VerAxLine, 18, 26, 22, 26)
        a.DrawLine(VerAxLine, 18, 42, 22, 42)
        a.DrawLine(VerAxLine, 18, 58, 22, 58)
        a.DrawLine(VerAxLine, 18, 74, 22, 74)
        a.DrawLine(VerAxLine, 18, 90, 22, 90)
        a.DrawLine(VerAxLine, 18, 106, 22, 106)
        a.DrawLine(VerAxLine, 18, 122, 22, 122)
        a.DrawLine(VerAxLine, 18, 138, 22, 138)

        a.DrawLine(VerAxLine, 20, 136, 20, 140)
        a.DrawLine(VerAxLine, 36, 136, 36, 140)
        a.DrawLine(VerAxLine, 52, 136, 52, 140)
        a.DrawLine(VerAxLine, 68, 136, 68, 140)
        a.DrawLine(VerAxLine, 84, 136, 84, 140)
        a.DrawLine(VerAxLine, 100, 136, 100, 140)
        a.DrawLine(VerAxLine, 116, 136, 116, 140)
        a.DrawLine(VerAxLine, 132, 136, 132, 140)
        a.DrawLine(VerAxLine, 148, 136, 148, 140)

        'Labeling scales
        '---------------
        'labeling Y axes
        Dim vertAxFont As New Font("Verdana", 7, FontStyle.Regular)
        Dim vertAxBrush As New SolidBrush(Color.Black)

        a.DrawString(FlightPlanning.MxVerDis.Text, vertAxFont, vertAxBrush, 1, 5)
        a.DrawString(FlightPlanning.MxVerDis.Text * 0.75, vertAxFont, vertAxBrush, 1, 21)
        a.DrawString(FlightPlanning.MxVerDis.Text * 0.5, vertAxFont, vertAxBrush, 1, 37)
        a.DrawString(FlightPlanning.MxVerDis.Text * 0.25, vertAxFont, vertAxBrush, 1, 53)
        a.DrawString("0", vertAxFont, vertAxBrush, 4, 69)
        a.DrawString(-FlightPlanning.MxVerDis.Text * 0.25, vertAxFont, vertAxBrush, -3, 85)
        a.DrawString(-FlightPlanning.MxVerDis.Text * 0.5, vertAxFont, vertAxBrush, -3, 101)
        a.DrawString(-FlightPlanning.MxVerDis.Text * 0.75, vertAxFont, vertAxBrush, -3, 117)
        a.DrawString(-FlightPlanning.MxVerDis.Text, vertAxFont, vertAxBrush, -3, 133)

        'labeling x axes
        a.DrawString(FlightPlanning.MxHorDis.Text, vertAxFont, vertAxBrush, 12, 142)
        a.DrawString(FlightPlanning.MxHorDis.Text * 0.75, vertAxFont, vertAxBrush, 28, 142)
        a.DrawString(FlightPlanning.MxHorDis.Text * 0.5, vertAxFont, vertAxBrush, 44, 142)
        a.DrawString(FlightPlanning.MxHorDis.Text * 0.25, vertAxFont, vertAxBrush, 60, 142)
        a.DrawString("0", vertAxFont, vertAxBrush, 80, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text * 0.25, vertAxFont, vertAxBrush, 88, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text * 0.5, vertAxFont, vertAxBrush, 105, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text * 0.75, vertAxFont, vertAxBrush, 121, 142)
        a.DrawString(-FlightPlanning.MxHorDis.Text, vertAxFont, vertAxBrush, 142, 142)
        PictureBox1.Refresh()
        a.Dispose()
    End Sub
End Class