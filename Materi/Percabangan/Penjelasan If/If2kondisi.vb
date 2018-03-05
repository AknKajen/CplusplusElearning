Public Class If2kondisi

    Private Sub If2kondisi_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        percabangan.Show()
        percabangan.Enabled = True
        percabangan.Focus()
    End Sub

    Private Sub If2kondisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim orata As New Process()
        orata.StartInfo.FileName = "C:\C++ E-Learning\res\percabangan\if2kondisi.exe"
        orata.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        orata.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class