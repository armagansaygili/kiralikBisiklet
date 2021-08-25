Imports System.Data.OleDb

Public Class sifre


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kullanici_adi As String
        kullanici_adi = kullaniciGiris.kullanici_adi

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
        Dim com As New OleDbCommand
        Dim dataset As New DataSet


        If TextBox2.Text = TextBox3.Text And TextBox1.Text = kullaniciGiris.kullanici_sifre Then
            con.Open()
            com.CommandText = ("update kullanici set `password`='" + TextBox2.Text + "' where username='" + kullanici_adi + "' and password='" + TextBox1.Text + "'")
            com.Connection = con
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Şifreniz Değişti.")
        Else
            MsgBox("Şifreleri kontrol ediniz.")

        End If

    End Sub

End Class