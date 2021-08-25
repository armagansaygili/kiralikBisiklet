Imports System.Data.OleDb

Public Class uyeSil
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        anaForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kullanici_adi = kullaniciGiris.kullanici_adi

        con.Open()
        Dim com As New OleDbCommand("Delete from kullanici where username='" + kullanici_adi + "'", con)
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Kullanıcı Silindi. Program kapatılıyor.")
        System.Threading.Thread.Sleep(500)
        Application.Restart()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class