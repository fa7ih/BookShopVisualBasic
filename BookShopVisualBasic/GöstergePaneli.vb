Imports System.Data.SqlClient
Public Class GöstergePaneli
    Dim bgl As New SqlConnection("Data Source=DESKTOP-BSG5U1A;Initial Catalog=KitapAlisveris;Integrated Security=True")

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub
    Private Sub CountKitap()
        Dim BookNum As Integer
        bgl.Open()
        Dim sql = "select count(*) from kitaplar"
        Dim kmt As SqlCommand
        kmt = New SqlCommand(sql, bgl)
        BookNum = kmt.ExecuteScalar
        lblkitap.Text = BookNum
        bgl.Close()
    End Sub
    Private Sub CountKullanici()
        Dim KullaniciNum As Integer
        bgl.Open()
        Dim sql = "select count(*) from Kullanici"
        Dim kmt As SqlCommand
        kmt = New SqlCommand(sql, bgl)
        KullaniciNum = kmt.ExecuteScalar
        lblkullanici.Text = KullaniciNum
        bgl.Close()
    End Sub
    Private Sub CountFatura()
        Dim FaturaNum As Integer
        bgl.Open()
        Dim sql = "select sum(tutar) from faturalar"
        Dim kmt As SqlCommand
        kmt = New SqlCommand(sql, bgl)
        FaturaNum = kmt.ExecuteScalar
        lblkar.Text = Convert.ToInt32(FaturaNum) + " TL"
        bgl.Close()
    End Sub
    Private Sub GöstergePaneli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountKitap()
        CountKullanici()
        ' CountFatura()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim obj = New Kitaplar
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim obj = New Kullanici
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()

    End Sub
End Class