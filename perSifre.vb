Imports System.Data.OleDb

Public Class perSifre


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kullanici_adi, kullanici_sifre As String
        kullanici_adi = kullaniciGiris.kullanici_adi
        kullanici_sifre = kullaniciGiris.kullanici_sifre
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
        Dim com As New OleDbCommand
        Dim dataset As New DataSet


        If (TextBox2.Text = TextBox3.Text) Then
            con.Open()
            com.CommandText = ("update personel set `password`='" + TextBox2.Text + "' where username='" + kullanici_adi + "' and password='" + TextBox1.Text + "'")
            com.Connection = con
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Şifreniz Değişti.")
        Else
            MsgBox("Şifreleri kontrol ediniz.")

        End If
    End Sub
End Class