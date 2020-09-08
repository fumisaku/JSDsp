Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class SC_B_Result_C
    'SCファイル
    'Breakin SC_B_Result    バトル結果

    Public Property 競技会名 As String
    Public Property 区分名 As String
    Public Property カテゴリ名 As String
    Public Property ラウンド表記名 As String
    Public Property 全ラウンド数 As Integer
    Public Property 終了ラウンド数 As Integer
    Public Property 勝敗方式 As String  '(P or R)　　Point（点数制） or Round 制


    Const MAX選手数 = 2
    Public Property 選手数 As Integer
    Public Property PCS数 As Integer
    Public Property 減点項目数 As Integer


    Public SC_BR_B_Result_選手() As SC_BR_B_Result_選手_C



    Sub New()

        ReDim SC_BR_B_Result_選手(MAX選手数)
        For i = 1 To MAX選手数
            SC_BR_B_Result_選手(i） = New SC_BR_B_Result_選手_C
        Next i

    End Sub


    Public Sub CSVRead(filepath As String)
        'SCファイルから読み込み

        Dim 登録済みレコード数 = 0

        Dim filename As String

        filename = "SC_B_Result.csv"

        If Dir(filepath & "\" & filename).ToUpper <> filename.ToUpper Then
            'ファイルが存在しない


        Else
            'ファイルが存在した

            ' StreamReader の新しいインスタンスを生成する
            Dim cReader As New System.IO.StreamReader(filepath & "\" & filename, System.Text.Encoding.Default)

            ' 読み込んだ結果をすべて格納するための変数を宣言する
            Dim stResult As String = String.Empty


            ' 読み込みできる文字がなくなるまで繰り返す

            While (cReader.Peek() >= 0)
                ' ファイルを 1 行ずつ読み込む
                Dim stBuffer As String = cReader.ReadLine()

                登録済みレコード数 = 登録済みレコード数 + 1

                'ファイルの１行目はヘッダーなので読み込まない
                If 登録済みレコード数 = 1 Then

                ElseIf 登録済みレコード数 = 2 Then
                    '2行目はヘッダー
                    Dim arBuffer = stBuffer.Split(",")

                    Me.競技会名 = arBuffer(1)
                    Me.区分名 = arBuffer(2)
                    Me.カテゴリ名 = arBuffer(3)
                    Me.ラウンド表記名 = arBuffer(4)

                    If IsNumeric(arBuffer(5)) Then
                        Me.全ラウンド数 = CInt(arBuffer(5)）
                    End If
                    If IsNumeric(arBuffer(6)) Then
                        Me.終了ラウンド数 = CInt(arBuffer(6)）
                    End If
                    Me.勝敗方式 = arBuffer(7)



                ElseIf 登録済みレコード数 >= 2 Then
                    '3行目以降は 選手結果データ

                    Dim arBuffer = stBuffer.Split(",")

                    Dim 選手数_Temp = 0

                    If IsNumeric(arBuffer(1)) Then
                        選手数_Temp = 選手数_Temp + 1
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).演技順 = CInt(arBuffer(1))
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).順位 = CInt(arBuffer(2))
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).背番号 = arBuffer(3)
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).リーダー名 = arBuffer(4)
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).パートナー名 = arBuffer(5)
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).カップル所属 = arBuffer(6)
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).WIN数 = arBuffer(7)
                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).総合得点 = CDec(arBuffer(8))




                        For r = 1 To Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).MAXラウンド数

                            If IsNumeric(arBuffer(18 * (r - 1) + 9)) Then

                                Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).SC_BR_B_Result_選手_ラウンド結果(r).TotalPoint = CDec(arBuffer(18 * (r - 1) + 9))

                                'PCSの結果
                                Dim PCS数_Temp = 0

                                For p = 1 To Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).SC_BR_B_Result_選手_ラウンド結果(r).MAXPCS数
                                    If IsNumeric(arBuffer(18 * (r - 1) + 9 + p)) Then
                                        PCS数_Temp = PCS数_Temp + 1
                                        Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).SC_BR_B_Result_選手_ラウンド結果(r).SC_BR_B_Result_選手_ラウンド結果_PCS得点(p).PCS得点 = CDec(arBuffer(18 * (r - 1) + 9 + p))
                                    End If
                                Next p

                                If PCS数 < PCS数_Temp Then
                                    PCS数 = PCS数_Temp
                                End If

                                '減点の結果
                                Dim 減点項目数_Temp = 0
                                For g = 1 To Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).SC_BR_B_Result_選手_ラウンド結果(r).MAX減点項目数
                                    If UBound(arBuffer) >= 18 * (r - 1) + 16 + (g - 1) * 2 Then
                                        If IsNumeric(arBuffer(18 * (r - 1) + 16 + (g - 1) * 2)) Then
                                            減点項目数_Temp = 減点項目数_Temp + 1
                                            Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).SC_BR_B_Result_選手_ラウンド結果(r).SC_BR_B_Result_選手_ラウンド結果_減点(g).減点項目名 = arBuffer(18 * (r - 1) + 15 + (g - 1) * 2)
                                            Me.SC_BR_B_Result_選手(登録済みレコード数 - 2).SC_BR_B_Result_選手_ラウンド結果(r).SC_BR_B_Result_選手_ラウンド結果_減点(g).減点 = CDec(arBuffer(18 * (r - 1) + 16 + (g - 1) * 2))
                                        End If
                                    End If
                                Next g

                                If 減点項目数 < 減点項目数_Temp Then
                                    減点項目数 = 減点項目数_Temp
                                End If
                            End If

                        Next r



                    End If

                    If 選手数 < 選手数_Temp Then
                        選手数 = 選手数_Temp
                    End If

                End If

            End While


            ' cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
            cReader.Close()


        End If


    End Sub

    Public Sub JSON書き出し(filepath As String)

        Dim filename = "SC_B_Result.json"

        ''JSONにシリアライズする
        Dim jText = JsonConvert.SerializeObject(Me, Formatting.Indented)

        ''元のファイルに出力する
        Using writer = New System.IO.StreamWriter(filepath & "\" & filename, True, System.Text.Encoding.GetEncoding("shift-jis"))
            writer.WriteLine(jText)
        End Using

    End Sub


End Class


Public Class SC_BR_B_Result_選手_C


    Public Property 演技順 As Integer
    Public Property 順位 As Integer
    Public Property 背番号 As String
    Public Property リーダー名 As String
    Public Property パートナー名 As String
    Public Property カップル所属 As String
    Public Property WIN数 As String  '
    Public Property 総合得点 As Decimal


    Public MAXラウンド数 = 4

    Public SC_BR_B_Result_選手_ラウンド結果() As SC_BR_B_Result_選手_ラウンド結果_C

    Sub New()
        ReDim SC_BR_B_Result_選手_ラウンド結果(MAXラウンド数)

        For i = 1 To MAXラウンド数
            SC_BR_B_Result_選手_ラウンド結果(i) = New SC_BR_B_Result_選手_ラウンド結果_C
        Next i
    End Sub

End Class

Public Class SC_BR_B_Result_選手_ラウンド結果_C




    Public Property ラウンド番号 As Integer
    Public Property TotalPoint As Decimal


    Public MAXPCS数 = 5



    Public SC_BR_B_Result_選手_ラウンド結果_PCS得点() As SC_BR_B_Result_選手_ラウンド結果_PCS得点_C

    Public MAX減点項目数 = 6


    Public SC_BR_B_Result_選手_ラウンド結果_減点() As SC_BR_B_Result_選手_ラウンド結果_減点_C

    Sub New()
        ReDim SC_BR_B_Result_選手_ラウンド結果_PCS得点(MAXPCS数)

        For i = 1 To MAXPCS数
            SC_BR_B_Result_選手_ラウンド結果_PCS得点(i) = New SC_BR_B_Result_選手_ラウンド結果_PCS得点_C
        Next i

        ReDim SC_BR_B_Result_選手_ラウンド結果_減点(MAX減点項目数)

        For i = 1 To MAX減点項目数
            SC_BR_B_Result_選手_ラウンド結果_減点(i) = New SC_BR_B_Result_選手_ラウンド結果_減点_C
        Next i

    End Sub


End Class

Public Class SC_BR_B_Result_選手_ラウンド結果_PCS得点_C


    Public Property PCS得点 As Decimal


End Class

Public Class SC_BR_B_Result_選手_ラウンド結果_減点_C

    Public Property 減点項目名 As String
    Public Property 減点 As Decimal


End Class




