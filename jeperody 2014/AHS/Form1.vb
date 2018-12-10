Public Class AHS

    Private Sub btnPlay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Me.Hide()
        AHSstart.Show()
    End Sub

    Private Sub btnQuit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub AHS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.American_Horror_Story, AudioPlayMode.BackgroundLoop)

    End Sub
End Class
