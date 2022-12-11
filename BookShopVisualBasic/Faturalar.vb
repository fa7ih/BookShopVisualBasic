Imports System.Data.SqlClient
Public Class Faturalar
    Dim bgl As New SqlConnection("Data Source=DESKTOP-BSG5U1A;Initial Catalog=KitapAlisveris;Integrated Security=True")
    Public Property KullaniciAdi As String
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
    Private Sub güncelle()
        Dim YeniMiktar = Stock - Convert.ToInt32(txtmiktar.Text)
        bgl.Open()
        Dim sorgu As String
        sorgu = "update kitaplar set miktar='" & YeniMiktar & "' where Id='" & key & "' "
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        bgl.Close()
        verileriGoster()
        temizle()
    End Sub
    Private Sub temizle()
        txtmiktar.Text = ""
        txtyazar.Text = ""
        key = 0
        txtfiyat.Text = ""
        txtkitap.Text = ""
    End Sub

    Private Sub Faturalar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verileriGoster()
        Unamelbl.Text = KullaniciAdi
        temizle()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub
    Dim key = 0, Stock = 0, i = 0, GrdToplam = 0

    Private Sub FaturaEkle()
        bgl.Open()
        Dim sorgu As String
        sorgu = "insert into faturalar values ('" & txtkitap.Text & "','" & txtyazar.Text & "','" & GrdToplam & "') "
        Dim komut As SqlCommand
        komut = New SqlCommand(sorgu, bgl)
        komut.ExecuteNonQuery()
        'MsgBox("Fatura bilgisi başarıyla kayıt edildi")
        bgl.Close()
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Kitap Alış-Veriş", New Font("Century Gothic", 25), Brushes.MidnightBlue, 350, 40)
        e.Graphics.DrawString("====FATURAN====", New Font("Century Gothic", 16), Brushes.MidnightBlue, 300, 100)
        Dim bm As New Bitmap(Me.DataGridView2.Width, Me.DataGridView2.Height)
        DataGridView2.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView2.Width, Me.DataGridView2.Height))
        e.Graphics.DrawImage(bm, 60, 120)
        e.Graphics.DrawString("Toplam Tutar" + GrdToplam.ToString, New Font("Century Gothic", 15), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("==========Mağzamızdan Satın Aldığınız İçin Teşekkürler==========" + GrdToplam.ToString, New Font("Century Gothic", 15), Brushes.Crimson, 150, 580)
        e.Graphics.DrawString("TOPLAM TUTAR:" + GrdToplam.ToString, New Font("Century Gothic", 15), Brushes.Crimson, 150, 660)
    End Sub

    Private Sub btnyazdır_Click(sender As Object, e As EventArgs) Handles btnyazdır.Click
        PrintPreviewDialog1.Show()
        FaturaEkle()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub btntemizle_Click(sender As Object, e As EventArgs) Handles btntemizle.Click
        temizle()
    End Sub

    Private Sub btnfaturaekle_Click(sender As Object, e As EventArgs) Handles btnfaturaekle.Click
        If txtfiyat.Text = "" Or txtmiktar.Text = "" Then
            MsgBox("Lütfen Miktarı Girin")
        ElseIf txtkitap.Text = "" Then
            MsgBox("Lütfen Kitap Seçin")
        ElseIf Convert.ToInt32(txtmiktar.Text) > Stock Then
            MsgBox("Yeterli Stok Yok!")
        Else
            Dim rnum As Integer = DataGridView2.Rows.Add()
            i = i + 1
            Dim toplam = Convert.ToInt32(txtmiktar.Text) * Convert.ToInt32(txtfiyat.Text)
            DataGridView2.Rows.Item(rnum).Cells("id").Value = i
            DataGridView2.Rows.Item(rnum).Cells("kitapadi").Value = txtkitap.Text
            DataGridView2.Rows.Item(rnum).Cells("fiyati").Value = txtfiyat.Text
            DataGridView2.Rows.Item(rnum).Cells("miktari").Value = txtmiktar.Text
            DataGridView2.Rows.Item(rnum).Cells("toplami").Value = toplam
            GrdToplam = GrdToplam + toplam
            Dim Tot As String
            Tot = Convert.ToString(GrdToplam) + " TL"
            toplamlb.Text = Tot
            güncelle()
            temizle()
        End If
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
        txtkitap.Text = row.Cells(1).Value.ToString
        txtfiyat.Text = row.Cells(5).Value.ToString
        Stock = Convert.ToInt32(row.Cells(4).Value.ToString)
        If txtkitap.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class