Public Class DefinisinDeklarasi

    Private Sub DefinisinDeklarasi_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'If dasar.Enabled = False Then
        dasar.Enabled = True
        dasar.Focus()
        'End If
    End Sub

    Private Sub DefinisinDeklarasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Bahasa As String
        Bahasa = mainmenu.Bahasa
        If Bahasa = "English" Then
            Button2.Text = "Compile Explanation"
            Button1.Text = "Back to Menu"
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        dasar.Show()
        dasar.Enabled = True
        dasar.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PengertianCompiler.Show()
        PengertianCompiler.Focus()
        Me.Enabled = False
    End Sub
End Class