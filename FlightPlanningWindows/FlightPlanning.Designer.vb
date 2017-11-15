<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FlightPlanning
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.a = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.MapScale = New System.Windows.Forms.ComboBox
        Me.FLength = New System.Windows.Forms.ComboBox
        Me.AvGrHt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.C_MapScale = New System.Windows.Forms.TextBox
        Me.C_FLength = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GoLNo = New System.Windows.Forms.Label
        Me.LnNo = New System.Windows.Forms.ComboBox
        Me.enter = New System.Windows.Forms.Button
        Me.EnLon = New System.Windows.Forms.TextBox
        Me.EnLat = New System.Windows.Forms.TextBox
        Me.StLat = New System.Windows.Forms.TextBox
        Me.StLon = New System.Windows.Forms.TextBox
        Me.Update = New System.Windows.Forms.Button
        Me.Edit = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.StIns = New System.Windows.Forms.Button
        Me.MxHtDiff = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MxHorDis = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.MxVerDis = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Flheight = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Preview Input"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Show Guidance"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Exit"
        '
        'a
        '
        Me.a.BackColor = System.Drawing.Color.Transparent
        Me.a.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.a.Location = New System.Drawing.Point(0, 3)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(105, 19)
        Me.a.TabIndex = 182
        Me.a.Text = "Initial Settings"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Map Scale                1:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(0, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Focal Length (cm)"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label6.Location = New System.Drawing.Point(0, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 18)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Flight height above ground (Meter)"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(0, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 19)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Start an End points of flight lines (Degree)"
        '
        'MapScale
        '
        Me.MapScale.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MapScale.Items.AddRange(New Object() {"10000", "5000", "2000", "1000", "500", "100", "Custom"})
        Me.MapScale.Location = New System.Drawing.Point(121, 17)
        Me.MapScale.Name = "MapScale"
        Me.MapScale.Size = New System.Drawing.Size(65, 19)
        Me.MapScale.TabIndex = 22
        Me.MapScale.Text = "0"
        '
        'FLength
        '
        Me.FLength.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.FLength.Items.AddRange(New Object() {"2", "3", "3.6", "4", "5", "Custom"})
        Me.FLength.Location = New System.Drawing.Point(121, 37)
        Me.FLength.Name = "FLength"
        Me.FLength.Size = New System.Drawing.Size(65, 19)
        Me.FLength.TabIndex = 23
        Me.FLength.Text = "0"
        '
        'AvGrHt
        '
        Me.AvGrHt.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.AvGrHt.Location = New System.Drawing.Point(195, 58)
        Me.AvGrHt.Name = "AvGrHt"
        Me.AvGrHt.Size = New System.Drawing.Size(50, 19)
        Me.AvGrHt.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(105, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 19)
        Me.Label14.TabIndex = 178
        Me.Label14.Text = "Start"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(108, 275)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 19)
        Me.Label15.TabIndex = 177
        Me.Label15.Text = "End "
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Enabled = False
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label20.Location = New System.Drawing.Point(140, 230)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 18)
        Me.Label20.TabIndex = 176
        Me.Label20.Text = "Latitude"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label21.Location = New System.Drawing.Point(194, 230)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 18)
        Me.Label21.TabIndex = 175
        Me.Label21.Text = "Longitude"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TextBox12.Location = New System.Drawing.Point(194, 250)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(51, 20)
        Me.TextBox12.TabIndex = 66
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox13.Enabled = False
        Me.TextBox13.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TextBox13.Location = New System.Drawing.Point(141, 250)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(51, 20)
        Me.TextBox13.TabIndex = 70
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox14.Enabled = False
        Me.TextBox14.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TextBox14.Location = New System.Drawing.Point(194, 271)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(51, 20)
        Me.TextBox14.TabIndex = 72
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox15.Enabled = False
        Me.TextBox15.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TextBox15.Location = New System.Drawing.Point(141, 271)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(51, 20)
        Me.TextBox15.TabIndex = 71
        '
        'C_MapScale
        '
        Me.C_MapScale.BackColor = System.Drawing.Color.LightGray
        Me.C_MapScale.Enabled = False
        Me.C_MapScale.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C_MapScale.Location = New System.Drawing.Point(194, 17)
        Me.C_MapScale.Name = "C_MapScale"
        Me.C_MapScale.Size = New System.Drawing.Size(51, 20)
        Me.C_MapScale.TabIndex = 73
        '
        'C_FLength
        '
        Me.C_FLength.BackColor = System.Drawing.Color.LightGray
        Me.C_FLength.Enabled = False
        Me.C_FLength.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C_FLength.Location = New System.Drawing.Point(194, 37)
        Me.C_FLength.Name = "C_FLength"
        Me.C_FLength.Size = New System.Drawing.Size(51, 20)
        Me.C_FLength.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label8.Location = New System.Drawing.Point(140, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Line No"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TextBox1.Location = New System.Drawing.Point(194, 209)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(51, 20)
        Me.TextBox1.TabIndex = 101
        '
        'GoLNo
        '
        Me.GoLNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GoLNo.Enabled = False
        Me.GoLNo.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.GoLNo.Location = New System.Drawing.Point(0, 210)
        Me.GoLNo.Name = "GoLNo"
        Me.GoLNo.Size = New System.Drawing.Size(69, 18)
        Me.GoLNo.TabIndex = 173
        Me.GoLNo.Text = "Line No"
        '
        'LnNo
        '
        Me.LnNo.Enabled = False
        Me.LnNo.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LnNo.Location = New System.Drawing.Point(67, 210)
        Me.LnNo.Name = "LnNo"
        Me.LnNo.Size = New System.Drawing.Size(34, 19)
        Me.LnNo.TabIndex = 104
        '
        'enter
        '
        Me.enter.BackColor = System.Drawing.Color.Goldenrod
        Me.enter.Enabled = False
        Me.enter.Location = New System.Drawing.Point(141, 292)
        Me.enter.Name = "enter"
        Me.enter.Size = New System.Drawing.Size(104, 20)
        Me.enter.TabIndex = 105
        Me.enter.Text = "Enter"
        Me.enter.UseVisualStyleBackColor = False
        '
        'EnLon
        '
        Me.EnLon.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.EnLon.Enabled = False
        Me.EnLon.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.EnLon.Location = New System.Drawing.Point(50, 271)
        Me.EnLon.Name = "EnLon"
        Me.EnLon.Size = New System.Drawing.Size(51, 20)
        Me.EnLon.TabIndex = 109
        '
        'EnLat
        '
        Me.EnLat.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.EnLat.Enabled = False
        Me.EnLat.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.EnLat.Location = New System.Drawing.Point(-3, 271)
        Me.EnLat.Name = "EnLat"
        Me.EnLat.Size = New System.Drawing.Size(51, 20)
        Me.EnLat.TabIndex = 108
        '
        'StLat
        '
        Me.StLat.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.StLat.Enabled = False
        Me.StLat.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.StLat.Location = New System.Drawing.Point(-3, 250)
        Me.StLat.Name = "StLat"
        Me.StLat.Size = New System.Drawing.Size(51, 20)
        Me.StLat.TabIndex = 107
        '
        'StLon
        '
        Me.StLon.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.StLon.Enabled = False
        Me.StLon.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.StLon.Location = New System.Drawing.Point(50, 250)
        Me.StLon.Name = "StLon"
        Me.StLon.Size = New System.Drawing.Size(51, 20)
        Me.StLon.TabIndex = 106
        '
        'Update
        '
        Me.Update.BackColor = System.Drawing.Color.Goldenrod
        Me.Update.Enabled = False
        Me.Update.Location = New System.Drawing.Point(0, 292)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(101, 20)
        Me.Update.TabIndex = 110
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = False
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.Goldenrod
        Me.Edit.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.Edit.Location = New System.Drawing.Point(0, 188)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(101, 20)
        Me.Edit.TabIndex = 111
        Me.Edit.Text = "Edit line"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label9.Location = New System.Drawing.Point(0, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 18)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Latitude"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(49, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 18)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Longitude"
        '
        'StIns
        '
        Me.StIns.BackColor = System.Drawing.Color.Goldenrod
        Me.StIns.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.StIns.Location = New System.Drawing.Point(140, 187)
        Me.StIns.Name = "StIns"
        Me.StIns.Size = New System.Drawing.Size(106, 20)
        Me.StIns.TabIndex = 128
        Me.StIns.Text = "Start Inserting"
        Me.StIns.UseVisualStyleBackColor = False
        '
        'MxHtDiff
        '
        Me.MxHtDiff.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MxHtDiff.Location = New System.Drawing.Point(217, 118)
        Me.MxHtDiff.Name = "MxHtDiff"
        Me.MxHtDiff.Size = New System.Drawing.Size(28, 19)
        Me.MxHtDiff.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(0, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 18)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "Max horz distance"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(121, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Max horz tolerance"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(0, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Max vert distance"
        '
        'MxHorDis
        '
        Me.MxHorDis.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MxHorDis.Location = New System.Drawing.Point(91, 118)
        Me.MxHorDis.Name = "MxHorDis"
        Me.MxHorDis.Size = New System.Drawing.Size(28, 19)
        Me.MxHorDis.TabIndex = 161
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(121, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 18)
        Me.Label10.TabIndex = 167
        Me.Label10.Text = "Max vert tolerance"
        '
        'MxVerDis
        '
        Me.MxVerDis.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.MxVerDis.Location = New System.Drawing.Point(91, 138)
        Me.MxVerDis.Name = "MxVerDis"
        Me.MxVerDis.Size = New System.Drawing.Size(28, 19)
        Me.MxVerDis.TabIndex = 165
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.TextBox4.Location = New System.Drawing.Point(217, 138)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(28, 19)
        Me.TextBox4.TabIndex = 166
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label11.Location = New System.Drawing.Point(0, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 18)
        Me.Label11.TabIndex = 184
        Me.Label11.Text = "Average ground height (Meter)"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.TextBox2.Location = New System.Drawing.Point(195, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(50, 19)
        Me.TextBox2.TabIndex = 185
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 18)
        Me.Label13.TabIndex = 186
        Me.Label13.Text = "Planned average flight height(Meter)"
        '
        'Flheight
        '
        Me.Flheight.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.Flheight.Location = New System.Drawing.Point(195, 98)
        Me.Flheight.Name = "Flheight"
        Me.Flheight.Size = New System.Drawing.Size(50, 19)
        Me.Flheight.TabIndex = 187
        '
        'FlightPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(249, 316)
        Me.Controls.Add(Me.Flheight)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.MxVerDis)
        Me.Controls.Add(Me.MxHtDiff)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MxHorDis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StIns)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.EnLon)
        Me.Controls.Add(Me.EnLat)
        Me.Controls.Add(Me.StLat)
        Me.Controls.Add(Me.StLon)
        Me.Controls.Add(Me.enter)
        Me.Controls.Add(Me.LnNo)
        Me.Controls.Add(Me.GoLNo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.C_FLength)
        Me.Controls.Add(Me.C_MapScale)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.AvGrHt)
        Me.Controls.Add(Me.FLength)
        Me.Controls.Add(Me.MapScale)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label7)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "FlightPlanning"
        Me.Text = "Input Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents a As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MapScale As System.Windows.Forms.ComboBox
    Friend WithEvents FLength As System.Windows.Forms.ComboBox
    Friend WithEvents AvGrHt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents C_MapScale As System.Windows.Forms.TextBox
    Friend WithEvents C_FLength As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GoLNo As System.Windows.Forms.Label
    Friend WithEvents LnNo As System.Windows.Forms.ComboBox
    Friend WithEvents enter As System.Windows.Forms.Button
    Friend WithEvents EnLon As System.Windows.Forms.TextBox
    Friend WithEvents EnLat As System.Windows.Forms.TextBox
    Friend WithEvents StLat As System.Windows.Forms.TextBox
    Friend WithEvents StLon As System.Windows.Forms.TextBox
    Friend WithEvents Update As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents StIns As System.Windows.Forms.Button
    Friend WithEvents MxHtDiff As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MxHorDis As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MxVerDis As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Flheight As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem

End Class
