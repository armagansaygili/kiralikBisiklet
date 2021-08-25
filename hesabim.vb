Imports System.Data.OleDb

Public Class hesap
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
    Public kullanici_adi, kullanici_id As String


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        anaForm.Show()
    End Sub

    Private Sub hesap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kullanici_adi = kullaniciGiris.kullanici_adi

        TextBox1.Text = verilerForm.hesapDgv.CurrentRow.Cells("username").Value.ToString
        TextBox2.Text = verilerForm.hesapDgv.CurrentRow.Cells("kullanici_ad").Value.ToString
        TextBox3.Text = verilerForm.hesapDgv.CurrentRow.Cells("kullanici_sad").Value.ToString
        DateTimePicker1.Text = verilerForm.hesapDgv.CurrentRow.Cells("dogum_gunu").Value.ToString
        TextBox5.Text = verilerForm.hesapDgv.CurrentRow.Cells("kullanici_tel").Value.ToString
        TextBox6.Text = verilerForm.hesapDgv.CurrentRow.Cells("meslek").Value.ToString
        TextBox7.Text = verilerForm.hesapDgv.CurrentRow.Cells("kullanici_mail").Value.ToString


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim com As New OleDbCommand("update kullanici set `username`='" + TextBox1.Text + "', `kullanici_ad`='" + TextBox2.Text + "', `kullanici_sad`='" + TextBox3.Text + "', `dogum_tarihi`='" + DateTimePicker1.Text + "', `kullanici_tel`='" + TextBox5.Text + "', `meslek`='" + TextBox6.Text + "', `kullanici_mail`='" + TextBox7.Text + "' where username='" + kullanici_adi + "'", con)
        com.ExecuteNonQuery()
        con.Close()
        MsgBox("Bilgiler Güncellendi.")
    End Sub
End Class