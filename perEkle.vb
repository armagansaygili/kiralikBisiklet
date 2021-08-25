Imports System.Data.OleDb

Public Class per

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
    Dim com As New OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim kullanici_adi, adi, soyadi, sifre, mail As String

        kullanici_adi = TextBox1.Text
        adi = TextBox2.Text
        soyadi = TextBox3.Text
        sifre = TextBox5.Text


        If kullanici_adi = "" Or adi = "" Or soyadi = "" Or sifre = "" Then
            MsgBox("Tüm alanları doldurunuz.")
        ElseIf True Then
            con.Open()
            com.CommandText = ("insert into personel(`username`,`password`,`kullanici_ad`,`kullanici_sad`) values('" + kullanici_adi + "','" + sifre + "','" + adi + "','" + soyadi + "')")
            com.Connection = con
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Kullanıcı Eklendi.",, "Eklendi")
            getir()
        End If
    End Sub

    Private Sub per_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getir()
    End Sub

    Sub getir()

        con.Open()
        Dim da = New OleDbDataAdapter("Select * from personel", con)
        Dim dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim per_id = DataGridView1.CurrentRow.Cells(0).Value.ToString
        con.Open()
        Dim com As New OleDbCommand("Delete from personel where personel_id=" + per_id + "", con)
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Personel silindi.")
        getir()
    End Sub
End Class