Public Class FrmImportant
    Private Sub FrmImportant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mediaplayer As New AxWMPLib.AxWindowsMediaPlayer()
        mediaplayer.Location = New Point(0, 0)
        mediaplayer.Size = Panel1.Size
        Panel1.Controls.Add(mediaplayer)
        Dim videopath As String = "E:\Kurt\Josh Hutcherson __ Whistle.mp4"
        If IO.File.Exists(videopath) Then
            mediaplayer.URL = videopath
            mediaplayer.Ctlcontrols.play()
            mediaplayer.uiMode = "none"
        Else
            MsgBox("no")
        End If

    End Sub

End Class