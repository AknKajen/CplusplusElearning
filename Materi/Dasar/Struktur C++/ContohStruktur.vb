Public Class contohstruktur

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim simbah As New Process()
        simbah.StartInfo.FileName = "C:\C++ E-Learning\res\dasar\HelloWorld.exe"
        simbah.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        simbah.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        dasar.Show()
        dasar.Focus()
    End Sub

    Private Sub contohstruktur_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        dasar.Enabled = True
        dasar.Focus()
    End Sub
End Class