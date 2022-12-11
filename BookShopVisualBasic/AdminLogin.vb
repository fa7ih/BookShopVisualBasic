Public Class AdminLogin
    Private Sub lbladmin_Click(sender As Object, e As EventArgs) Handles lbladmin.Click
        Dim fatura = New Login
        fatura.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub btngiris_Click(sender As Object, e As EventArgs) Handles btngiris.Click
        If txtpassword.Text = "admin" Then
            Dim fatura = New Kitaplar
            fatura.Show()
            Me.Hide()
        Else
            MsgBox("Hatalı Şifre Girdiniz!!!")
        End If
    End Sub
End Class