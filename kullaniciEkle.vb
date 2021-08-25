Imports System.Data.OleDb

Public Class kullaniciEkle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        kullaniciGiris.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
        Dim com As New OleDbCommand


        Dim kullanici_adi, adi, soyadi, sifre, sifre_tekrar As String

        kullanici_adi = TextBox1.Text
        adi = TextBox2.Text
        soyadi = TextBox3.Text
        sifre = TextBox4.Text
        sifre_tekrar = TextBox5.Text

        If kullanici_adi = "" Or adi = "" Or soyadi = "" Or sifre = "" Or sifre_tekrar = "" Then
            MsgBox("Tüm alanları doldurunuz.")
        ElseIf True Then
            If TextBox4.Text = TextBox5.Text Then
                con.Open()
                com.CommandText = ("insert into kullanici(`username`,`password`,`kullanici_ad`,`kullanici_sad`) values('" + kullanici_adi + "','" + sifre + "','" + adi + "','" + soyadi + "')")
                com.Connection = con
                com.ExecuteNonQuery()
                con.Close()
                MsgBox("Kullanıcı Eklendi.",, "Eklendi")

            Else
                MsgBox("Şifreler eşleşmiyor.", MsgBoxStyle.Critical, "Hata")
                TextBox4.Clear()
                TextBox5.Clear()
            End If
        End If




    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class