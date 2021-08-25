Imports System.Data.OleDb

Public Class verilerForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\armsa\Desktop\Project\kiralikBisiklet\kiralikBisiklet\kiralikBisiklet.mdb;Persist Security Info=False;")
    Public kullanici_adi, kullanici_id As String

    Private Sub verilerForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        kullanici_adi = kullaniciGiris.kullanici_adi
        con.Open()
        Dim da = New OleDbDataAdapter("Select * from kullanici where username='" + kullanici_adi + "'", con)
        Dim dt = New DataTable()
        da.Fill(dt)
        hesapDgv.DataSource = dt
        con.Close()









        Dim da2 = New OleDbDataAdapter("select sum(kira_ucret) as ucret from kiralama where teslim_tarihi between date() and date()-1", con)
        Dim da3 = New OleDbDataAdapter("select sum(kira_ucret) as ucret from kiralama where teslim_tarihi between date() and date()-7", con)
        Dim da4 = New OleDbDataAdapter("select sum(kira_ucret) as ucret from kiralama where teslim_tarihi between date() and date()-30", con)

        Dim dt2 = New DataTable()
        Dim dt3 = New DataTable()
        Dim dt4 = New DataTable()

        da2.Fill(dt2)
        da3.Fill(dt3)
        da4.Fill(dt4)

        DataGridView1.DataSource = dt2
        DataGridView2.DataSource = dt3
        DataGridView3.DataSource = dt4




    End Sub

End Class