Public Class WB_T02

    Private 設定 As 設定_C

    Sub New(設定_ As 設定_C)
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        設定 = 設定_

    End Sub

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        初期設定()

    End Sub

    Private Sub 初期設定()

        'イメージブラシの作成
        Dim imageBrush As New ImageBrush()
        imageBrush.ImageSource = New System.Windows.Media.Imaging.BitmapImage(New Uri(設定.IMGPATH & "\" & "tounament_back.png", UriKind.Relative))
        imageBrush.Opacity = 1.0   '0.3

        'ブラシを背景に設定する
        Me.Background = imageBrush

        'プライマリーWindowの解像度
        Dim PriWidth = SystemParameters.PrimaryScreenWidth / 96 * 120



        Me.Left = PriWidth + 10
        Me.Top = 0

        'Dim workingArea As secondaryScreen

        'ロゴのイメージ
        Dim ロゴ中央 As Image
        ロゴ中央 = New Image
        ロゴ中央 = FindName("ロゴ中央")

        ロゴ中央.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "wdsf world open series breaking BLK.png", UriKind.Absolute))

        Dim ロゴ右 As Image
        ロゴ右 = New Image
        ロゴ右 = FindName("ロゴ右")
        ロゴ右.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "JDSF.png", UriKind.Absolute))

        Dim ロゴ左 As Image
        ロゴ左 = New Image
        ロゴ左 = FindName("ロゴ左")
        ロゴ左.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "JDSF_BRLogo.png", UriKind.Absolute))



        Line色変更()

        初期化()


    End Sub
    Private Sub Line色変更()


        For c = 1 To 4
            CType(FindName("LN_2R_" & c & "V"), Line).Stroke = Brushes.White
            CType(FindName("LN_2R_" & c & "H"), Line).Stroke = Brushes.White

            CType(FindName("LN_SF_" & c & "V"), Line).Stroke = Brushes.White
        Next c

        CType(FindName("LN_FF_1H"), Line).Stroke = Brushes.White
        CType(FindName("LN_FF_1V"), Line).Stroke = Brushes.White


    End Sub

    Public Sub 初期化()
        '全 Oppacity =0

        '１Rのテキストボックス


        '2Rのテキストボックス
        For s = 1 To 8
            Dim ss As String = Format(s, "00")
            CType(FindName("TB_2R_" & ss), TextBox).Opacity = 0
            CType(FindName("TB_2R_" & ss), TextBox).Text = ""
            CType(FindName("TB_2R_" & ss), TextBox).Background = Brushes.White
            CType(FindName("TB_2R_" & ss), TextBox).Foreground = Brushes.Black

        Next s

        'SFのテキストボックス
        For s = 1 To 4
            Dim ss As String = Format(s, "00")
            CType(FindName("TB_SF_" & ss), TextBox).Opacity = 0
            CType(FindName("TB_SF_" & ss), TextBox).Text = ""
            CType(FindName("TB_SF_" & ss), TextBox).Background = Brushes.White
            CType(FindName("TB_SF_" & ss), TextBox).Foreground = Brushes.Black

        Next s

        'FFのテキストボックス
        For s = 1 To 2
            Dim ss As String = Format(s, "00")
            CType(FindName("TB_FF_" & ss), TextBox).Opacity = 0
            CType(FindName("TB_FF_" & ss), TextBox).Text = ""
            CType(FindName("TB_FF_" & ss), TextBox).Background = Brushes.White
            CType(FindName("TB_FF_" & ss), TextBox).Foreground = Brushes.Black

        Next s

        '優勝者・3位のテキストボックス
        CType(FindName("TB_1ST"), TextBox).Opacity = 0
        CType(FindName("TB_3RD"), TextBox).Opacity = 0
        CType(FindName("TB_1ST"), TextBox).Text = ""
        CType(FindName("TB_3RD"), TextBox).Text = ""


        'LINE


        For c = 1 To 4
            CType(FindName("LN_2R_" & c & "V"), Line).Opacity = 0
            CType(FindName("LN_2R_" & c & "H"), Line).Opacity = 0
            CType(FindName("LN_SF_" & c & "V"), Line).Opacity = 0


        Next c

        CType(FindName("LN_FF_1H"), Line).Opacity = 0
        CType(FindName("LN_FF_1V"), Line).Opacity = 0


        'ラベル
        CType(FindName("LB_Gold"), Label).Opacity = 0
        CType(FindName("LB_Bronze"), Label).Opacity = 0
        CType(FindName("LB_Silver_1"), Label).Opacity = 0
        CType(FindName("LB_Silver_1"), Label).Content = ""
        CType(FindName("LB_Silver_2"), Label).Opacity = 0
        CType(FindName("LB_Silver_2"), Label).Content = ""



    End Sub

    Public Sub データセット(SC_BG_Startlist As SC_BG_Startlist_C, SC_BR_Result As SC_BR_Result_C, カテゴリ番号 As String)




        CType(FindName("TB_Side"), TextBox).Text = "◀ " & SC_BG_Startlist.SC_BG_Startlist_選手(1).カテゴリ名 & " ▶"


        '選手名セット　１Ｒ

        For i = 1 To UBound(SC_BG_Startlist.SC_BG_Startlist_選手) - 1

            If SC_BG_Startlist.SC_BG_Startlist_選手(i).背番号 IsNot Nothing Then
                Dim TB番号 As String = i.ToString("00")

                CType(FindName("TB_2R_" & TB番号), TextBox).Text = SC_BG_Startlist.SC_BG_Startlist_選手(i).リーダー名
            End If
        Next i


        '1Rの結果 
        For k = 1 To 4
            For i = 1 To UBound(SC_BR_Result.SC_BR_Result_結果)

                If Strings.Right(SC_BR_Result.SC_BR_Result_結果(i).区分番号, 1) = CStr(k) And
                   SC_BR_Result.SC_BR_Result_結果(i).ラウンド番号 = "010" And
                   SC_BR_Result.SC_BR_Result_結果(i).カテゴリ番号 = カテゴリ番号 Then

                    Dim 勝TB番号 As String = ""

                    For pk = 1 To 2
                        Dim TB番号 As String = (((k - 1) * 2) + pk).ToString("00")
                        If CType(FindName("TB_2R_" & TB番号), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名 Then

                            '勝った方
                            CType(FindName("TB_2R_" & TB番号), TextBox).Foreground = Brushes.Black
                            CType(FindName("TB_2R_" & TB番号), TextBox).Background = Brushes.White

                            勝TB番号 = TB番号

                        Else
                            '負けた方
                            CType(FindName("TB_2R_" & TB番号), TextBox).Foreground = Brushes.DimGray
                            CType(FindName("TB_2R_" & TB番号), TextBox).Background = Brushes.Gray


                        End If

                    Next pk


                    '次ラウンドのTextboxにも記入
                    Dim 次区分番号 As String = ((勝TB番号 + 1) \ 2).ToString("00")

                    CType(FindName("TB_SF_" & 次区分番号), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名

                    i = UBound(SC_BR_Result.SC_BR_Result_結果)
                End If
            Next i
        Next k

        'SFの結果 
        For k = 1 To 2
            For i = 1 To UBound(SC_BR_Result.SC_BR_Result_結果)

                If Strings.Right(SC_BR_Result.SC_BR_Result_結果(i).区分番号, 1) = CStr(k) And
                   SC_BR_Result.SC_BR_Result_結果(i).ラウンド番号 = "200" And
                   SC_BR_Result.SC_BR_Result_結果(i).カテゴリ番号 = カテゴリ番号 Then

                    Dim 勝TB番号 As String = ""

                    For pk = 1 To 2
                        Dim TB番号 As String = (((k - 1) * 2) + pk).ToString("00")
                        If CType(FindName("TB_SF_" & TB番号), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名 Then

                            '勝った方
                            CType(FindName("TB_SF_" & TB番号), TextBox).Foreground = Brushes.Black
                            CType(FindName("TB_SF_" & TB番号), TextBox).Background = Brushes.White

                            勝TB番号 = TB番号

                        Else
                            '負けた方
                            CType(FindName("TB_SF_" & TB番号), TextBox).Foreground = Brushes.DimGray
                            CType(FindName("TB_SF_" & TB番号), TextBox).Background = Brushes.Gray


                        End If

                    Next pk


                    '次ラウンドのTextboxにも記入
                    Dim 次区分番号 As String = ((勝TB番号 + 1) \ 2).ToString("00")

                    CType(FindName("TB_FF_" & 次区分番号), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名

                    i = UBound(SC_BR_Result.SC_BR_Result_結果)
                End If
            Next i
        Next k


        '3位決定戦の結果 
        For k = 1 To 1
            For i = 1 To UBound(SC_BR_Result.SC_BR_Result_結果)

                If Strings.Right(SC_BR_Result.SC_BR_Result_結果(i).区分番号, 1) = CStr(k) And
                   SC_BR_Result.SC_BR_Result_結果(i).ラウンド番号 = "300" And
                   SC_BR_Result.SC_BR_Result_結果(i).カテゴリ番号 = カテゴリ番号 Then

                    Dim 勝TB番号 As String = ""

                    For pk = 1 To 2
                        Dim TB番号 As String = (((k - 1) * 2) + pk).ToString("00")
                        If CType(FindName("TB_SF_" & TB番号), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名 Then

                            '勝った方
                            'CType(FindName("TB_3RD"), TextBox).Foreground = Brushes.Black
                            'CType(FindName("TB_3RD"), TextBox).Background = Brushes.White

                            勝TB番号 = TB番号

                        Else
                            '負けた方
                            'CType(FindName("TB_SF_" & TB番号), TextBox).Foreground = Brushes.DimGray
                            'CType(FindName("TB_SF_" & TB番号), TextBox).Background = Brushes.Gray


                        End If

                    Next pk


                    '次ラウンドのTextboxにも記入
                    'Dim 次区分番号 As String = ((勝TB番号 + 1) \ 2).ToString("00")

                    CType(FindName("TB_3RD"), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名

                    i = UBound(SC_BR_Result.SC_BR_Result_結果)
                End If
            Next i
        Next k

        '決勝の結果 
        For k = 1 To 1
            For i = 1 To UBound(SC_BR_Result.SC_BR_Result_結果)

                If Strings.Right(SC_BR_Result.SC_BR_Result_結果(i).区分番号, 1) = CStr(k) And
                   SC_BR_Result.SC_BR_Result_結果(i).ラウンド番号 = "400" And
                   SC_BR_Result.SC_BR_Result_結果(i).カテゴリ番号 = カテゴリ番号 Then

                    Dim 勝TB番号 As String = ""

                    For pk = 1 To 2
                        Dim TB番号 As String = (((k - 1) * 2) + pk).ToString("00")
                        If CType(FindName("TB_FF_" & TB番号), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名 Then

                            '勝った方
                            CType(FindName("TB_FF_" & TB番号), TextBox).Foreground = Brushes.Black
                            CType(FindName("TB_FF_" & TB番号), TextBox).Background = Brushes.White

                            勝TB番号 = TB番号

                        Else
                            '負けた方  銀メダル
                            CType(FindName("TB_FF_" & TB番号), TextBox).Foreground = Brushes.Black
                            CType(FindName("TB_FF_" & TB番号), TextBox).Background = Brushes.Silver
                            CType(FindName("LB_Silver_" & CInt(TB番号）), Label).Content = "Silver"

                        End If

                    Next pk


                    '次ラウンドのTextboxにも記入
                    'Dim 次区分番号 As String = ((勝TB番号 + 1) \ 2).ToString("00")

                    CType(FindName("TB_1ST"), TextBox).Text = SC_BR_Result.SC_BR_Result_結果(i).勝者リーダー名

                    i = UBound(SC_BR_Result.SC_BR_Result_結果)
                End If
            Next i
        Next k

    End Sub


    Public Sub No1()
        '全フェードイン
        sb = New System.Windows.Media.Animation.Storyboard

        '１Rのテキストボックス

        For s = 1 To 8
            Dim ss As String = Format(s, "00")
            フェードイン(CType(FindName("TB_2R_" & ss), TextBox), sb, 0)
        Next s

        'SFのテキストボックス
        For s = 1 To 4
            Dim ss As String = Format(s, "00")
            フェードイン(CType(FindName("TB_SF_" & ss), TextBox), sb, 0)
        Next s

        'FFのテキストボックス
        For s = 1 To 2
            Dim ss As String = Format(s, "00")
            フェードイン(CType(FindName("TB_FF_" & ss), TextBox), sb, 0)
        Next s

        '優勝者・3位のテキストボックス
        フェードイン(CType(FindName("TB_1ST"), TextBox), sb, 0)
        フェードイン(CType(FindName("TB_3RD"), TextBox), sb, 0)

        フェードイン(CType(FindName("LB_Gold"), Label), sb, 0)
        フェードイン(CType(FindName("LB_Bronze"), Label), sb, 0)
        フェードイン(CType(FindName("LB_Silver_1"), Label), sb, 0)
        フェードイン(CType(FindName("LB_Silver_2"), Label), sb, 0)


        'LINE


        For c = 1 To 4
            フェードイン(CType(FindName("LN_2R_" & c & "V"), Line), sb, 0)
            フェードイン(CType(FindName("LN_2R_" & c & "H"), Line), sb, 0)
            フェードイン(CType(FindName("LN_SF_" & c & "V"), Line), sb, 0)
        Next c

        フェードイン(CType(FindName("LN_FF_1H"), Line), sb, 0)
        フェードイン(CType(FindName("LN_FF_1V"), Line), sb, 0)

    End Sub

    Public Sub 全フェードアウト()
        '全フェードアウト
        sb = New System.Windows.Media.Animation.Storyboard

        '１Rのテキストボックス

        For s = 1 To 8
            Dim ss As String = Format(s, "00")
            フェードアウト(CType(FindName("TB_2R_" & ss), TextBox), sb, 0)
        Next s

        'SFのテキストボックス
        For s = 1 To 4
            Dim ss As String = Format(s, "00")
            フェードアウト(CType(FindName("TB_SF_" & ss), TextBox), sb, 0)
        Next s

        'FFのテキストボックス
        For s = 1 To 2
            Dim ss As String = Format(s, "00")
            フェードアウト(CType(FindName("TB_FF_" & ss), TextBox), sb, 0)
        Next s

        '優勝者・3位のテキストボックス
        フェードアウト(CType(FindName("TB_1ST"), TextBox), sb, 0)
        フェードアウト(CType(FindName("TB_3RD"), TextBox), sb, 0)

        フェードアウト(CType(FindName("LB_Gold"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_Bronze"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_Silver_1"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_Silver_2"), Label), sb, 0)


        'LINE


        For c = 1 To 4
            フェードアウト(CType(FindName("LN_2R_" & c & "V"), Line), sb, 0)
            フェードアウト(CType(FindName("LN_2R_" & c & "H"), Line), sb, 0)
            フェードアウト(CType(FindName("LN_SF_" & c & "V"), Line), sb, 0)
        Next c

        フェードアウト(CType(FindName("LN_FF_1H"), Line), sb, 0)
        フェードアウト(CType(FindName("LN_FF_1V"), Line), sb, 0)

    End Sub


    Private sb As System.Windows.Media.Animation.Storyboard


    Private Sub フェードイン(obj As Object, sb As System.Windows.Media.Animation.Storyboard, Begintime As Integer)


        'Dim sb As System.Windows.Media.Animation.Storyboard
        'sb = New System.Windows.Media.Animation.Storyboard

        Dim FadeInAnimation As New System.Windows.Media.Animation.DoubleAnimation
        FadeInAnimation = New System.Windows.Media.Animation.DoubleAnimation



        If obj IsNot Nothing Then

            If obj.opacity = 0 Then  '元々表示されていたらフェードインしない。

                sb.SetTarget(FadeInAnimation, obj)
                sb.SetTargetProperty(FadeInAnimation, New PropertyPath("(Canvas.Left)"))

                FadeInAnimation.Duration = New Duration(New TimeSpan(0, 0, 0, 2, 250))
                FadeInAnimation.BeginTime = TimeSpan.FromMilliseconds(Begintime)

                FadeInAnimation.From = 0.0
                FadeInAnimation.To = 1.0
                FadeInAnimation.DecelerationRatio = 0.8
                System.Windows.Media.Animation.Storyboard.SetTargetProperty(FadeInAnimation, New PropertyPath("Opacity"))
                sb.Children.Add(FadeInAnimation)

                obj.visibility = Visibility.Visible
            End If


        End If


        'StoryBoard 終了時の処理を定義
        'AddHandler sb.Completed, Sub() Me.フェードアウト()



        'sb.Begin()

    End Sub


    Private Sub フェードアウト(obj As Object, sb As System.Windows.Media.Animation.Storyboard, Begintime As Integer)


        'Dim sb As System.Windows.Media.Animation.Storyboard
        'sb = New System.Windows.Media.Animation.Storyboard

        Dim FadeInAnimation As New System.Windows.Media.Animation.DoubleAnimation
        FadeInAnimation = New System.Windows.Media.Animation.DoubleAnimation



        If obj IsNot Nothing Then

            If obj.opacity <> 0 Then '元々消えていたらフェードアウトしない

                sb.SetTarget(FadeInAnimation, obj)
                sb.SetTargetProperty(FadeInAnimation, New PropertyPath("(Canvas.Left)"))

                FadeInAnimation.Duration = New Duration(New TimeSpan(0, 0, 0, 2, 100))
                FadeInAnimation.BeginTime = TimeSpan.FromMilliseconds(Begintime)

                FadeInAnimation.From = 1.0
                FadeInAnimation.To = 0.0
                FadeInAnimation.DecelerationRatio = 0.8
                System.Windows.Media.Animation.Storyboard.SetTargetProperty(FadeInAnimation, New PropertyPath("Opacity"))
                sb.Children.Add(FadeInAnimation)

                obj.visibility = Visibility.Visible
            End If

        End If


        'StoryBoard 終了時の処理を定義
        'AddHandler sb.Completed, Sub() Me.フェードアウト()



        'sb.Begin()

    End Sub

    Public Sub SBStart()

        sb.Begin()


    End Sub

End Class
