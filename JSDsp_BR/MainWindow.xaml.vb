Class MainWindow

    Private 設定 As 設定_C


    Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        設定 = New 設定_C
        If 設定.JSON読み込み("") <> 0 Then
            'JSONファイルが存在しない時
            MsgBox("JS_Disp_BR.json ファイルが存在しません。")

            'デフォルト値を設定
            設定.システムPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\JSDsp_BR\JSDsp_BR\JSDsp_BR\bin\Debug"
            設定.IMGPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\JSDsp_BR\JSDsp_BR\JSDsp_BR\bin\Debug\img"
            設定.SCファイルPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\JSServer\JSServer\bin\Debug"
            設定.選手写真IMGPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\パワポ\ブレイキン\BB\"

            設定.トーナメント1_人数 = "16"
            設定.トーナメント1_カテゴリ番号 = "B1"

            設定.トーナメント2_人数 = "8"
            設定.トーナメント2_カテゴリ番号 = "B2"

            設定.トーナメント3_人数 = "4"
            設定.トーナメント3_カテゴリ番号 = "B3"

            設定.トーナメント4_人数 = "4"
            設定.トーナメント4_カテゴリ番号 = "B4"

        End If

        Select Case 設定.トーナメント1_人数

            Case "4"
                Me.RB_T11.IsChecked = True
            Case "8"
                Me.RB_T12.IsChecked = True
            Case "16"
                Me.RB_T13.IsChecked = True

            Case "2"
                Me.RB_T14.IsChecked = True
        End Select

        Me.TB_T01.Text = 設定.トーナメント1_カテゴリ番号

        Select Case 設定.トーナメント2_人数
            Case "4"
                Me.RB_T21.IsChecked = True
            Case "8"
                Me.RB_T22.IsChecked = True
            Case "16"
                Me.RB_T23.IsChecked = True
            Case "2"
                Me.RB_T24.IsChecked = True
        End Select

        Me.TB_T02.Text = 設定.トーナメント2_カテゴリ番号

        Select Case 設定.トーナメント3_人数
            Case "4"
                Me.RB_T31.IsChecked = True
            Case "8"
                Me.RB_T32.IsChecked = True
            Case "16"
                Me.RB_T33.IsChecked = True
            Case "2"
                Me.RB_T34.IsChecked = True
        End Select

        Me.TB_T03.Text = 設定.トーナメント3_カテゴリ番号

        Select Case 設定.トーナメント4_人数
            Case "4"
                Me.RB_T41.IsChecked = True
            Case "8"
                Me.RB_T42.IsChecked = True
            Case "16"
                Me.RB_T43.IsChecked = True
            Case "2"
                Me.RB_T44.IsChecked = True
        End Select

        Me.TB_T04.Text = 設定.トーナメント4_カテゴリ番号


    End Sub



    Private Sub デフォルト設定書き出し()

        Dim 設定 = New 設定_C
        設定.システムPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\JSDsp_BR\JSDsp_BR\JSDsp_BR\bin\Debug"

        設定.IMGPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\JSDsp_BR\JSDsp_BR\JSDsp_BR\bin\Debug\img"
        設定.SCファイルPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\JSServer\JSServer\bin\Debug"
        設定.選手写真IMGPATH = "C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\パワポ\ブレイキン\BB\"

        設定.トーナメント1_人数 = "16"
        設定.トーナメント1_カテゴリ番号 = "B1"

        設定.トーナメント2_人数 = "8"
        設定.トーナメント2_カテゴリ番号 = "B2"

        設定.トーナメント3_人数 = "4"
        設定.トーナメント3_カテゴリ番号 = "B3"

        設定.トーナメント4_人数 = "4"
        設定.トーナメント4_カテゴリ番号 = "B4"

        If Me.RB_T11.IsChecked = True Then
            設定.トーナメント1_人数 = "4"
        ElseIf Me.RB_T12.IsChecked = True Then
            設定.トーナメント1_人数 = "8"
        ElseIf Me.RB_T13.IsChecked = True Then
            設定.トーナメント1_人数 = "16"
        Else
            設定.トーナメント1_人数 = "2"
        End If

        If Me.RB_T21.IsChecked = True Then
            設定.トーナメント2_人数 = "4"
        ElseIf Me.RB_T22.IsChecked = True Then
            設定.トーナメント2_人数 = "8"
        ElseIf Me.RB_T23.IsChecked = True Then
            設定.トーナメント2_人数 = "16"
        Else
            設定.トーナメント2_人数 = "2"
        End If

        If Me.RB_T31.IsChecked = True Then
            設定.トーナメント3_人数 = "4"
        ElseIf Me.RB_T32.IsChecked = True Then
            設定.トーナメント3_人数 = "8"
        ElseIf Me.RB_T33.IsChecked = True Then
            設定.トーナメント3_人数 = "16"
        Else
            設定.トーナメント3_人数 = "2"
        End If

        If Me.RB_T41.IsChecked = True Then
            設定.トーナメント4_人数 = "4"
        ElseIf Me.RB_T42.IsChecked = True Then
            設定.トーナメント4_人数 = "8"
        ElseIf Me.RB_T43.IsChecked = True Then
            設定.トーナメント4_人数 = "16"
        Else
            設定.トーナメント4_人数 = "2"
        End If




        設定.JSON書き出し("C:\Users\FUMIHIKOSAKURA\Box\90_JDSF\08_新審判基準委員会\40_総合支援システム\V0.1\JSDsp_BR\JSDsp_BR\JSDsp_BR\bin\Debug")

    End Sub



    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        '設定保存ボタン

        設定.トーナメント1_カテゴリ番号 = Me.TB_T01.Text

        設定.トーナメント2_カテゴリ番号 = Me.TB_T02.Text

        設定.トーナメント3_カテゴリ番号 = Me.TB_T03.Text

        設定.トーナメント4_カテゴリ番号 = Me.TB_T04.Text


        If Me.RB_T11.IsChecked = True Then
            設定.トーナメント1_人数 = "4"
        ElseIf Me.RB_T12.IsChecked = True Then
            設定.トーナメント1_人数 = "8"
        ElseIf Me.RB_T13.IsChecked = True Then
            設定.トーナメント1_人数 = "16"
        Else
            設定.トーナメント1_人数 = "2"
        End If

        If Me.RB_T21.IsChecked = True Then
            設定.トーナメント2_人数 = "4"
        ElseIf Me.RB_T22.IsChecked = True Then
            設定.トーナメント2_人数 = "8"
        ElseIf Me.RB_T23.IsChecked = True Then
            設定.トーナメント2_人数 = "16"
        Else
            設定.トーナメント2_人数 = "2"
        End If

        If Me.RB_T31.IsChecked = True Then
            設定.トーナメント3_人数 = "4"
        ElseIf Me.RB_T32.IsChecked = True Then
            設定.トーナメント3_人数 = "8"
        ElseIf Me.RB_T33.IsChecked = True Then
            設定.トーナメント3_人数 = "16"
        Else
            設定.トーナメント3_人数 = "2"
        End If

        If Me.RB_T41.IsChecked = True Then
            設定.トーナメント4_人数 = "4"
        ElseIf Me.RB_T42.IsChecked = True Then
            設定.トーナメント4_人数 = "8"
        ElseIf Me.RB_T43.IsChecked = True Then
            設定.トーナメント4_人数 = "16"
        Else
            設定.トーナメント4_人数 = "2"
        End If

        設定.JSON書き出し("")


    End Sub

    Private Sub PB_T01_Click(sender As Object, e As RoutedEventArgs) Handles PB_T01.Click
        'トーナメント １ 
        If Me.RB_T11.IsChecked = True Then
            '4人の時
            トーナメント結果ボタン_4人("1")


        ElseIf Me.RB_T12.IsChecked = True Then
            '8人の時
            トーナメント結果ボタン_8人("1")

        ElseIf Me.RB_T13.IsChecked = True Then
            トーナメント結果ボタン_16人("1")

        ElseIf Me.RB_T14.IsChecked = True Then
            トーナメント結果ボタン_2人("1")

        Else
            MsgBox("トーナメントの人数を選択してください。")

        End If


    End Sub

    Private Sub PB_T02_Click(sender As Object, e As RoutedEventArgs) Handles PB_T02.Click
        'トーナメント ２　
        If Me.RB_T21.IsChecked = True Then
            '8人の時
            トーナメント結果ボタン_4人("2")


        ElseIf Me.RB_T22.IsChecked = True Then
            '8人の時
            トーナメント結果ボタン_8人("2")

        ElseIf Me.RB_T23.IsChecked = True Then
            トーナメント結果ボタン_16人("2")

        ElseIf Me.RB_T24.IsChecked = True Then
            トーナメント結果ボタン_2人("2")
        Else
            MsgBox("トーナメントの人数を選択してください。")

        End If

    End Sub

    Private Sub PB_T03_Click(sender As Object, e As RoutedEventArgs) Handles PB_T03.Click
        'トーナメント ３
        If Me.RB_T31.IsChecked = True Then
            '8人の時
            トーナメント結果ボタン_4人("3")


        ElseIf Me.RB_T32.IsChecked = True Then
            '8人の時
            トーナメント結果ボタン_8人("3")

        ElseIf Me.RB_T33.IsChecked = True Then
            トーナメント結果ボタン_16人("3")

        ElseIf Me.RB_T34.IsChecked = True Then
            トーナメント結果ボタン_2人("3")

        Else
            MsgBox("トーナメントの人数を選択してください。")

        End If

    End Sub

    Private Sub PB_T04_Click(sender As Object, e As RoutedEventArgs) Handles PB_T04.Click
        'トーナメント ２　
        If Me.RB_T41.IsChecked = True Then
            '8人の時
            トーナメント結果ボタン_4人("4")


        ElseIf Me.RB_T42.IsChecked = True Then
            '8人の時
            トーナメント結果ボタン_8人("4")

        ElseIf Me.RB_T43.IsChecked = True Then
            トーナメント結果ボタン_16人("4")

        ElseIf Me.RB_T44.IsChecked = True Then
            トーナメント結果ボタン_2人("4")

        Else
            MsgBox("トーナメントの人数を選択してください。")

        End If

    End Sub


    Private Sub PB_B01_Click(sender As Object, e As RoutedEventArgs) Handles PB_B01.Click
        'バトル結果
        バトル結果ボタン()

        WB_T01カウンタ = 0
        WB_T02カウンタ = 0

    End Sub

    Private Sub PB_B01_Clear_Click(sender As Object, e As RoutedEventArgs) Handles PB_B01_Clear.Click

        'バトル結果クリアボタン
        WB_R01カウンタ = 100
        バトル結果ボタン()


    End Sub

    Private Sub PB_B01_3R結果_Click(sender As Object, e As RoutedEventArgs) Handles PB_B01_3R結果.Click

        '3ラウンドの結果表示
        WB_R01カウンタ = 4
        バトル結果ボタン()



    End Sub

    Private 確認画面 As 確認画面
    Private Sub 確認画面作成()

        If 確認画面 Is Nothing Then
            確認画面 = New 確認画面
            確認画面.Show()
        End If


    End Sub


    Private 表示画面 As 表示画面
    Private Sub 表示画面作成()

        If 表示画面 Is Nothing Then
            表示画面 = New 表示画面

            'プライマリーWindowの解像度
            Dim PriWidth = SystemParameters.PrimaryScreenWidth / 96 * 120



            表示画面.Left = PriWidth + 120
            表示画面.Top = 0



            'タイトルバーを表示しない
            表示画面.WindowStyle = WindowStyle.None

            '最大化表示  ここで最大化するとプライマリーになってしまうので、表示画面.xaml.vb の中で最大化させる
            '表示画面.WindowState = WindowState.Maximized



            表示画面.Show()

        End If


    End Sub


    Private Sub ORG画面非表示()
        '表示画面を使うので、元の画面は非表示にする

        If WB_R01 IsNot Nothing Then
            WB_R01.Hide()
        End If
        If WB_T01 IsNot Nothing Then
            WB_T01.Hide()
        End If
        If WB_T02 IsNot Nothing Then
            WB_T02.Hide()
        End If
        If WB_T03 IsNot Nothing Then
            WB_T03.Hide()
        End If
        If WB_T04 IsNot Nothing Then
            WB_T04.Hide()
        End If

    End Sub

    '======バトル結果画面===================

    Private WB_R01 As WB_R02
    Private WB_R01カウンタ As Integer = 0
    Private Sub バトル結果ボタン()
        'バトル結果ボタンが押された時の処理

        確認画面作成()
        表示画面作成()

        Dim バトル結果 = New SC_B_Result_C
        バトル結果.CSVRead(設定.SCファイルPATH)

        Dim FadeFlag As Boolean = False

        If Me.CB_フェードOFF.IsChecked Then
            FadeFlag = False
        Else
            FadeFlag = True
        End If

        Select Case WB_R01カウンタ
            Case 0
                '初期表示

                If WB_R01 Is Nothing Then
                    WB_R01 = New WB_R02(設定)
                Else
                    WB_R01.全フェードアウト(FadeFlag)
                    WB_R01.SBStart()
                End If

                WB_R01カウンタ = WB_R01カウンタ + 1

            Case 1

                WB_R01.データセット(バトル結果)

                WB_R01.No00(FadeFlag)
                WB_R01.SBStart()

                WB_R01カウンタ = WB_R01カウンタ + 1

            Case 2
                If WB_R01.データセット(バトル結果) = 0 Then
                    WB_R01カウンタ = WB_R01カウンタ + 1
                Else
                    '結果が出た時
                    WB_R01カウンタ = 0

                End If

                WB_R01.No00(FadeFlag)
                WB_R01.No01(FadeFlag)
                WB_R01.SBStart()


            Case 3
                WB_R01.WINNERフェードアウト()
                WB_R01.SBStart()

                WB_R01カウンタ = WB_R01カウンタ + 1

            Case 4
                If WB_R01.データセット(バトル結果) = 0 Then
                    WB_R01カウンタ = WB_R01カウンタ + 1
                Else
                    '結果が出た時
                    WB_R01カウンタ = 0
                End If

                WB_R01.No00(FadeFlag)
                WB_R01.No01(FadeFlag)
                WB_R01.No02(FadeFlag)
                WB_R01.SBStart()



            Case 5
                WB_R01.WINNERフェードアウト()
                WB_R01.SBStart()

                WB_R01カウンタ = WB_R01カウンタ + 1


            Case 6
                If WB_R01.データセット(バトル結果) = 0 Then
                    WB_R01カウンタ = WB_R01カウンタ + 1
                Else
                    '結果が出た時
                    WB_R01カウンタ = 0
                End If

                WB_R01.No00(FadeFlag)
                WB_R01.No01(FadeFlag)
                WB_R01.No02(FadeFlag)
                WB_R01.No03(FadeFlag)
                WB_R01.SBStart()



            Case 7
                WB_R01.ラウンド４に向けてのフェードアウト()
                WB_R01.SBStart()

                WB_R01カウンタ = 2

            Case 8
                WB_R01.全フェードアウト(FadeFlag)
                WB_R01.SBStart()

                WB_R01カウンタ = 1

            Case Else
                WB_R01.全フェードアウト(FadeFlag)
                WB_R01.SBStart()

                WB_R01カウンタ = 1

        End Select

        WB_R01.Show()

        If WB_T01 IsNot Nothing Then
            WB_T01.Hide()
        End If
        If WB_T02 IsNot Nothing Then
            WB_T02.Hide()
        End If
        If WB_T03 IsNot Nothing Then
            WB_T03.Hide()
        End If
        If WB_T04 IsNot Nothing Then
            WB_T04.Hide()
        End If


        確認画面.DataContext = WB_R01
        表示画面.DataContext = WB_R01

        Me.LB_B01.Content = WB_R01カウンタ


    End Sub

    '======トーナメント結果画面 １　16人===================

    Private WB_T01 As WB_T01
    Private WB_T01カウンタ As Integer = 0
    Private Sub トーナメント結果ボタン_16人(T番号 As String)

        確認画面作成()
        表示画面作成()


        '16人トーナメント表
        'Dim カテゴリ番号 As String = Me.TB_T01.Text
        Dim カテゴリ番号 As String = CType(FindName("TB_T0" & T番号), TextBox).Text




        Dim SC_BR_Result As SC_BR_Result_C
        SC_BR_Result = New SC_BR_Result_C

        SC_BR_Result.CSVRead(設定.SCファイルPATH)





        Dim SC_BG_Startlist As SC_BG_Startlist_C
        SC_BG_Startlist = New SC_BG_Startlist_C


        SC_BG_Startlist.CSVRead(設定.SCファイルPATH, カテゴリ番号)



        '選手人数チェック
        If SC_BG_Startlist.Get_出場者数(カテゴリ番号) < 14 Then
            MsgBox("選手が16人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        ElseIf SC_BG_Startlist.Get_出場者数(カテゴリ番号) > 16 Then
            MsgBox("選手が16人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        Else

        End If


        Select Case WB_T01カウンタ
            Case 0
                If WB_T01 Is Nothing Then
                    WB_T01 = New WB_T01(設定)
                    WB_T01.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                Else
                    WB_T01.全フェードアウト()
                    WB_T01.SBStart()
                End If

                WB_T01カウンタ = 1

            Case 1
                WB_T01.初期化()
                WB_T01.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                WB_T01.No1()
                WB_T01.SBStart()

                WB_T01カウンタ = 2

            Case 2
                WB_T01.全フェードアウト()
                WB_T01.SBStart()

                WB_T01カウンタ = 1

            Case Else

                WB_T01.Close()

                WB_T01カウンタ = 0

        End Select


        WB_T01.Show()

        If WB_R01 IsNot Nothing Then
            WB_R01.Hide()
        End If
        If WB_T02 IsNot Nothing Then
            WB_T02.Hide()
        End If
        If WB_T03 IsNot Nothing Then
            WB_T03.Hide()
        End If
        If WB_T04 IsNot Nothing Then
            WB_T04.Hide()
        End If


        確認画面.DataContext = WB_T01
        表示画面.DataContext = WB_T01

    End Sub


    '======トーナメント結果画面 ２　8人===================

    Private WB_T02 As WB_T02
    Private WB_T02カウンタ As Integer = 0
    Private Sub トーナメント結果ボタン_8人(T番号 As String)

        確認画面作成()
        表示画面作成()

        '8人トーナメント表

        'Dim カテゴリ番号 As String = Me.TB_T02.Text
        Dim カテゴリ番号 As String = CType(FindName("TB_T0" & T番号), TextBox).Text


        Dim SC_BR_Result As SC_BR_Result_C
        SC_BR_Result = New SC_BR_Result_C

        SC_BR_Result.CSVRead(設定.SCファイルPATH)



        Dim SC_BG_Startlist As SC_BG_Startlist_C
        SC_BG_Startlist = New SC_BG_Startlist_C

        SC_BG_Startlist.CSVRead(設定.SCファイルPATH, カテゴリ番号)




        '選手人数チェック
        If SC_BG_Startlist.Get_出場者数(カテゴリ番号) < 6 Then
            MsgBox("選手が8人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        ElseIf SC_BG_Startlist.Get_出場者数(カテゴリ番号) > 8 Then
            MsgBox("選手が8人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        Else

        End If

        Select Case WB_T02カウンタ
            Case 0

                If WB_T02 Is Nothing Then
                    WB_T02 = New WB_T02(設定)
                    WB_T02.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                Else
                    WB_T02.全フェードアウト()
                    WB_T02.SBStart()
                End If

                WB_T02カウンタ = 1


            Case 1
                WB_T02.初期化()
                WB_T02.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                WB_T02.No1()
                WB_T02.SBStart()

                WB_T02カウンタ = 2


            Case 2
                WB_T02.全フェードアウト()
                WB_T02.SBStart()

                WB_T02カウンタ = 1




            Case Else

                WB_T02.Close()

                WB_T02カウンタ = 0



        End Select


        WB_T02.Show()

        If WB_R01 IsNot Nothing Then
            WB_R01.Hide()
        End If
        If WB_T01 IsNot Nothing Then
            WB_T01.Hide()
        End If
        If WB_T03 IsNot Nothing Then
            WB_T03.Hide()
        End If
        If WB_T04 IsNot Nothing Then
            WB_T04.Hide()
        End If


        確認画面.DataContext = WB_T02
        表示画面.DataContext = WB_T02


    End Sub




    '======トーナメント結果画面 ２　8人===================

    Private WB_T03 As WB_T03
    Private WB_T03カウンタ As Integer = 0
    Private Sub トーナメント結果ボタン_4人(T番号 As String)

        確認画面作成()
        表示画面作成()

        '4人トーナメント表

        ' Dim カテゴリ番号 As String = Me.TB_T03.Text
        Dim カテゴリ番号 As String = CType(FindName("TB_T0" & T番号), TextBox).Text


        Dim SC_BR_Result As SC_BR_Result_C
        SC_BR_Result = New SC_BR_Result_C

        SC_BR_Result.CSVRead(設定.SCファイルPATH)



        Dim SC_BG_Startlist As SC_BG_Startlist_C
        SC_BG_Startlist = New SC_BG_Startlist_C

        SC_BG_Startlist.CSVRead(設定.SCファイルPATH, カテゴリ番号)


        '選手人数チェック
        If SC_BG_Startlist.Get_出場者数(カテゴリ番号) < 3 Then
            MsgBox("選手が4人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        ElseIf SC_BG_Startlist.Get_出場者数(カテゴリ番号) > 4 Then
            MsgBox("選手が4人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        Else

        End If

        Select Case WB_T03カウンタ
            Case 0

                If WB_T03 Is Nothing Then
                    WB_T03 = New WB_T03(設定)
                    WB_T03.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                Else
                    WB_T03.全フェードアウト()
                    WB_T03.SBStart()
                End If

                WB_T03カウンタ = 1


            Case 1
                WB_T03.初期化()
                WB_T03.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                WB_T03.No1()
                WB_T03.SBStart()

                WB_T03カウンタ = 2


            Case 2
                WB_T03.全フェードアウト()
                WB_T03.SBStart()

                WB_T03カウンタ = 1




            Case Else

                WB_T03.Close()

                WB_T03カウンタ = 0



        End Select


        WB_T03.Show()

        If WB_R01 IsNot Nothing Then
            WB_R01.Hide()
        End If
        If WB_T01 IsNot Nothing Then
            WB_T01.Hide()
        End If
        If WB_T02 IsNot Nothing Then
            WB_T02.Hide()
        End If
        If WB_T04 IsNot Nothing Then
            WB_T04.Hide()
        End If


        確認画面.DataContext = WB_T03
        表示画面.DataContext = WB_T03

    End Sub



    '======トーナメント結果画面 ２　2人===================

    Private WB_T04 As WB_T04
    Private WB_T04カウンタ As Integer = 0
    Private Sub トーナメント結果ボタン_2人(T番号 As String)

        確認画面作成()
        表示画面作成()

        '2人トーナメント表

        ' Dim カテゴリ番号 As String = Me.TB_T03.Text
        Dim カテゴリ番号 As String = CType(FindName("TB_T0" & T番号), TextBox).Text


        Dim SC_BR_Result As SC_BR_Result_C
        SC_BR_Result = New SC_BR_Result_C

        SC_BR_Result.CSVRead(設定.SCファイルPATH)



        Dim SC_BG_Startlist As SC_BG_Startlist_C
        SC_BG_Startlist = New SC_BG_Startlist_C

        SC_BG_Startlist.CSVRead(設定.SCファイルPATH, カテゴリ番号)


        '選手人数チェック
        If SC_BG_Startlist.Get_出場者数(カテゴリ番号) < 3 Then
            MsgBox("選手が2人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        ElseIf SC_BG_Startlist.Get_出場者数(カテゴリ番号) > 4 Then
            MsgBox("選手が2人ではありません。" & SC_BG_Startlist.Get_出場者数(カテゴリ番号) & "人")
            Exit Sub
        Else

        End If

        Select Case WB_T04カウンタ
            Case 0

                If WB_T04 Is Nothing Then
                    WB_T04 = New WB_T04(設定)
                    WB_T04.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                Else
                    WB_T04.全フェードアウト()
                    WB_T04.SBStart()
                End If

                WB_T04カウンタ = 1


            Case 1
                WB_T04.初期化()
                WB_T04.データセット(SC_BG_Startlist, SC_BR_Result, カテゴリ番号)
                WB_T04.No1()
                WB_T04.SBStart()

                WB_T04カウンタ = 2


            Case 2
                WB_T04.全フェードアウト()
                WB_T04.SBStart()

                WB_T04カウンタ = 1




            Case Else

                WB_T04.Close()

                WB_T04カウンタ = 0



        End Select


        WB_T04.Show()

        If WB_R01 IsNot Nothing Then
            WB_R01.Hide()
        End If
        If WB_T01 IsNot Nothing Then
            WB_T01.Hide()
        End If
        If WB_T02 IsNot Nothing Then
            WB_T02.Hide()
        End If
        If WB_T03 IsNot Nothing Then
            WB_T03.Hide()
        End If


        確認画面.DataContext = WB_T04
        表示画面.DataContext = WB_T04

    End Sub


    Private Sub Window_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs)

        If MsgBox("終了しても良いですか？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then

            e.Cancel = True
            Return

        Else

            If WB_R01 IsNot Nothing Then
                WB_R01.Close()
            End If

            If WB_T01 IsNot Nothing Then
                WB_T01.Close()
            End If

            If WB_T02 IsNot Nothing Then
                WB_T02.Close()
            End If

            If WB_T03 IsNot Nothing Then
                WB_T03.Close()
            End If

            If WB_T04 IsNot Nothing Then
                WB_T04.Close()
            End If


            If 確認画面 IsNot Nothing Then
                確認画面.Close()
            End If

            If 表示画面 IsNot Nothing Then
                表示画面.Close()
            End If

            Application.Current.Shutdown()

        End If


    End Sub

    Private Sub PB_確認画面_Click(sender As Object, e As RoutedEventArgs) Handles PB_確認画面.Click

        If 確認画面 IsNot Nothing Then

            If 確認画面.IsVisible = True Then
                確認画面.Hide()

            Else

                確認画面.Show()
            End If


        End If


    End Sub

    Private Sub PB_表示画面_Click(sender As Object, e As RoutedEventArgs) Handles PB_表示画面.Click

        If 表示画面 IsNot Nothing Then

            If 表示画面.IsVisible = True Then
                表示画面.Hide()

            Else

                表示画面.Show()
            End If


        End If


    End Sub

    Private Sub PB_バトル画面_Click(sender As Object, e As RoutedEventArgs) Handles PB_バトル画面.Click

        If WB_R01 IsNot Nothing Then

            If WB_R01.IsVisible = True Then
                WB_R01.Hide()

            Else

                WB_R01.Show()
            End If


        End If


    End Sub

End Class
