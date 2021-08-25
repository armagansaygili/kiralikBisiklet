<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sifre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sifre))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(52, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(147, 16)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(52, 176)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(147, 16)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(52, 239)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(147, 16)
        Me.TextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(99, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eski Şifre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(110, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Şifre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(88, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Şifre Tekrarı"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(52, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "ŞİFRE DEĞİŞTİR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(52, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 1)
        Me.Panel2.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 1)
        Me.Panel1.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(0, -11)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(147, 23)
        Me.TextBox4.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(52, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(147, 1)
        Me.Panel3.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(52, 196)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(147, 1)
        Me.Panel4.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(52, 259)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(147, 1)
        Me.Panel5.TabIndex = 15
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(250, 89)
        Me.Panel7.TabIndex = 26
        '
        'sifre
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(250, 334)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "sifre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
End Class
