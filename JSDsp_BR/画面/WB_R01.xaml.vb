Public Class WB_R01


    Private 設定 As 設定_C

    Sub New(設定_ As 設定_C)
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        設定 = 設定_

    End Sub


    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        初期化()

    End Sub

    Private Sub 初期化()

        'イメージブラシの作成
        Dim imageBrush As New ImageBrush()
        imageBrush.ImageSource = New System.Windows.Media.Imaging.BitmapImage(New Uri(設定.IMGPATH & "\" & "BR_Battle_back.png", UriKind.Relative))
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

        Dim 選手名_赤 As Image
        選手名_赤 = New Image
        選手名_赤 = FindName("選手名_赤")
        選手名_赤.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "name_red.png", UriKind.Absolute))

        Dim 選手名_青 As Image
        選手名_青 = New Image
        選手名_青 = FindName("選手名_青")
        選手名_青.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "name_blue.png", UriKind.Absolute))



        '選手写真_赤
        CType(FindName("選手イメージ_赤"), Image).Opacity = 0


        '選手写真_青
        CType(FindName("選手イメージ_青"), Image).Opacity = 0

        '選手名_背景
        CType(FindName("選手名_赤"), Image).Opacity = 0
        CType(FindName("選手名_青"), Image).Opacity = 0


        '選手名_赤
        CType(FindName("LB_選手名_赤"), Label).Opacity = 0
        CType(FindName("LB_所属名_赤"), Label).Opacity = 0


        '選手名_青
        CType(FindName("LB_選手名_青"), Label).Opacity = 0
        CType(FindName("LB_所属名_青"), Label).Opacity = 0

        'Label
        CType(FindName("LB_R1"), Label).Opacity = 0
        CType(FindName("LB_R1"), Label).Foreground = Brushes.White
        CType(FindName("LB_R2"), Label).Opacity = 0
        CType(FindName("LB_R2"), Label).Foreground = Brushes.White
        CType(FindName("LB_R3"), Label).Opacity = 0
        CType(FindName("LB_R3"), Label).Foreground = Brushes.White
        CType(FindName("LB_Total"), Label).Opacity = 0
        CType(FindName("LB_Total"), Label).Foreground = Brushes.White

        CType(FindName("LB_VS"), Label).Opacity = 0
        CType(FindName("LB_VS"), Label).Foreground = Brushes.White

        For r = 1 To 3
            CType(FindName("LB_PCS_R" & r), Label).Opacity = 0
            CType(FindName("LB_PCS_R" & r), Label).Foreground = Brushes.White

            CType(FindName("LB_RED_R" & r), Label).Opacity = 0
            CType(FindName("LB_RED_R" & r), Label).Foreground = Brushes.White
        Next r


        'ラウンドポイント
        CType(FindName("TB_POINT_1_1"), TextBox).Opacity = 0
        CType(FindName("TB_POINT_1_2"), TextBox).Opacity = 0
        CType(FindName("TB_POINT_1_3"), TextBox).Opacity = 0
        CType(FindName("TB_POINT_1_Total"), TextBox).Opacity = 0

        CType(FindName("TB_POINT_2_1"), TextBox).Opacity = 0
        CType(FindName("TB_POINT_2_2"), TextBox).Opacity = 0
        CType(FindName("TB_POINT_2_3"), TextBox).Opacity = 0
        CType(FindName("TB_POINT_2_Total"), TextBox).Opacity = 0



        CType(FindName("LB_PCS_T00"), Label).Opacity = 0
        CType(FindName("LB_PCS_T00"), Label).Foreground = Brushes.White

        CType(FindName("LB_PCS_T01"), Label).Opacity = 0
        CType(FindName("LB_PCS_T01"), Label).Foreground = Brushes.White

        CType(FindName("LB_PCS_T02"), Label).Opacity = 0
        CType(FindName("LB_PCS_T02"), Label).Foreground = Brushes.White

        CType(FindName("LB_PCS_T03"), Label).Opacity = 0
        CType(FindName("LB_PCS_T03"), Label).Foreground = Brushes.White

        CType(FindName("LB_PCS_T04"), Label).Opacity = 0
        CType(FindName("LB_PCS_T04"), Label).Foreground = Brushes.White


        'PCS項目　４つ×3バトル
        CType(FindName("TB_PCS_11"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_12"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_13"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_14"), TextBox).Opacity = 0

        CType(FindName("TB_PCS_21"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_22"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_23"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_24"), TextBox).Opacity = 0

        CType(FindName("TB_PCS_31"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_32"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_33"), TextBox).Opacity = 0
        CType(FindName("TB_PCS_34"), TextBox).Opacity = 0


        '減点項目　５つ×2人分　×3バトル

        CType(FindName("TB_RED_1_11"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_12"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_13"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_14"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_15"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_11"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_12"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_13"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_14"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_15"), TextBox).Opacity = 0

        CType(FindName("TB_RED_1_21"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_22"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_23"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_24"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_25"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_21"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_22"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_23"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_24"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_25"), TextBox).Opacity = 0

        CType(FindName("TB_RED_1_31"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_32"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_33"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_34"), TextBox).Opacity = 0
        CType(FindName("TB_RED_1_35"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_31"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_32"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_33"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_34"), TextBox).Opacity = 0
        CType(FindName("TB_RED_2_35"), TextBox).Opacity = 0


        CType(FindName("IMG_WINNER"), Image).Opacity = 0
        CType(FindName("LB_WINNER"), Label).Opacity = 0
        CType(FindName("LB_WINNER"), Label).Foreground = Brushes.White
        CType(FindName("LB_勝者名"), Label).Opacity = 0



    End Sub
    Public Sub No00()

        sb = New System.Windows.Media.Animation.Storyboard

        フェードイン(CType(FindName("選手名_赤"), Image), sb, 0)
        フェードイン(CType(FindName("選手名_青"), Image), sb, 0)

        フェードイン(CType(FindName("LB_選手名_赤"), Label), sb, 500)
        フェードイン(CType(FindName("LB_選手名_青"), Label), sb, 500)
        フェードイン(CType(FindName("LB_所属名_赤"), Label), sb, 500)
        フェードイン(CType(FindName("LB_所属名_青"), Label), sb, 500)

        フェードイン(CType(FindName("選手イメージ_赤"), Image), sb, 1000)
        フェードイン(CType(FindName("選手イメージ_青"), Image), sb, 1000)


        フェードイン(CType(FindName("LB_PCS_T00"), Label), sb, 1500)
        フェードイン(CType(FindName("LB_PCS_T01"), Label), sb, 1500)
        フェードイン(CType(FindName("LB_PCS_T02"), Label), sb, 1500)
        フェードイン(CType(FindName("LB_PCS_T03"), Label), sb, 1500)
        フェードイン(CType(FindName("LB_PCS_T04"), Label), sb, 1500)

        フェードイン(CType(FindName("LB_VS"), Label), sb, 1750)



    End Sub

    Public Sub No01()

        sb = New System.Windows.Media.Animation.Storyboard

        For p = 1 To 4
            フェードイン(CType(FindName("TB_PCS_1" & p), TextBox), sb, 0)
        Next p

        For s = 1 To 2
            For d = 1 To 5
                フェードイン(CType(FindName("TB_RED_" & s & "_1" & d), TextBox), sb, 500)
            Next d
        Next s
        フェードイン(CType(FindName("LB_PCS_R1"), Label), sb, 0)
        フェードイン(CType(FindName("LB_RED_R1"), Label), sb, 0)


        '結果
        フェードイン(CType(FindName("TB_POINT_1_1"), TextBox), sb, 750)
        フェードイン(CType(FindName("TB_POINT_2_1"), TextBox), sb, 750)
        フェードイン(CType(FindName("LB_R1"), Label), sb, 750)



        'total結果
        フェードイン(CType(FindName("TB_POINT_1_Total"), TextBox), sb, 1000)
        フェードイン(CType(FindName("TB_POINT_2_Total"), TextBox), sb, 1000)
        フェードイン(CType(FindName("LB_Total"), Label), sb, 1000)



        'WINNER
        フェードイン(CType(FindName("LB_WINNER"), Label), sb, 1500)
        フェードイン(CType(FindName("IMG_WINNER"), Image), sb, 1500)
        フェードイン(CType(FindName("LB_勝者名"), Label), sb, 1750)

    End Sub

    Public Sub No02()

        sb = New System.Windows.Media.Animation.Storyboard

        For p = 1 To 4
            フェードイン(CType(FindName("TB_PCS_2" & p), TextBox), sb, 500)
        Next p


        For s = 1 To 2
            For d = 1 To 5
                フェードイン(CType(FindName("TB_RED_" & s & "_2" & d), TextBox), sb, 1000)
            Next d
        Next s
        フェードイン(CType(FindName("LB_PCS_R2"), Label), sb, 500)
        フェードイン(CType(FindName("LB_RED_R2"), Label), sb, 500)



        '結果
        フェードイン(CType(FindName("TB_POINT_1_2"), TextBox), sb, 1250)
        フェードイン(CType(FindName("TB_POINT_2_2"), TextBox), sb, 1250)
        フェードイン(CType(FindName("LB_R2"), Label), sb, 750)


        'total結果
        フェードイン(CType(FindName("TB_POINT_1_Total"), TextBox), sb, 1500)
        フェードイン(CType(FindName("TB_POINT_2_Total"), TextBox), sb, 1500)
        フェードイン(CType(FindName("LB_Total"), Label), sb, 1500)



        'WINNER
        フェードイン(CType(FindName("LB_WINNER"), Label), sb, 1750)
        フェードイン(CType(FindName("IMG_WINNER"), Image), sb, 1750)
        フェードイン(CType(FindName("LB_勝者名"), Label), sb, 2000)


    End Sub

    Public Sub No03()

        sb = New System.Windows.Media.Animation.Storyboard

        For p = 1 To 4
            フェードイン(CType(FindName("TB_PCS_3" & p), TextBox), sb, 0)
        Next p


        For s = 1 To 2
            For d = 1 To 5
                フェードイン(CType(FindName("TB_RED_" & s & "_3" & d), TextBox), sb, 500)
            Next d
        Next s
        フェードイン(CType(FindName("LB_PCS_R3"), Label), sb, 0)
        フェードイン(CType(FindName("LB_RED_R3"), Label), sb, 0)



        '結果
        フェードイン(CType(FindName("TB_POINT_1_3"), TextBox), sb, 750)
        フェードイン(CType(FindName("TB_POINT_2_3"), TextBox), sb, 750)
        フェードイン(CType(FindName("LB_R3"), Label), sb, 750)


        'total結果
        フェードイン(CType(FindName("TB_POINT_1_Total"), TextBox), sb, 1000)
        フェードイン(CType(FindName("TB_POINT_2_Total"), TextBox), sb, 1000)
        フェードイン(CType(FindName("LB_Total"), Label), sb, 1000)


        'WINNER
        フェードイン(CType(FindName("LB_WINNER"), Label), sb, 1250)
        フェードイン(CType(FindName("IMG_WINNER"), Image), sb, 1250)
        フェードイン(CType(FindName("LB_勝者名"), Label), sb, 1500)





    End Sub


    Public Sub WINNERフェードアウト()

        sb = New System.Windows.Media.Animation.Storyboard

        フェードアウト(CType(FindName("LB_WINNER"), Label), sb, 0)
        フェードアウト(CType(FindName("IMG_WINNER"), Image), sb, 0)
        フェードアウト(CType(FindName("LB_勝者名"), Label), sb, 0)

        フェードアウト(CType(FindName("TB_POINT_1_Total"), TextBox), sb, 0)
        フェードアウト(CType(FindName("TB_POINT_2_Total"), TextBox), sb, 0)
        フェードアウト(CType(FindName("LB_Total"), Label), sb, 0)

    End Sub


    Public Sub ラウンド４に向けてのフェードアウト()

        sb = New System.Windows.Media.Animation.Storyboard


        'トータルポイント
        For s = 1 To 2
            For r = 1 To 3
                フェードアウト(CType(FindName("TB_POINT_" & s & "_" & r), TextBox), sb, 0)
            Next r
            フェードアウト(CType(FindName("TB_POINT_" & s & "_Total"), TextBox), sb, 0)
        Next s

        For r = 1 To 3
            フェードアウト(CType(FindName("LB_R" & r), Label), sb, 0)
            フェードアウト(CType(FindName("LB_PCS_R" & r), Label), sb, 0)
            フェードアウト(CType(FindName("LB_RED_R" & r), Label), sb, 0)

        Next r
        フェードアウト(CType(FindName("LB_Total"), Label), sb, 0)

        フェードアウト(CType(FindName("LB_VS"), Label), sb, 0)




        'PCSラベル
        For p = 0 To 4
            フェードアウト(CType(FindName("LB_PCS_T0" & p), Label), sb, 0)
        Next p


        'PCS
        For r = 1 To 3
            For p = 1 To 4
                フェードアウト(CType(FindName("TB_PCS_" & r & p), TextBox), sb, 0)
            Next p
        Next r

        '減点
        For s = 1 To 2
            For r = 1 To 3
                For d = 1 To 5
                    フェードアウト(CType(FindName("TB_RED_" & s & "_" & r & d), TextBox), sb, 0)
                Next d
            Next r
        Next s

        'WINNER
        フェードアウト(CType(FindName("LB_WINNER"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_勝者名"), Label), sb, 0)
        フェードアウト(CType(FindName("IMG_WINNER"), Image), sb, 0)

    End Sub


    Public Sub 全フェードアウト()

        sb = New System.Windows.Media.Animation.Storyboard

        '写真
        フェードアウト(CType(FindName("選手イメージ_赤"), Image), sb, 250)
        フェードアウト(CType(FindName("選手イメージ_青"), Image), sb, 250)

        フェードアウト(CType(FindName("LB_選手名_赤"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_選手名_青"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_所属名_赤"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_所属名_青"), Label), sb, 0)

        フェードアウト(CType(FindName("選手名_赤"), Image), sb, 0)
        フェードアウト(CType(FindName("選手名_青"), Image), sb, 0)



        'トータルポイント
        For s = 1 To 2
            For r = 1 To 3
                フェードアウト(CType(FindName("TB_POINT_" & s & "_" & r), TextBox), sb, 0)
            Next r
            フェードアウト(CType(FindName("TB_POINT_" & s & "_Total"), TextBox), sb, 0)
        Next s

        For r = 1 To 3
            フェードアウト(CType(FindName("LB_R" & r), Label), sb, 0)
            フェードアウト(CType(FindName("LB_PCS_R" & r), Label), sb, 0)
            フェードアウト(CType(FindName("LB_RED_R" & r), Label), sb, 0)

        Next r
        フェードアウト(CType(FindName("LB_Total"), Label), sb, 0)

        フェードアウト(CType(FindName("LB_VS"), Label), sb, 0)




        'PCSラベル
        For p = 0 To 4
            フェードアウト(CType(FindName("LB_PCS_T0" & p), Label), sb, 0)
        Next p


        'PCS
        For r = 1 To 3
            For p = 1 To 4
                フェードアウト(CType(FindName("TB_PCS_" & r & p), TextBox), sb, 0)
            Next p
        Next r

        '減点
        For s = 1 To 2
            For r = 1 To 3
                For d = 1 To 5
                    フェードアウト(CType(FindName("TB_RED_" & s & "_" & r & d), TextBox), sb, 0)
                Next d
            Next r
        Next s

        'WINNER
        フェードアウト(CType(FindName("LB_WINNER"), Label), sb, 0)
        フェードアウト(CType(FindName("LB_勝者名"), Label), sb, 0)
        フェードアウト(CType(FindName("IMG_WINNER"), Image), sb, 0)

    End Sub


    Public Function データセット(バトル結果 As SC_B_Result_C)

        Dim 勝者番号 As Integer = 0

        '選手写真
        CType(FindName("選手イメージ_赤"), Image).Source = New BitmapImage(New Uri(設定.選手写真IMGPATH & "\" & バトル結果.SC_BR_B_Result_選手(1).背番号 & ".jpg", UriKind.Absolute))
        CType(FindName("選手イメージ_青"), Image).Source = New BitmapImage(New Uri(設定.選手写真IMGPATH & "\" & バトル結果.SC_BR_B_Result_選手(2).背番号 & ".jpg", UriKind.Absolute))


        '選手名・所属名

        CType(FindName("LB_選手名_赤”), Label).Content = バトル結果.SC_BR_B_Result_選手(1).リーダー名
        CType(FindName("LB_所属名_赤”), Label).Content = バトル結果.SC_BR_B_Result_選手(1).カップル所属

        CType(FindName("LB_選手名_青”), Label).Content = バトル結果.SC_BR_B_Result_選手(2).リーダー名
        CType(FindName("LB_所属名_青”), Label).Content = バトル結果.SC_BR_B_Result_選手(2).カップル所属



        'Total点数


        Dim 画面番号 As Integer = 1   '１～３ラウンドの間は、「1」、4ラウンドを超える場合は「２」
        If バトル結果.終了ラウンド数 >= 4 Then
            画面番号 = 2
        End If




        '赤の得点
        CType(FindName("TB_POINT_1_1"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(1 + (画面番号 - 1) * 3).TotalPoint, "00.00")
        CType(FindName("TB_POINT_1_2"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(2).TotalPoint, "00.00")
        CType(FindName("TB_POINT_1_3"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(3).TotalPoint, "00.00")
        If バトル結果.勝敗方式 = "P" Then
            CType(FindName("TB_POINT_1_Total"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(1).総合得点, "00.00")
        Else
            CType(FindName("TB_POINT_1_Total"), TextBox).Text = バトル結果.SC_BR_B_Result_選手(1).WIN数
        End If





        '青の得点
        CType(FindName("TB_POINT_2_1"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(1 + (画面番号 - 1) * 3).TotalPoint, "00.00")
        CType(FindName("TB_POINT_2_2"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(2).TotalPoint, "00.00")
        CType(FindName("TB_POINT_2_3"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(3).TotalPoint, "00.00")
        If バトル結果.勝敗方式 = "P" Then
            CType(FindName("TB_POINT_2_Total"), TextBox).Text = Format(バトル結果.SC_BR_B_Result_選手(2).総合得点, "00.00")
        Else
            CType(FindName("TB_POINT_2_Total"), TextBox).Text = バトル結果.SC_BR_B_Result_選手(2).WIN数
        End If




        '得点の色付け

        'ラウンド１、４
        If バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(1 + (画面番号 - 1) * 3).TotalPoint > バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(1 + (画面番号 - 1) * 3).TotalPoint Then
            '赤の勝
            TB_POINT_1_1.Background = Brushes.Red
            TB_POINT_1_1.Foreground = Brushes.White
            TB_POINT_2_1.Background = Brushes.White
            TB_POINT_2_1.Foreground = Brushes.Black
        ElseIf バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(1 + (画面番号 - 1) * 3).TotalPoint < バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(1 + (画面番号 - 1) * 3).TotalPoint Then
            '青の勝
            TB_POINT_1_1.Background = Brushes.White
            TB_POINT_1_1.Foreground = Brushes.Black
            TB_POINT_2_1.Background = Brushes.Blue
            TB_POINT_2_1.Foreground = Brushes.White
        Else
            TB_POINT_1_1.Background = Brushes.White
            TB_POINT_1_1.Foreground = Brushes.Black
            TB_POINT_2_1.Background = Brushes.White
            TB_POINT_2_1.Foreground = Brushes.Black
        End If

        'ラウンド2
        If バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(2).TotalPoint > バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(2).TotalPoint Then
            '赤の勝
            TB_POINT_1_2.Background = Brushes.Red
            TB_POINT_1_2.Foreground = Brushes.White
            TB_POINT_2_2.Background = Brushes.White
            TB_POINT_2_2.Foreground = Brushes.Black
        ElseIf バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(2).TotalPoint < バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(2).TotalPoint Then
            '青の勝
            TB_POINT_1_2.Background = Brushes.White
            TB_POINT_1_2.Foreground = Brushes.Black
            TB_POINT_2_2.Background = Brushes.Blue
            TB_POINT_2_2.Foreground = Brushes.White
        Else
            TB_POINT_1_2.Background = Brushes.White
            TB_POINT_1_2.Foreground = Brushes.Black
            TB_POINT_2_2.Background = Brushes.White
            TB_POINT_2_2.Foreground = Brushes.Black
        End If

        'ラウンド3
        If バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(3).TotalPoint > バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(3).TotalPoint Then
            '赤の勝
            TB_POINT_1_3.Background = Brushes.Red
            TB_POINT_1_3.Foreground = Brushes.White
            TB_POINT_2_3.Background = Brushes.White
            TB_POINT_2_3.Foreground = Brushes.Black
        ElseIf バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(3).TotalPoint < バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(3).TotalPoint Then
            '青の勝
            TB_POINT_1_3.Background = Brushes.White
            TB_POINT_1_3.Foreground = Brushes.Black
            TB_POINT_2_3.Background = Brushes.Blue
            TB_POINT_2_3.Foreground = Brushes.White
        Else
            TB_POINT_1_3.Background = Brushes.White
            TB_POINT_1_3.Foreground = Brushes.Black
            TB_POINT_2_3.Background = Brushes.White
            TB_POINT_2_3.Foreground = Brushes.Black
        End If

        '総合結果

        If バトル結果.勝敗方式 = "P" Then
            '得点方式の場合
            If バトル結果.終了ラウンド数 >= 2 Then
                If バトル結果.SC_BR_B_Result_選手(1).総合得点 > バトル結果.SC_BR_B_Result_選手(2).総合得点 Then
                    '赤の勝ち
                    TB_POINT_1_Total.Background = Brushes.Red
                    TB_POINT_1_Total.Foreground = Brushes.White
                    TB_POINT_2_Total.Background = Brushes.White
                    TB_POINT_2_Total.Foreground = Brushes.Black

                    LB_勝者名.Content = バトル結果.SC_BR_B_Result_選手(1).リーダー名
                    IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner_red.png", UriKind.Absolute))

                    勝者番号 = 1

                ElseIf バトル結果.SC_BR_B_Result_選手(1).総合得点 < バトル結果.SC_BR_B_Result_選手(2).総合得点 Then
                    '青の勝ち
                    TB_POINT_1_Total.Background = Brushes.White
                    TB_POINT_1_Total.Foreground = Brushes.Black
                    TB_POINT_2_Total.Background = Brushes.Blue
                    TB_POINT_2_Total.Foreground = Brushes.White

                    LB_勝者名.Content = バトル結果.SC_BR_B_Result_選手(2).リーダー名
                    IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner_blue.png", UriKind.Absolute))

                    勝者番号 = 2

                Else
                    TB_POINT_1_Total.Background = Brushes.White
                    TB_POINT_1_Total.Foreground = Brushes.Black
                    TB_POINT_2_Total.Background = Brushes.White
                    TB_POINT_2_Total.Foreground = Brushes.Black

                    LB_勝者名.Content = "Continue"
                    IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner.png", UriKind.Absolute))

                    勝者番号 = 0

                End If
            Else
                'まだ結果が出ていない
                TB_POINT_1_Total.Background = Brushes.White
                TB_POINT_1_Total.Foreground = Brushes.Black
                TB_POINT_2_Total.Background = Brushes.White
                TB_POINT_2_Total.Foreground = Brushes.Black

                LB_勝者名.Content = "Continue"
                IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner.png", UriKind.Absolute))

                勝者番号 = 0

            End If

        Else
            'ラウンド制の場合
            If バトル結果.終了ラウンド数 >= 2 Then
                If バトル結果.SC_BR_B_Result_選手(1).WIN数 > バトル結果.SC_BR_B_Result_選手(2).WIN数 And バトル結果.SC_BR_B_Result_選手(1).WIN数 >= 2 Then
                    '赤の勝ち
                    TB_POINT_1_Total.Background = Brushes.Red
                    TB_POINT_1_Total.Foreground = Brushes.White
                    TB_POINT_2_Total.Background = Brushes.White
                    TB_POINT_2_Total.Foreground = Brushes.Black

                    LB_勝者名.Content = バトル結果.SC_BR_B_Result_選手(1).リーダー名
                    IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner_red.png", UriKind.Absolute))

                    勝者番号 = 1

                ElseIf バトル結果.SC_BR_B_Result_選手(1).WIN数 < バトル結果.SC_BR_B_Result_選手(2).WIN数 And バトル結果.SC_BR_B_Result_選手(2).WIN数 >= 2 Then
                    '青の勝ち
                    TB_POINT_1_Total.Background = Brushes.White
                    TB_POINT_1_Total.Foreground = Brushes.Black
                    TB_POINT_2_Total.Background = Brushes.Blue
                    TB_POINT_2_Total.Foreground = Brushes.White

                    LB_勝者名.Content = バトル結果.SC_BR_B_Result_選手(2).リーダー名
                    IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner_blue.png", UriKind.Absolute))

                    勝者番号 = 2
                Else
                    TB_POINT_1_Total.Background = Brushes.White
                    TB_POINT_1_Total.Foreground = Brushes.Black
                    TB_POINT_2_Total.Background = Brushes.White
                    TB_POINT_2_Total.Foreground = Brushes.Black

                    LB_勝者名.Content = "Continue"
                    IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner.png", UriKind.Absolute))

                    勝者番号 = 0

                End If
            Else
                'まだ結果が出ていない
                TB_POINT_1_Total.Background = Brushes.White
                TB_POINT_1_Total.Foreground = Brushes.Black
                TB_POINT_2_Total.Background = Brushes.White
                TB_POINT_2_Total.Foreground = Brushes.Black

                LB_勝者名.Content = "Continue"
                IMG_WINNER.Source = New BitmapImage(New Uri(設定.IMGPATH & "\" & "winner.png", UriKind.Absolute))

                勝者番号 = 0

            End If

        End If


        'PCS
        'PCS項目　４つ×3バトル
        For r = 1 To 3
            For p = 1 To 4

                Dim 赤得点 = バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(r).SC_BR_B_Result_選手_ラウンド結果_PCS得点(p).PCS得点
                Dim 青得点 = バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(r).SC_BR_B_Result_選手_ラウンド結果_PCS得点(p).PCS得点

                If 画面番号 = 2 And r = 1 Then
                    赤得点 = バトル結果.SC_BR_B_Result_選手(1).SC_BR_B_Result_選手_ラウンド結果(r + (画面番号 - 1) * 3).SC_BR_B_Result_選手_ラウンド結果_PCS得点(p).PCS得点
                    青得点 = バトル結果.SC_BR_B_Result_選手(2).SC_BR_B_Result_選手_ラウンド結果(r + (画面番号 - 1) * 3).SC_BR_B_Result_選手_ラウンド結果_PCS得点(p).PCS得点
                End If

                TB_PCS設定("TB_PCS_" & r & p, 赤得点, 青得点)
            Next p
        Next r



        '減点
        For s = 1 To 2 '選手
            For r = 1 To 3
                For d = 1 To 5

                    Dim 減点項目名 As String = バトル結果.SC_BR_B_Result_選手(s).SC_BR_B_Result_選手_ラウンド結果(r).SC_BR_B_Result_選手_ラウンド結果_減点(d).減点項目名
                    Dim 減点点数 As Decimal = バトル結果.SC_BR_B_Result_選手(s).SC_BR_B_Result_選手_ラウンド結果(r).SC_BR_B_Result_選手_ラウンド結果_減点(d).減点

                    If 画面番号 = 2 And r = 1 Then
                        減点項目名 = バトル結果.SC_BR_B_Result_選手(s).SC_BR_B_Result_選手_ラウンド結果(r + (画面番号 - 1) * 3).SC_BR_B_Result_選手_ラウンド結果_減点(d).減点項目名
                        減点点数 = バトル結果.SC_BR_B_Result_選手(s).SC_BR_B_Result_選手_ラウンド結果(r + (画面番号 - 1) * 3).SC_BR_B_Result_選手_ラウンド結果_減点(d).減点
                    End If

                    TB_減点設定(s, r, d, 減点項目名, 減点点数)

                Next d
            Next r
        Next s

        'ラウンド番号ラベルの変更
        CType(FindName("LB_R1"), Label).Content = "R" & 1 + (画面番号 - 1) * 3
        CType(FindName("LB_R2"), Label).Content = "R" & 2 + (画面番号 - 1) * 3
        CType(FindName("LB_R3"), Label).Content = "R" & 3 + (画面番号 - 1) * 3


        CType(FindName("LB_PCS_R1"), Label).Content = "R" & 1 + (画面番号 - 1) * 3
        CType(FindName("LB_PCS_R2"), Label).Content = "R" & 2 + (画面番号 - 1) * 3
        CType(FindName("LB_PCS_R3"), Label).Content = "R" & 3 + (画面番号 - 1) * 3

        CType(FindName("LB_RED_R1"), Label).Content = "R" & 1 + (画面番号 - 1) * 3
        CType(FindName("LB_RED_R2"), Label).Content = "R" & 2 + (画面番号 - 1) * 3
        CType(FindName("LB_RED_R3"), Label).Content = "R" & 3 + (画面番号 - 1) * 3


        Return 勝者番号

    End Function

    Private Sub TB_PCS設定(TB名 As String, 赤得点 As Decimal, 青得点 As Decimal)

        If 赤得点 > 青得点 Then
            CType(FindName(TB名), TextBox).Text = Format(((赤得点 - 青得点) / 赤得点) * 100, "0.0") & "%"
            CType(FindName(TB名), TextBox).Foreground = Brushes.White
            CType(FindName(TB名), TextBox).Background = Brushes.Red

        ElseIf 赤得点 < 青得点 Then
            CType(FindName(TB名), TextBox).Text = Format(((青得点 - 赤得点) / 青得点) * 100, "0.0") & "%"
            CType(FindName(TB名), TextBox).Foreground = Brushes.White
            CType(FindName(TB名), TextBox).Background = Brushes.Blue

        ElseIf 赤得点 = 0 Then
            '未実施の時
            CType(FindName(TB名), TextBox).Text = "0.0%"
            CType(FindName(TB名), TextBox).Foreground = Brushes.White
            CType(FindName(TB名), TextBox).Background = Brushes.Gray

        Else
            '同点の時
            CType(FindName(TB名), TextBox).Text = "0.0%"
            CType(FindName(TB名), TextBox).Foreground = Brushes.White
            CType(FindName(TB名), TextBox).Background = Brushes.YellowGreen
        End If




    End Sub

    Private Sub TB_減点設定(選手番号 As Integer, ラウンド番号 As Integer, 減点番号 As Integer, 減点項目名 As String, 減点 As Decimal)

        Dim xName As String = "TB_RED_" & 選手番号 & "_" & ラウンド番号 & 減点番号

        Dim TB As TextBox = CType(FindName(xName), TextBox)

        TB.Text = 減点項目名
        If 減点 = 0 Then
            TB.Background = Brushes.Transparent
            TB.Foreground = Brushes.White
        Else
            TB.Background = Brushes.Yellow
            TB.Foreground = Brushes.Black
        End If

    End Sub

    Private sb As System.Windows.Media.Animation.Storyboard


    Private Sub フェードイン(obj As Object, sb As System.Windows.Media.Animation.Storyboard, Begintime As Integer)



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

        'sb1.Begin()

        'System.Threading.Thread.Sleep(1000)
        'sb2.Begin()

        'System.Threading.Thread.Sleep(1000)
        'sb3.Begin()


    End Sub

End Class
