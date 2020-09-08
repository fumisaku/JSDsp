Public Class 表示画面


    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        初期化()

    End Sub

    Private Sub 初期化()

        'プライマリーWindowの解像度
        'Dim PriWidth = SystemParameters.PrimaryScreenWidth / 96 * 120

        'Me.Left = PriWidth + 10
        'Me.Top = 0

        '最大化表示
        Me.WindowState = WindowState.Maximized


    End Sub

    Private Sub Window_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs)

        Me.Hide()
        e.Cancel = True
        Return

    End Sub

    Private Sub KeyDownEvent_(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.Key = Key.Escape Then

            Me.Hide()

        End If



    End Sub


End Class
