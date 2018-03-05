Public Class PenjelasanChar

    Private Sub PenjelasanChar_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        dasar.Enabled = True
        dasar.Show()
        dasar.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim orata As New Process()
        orata.StartInfo.FileName = "C:\C++ E-Learning\res\dasar\char.exe"
        orata.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        orata.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class