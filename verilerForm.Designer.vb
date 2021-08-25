<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class verilerForm
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
        Me.hesapDgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.hesapDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hesapDgv
        '
        Me.hesapDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hesapDgv.Location = New System.Drawing.Point(34, 36)
        Me.hesapDgv.Name = "hesapDgv"
        Me.hesapDgv.RowTemplate.Height = 25
        Me.hesapDgv.Size = New System.Drawing.Size(188, 66)
        Me.hesapDgv.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "hesap"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(287, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(188, 66)
        Me.DataGridView1.TabIndex = 37
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(287, 44)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(188, 66)
        Me.DataGridView2.TabIndex = 38
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(498, 44)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 25
        Me.DataGridView3.Size = New System.Drawing.Size(188, 66)
        Me.DataGridView3.TabIndex = 39
        '
        'verilerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 383)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hesapDgv)
        Me.Name = "verilerForm"
        Me.Text = "Form1"
        CType(Me.hesapDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents hesapDgv As DataGridView
    Friend WithEvents Label1 As Label
    Public WithEvents DataGridView1 As DataGridView
    Public WithEvents DataGridView2 As DataGridView
    Public WithEvents DataGridView3 As DataGridView
End Class
