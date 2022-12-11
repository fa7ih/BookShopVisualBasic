Imports System.Data.SqlClient
Public Class Login
    Dim bgl As New SqlConnection("Data Source=DESKTOP-BSG5U1A;Initial Catalog=KitapAlisveris;Integrated Security=True")
    Dim kmt As SqlCommand
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()

    End Sub

    Private Sub btngiris_Click(sender As Object, e As EventArgs) Handles btngiris.Click
        If txtkullaniciadi.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Lütfen Kullanici Adi Ve Şifrenizi Giriniz!")
        Else
            bgl.Open()
            Dim sorgu = "select * from Kullanici where ad='" & txtkullaniciadi.Text & "' and sifre='" & txtpassword.Text & "'"
            kmt = New SqlCommand(sorgu, bgl)
            Dim da As SqlDataAdapter = New SqlDataAdapter(kmt)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Şifre veya Kullanıcıadı hatalı!!!")
            Else
                Dim fatura = New Faturalar
                fatura.KullaniciAdi = txtkullaniciadi.Text
                fatura.Show()
                Me.Hide()

            End If
            bgl.Close()

        End If
    End Sub

    Private Sub lbladmin_Click(sender As Object, e As EventArgs) Handles lbladmin.Click
        Dim fatura = New AdminLogin
        fatura.Show()
        Me.Hide()
    End Sub
End Class