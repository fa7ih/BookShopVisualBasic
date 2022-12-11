Imports System.Data.SqlClient

Public Class Kitaplar
    Dim bgl As New SqlConnection("Data Source=DESKTOP-BSG5U1A;Initial Catalog=KitapAlisveris;Integrated Security=True")
    Private Sub verileriGoster()
        bgl.Open()
        Dim sorgu = "select * from kitaplar"
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(sorgu, bgl)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(da)
        Dim ds As DataSet
        ds = New DataSet
        da.Fill(ds)
        dataGridView1.DataSource = ds.Tables(0)
        bgl.Close()

    End Sub
    Private Sub bul()
        bgl.Open()
        Dim sorgu = "select * from kitaplar where kategori='" & cmbfitre.SelectedItem.ToString & "'"
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(sorgu, bgl)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(da)
        Dim ds As DataSet
        ds = New DataSet
        da.Fill(ds)
        dataGridView1.DataSource = ds.Tables(0)
        bgl.Close()

    End Sub
    Private Sub Temizle()
        txtfiyat.Text = ""
        txtkitap.Text = ""
        txtmiktar.Text = ""
        txtyazar.Text = ""
        cmbkategori.SelectedIndex = -1
        cmbfitre.SelectedIndex = -1
        key = 0
    End Sub

    Private Sub btnkaydet_Click(sender As Object, e As EventArgs) Handles btnkaydet.Click
        If txtkitap.Text = "" Or txtmiktar.Text = "" Or txtfiyat.Text = "" Or txtyazar.Text = "" Or cmbkategori.SelectedIndex = -1 Then
            MsgBox("Lütfen Tüm Bilgileri Doldurunuz")
        End If
        bgl.Open()
        Dim sorgu As String
        sorgu = "insert into kitaplar values ('" & txtkitap.Text & "','" & txtyazar.Text & "','" & cmbkategori.SelectedItem.ToString & "','" & txtmiktar.Text & "','" & txtfiyat.Text & "') "
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        MsgBox("Kitap bilgisi başarıyla kayıt edildi")
        bgl.Close()
        verileriGoster()
        Temizle()
    End Sub

    Dim key = 0
    Private Sub dataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridView1.CellMouseClick
        Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
        txtkitap.Text = row.Cells(1).Value.ToString
        txtyazar.Text = row.Cells(2).Value.ToString
        cmbkategori.SelectedItem = row.Cells(3).Value.ToString
        txtmiktar.Text = row.Cells(4).Value.ToString
        txtfiyat.Text = row.Cells(5).Value.ToString
        If txtkitap.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Kitaplar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verileriGoster()
        Temizle()

    End Sub

    Private Sub btntemizle_Click(sender As Object, e As EventArgs) Handles btntemizle.Click
        Temizle()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()

    End Sub

    Private Sub btnsil_Click(sender As Object, e As EventArgs) Handles btnsil.Click
        If key = 0 Then
            MsgBox("Silinecek kitabı Seçin")
        End If
        bgl.Open()
        Dim sorgu As String
        sorgu = "delete from kitaplar where Id=" & key & ""
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        MsgBox("Kitap bilgisi başarıyla Silindi")
        bgl.Close()
        verileriGoster()
        Temizle()
    End Sub

    Private Sub btndüzenle_Click(sender As Object, e As EventArgs) Handles btndüzenle.Click
        If txtkitap.Text = "" Or txtmiktar.Text = "" Or txtfiyat.Text = "" Or txtyazar.Text = "" Or cmbkategori.SelectedIndex = -1 Then
            MsgBox("Lütfen Tüm Bilgileri Doldurunuz")
        End If
        bgl.Open()
        Dim sorgu As String
        sorgu = "update kitaplar set baslik= '" & txtkitap.Text & "',yazar='" & txtyazar.Text & "',kategori='" & cmbkategori.SelectedItem.ToString & "',miktar='" & txtmiktar.Text & "',fiyat='" & txtfiyat.Text & "' where Id='" & key & "' "
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        MsgBox("Kitap bilgisi başarıyla Güncellendi")
        bgl.Close()
        verileriGoster()
        Temizle()
    End Sub

    Private Sub cmbfitre_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbfitre.SelectionChangeCommitted
        bul()

    End Sub

    Private Sub btnbul_Click(sender As Object, e As EventArgs) Handles btnbul.Click
        verileriGoster()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim obj = New Kullanici
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