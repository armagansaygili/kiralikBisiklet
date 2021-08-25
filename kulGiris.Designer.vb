<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kullaniciGiris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kullaniciGiris))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.kullaniciLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 157)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(42, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 1)
        Me.Panel2.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(42, 284)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 1)
        Me.Panel3.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(43, 261)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(180, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(43, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1.TabIndex = 0
        '
        'kullaniciLbl
        '
        Me.kullaniciLbl.AutoSize = True
        Me.kullaniciLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.kullaniciLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.kullaniciLbl.Location = New System.Drawing.Point(42, 174)
        Me.kullaniciLbl.Name = "kullaniciLbl"
        Me.kullaniciLbl.Size = New System.Drawing.Size(107, 19)
        Me.kullaniciLbl.TabIndex = 19
        Me.kullaniciLbl.Text = "KULLANICI ADI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ŞİFRE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(61, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "GİRİŞ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(64, 371)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(137, 15)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Üye olmak için tıklayınız!"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(61, 302)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(53, 23)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Üye"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(121, 302)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(86, 23)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Personel"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'kullaniciGiris
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(266, 417)
        Me.Controls.Add(Me.kullaniciLbl)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "kullaniciGiris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GİRİŞ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents kullaniciLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
