<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppForm))
        Me.btRev = New System.Windows.Forms.Button()
        Me.btForw = New System.Windows.Forms.Button()
        Me.lbSpeed = New System.Windows.Forms.Label()
        Me.btLEDoff = New System.Windows.Forms.Button()
        Me.btLEDon = New System.Windows.Forms.Button()
        Me.LbFuelRate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PicFuelRate = New System.Windows.Forms.PictureBox()
        Me.PicSpeed = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PicBeam = New System.Windows.Forms.PictureBox()
        Me.PicBat = New System.Windows.Forms.PictureBox()
        Me.PicBelt = New System.Windows.Forms.PictureBox()
        Me.PicCheck = New System.Windows.Forms.PictureBox()
        Me.PicOil = New System.Windows.Forms.PictureBox()
        Me.PicBrake = New System.Windows.Forms.PictureBox()
        Me.PicTurnLf = New System.Windows.Forms.PictureBox()
        Me.PicAT = New System.Windows.Forms.PictureBox()
        Me.PicDoor = New System.Windows.Forms.PictureBox()
        Me.PicOD = New System.Windows.Forms.PictureBox()
        Me.PicTurnRt = New System.Windows.Forms.PictureBox()
        Me.PicAccid = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFuelRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBelt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBrake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTurnLf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTurnRt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAccid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRev
        '
        Me.btRev.Location = New System.Drawing.Point(397, 12)
        Me.btRev.Name = "btRev"
        Me.btRev.Size = New System.Drawing.Size(23, 23)
        Me.btRev.TabIndex = 1
        Me.btRev.Text = "<"
        Me.btRev.UseVisualStyleBackColor = True
        '
        'btForw
        '
        Me.btForw.Location = New System.Drawing.Point(426, 12)
        Me.btForw.Name = "btForw"
        Me.btForw.Size = New System.Drawing.Size(19, 23)
        Me.btForw.TabIndex = 2
        Me.btForw.Text = ">"
        Me.btForw.UseVisualStyleBackColor = True
        '
        'lbSpeed
        '
        Me.lbSpeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbSpeed.Font = New System.Drawing.Font("DejaVu Sans Condensed", 99.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbSpeed.ForeColor = System.Drawing.Color.Orange
        Me.lbSpeed.Location = New System.Drawing.Point(200, 115)
        Me.lbSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.lbSpeed.Name = "lbSpeed"
        Me.lbSpeed.Size = New System.Drawing.Size(342, 159)
        Me.lbSpeed.TabIndex = 3
        Me.lbSpeed.Text = "199"
        Me.lbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btLEDoff
        '
        Me.btLEDoff.Location = New System.Drawing.Point(291, 12)
        Me.btLEDoff.Name = "btLEDoff"
        Me.btLEDoff.Size = New System.Drawing.Size(48, 23)
        Me.btLEDoff.TabIndex = 6
        Me.btLEDoff.Text = "LEDoff"
        Me.btLEDoff.UseVisualStyleBackColor = True
        '
        'btLEDon
        '
        Me.btLEDon.Location = New System.Drawing.Point(345, 12)
        Me.btLEDon.Name = "btLEDon"
        Me.btLEDon.Size = New System.Drawing.Size(46, 23)
        Me.btLEDon.TabIndex = 5
        Me.btLEDon.Text = "LEDon"
        Me.btLEDon.UseVisualStyleBackColor = True
        '
        'LbFuelRate
        '
        Me.LbFuelRate.AutoSize = True
        Me.LbFuelRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LbFuelRate.ForeColor = System.Drawing.Color.Orange
        Me.LbFuelRate.Location = New System.Drawing.Point(351, 335)
        Me.LbFuelRate.Name = "LbFuelRate"
        Me.LbFuelRate.Size = New System.Drawing.Size(123, 24)
        Me.LbFuelRate.TabIndex = 12
        Me.LbFuelRate.Text = "100 л/100км"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(261, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "РАСХОД ТОПЛИВА"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Dashboard.My.Resources.Resources.temp
        Me.PictureBox5.Location = New System.Drawing.Point(124, 367)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 367)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PicFuelRate
        '
        Me.PicFuelRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFuelRate.Location = New System.Drawing.Point(265, 310)
        Me.PicFuelRate.Name = "PicFuelRate"
        Me.PicFuelRate.Size = New System.Drawing.Size(209, 22)
        Me.PicFuelRate.TabIndex = 9
        Me.PicFuelRate.TabStop = False
        '
        'PicSpeed
        '
        Me.PicSpeed.Image = Global.Dashboard.My.Resources.Resources.SpeedScale
        Me.PicSpeed.Location = New System.Drawing.Point(58, 10)
        Me.PicSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.PicSpeed.Name = "PicSpeed"
        Me.PicSpeed.Size = New System.Drawing.Size(688, 180)
        Me.PicSpeed.TabIndex = 0
        Me.PicSpeed.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(273, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 20)
        Me.TextBox1.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(273, 20)
        Me.TextBox3.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 92)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(273, 20)
        Me.TextBox4.TabIndex = 19
        '
        'PicBeam
        '
        Me.PicBeam.Image = Global.Dashboard.My.Resources.Resources.low_beam_dis
        Me.PicBeam.Location = New System.Drawing.Point(12, 423)
        Me.PicBeam.Name = "PicBeam"
        Me.PicBeam.Size = New System.Drawing.Size(50, 50)
        Me.PicBeam.TabIndex = 20
        Me.PicBeam.TabStop = False
        '
        'PicBat
        '
        Me.PicBat.Image = CType(resources.GetObject("PicBat.Image"), System.Drawing.Image)
        Me.PicBat.Location = New System.Drawing.Point(570, 367)
        Me.PicBat.Name = "PicBat"
        Me.PicBat.Size = New System.Drawing.Size(50, 50)
        Me.PicBat.TabIndex = 21
        Me.PicBat.TabStop = False
        '
        'PicBelt
        '
        Me.PicBelt.Image = Global.Dashboard.My.Resources.Resources.belt_dis
        Me.PicBelt.Location = New System.Drawing.Point(124, 423)
        Me.PicBelt.Name = "PicBelt"
        Me.PicBelt.Size = New System.Drawing.Size(50, 50)
        Me.PicBelt.TabIndex = 22
        Me.PicBelt.TabStop = False
        '
        'PicCheck
        '
        Me.PicCheck.Image = Global.Dashboard.My.Resources.Resources.check_dis
        Me.PicCheck.Location = New System.Drawing.Point(570, 423)
        Me.PicCheck.Name = "PicCheck"
        Me.PicCheck.Size = New System.Drawing.Size(50, 50)
        Me.PicCheck.TabIndex = 23
        Me.PicCheck.TabStop = False
        '
        'PicOil
        '
        Me.PicOil.Image = Global.Dashboard.My.Resources.Resources.oil_dis
        Me.PicOil.Location = New System.Drawing.Point(626, 423)
        Me.PicOil.Name = "PicOil"
        Me.PicOil.Size = New System.Drawing.Size(50, 50)
        Me.PicOil.TabIndex = 24
        Me.PicOil.TabStop = False
        '
        'PicBrake
        '
        Me.PicBrake.Image = Global.Dashboard.My.Resources.Resources.brake_dis
        Me.PicBrake.Location = New System.Drawing.Point(68, 423)
        Me.PicBrake.Name = "PicBrake"
        Me.PicBrake.Size = New System.Drawing.Size(50, 50)
        Me.PicBrake.TabIndex = 25
        Me.PicBrake.TabStop = False
        '
        'PicTurnLf
        '
        Me.PicTurnLf.Image = Global.Dashboard.My.Resources.Resources.turn_lf_dis
        Me.PicTurnLf.Location = New System.Drawing.Point(109, 205)
        Me.PicTurnLf.Name = "PicTurnLf"
        Me.PicTurnLf.Size = New System.Drawing.Size(50, 50)
        Me.PicTurnLf.TabIndex = 26
        Me.PicTurnLf.TabStop = False
        '
        'PicAT
        '
        Me.PicAT.Image = Global.Dashboard.My.Resources.Resources.at_dis
        Me.PicAT.Location = New System.Drawing.Point(514, 423)
        Me.PicAT.Name = "PicAT"
        Me.PicAT.Size = New System.Drawing.Size(50, 50)
        Me.PicAT.TabIndex = 27
        Me.PicAT.TabStop = False
        '
        'PicDoor
        '
        Me.PicDoor.Image = Global.Dashboard.My.Resources.Resources.door_dis
        Me.PicDoor.Location = New System.Drawing.Point(180, 423)
        Me.PicDoor.Name = "PicDoor"
        Me.PicDoor.Size = New System.Drawing.Size(50, 50)
        Me.PicDoor.TabIndex = 28
        Me.PicDoor.TabStop = False
        '
        'PicOD
        '
        Me.PicOD.Image = Global.Dashboard.My.Resources.Resources.od_dis
        Me.PicOD.Location = New System.Drawing.Point(458, 423)
        Me.PicOD.Name = "PicOD"
        Me.PicOD.Size = New System.Drawing.Size(50, 50)
        Me.PicOD.TabIndex = 29
        Me.PicOD.TabStop = False
        '
        'PicTurnRt
        '
        Me.PicTurnRt.Image = Global.Dashboard.My.Resources.Resources.turn_rt_dis
        Me.PicTurnRt.Location = New System.Drawing.Point(626, 205)
        Me.PicTurnRt.Name = "PicTurnRt"
        Me.PicTurnRt.Size = New System.Drawing.Size(50, 50)
        Me.PicTurnRt.TabIndex = 30
        Me.PicTurnRt.TabStop = False
        '
        'PicAccid
        '
        Me.PicAccid.Image = Global.Dashboard.My.Resources.Resources.accident_dis
        Me.PicAccid.Location = New System.Drawing.Point(345, 423)
        Me.PicAccid.Name = "PicAccid"
        Me.PicAccid.Size = New System.Drawing.Size(50, 50)
        Me.PicAccid.TabIndex = 31
        Me.PicAccid.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(69, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "50 л"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(187, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(625, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "14 В"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 118)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(125, 329)
        Me.ListBox1.TabIndex = 35
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(144, 118)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(125, 329)
        Me.ListBox2.TabIndex = 36
        '
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 485)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicAccid)
        Me.Controls.Add(Me.PicTurnRt)
        Me.Controls.Add(Me.PicOD)
        Me.Controls.Add(Me.PicDoor)
        Me.Controls.Add(Me.PicAT)
        Me.Controls.Add(Me.PicTurnLf)
        Me.Controls.Add(Me.PicBrake)
        Me.Controls.Add(Me.PicOil)
        Me.Controls.Add(Me.PicCheck)
        Me.Controls.Add(Me.PicBelt)
        Me.Controls.Add(Me.PicBat)
        Me.Controls.Add(Me.PicBeam)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbFuelRate)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PicFuelRate)
        Me.Controls.Add(Me.btLEDoff)
        Me.Controls.Add(Me.btLEDon)
        Me.Controls.Add(Me.lbSpeed)
        Me.Controls.Add(Me.btForw)
        Me.Controls.Add(Me.btRev)
        Me.Controls.Add(Me.PicSpeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AppForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppForm"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFuelRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBelt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBrake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTurnLf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTurnRt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAccid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicSpeed As PictureBox
    Friend WithEvents btRev As Button
    Friend WithEvents btForw As Button
    Friend WithEvents lbSpeed As Label
    Friend WithEvents btLEDoff As Button
    Friend WithEvents btLEDon As Button
    Friend WithEvents PicFuelRate As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LbFuelRate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PicBeam As PictureBox
    Friend WithEvents PicBat As PictureBox
    Friend WithEvents PicBelt As PictureBox
    Friend WithEvents PicCheck As PictureBox
    Friend WithEvents PicOil As PictureBox
    Friend WithEvents PicBrake As PictureBox
    Friend WithEvents PicTurnLf As PictureBox
    Friend WithEvents PicAT As PictureBox
    Friend WithEvents PicDoor As PictureBox
    Friend WithEvents PicOD As PictureBox
    Friend WithEvents PicTurnRt As PictureBox
    Friend WithEvents PicAccid As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
