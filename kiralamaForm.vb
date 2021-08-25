Imports System.Data.OleDb

Public Class kiralama
    Public kullanici_id, bisiklet_id As String
    Public tarih, tarih2 As Date

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
    Dim com, com2 As New OleDbCommand
    Public Sub getir()
        kullanici_id = verilerForm.hesapDgv.CurrentRow.Cells("kullanici_id").Value.ToString
        con.Open()
        Dim da = New OleDbDataAdapter("Select bisiklet_marka,bisiklet_model,bisiklet_ucret,resim,bisiklet_id,bakim_durumu from bisiklet where kira_durumu='1'  and bakim_durumu='0'", con)
        Dim dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub kiralama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getir()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        DataGridView1.Columns(0).HeaderText = "Bisiklet Marka"
        DataGridView1.Columns(1).HeaderText = "Bisiklet Model"
        DataGridView1.Columns(2).HeaderText = "Kira Ücreti"
        DataGridView1.Columns(3).HeaderText = "Resim"
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False

        DateTimePicker1.Value = Now()
        DateTimePicker1.MinDate = Now()
        DateTimePicker3.Enabled = False



    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        DateTimePicker3.MinDate = DateTimePicker1.Value
        DateTimePicker3.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        PictureBox1.ImageLocation = DataGridView1.CurrentRow.Cells(3).Value.ToString
        bisiklet_id = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gun = DateDiff("d", DateTimePicker1.Value, DateTimePicker3.Value)
        Dim ucret, gunluk_kira As String
        gunluk_kira = DataGridView1.CurrentRow.Cells(2).Value.ToString
        ucret = (Convert.ToInt32(gunluk_kira) * Convert.ToInt32(gun)).ToString

        If DateTimePicker1.Value = DateTimePicker3.Value Then

            MsgBox("Aynı güne teslim bisiklet kiralayamazsınız.",, "Uyarı")

        Else
            con.Open()
            com.CommandText = ("insert into kiralama(`bisiklet_id`,`kiralama_tarihi`,`teslim_tarihi`,`kira_ucret`,`teslim_durumu`,kullanici_id) values(" + bisiklet_id + ",'" + DateTimePicker1.Text + "','" + DateTimePicker3.Text + "','" + ucret + "','0'," + kullanici_id + ")")
            com.Connection = con
            com2.CommandText = (" update bisiklet set `kira_durumu`='0' where `bisiklet_id`=" + bisiklet_id + "")
            com2.Connection = con
            com.ExecuteNonQuery()
            com2.ExecuteNonQuery()
            con.Close()
            getir()
            anaForm.kiraGetir()
        End If


    End Sub
End Class