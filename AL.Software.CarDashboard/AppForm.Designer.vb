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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(688, 485)
        Me.Controls.Add(Me.btForw)
        Me.Controls.Add(Me.btRev)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btRev As Button
    Friend WithEvents btForw As Button
End Class
