<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uyeSil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Üyeliğinizi silmek istediğinizde emin misiniz? "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(132, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bu işlem geri alınamaz."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(66, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "EVET"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(209, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "HAYIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'uyeSil
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(395, 150)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "uyeSil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "uyeSil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
