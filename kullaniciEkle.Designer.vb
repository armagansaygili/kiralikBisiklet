<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kullaniciEkle
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kullaniciEkle))
        Me.kAdiLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'kAdiLbl
        '
        Me.kAdiLbl.AutoSize = True
        Me.kAdiLbl.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.kAdiLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.kAdiLbl.Location = New System.Drawing.Point(42, 90)
        Me.kAdiLbl.Name = "kAdiLbl"
        Me.kAdiLbl.Size = New System.Drawing.Size(89, 18)
        Me.kAdiLbl.TabIndex = 0
        Me.kAdiLbl.Text = "Kullanıcı Adı:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(43, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Şifre Tekrarı:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(42, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Şifre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(43, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Soyad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(43, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Ad:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(43, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 16)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(43, 165)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(156, 16)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(43, 220)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(156, 16)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(43, 331)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(156, 16)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(43, 275)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.Size = New System.Drawing.Size(156, 16)
        Me.TextBox5.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(42, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "KAYIT OL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(42, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "ÇIKIŞ"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(43, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 1)
        Me.Panel2.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 0)
        Me.Panel1.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(43, 184)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(156, 1)
        Me.Panel3.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(43, 239)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(156, 1)
        Me.Panel4.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(43, 294)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(156, 1)
        Me.Panel5.TabIndex = 24
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(43, 350)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(156, 1)
        Me.Panel6.TabIndex = 23
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(244, 89)
        Me.Panel7.TabIndex = 25
        '
        'kullaniciEkle
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(244, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kAdiLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "kullaniciEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "kullaniciEkle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents kAdiLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
End Class
