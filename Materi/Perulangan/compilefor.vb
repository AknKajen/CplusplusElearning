Public Class compilefor

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Dim orata As New Process()
            orata.StartInfo.FileName = "C:\C++ E-Learning\res\perulangan\forincrement.exe"
            orata.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            orata.Start()
            Me.Hide()
            perulangan.Enabled = True
        ElseIf RadioButton2.Checked = True Then
            Dim orata As New Process()
            orata.StartInfo.FileName = "C:\C++ E-Learning\res\perulangan\fordecrement.exe"
            orata.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            orata.Start()
            Me.Hide()
            perulangan.Enabled = True
        End If
    End Sub

    Private Sub compilefor_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        perulangan.Enabled = True
        perulangan.Focus()
    End Sub
End Class