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
        Me.PicTemp = New System.Windows.Forms.PictureBox()
        Me.PicFuel = New System.Windows.Forms.PictureBox()
        Me.PicSpeed = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFuelRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFuel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRev
        '
        Me.btRev.Location = New System.Drawing.Point(12, 193)
        Me.btRev.Name = "btRev"
        Me.btRev.Size = New System.Drawing.Size(75, 23)
        Me.btRev.TabIndex = 1
        Me.btRev.Text = "<"
        Me.btRev.UseVisualStyleBackColor = True
        '
        'btForw
        '
        Me.btForw.Location = New System.Drawing.Point(93, 193)
        Me.btForw.Name = "btForw"
        Me.btForw.Size = New System.Drawing.Size(75, 23)
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
        Me.btLEDoff.Location = New System.Drawing.Point(12, 164)
        Me.btLEDoff.Name = "btLEDoff"
        Me.btLEDoff.Size = New System.Drawing.Size(75, 23)
        Me.btLEDoff.TabIndex = 6
        Me.btLEDoff.Text = "LEDoff"
        Me.btLEDoff.UseVisualStyleBackColor = True
        '
        'btLEDon
        '
        Me.btLEDon.Location = New System.Drawing.Point(93, 164)
        Me.btLEDon.Name = "btLEDon"
        Me.btLEDon.Size = New System.Drawing.Size(75, 23)
        Me.btLEDon.TabIndex = 5
        Me.btLEDon.Text = "LEDon"
        Me.btLEDon.UseVisualStyleBackColor = True
        '
        'LbFuelRate
        '
        Me.LbFuelRate.AutoSize = True
        Me.LbFuelRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LbFuelRate.ForeColor = System.Drawing.Color.Orange
        Me.LbFuelRate.Location = New System.Drawing.Point(351, 404)
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
        Me.Label2.Location = New System.Drawing.Point(261, 352)
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
        Me.PictureBox5.Location = New System.Drawing.Point(561, 406)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(111, 406)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PicFuelRate
        '
        Me.PicFuelRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFuelRate.Location = New System.Drawing.Point(265, 379)
        Me.PicFuelRate.Name = "PicFuelRate"
        Me.PicFuelRate.Size = New System.Drawing.Size(209, 22)
        Me.PicFuelRate.TabIndex = 9
        Me.PicFuelRate.TabStop = False
        '
        'PicTemp
        '
        Me.PicTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicTemp.Location = New System.Drawing.Point(561, 280)
        Me.PicTemp.Name = "PicTemp"
        Me.PicTemp.Size = New System.Drawing.Size(50, 120)
        Me.PicTemp.TabIndex = 8
        Me.PicTemp.TabStop = False
        '
        'PicFuel
        '
        Me.PicFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFuel.Location = New System.Drawing.Point(111, 280)
        Me.PicFuel.Margin = New System.Windows.Forms.Padding(0)
        Me.PicFuel.Name = "PicFuel"
        Me.PicFuel.Size = New System.Drawing.Size(50, 120)
        Me.PicFuel.TabIndex = 7
        Me.PicFuel.TabStop = False
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
        Me.Button1.Location = New System.Drawing.Point(12, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
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
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 485)
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
        Me.Controls.Add(Me.PicTemp)
        Me.Controls.Add(Me.PicFuel)
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
        CType(Me.PicTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFuel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicSpeed As PictureBox
    Friend WithEvents btRev As Button
    Friend WithEvents btForw As Button
    Friend WithEvents lbSpeed As Label
    Friend WithEvents btLEDoff As Button
    Friend WithEvents btLEDon As Button
    Friend WithEvents PicFuel As PictureBox
    Friend WithEvents PicTemp As PictureBox
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
End Class
