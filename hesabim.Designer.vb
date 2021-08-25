<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hesap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hesap))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kAdiLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 90)
        Me.Panel2.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "E-posta Adresi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(67, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Meslek:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(126, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "ÇIKIŞ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(126, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "GÜNCELLE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(91, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Ad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(74, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Soyad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(66, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Telefon:"
        '
        'kAdiLbl
        '
        Me.kAdiLbl.AutoSize = True
        Me.kAdiLbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.kAdiLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.kAdiLbl.Location = New System.Drawing.Point(41, 127)
        Me.kAdiLbl.Name = "kAdiLbl"
        Me.kAdiLbl.Size = New System.Drawing.Size(76, 15)
        Me.kAdiLbl.TabIndex = 40
        Me.kAdiLbl.Text = "Kullanıcı Adı:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(35, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Doğum Günü:"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox6.Location = New System.Drawing.Point(126, 346)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 23)
        Me.TextBox6.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox5.Location = New System.Drawing.Point(126, 311)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(120, 23)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox7.Location = New System.Drawing.Point(126, 273)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(120, 23)
        Me.TextBox7.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.Location = New System.Drawing.Point(126, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(120, 23)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(126, 162)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 23)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(126, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 23)
        Me.TextBox1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(126, 235)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'hesap
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(283, 467)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kAdiLbl)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "hesap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hesabım"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents kAdiLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
