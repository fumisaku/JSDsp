Public Class 確認画面


    Private Sub Window_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs)

        Me.Hide()
        e.Cancel = True
        Return

    End Sub

End Class
