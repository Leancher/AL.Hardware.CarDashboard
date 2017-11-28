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
        Me.btRev = New System.Windows.Forms.Button()
        Me.btForw = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbSpeed = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btLEDoff = New System.Windows.Forms.Button()
        Me.btLEDon = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRev
        '
        Me.btRev.Location = New System.Drawing.Point(87, 389)
        Me.btRev.Name = "btRev"
        Me.btRev.Size = New System.Drawing.Size(75, 23)
        Me.btRev.TabIndex = 1
        Me.btRev.Text = "<"
        Me.btRev.UseVisualStyleBackColor = True
        '
        'btForw
        '
        Me.btForw.Location = New System.Drawing.Point(184, 389)
        Me.btForw.Name = "btForw"
        Me.btForw.Size = New System.Drawing.Size(75, 23)
        Me.btForw.TabIndex = 2
        Me.btForw.Text = ">"
        Me.btForw.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Dashboard.My.Resources.Resources.SpeedScale
        Me.PictureBox1.Location = New System.Drawing.Point(58, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(688, 180)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbSpeed
        '
        Me.lbSpeed.Font = New System.Drawing.Font("Haettenschweiler", 120.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbSpeed.ForeColor = System.Drawing.Color.Orange
        Me.lbSpeed.Location = New System.Drawing.Point(224, 114)
        Me.lbSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.lbSpeed.Name = "lbSpeed"
        Me.lbSpeed.Size = New System.Drawing.Size(383, 169)
        Me.lbSpeed.TabIndex = 3
        Me.lbSpeed.Text = "180"
        Me.lbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(523, 392)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'btLEDoff
        '
        Me.btLEDoff.Location = New System.Drawing.Point(168, 438)
        Me.btLEDoff.Name = "btLEDoff"
        Me.btLEDoff.Size = New System.Drawing.Size(75, 23)
        Me.btLEDoff.TabIndex = 6
        Me.btLEDoff.Text = "LEDoff"
        Me.btLEDoff.UseVisualStyleBackColor = True
        '
        'btLEDon
        '
        Me.btLEDon.Location = New System.Drawing.Point(87, 438)
        Me.btLEDon.Name = "btLEDon"
        Me.btLEDon.Size = New System.Drawing.Size(75, 23)
        Me.btLEDon.TabIndex = 5
        Me.btLEDon.Text = "LEDon"
        Me.btLEDon.UseVisualStyleBackColor = True
        '
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 485)
        Me.Controls.Add(Me.btLEDoff)
        Me.Controls.Add(Me.btLEDon)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbSpeed)
        Me.Controls.Add(Me.btForw)
        Me.Controls.Add(Me.btRev)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AppForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btRev As Button
    Friend WithEvents btForw As Button
    Friend WithEvents lbSpeed As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btLEDoff As Button
    Friend WithEvents btLEDon As Button
End Class
