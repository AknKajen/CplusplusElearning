Public Class Splash
    Public Bahasa As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            'Me.Dispose()
            mainmenu.Show()
        End If

    End Sub

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pengaturan.ComboBox1.Text = "Bahasa Indonesia"
        mainmenu.Bahasa = "Indonesia"
    End Sub
End Class