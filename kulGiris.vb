Imports System.Data.OleDb
Imports System.Data



Public Class kullaniciGiris
    Public kullanici_adi, kullanici_id, kullanici_sifre As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
        Dim com As New OleDbCommand
        Dim adp As New OleDbDataAdapter
        Dim dataset As New DataSet


        If RadioButton1.Checked = True Then
            com.CommandText = ("Select kullanici_id,username,password from kullanici where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'")
            con.Open()
            com.Connection = con
            adp.SelectCommand = com
            adp.Fill(dataset, "0")
            Dim a = dataset.Tables(0).Rows.Count
            If a > 0 Then
                kullanici_adi = TextBox1.Text
                kullanici_sifre = TextBox2.Text
                verilerForm.Show()
                anaForm.Show()
                verilerForm.Visible = False
                Me.Hide()
            Else
                MsgBox("Kullanıcı Adı veya Şifresi Yanlış!", MsgBoxStyle.Critical, "Hata")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If

        If RadioButton2.Checked = True Then
            com.CommandText = ("Select personel_id,username,password from personel where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'")
            con.Open()
            com.Connection = con
            adp.SelectCommand = com
            adp.Fill(dataset, "0")
            Dim a = dataset.Tables(0).Rows.Count
            If a > 0 Then
                verilerForm.Show()
                perAnaForm.Show()
                verilerForm.Visible = False
                Me.Hide()
            End If

        End If


        con.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        kullaniciEkle.Show()
        Me.Hide()
    End Sub




End Class
