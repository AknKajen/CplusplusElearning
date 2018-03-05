Public Class Pengaturan
    Public Bahasa As String
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Bahasa Indonesia" Then
            Bahasa = "Indonesia"
            mainmenu.Bahasa = "Bahasa Indonesia"
        ElseIf ComboBox1.Text = "English Languages" Then
            Bahasa = "English"
            mainmenu.Bahasa = "English"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Bahasa = "English" Then
            mainmenu.Bahasa = "English"
            mainmenu.Button1.Text = "Basic Lessons"
            mainmenu.Button2.Text = "IF Lessons"
            mainmenu.Button3.Text = "Looping Lessons"
            mainmenu.Button4.Text = "Advanced Lessons"
        ElseIf Bahasa = "Indonesia" Then
            mainmenu.Bahasa = "Indonesia"
            mainmenu.Button1.Text = "Materi Dasar"
            mainmenu.Button2.Text = "Materi Percabangan"
            mainmenu.Button3.Text = "Materi Perulangan"
            mainmenu.Button4.Text = "Materi Lanjut"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class