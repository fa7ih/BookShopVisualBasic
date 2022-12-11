Imports System.Data.SqlClient

Public Class Kullanici
    Dim bgl As New SqlConnection("Data Source=DESKTOP-BSG5U1A;Initial Catalog=KitapAlisveris;Integrated Security=True")
    Private Sub verileriGoster()
        bgl.Open()
        Dim sorgu = "select * from Kullanici"
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(sorgu, bgl)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(da)
        Dim ds As DataSet
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        bgl.Close()

    End Sub

    Private Sub Temizle()
        txtadres.Text = ""
        txtisim.Text = ""
        txtsifre.Text = ""
        txttelefon.Text = ""
        key = 0
    End Sub

    Private Sub btnkaydet_Click(sender As Object, e As EventArgs) Handles btnkaydet.Click
        If txtisim.Text = "" Or txtadres.Text = "" Or txttelefon.Text = "" Or txtsifre.Text = "" Then
            MsgBox("Lütfen Tüm Bilgileri Doldurunuz")
        End If
        bgl.Open()
        Dim sorgu As String
        sorgu = "insert into Kullanici values ('" & txtisim.Text & "','" & txttelefon.Text & "','" & txtadres.Text & "','" & txtsifre.Text & "') "
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        MsgBox("Kullanıcı başarıyla kayıt edildi")
        bgl.Close()
        verileriGoster()
        Temizle()
    End Sub

    Private Sub Kullanici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verileriGoster()
        Temizle()

    End Sub
    Dim key = 0
    Private Sub btnsil_Click(sender As Object, e As EventArgs) Handles btnsil.Click
        If key = 0 Then
            MsgBox("Silinecek Kullanıcıyı Seçin")
        End If
        bgl.Open()
        Dim sorgu As String
        sorgu = "delete from kullanici where Id=" & key & ""
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        MsgBox("Kullanıcı başarıyla Silindi")
        bgl.Close()
        verileriGoster()
        Temizle()

    End Sub

    Private Sub dataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridView1.CellMouseClick
        Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
        txtisim.Text = row.Cells(1).Value.ToString
        txttelefon.Text = row.Cells(2).Value.ToString
        txtadres.Text = row.Cells(3).Value.ToString
        txtsifre.Text = row.Cells(4).Value.ToString
        If txtisim.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub

    Private Sub btntemizle_Click(sender As Object, e As EventArgs) Handles btntemizle.Click
        Temizle()

    End Sub

    Private Sub btndüzenle_Click(sender As Object, e As EventArgs) Handles btndüzenle.Click
        If txtisim.Text = "" Or txtadres.Text = "" Or txttelefon.Text = "" Or txtsifre.Text = "" Then
            MsgBox("Lütfen Tüm Bilgileri Doldurunuz")
        End If
        bgl.Open()
        Dim sorgu As String
        sorgu = "update Kullanici set ad= '" & txtisim.Text & "',telefon='" & txttelefon.Text & "',adres='" & txtadres.Text & "',sifre='" & txtsifre.Text & "' where Id='" & key & "' "
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        MsgBox("Kullanıcı başarıyla Güncellendi")
        bgl.Close()
        verileriGoster()
        Temizle()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim obj = New Kitaplar
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim obj = New GöstergePaneli
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()

    End Sub
End Class