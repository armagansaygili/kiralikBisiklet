Imports System.Data.OleDb
Imports System.IO

Public Class perAnaForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
    Dim com As New OleDbCommand
    Dim kullanici_id As String
    Dim yol, Hedef As String
    Private Sub perAnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getir()
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        DataGridView1.Columns(0).HeaderText = "Bisiklet Marka"
        DataGridView1.Columns(1).HeaderText = "Bisiklet Model"
        DataGridView1.Columns(2).HeaderText = "Kira Ücreti"
        DataGridView1.Columns(3).HeaderText = "Resim"
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False

        DataGridView2.Columns(0).HeaderText = "Bisiklet Marka"
        DataGridView2.Columns(1).HeaderText = "Bisiklet Model"
        DataGridView2.Columns(2).HeaderText = "Kira Ücreti"
        DataGridView2.Columns(3).Visible = False
        DataGridView2.Columns(4).Visible = False

        DataGridView3.Columns(0).HeaderText = "Bisiklet Marka"
        DataGridView3.Columns(1).HeaderText = "Bisiklet Model"
        DataGridView3.Columns(2).HeaderText = "Kira Ücreti"
        DataGridView3.Columns(3).Visible = False
        DataGridView3.Columns(4).Visible = False

        DataGridView4.Columns(0).HeaderText = "Bisiklet ID"
        DataGridView4.Columns(1).HeaderText = "Kiralama Sayısı"
        DataGridView4.Columns(2).HeaderText = "Marka"
        DataGridView4.Columns(3).HeaderText = "Model"

        DataGridView5.Columns(0).HeaderText = "Bisiklet ID"
        DataGridView5.Columns(1).HeaderText = "Kiralama Sayısı"
        DataGridView5.Columns(2).HeaderText = "Marka"
        DataGridView5.Columns(3).HeaderText = "Model"


        DataGridView6.Columns(3).Visible = False
        DataGridView6.Columns(4).Visible = False
        If verilerForm.DataGridView1.CurrentRow.Cells("ucret").Value.ToString <> "" Then
            Label18.Text = verilerForm.DataGridView1.CurrentRow.Cells("ucret").Value.ToString + "₺"
        Else
            Label18.Text = "####"
        End If

        If verilerForm.DataGridView2.CurrentRow.Cells("ucret").Value.ToString <> "" Then
            Label19.Text = verilerForm.DataGridView2.CurrentRow.Cells("ucret").Value.ToString + "₺"
        Else
            Label19.Text = "####"
        End If

        If verilerForm.DataGridView3.CurrentRow.Cells("ucret").Value.ToString <> "" Then
            Label20.Text = verilerForm.DataGridView3.CurrentRow.Cells("ucret").Value.ToString + "₺"
        Else
            Label20.Text = "####"
        End If




    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        PictureBox1.ImageLocation = DataGridView1.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then

            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        yol = Directory.GetCurrentDirectory()
        Hedef = yol + "\resim\" + TextBox2.Text + kullanici_id + ".jpg"
        System.IO.File.Copy(OpenFileDialog1.FileName, Hedef, True)

        con.Open()
        com.CommandText = ("insert into bisiklet(`bisiklet_marka`,`bisiklet_model`,`bisiklet_ucret`,`kullanici_id`,`kira_durumu`,`resim`) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + kullanici_id + "',0,'" + Hedef + "')")
        com.Connection = con
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Bisiklet Eklendi.",, "Bilgi")
        getir()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con.Open()
        com.CommandText = ("Update bisiklet set `kira_durumu`='1' where bisiklet_id=" + DataGridView3.CurrentRow.Cells(4).Value.ToString)
        com.Connection = con
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Bisiklet Kiraya Konuldu.",, "Bilgi")
        getir()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con.Open()
        com.CommandText = ("DELETE bisiklet bisiklet_id=" + DataGridView3.CurrentRow.Cells(4).Value.ToString)
        com.Connection = con
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Bisiklet Kaldırıldı.",, "Bilgi")
        getir()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con.Open()
        com.CommandText = ("Update bisiklet set `bakim_durumu`='1' where bisiklet_id=" + DataGridView3.CurrentRow.Cells(4).Value.ToString)
        com.Connection = con
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Bisiklet bakıma alındı.",, "Bilgi")
        getir()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        con.Open()
        com.CommandText = ("Update bisiklet set `bakim_durumu`='0' where bisiklet_id=" + DataGridView1.CurrentRow.Cells(4).Value.ToString)
        com.Connection = con
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Bisiklet bakımı bitti.",, "Bilgi")
        getir()
    End Sub

    Private Sub perAnaForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        Dim da = New OleDbDataAdapter("SELECT bisiklet_marka,bisiklet_model,teslim_tarihi,kira_ucret FROM bisiklet INNER JOIN kiralama ON bisiklet.bisiklet_id = kiralama.bisiklet_id WHERE (((kiralama.[teslim_tarihi]) between #" + DateTimePicker2.Text + "# and #" + DateTimePicker1.Text + "#))", con)
        Dim dt = New DataTable()
        da.Fill(dt)
        DataGridView7.DataSource = dt

        DataGridView7.Columns(0).HeaderText = "Bisiklet Marka"
        DataGridView7.Columns(1).HeaderText = "Bisiklet Model"
        DataGridView7.Columns(2).HeaderText = "Teslim Tarihi"
        DataGridView7.Columns(3).HeaderText = "Kira Ücreti"

    End Sub

    Sub getir()

        con.Open()
        Dim da = New OleDbDataAdapter("Select bisiklet_marka,bisiklet_model,bisiklet_ucret,resim,bisiklet_id from bisiklet where bakim_durumu='0'", con)
        Dim da2 = New OleDbDataAdapter("Select bisiklet_marka,bisiklet_model,bisiklet_ucret,resim,bisiklet_id from bisiklet where kira_durumu='0' and bakim_durumu='0'", con)
        Dim da3 = New OleDbDataAdapter("Select bisiklet_marka,bisiklet_model,bisiklet_ucret,resim,bisiklet_id from bisiklet where kira_durumu='1' and bakim_durumu='0'", con)
        Dim da4 = New OleDbDataAdapter("SELECT top 3 kiralama.bisiklet_id, Count(kiralama.kiralama_no) AS Saykiralama_no, bisiklet.bisiklet_marka, bisiklet.bisiklet_model FROM bisiklet INNER JOIN kiralama ON bisiklet.bisiklet_id = kiralama.bisiklet_id GROUP BY kiralama.bisiklet_id, bisiklet.bisiklet_marka, bisiklet.bisiklet_model ORDER BY Count(kiralama.kiralama_no) DESC", con)
        Dim da5 = New OleDbDataAdapter("SELECT top 3 kiralama.bisiklet_id, Count(kiralama.kiralama_no) AS Saykiralama_no, bisiklet.bisiklet_marka, bisiklet.bisiklet_model FROM bisiklet INNER JOIN kiralama ON bisiklet.bisiklet_id = kiralama.bisiklet_id GROUP BY kiralama.bisiklet_id, bisiklet.bisiklet_marka, bisiklet.bisiklet_model ORDER BY Count(kiralama.kiralama_no) ASC", con)
        Dim da6 = New OleDbDataAdapter("Select bisiklet_marka,bisiklet_model,bisiklet_ucret,resim,bisiklet_id from bisiklet where kira_durumu='1' and bakim_durumu='1'", con)

        Dim dt = New DataTable()
        Dim dt2 = New DataTable()
        Dim dt3 = New DataTable()
        Dim dt4 = New DataTable()
        Dim dt5 = New DataTable()
        Dim dt6 = New DataTable()

        da.Fill(dt)
        da2.Fill(dt2)
        da3.Fill(dt3)
        da4.Fill(dt4)
        da5.Fill(dt5)
        da6.Fill(dt6)

        DataGridView1.DataSource = dt
        DataGridView2.DataSource = dt2
        DataGridView3.DataSource = dt3
        DataGridView4.DataSource = dt4
        DataGridView5.DataSource = dt5
        DataGridView6.DataSource = dt6

        con.Close()
    End Sub
    Private Sub CikisMenuStrip1_ItemClicked(sender As Object, e As EventArgs) Handles cikis.Click
        Application.Restart()
    End Sub

    Private Sub hesabimMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles hesabimMenu.Click
        perHesabim.Show()
    End Sub

    Private Sub sifreMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles sifreMenu.Click
        perSifre.Show()
    End Sub

    Private Sub perEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles perEkle.Click
        per.Show()
    End Sub
End Class