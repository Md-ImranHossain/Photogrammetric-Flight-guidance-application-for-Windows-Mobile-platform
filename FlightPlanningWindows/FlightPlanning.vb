'Importing system class for creating, writing and reading text file
'==================================================================
Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms


Public Class FlightPlanning
    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'Preview all input data in a new form
        '====================================
        Preview.Show()
        Me.Hide()


        Preview.Label6.Text = MapScale.Text
        Dim pathh As String = "c:\FlightLineInfo.txt"

        Dim rall As String
        Try
            Dim r As New System.IO.StreamReader(pathh)
            Do While r.Peek() <> -1

                rall = r.ReadLine
                Preview.ListBox1.Items.Add(rall)

            Loop
            r.Close()

        Catch ec As Exception
            Console.WriteLine(ec)
        End Try


        If MapScale.Text = "Custom" Then
            Preview.Label6.Text = C_MapScale.Text
        Else
            Preview.Label6.Text = MapScale.Text
        End If

        If FLength.Text = "Custom" Then
            Preview.Label8.Text = C_FLength.Text
        Else
            Preview.Label8.Text = FLength.Text
        End If

        Preview.Label12.Text = AvGrHt.Text
        Preview.Label22.Text = Flheight.Text
        Preview.Label23.Text = TextBox2.Text
        Preview.Label24.Text = MxHorDis.Text
        Preview.Label25.Text = MxVerDis.Text
        Preview.Label26.Text = TextBox4.Text
        Preview.Label27.Text = MxHtDiff.Text


    End Sub

    'If user select custom for any input the input box next to it change its
    'color to white and become active
    '================================
    Private Sub MapScale_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MapScale.TextChanged
        If MapScale.Text = "Custom" Then
            C_MapScale.BackColor = Color.White
            C_MapScale.Enabled = True
        Else
            C_MapScale.Text = Nothing
            C_MapScale.BackColor = Color.LightGray
            C_MapScale.Enabled = False

        End If
    End Sub
    'Automatic calculation of average ground height
    '==============================================
    Private Sub FLength_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FLength.LostFocus
        'Dim MScale As Integer
        'If C_MapScale.Enabled = True Then
        '    MScale = C_MapScale.Text
        'Else
        '    MScale = MapScale.Text
        'End If
        'Dim FoLength As Double
        'If C_FLength.Enabled = True Then
        '    FoLength = CDbl(C_FLength.Text)
        'Else
        '    FoLength = CDbl(FLength.Text)
        'End If
        'AvGrHt.Text = (MScale * FoLength) / 100
    End Sub

    Private Sub FLength_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FLength.TextChanged
        If FLength.Text = "Custom" Then
            C_FLength.BackColor = Color.White
            C_FLength.Enabled = True
        Else
            C_FLength.Text = Nothing
            C_FLength.BackColor = Color.LightGray
            C_FLength.Enabled = False
        End If
    End Sub
    
    'Enabling option for editing flight line data
    '=============================================
    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        GoLNo.Enabled = True
        LnNo.Enabled = True
        StLat.Enabled = True
        StLon.Enabled = True
        EnLat.Enabled = True
        EnLon.Enabled = True
        Update.Enabled = True
        Label9.Enabled = True
        Label12.Enabled = True
        StLat.BackColor = Color.White
        StLon.BackColor = Color.White
        EnLat.BackColor = Color.White
        EnLon.BackColor = Color.White


        Dim pathe As String = "c:\FlightLineInfo.txt"
        Dim strLine As String
        Dim intID As String
        Dim a As Integer
        Dim b As Integer
        Try
            Dim oRead As New System.IO.StreamReader(pathe)

            Do While oRead.Peek() <> -1

                strLine = oRead.ReadLine()
                intID = strLine.Substring(0, 3)
                LnNo.Items.Add(intID)


            Loop
            oRead.Close()

        Catch exec As Exception
            Console.WriteLine(exec)

        End Try


    End Sub

    Private Sub StIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StIns.Click

        'Create a text file for storing data in C: drive
        '===============================================
        Dim path As String = "c:\FlightLineInfo.txt"
        Try
            If File.Exists(path) Then
                File.Delete(path) 'Delete file if already existed
            End If

            ' Create the file.
            Dim oWrite As System.IO.StreamWriter
            oWrite = File.CreateText(path)
            'oWrite.WriteLine("{0,3}{1,10}{2,10}{3,10}{4,10}", "LineNo", "StartLat", "StartLon", "EndLat", "EndLon") 'Header fields
            oWrite.Close()

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


        Label8.Enabled = True
        TextBox1.Enabled = True
        Label20.Enabled = True
        Label21.Enabled = True
        TextBox12.Enabled = True
        TextBox13.Enabled = True
        TextBox14.Enabled = True
        TextBox15.Enabled = True
        enter.Enabled = True
        StIns.Enabled = False
        TextBox1.BackColor = Color.White
        TextBox12.BackColor = Color.White
        TextBox13.BackColor = Color.White
        TextBox14.BackColor = Color.White
        TextBox15.BackColor = Color.White


    End Sub
    'Writing values in the text box to the text file
    '===============================================
    Private Sub enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enter.Click
        Dim pat As String = "c:\FlightLineInfo.txt"
        Try
            Dim oWrite As System.IO.StreamWriter
            oWrite = File.AppendText(pat)
            oWrite.WriteLine("{0,3}{1,10}{2,10}{3,10}{4,10}", TextBox1.Text, TextBox13.Text, TextBox12.Text, TextBox15.Text, TextBox14.Text)
            oWrite.Close()

        Catch exc As Exception
            Console.WriteLine(exc)
        End Try

        LnNo.Items.Add(TextBox1.Text)


        TextBox13.Text = Nothing
        TextBox12.Text = Nothing
        TextBox15.Text = Nothing
        TextBox14.Text = Nothing
        MsgBox("Coordinates for Line No: " & TextBox1.Text & " has been inserted")
        TextBox1.Text = Nothing

        

    End Sub

    'Loading flight line data in to the editor
    '=========================================
    Private Sub LnNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LnNo.SelectedIndexChanged
        Dim pathe As String = "c:\FlightLineInfo.txt"
        Dim strLine As String
        Dim intID As String
        Dim a As Integer
        Dim b As Integer
        Try
            Dim oRead As New System.IO.StreamReader(pathe)

            Do While oRead.Peek() <> -1

                strLine = oRead.ReadLine()
                intID = strLine.Substring(0, 3)
                a = CInt(intID)
                b = CInt(LnNo.Text)
                If a = b Then
                    StLat.Text = strLine.Substring(3, 10)
                    StLon.Text = strLine.Substring(13, 10)
                    EnLat.Text = strLine.Substring(23, 10)
                    EnLon.Text = strLine.Substring(33, 10)
                End If

            Loop
            oRead.Close()

        Catch exec As Exception
            Console.WriteLine(exec)

        End Try
    End Sub

    'Updating the editing on the text file
    '=====================================
    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update.Click

        Dim Fs As FileStream = New FileStream("c:\FlightLineInfo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
        Dim sw As New StreamWriter(Fs)
        Dim sr As New StreamReader(Fs)
        Dim str As String
        Dim strall As String
        Dim intID As String
        Dim a As Integer
        Dim b As Integer


        str = sr.ReadLine()
        strall = str

        Try
            Do While sr.Peek() <> -1
                str = sr.ReadLine()
                intID = str.Substring(0, 3)

                a = CInt(intID)
                b = CInt(LnNo.Text)

                If a = b Then
                    str = str.Remove(0, 43)
                    'str = str.Replace(str.Substring(13, 10), StLon.Text)
                    'str = str.Replace(str.Substring(23, 10), EnLat.Text)
                    'str = str.Replace(str.Substring(33, 10), EnLon.Text)

                End If
                strall = strall & vbCrLf & str
            Loop
            Fs.Position = 0
            Fs.SetLength(str.Length)
            sw.WriteLine(strall)
            sw.WriteLine("{0,3}{1,10}{2,10}{3,10}{4,10}", LnNo.Text, StLat.Text, StLon.Text, EnLat.Text, EnLon.Text)
            sw.Flush()
            sw.Close()
            Fs.Close()
            MsgBox(strall)

        Catch exec As Exception
            Console.WriteLine(exec)

        End Try
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        'Dim a As Double
        Me.Hide()
        Guidance.Show()
        'a = MxHtDiff.Text
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        Flheight.Text = CDbl(TextBox2.Text) + CDbl(AvGrHt.Text)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.Close()
    End Sub

    Private Sub AvGrHt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AvGrHt.GotFocus
        Dim MScale As Integer
        If C_MapScale.Enabled = True Then
            MScale = C_MapScale.Text
        Else
            MScale = MapScale.Text
        End If
        Dim FoLength As Double
        If C_FLength.Enabled = True Then
            FoLength = CDbl(C_FLength.Text)
        Else
            FoLength = CDbl(FLength.Text)
        End If
        AvGrHt.Text = (MScale * FoLength) / 100
    End Sub
End Class
