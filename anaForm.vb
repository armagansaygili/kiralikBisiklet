Imports System.Data.OleDb

Public Class anaForm
    Dim kullanici_id, bisiklet_id, kiralama_no As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
    Dim com, com2 As New OleDbCommand
    Private Sub anaForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub hesabimMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles hesabimMenu.Click
        hesap.Show()
    End Sub

    Private Sub sifreMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sifreMenu.Click
        sifre.Show()
    End Sub

    Private Sub uyelikMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles uyelikMenu.Click
        uyeSil.Show()
    End Sub

    Private Sub kiralamaMenuMenuStrip1_ItemClicked(sender As Object, e As EventArgs) Handles kiralamaMenu.Click
        kiralama.Show()
    End Sub

    Private Sub cikisMenuStrip1_ItemClicked(sender As Object, e As EventArgs) Handles cikis.Click
        Application.Restart()
    End Sub

    Private Sub anaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kiraGetir()
        gecmisGetir()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        DataGridView1.Columns(0).HeaderText = "Bisiklet Marka"
        DataGridView1.Columns(0).Visible = False

        DataGridView1.Columns(1).HeaderText = "Bisiklet Model"
        DataGridView1.Columns(1).Visible = False

        DataGridView1.Columns(2).HeaderText = "Kiralama No"
        DataGridView1.Columns(3).HeaderText = "Kiralama Tarihi"
        DataGridView1.Columns(4).HeaderText = "Teslim Tarihi"
        DataGridView1.Columns(5).HeaderText = "Kira Ücreti"
        DataGridView1.Columns(5).Visible = False

        DataGridView1.Columns(6).HeaderText = "Resim"
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).HeaderText = "Kullanici ID"
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).HeaderText = "Teslim Durumu"
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).HeaderText = "Bisiklet ID"
        DataGridView1.Columns(9).Visible = False

        DataGridView2.Columns(0).HeaderText = "Bisiklet Marka"
        DataGridView2.Columns(0).Visible = False

        DataGridView2.Columns(1).HeaderText = "Bisiklet Model"
        DataGridView2.Columns(1).Visible = False

        DataGridView2.Columns(2).HeaderText = "Kiralama No"
        DataGridView2.Columns(3).HeaderText = "Kiralama Tarihi"
        DataGridView2.Columns(4).HeaderText = "Teslim Tarihi"
        DataGridView2.Columns(5).HeaderText = "Kira Ücreti"
        DataGridView2.Columns(5).Visible = False

        DataGridView2.Columns(6).HeaderText = "Resim"
        DataGridView2.Columns(6).Visible = False
        DataGridView2.Columns(7).HeaderText = "Kullanici ID"
        DataGridView2.Columns(7).Visible = False
        DataGridView2.Columns(8).HeaderText = "Teslim Durumu"
        DataGridView2.Columns(8).Visible = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
        TextBox2.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
        TextBox4.Text = DataGridView2.CurrentRow.Cells(5).Value.ToString
        PictureBox1.ImageLocation = DataGridView2.CurrentRow.Cells(6).Value.ToString

        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kiralama_no = DataGridView1.CurrentRow.Cells("kiralama_no").Value.ToString
        bisiklet_id = DataGridView1.CurrentRow.Cells("bisiklet_id").Value.ToString
        con.Open()
        com.CommandText = ("update kiralama set `teslim_durumu`='1' where kiralama_no=" + kiralama_no + "")
        com2.CommandText = ("update bisiklet set `kira_durumu`='1' where bisiklet_id=" + bisiklet_id + "")
        com.Connection = con
        com2.Connection = con
        com2.ExecuteNonQuery()
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Teslim Edildi.")
        kiraGetir()
        gecmisGetir()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TextBox4.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        PictureBox1.ImageLocation = DataGridView1.CurrentRow.Cells(6).Value.ToString

        Button2.Enabled = True

    End Sub

    Sub kiraGetir()
        kullanici_id = verilerForm.hesapDgv.CurrentRow.Cells("kullanici_id").Value.ToString
        con.Open()
        Dim da = New OleDbDataAdapter("SELECT bisiklet_marka,bisiklet_model,kiralama_no,kiralama_tarihi,teslim_tarihi,kira_ucret,resim,kiralama.kullanici_id,kiralama.teslim_durumu,bisiklet.bisiklet_id FROM bisiklet INNER JOIN kiralama ON bisiklet.bisiklet_id = kiralama.bisiklet_id where kiralama.kullanici_id=" + kullanici_id + " and kiralama.teslim_durumu='0'", con)
        Dim dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Sub gecmisGetir()
        kullanici_id = verilerForm.hesapDgv.CurrentRow.Cells("kullanici_id").Value.ToString
        con.Open()
        Dim da = New OleDbDataAdapter("SELECT bisiklet_marka,bisiklet_model,kiralama_no,kiralama_tarihi,teslim_tarihi,kira_ucret,resim,kiralama.kullanici_id,kiralama.teslim_durumu FROM bisiklet INNER JOIN kiralama ON bisiklet.bisiklet_id = kiralama.bisiklet_id where kiralama.kullanici_id=" + kullanici_id + " and kiralama.teslim_durumu='1'", con)
        Dim dt = New DataTable()
        da.Fill(dt)
        DataGridView2.DataSource = dt
        con.Close()
    End Sub
End Class