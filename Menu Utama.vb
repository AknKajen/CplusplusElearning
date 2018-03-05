Public Class mainmenu
    Public Bahasa As String

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim response As MsgBoxResult
        response = MsgBox("Anda yakin Ingin keluar??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
            Splash.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
        Form2.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dasar.Show()
        Me.Hide()
        dasar.Focus()
    End Sub

    Private Sub mainmenu_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Splash.Dispose()
    End Sub

    Private Sub PercabanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PercabanganToolStripMenuItem.Click
        percabangan.Show()
        percabangan.Focus()
        Me.Hide()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
    End Sub

    Private Sub OratakashiNhamakoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OratakashiNhamakoToolStripMenuItem.Click
        Profil.Show()
        Profil.Focus()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'LoginToolStripMenuItem.Text = "Login"
        'LogoutToolStripMenuItem.Visible = False
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengaturanToolStripMenuItem.Click
        Pengaturan.Show()
        Pengaturan.Focus()
        If Bahasa = "Bahasa Indonesia" Then
            Pengaturan.ComboBox1.Text = "Bahasa Indonesia"
        ElseIf Bahasa = "English" Then
            Pengaturan.ComboBox1.Text = "English Languages"
        End If
    End Sub

    Private Sub mainmenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Bahasa = "English" Then
            Button1.Text = "Basic Lessons"
            Button2.Text = "IF Lessons"
            Button3.Text = "Looping Lessons"
            Button4.Text = "Advanced Lessons"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        percabangan.Show()
        percabangan.Focus()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        perulangan.Show()
        perulangan.Focus()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lanjut.Show()
        lanjut.Focus()
        Me.Hide()
    End Sub

    Private Sub DasarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DasarToolStripMenuItem.Click
        dasar.Show()
        Me.Hide()
        dasar.Focus()
    End Sub

    Private Sub PerulanganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerulanganToolStripMenuItem.Click
        perulangan.Show()
        perulangan.Focus()
        Me.Hide()
    End Sub

    Private Sub MateriLanjutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MateriLanjutToolStripMenuItem.Click
        lanjut.Show()
        lanjut.Focus()
        Me.Hide()
    End Sub
End Class
