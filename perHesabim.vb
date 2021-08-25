Imports System.Data.OleDb

Public Class perHesabim
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
    Public kullanici_adi, kullanici_id As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim com As New OleDbCommand("update personel set `username`='" + TextBox1.Text + "', `personel_ad`='" + TextBox2.Text + "', `personel_sad`='" + TextBox3.Text + "', `personel_tel`='" + TextBox5.Text + "', `personel_mail`='" + TextBox7.Text + "' where username='" + kullanici_adi + "'", con)
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Bilgiler Güncellendi.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class