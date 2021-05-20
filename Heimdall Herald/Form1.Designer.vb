<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class heimdall_herald
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(heimdall_herald))
        Me.config_class = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.count_herald = New System.Windows.Forms.Label()
        Me.counter = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'config_class
        '
        Me.config_class.BackColor = System.Drawing.Color.Black
        Me.config_class.Font = New System.Drawing.Font("Zag Bold", 15.7!, System.Drawing.FontStyle.Bold)
        Me.config_class.ForeColor = System.Drawing.SystemColors.Window
        Me.config_class.Location = New System.Drawing.Point(-1, -2)
        Me.config_class.Name = "config_class"
        Me.config_class.Size = New System.Drawing.Size(671, 465)
        Me.config_class.TabIndex = 0
        Me.config_class.Text = "Heimdall #~~>>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(136, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Haberci "
        '
        'count_herald
        '
        Me.count_herald.AutoSize = True
        Me.count_herald.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.count_herald.Location = New System.Drawing.Point(232, 466)
        Me.count_herald.Name = "count_herald"
        Me.count_herald.Size = New System.Drawing.Size(27, 27)
        Me.count_herald.TabIndex = 2
        Me.count_herald.Text = "15"
        '
        'counter
        '
        Me.counter.Enabled = True
        Me.counter.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(300, 469)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "saniye sonra otomatik olarak kapanacak."
        '
        'heimdall_herald
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(669, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.count_herald)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.config_class)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "heimdall_herald"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                             Heim" &
    "dall Herald - Heimdall Habercisi"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents config_class As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents count_herald As Label
    Friend WithEvents counter As Timer
    Friend WithEvents Label2 As Label
End Class
