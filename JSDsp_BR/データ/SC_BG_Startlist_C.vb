Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class SC_BG_Startlist_C

    Public Property 競技会名 As String
    Public Property 区分名 As String


    Public SC_BG_Startlist_選手() As SC_BG_Startlist_選手_C


    Public Sub CSVRead(filepath As String, カテゴリ番号 As String)
        'SCファイルから読み込み

        Dim 登録済みレコード数 = 0

        Dim filename As String

        filename = "SC_BG_Startlist_" & カテゴリ番号 & ".csv"

        If Dir(filepath & "\" & filename).ToUpper <> filename.ToUpper Then
            'ファイルが存在しない


        Else
            'ファイルが存在した

            ' StreamReader の新しいインスタンスを生成する
            Dim cReader As New System.IO.StreamReader(filepath & "\" & filename, System.Text.Encoding.Default)

            ' 読み込んだ結果をすべて格納するための変数を宣言する
            Dim stResult As String = String.Empty


            ''CSVの全データ取得し、改行で区切
            Dim getCSV行 = Split(cReader.ReadToEnd, vbCrLf)

            ''行数を取得
            Dim 行数 As Integer = getCSV行.Count - 1

            '行数を基に子クラスを作成
            ReDim SC_BG_Startlist_選手(行数)
            For i = 1 To 行数
                SC_BG_Startlist_選手(i） = New SC_BG_Startlist_選手_C
            Next i


            '1行づつ読み込み
            '読み込みできる文字がなくなるまで繰り返す
            For rowCount As Integer = 0 To 行数

                Dim get行 As String = getCSV行(rowCount)
                ''空白行は飛ばす
                If get行 = "" Then Exit For

                Dim arBuffer = get行.Split(",")

                If rowCount = 0 Then

                    Me.競技会名 = arBuffer(1)
                    Me.区分名 = arBuffer(2)


                ElseIf arBuffer(1) <> "" Then
                    '2行目以降
                    Me.SC_BG_Startlist_選手(rowCount).カテゴリ番号 = arBuffer(1)
                    Me.SC_BG_Startlist_選手(rowCount).カテゴリ名 = arBuffer(2)
                    Me.SC_BG_Startlist_選手(rowCount).区分番号 = arBuffer(3)
                    Me.SC_BG_Startlist_選手(rowCount).選手番号 = arBuffer(4)
                    Me.SC_BG_Startlist_選手(rowCount).背番号 = arBuffer(5)
                    Me.SC_BG_Startlist_選手(rowCount).リーダー名 = arBuffer(6)
                    Me.SC_BG_Startlist_選手(rowCount).パートナー名 = arBuffer(7)
                    Me.SC_BG_Startlist_選手(rowCount).所属 = arBuffer(8)

                End If

            Next rowCount



            ' cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
            cReader.Close()


        End If

    End Sub

    Public Sub JSON書き出し(filepath As String, カテゴリ番号 As String)

        Dim filename = "SC_BG_Startlist_" & カテゴリ番号 & ".json"

        ''JSONにシリアライズする
        Dim jText = JsonConvert.SerializeObject(Me, Formatting.Indented)

        ''元のファイルに出力する
        Using writer = New System.IO.StreamWriter(filepath & "\" & filename, False, System.Text.Encoding.GetEncoding("shift-jis"))
            writer.WriteLine(jText)
        End Using

    End Sub


    Public Sub JSON読み込み(filepath As String, カテゴリ番号 As String)

        Dim filename = "SC_BG_Startlist_" & カテゴリ番号 & ".json"

        ''JSON読み込み用
        Dim jText As String = String.Empty

        ''ファイルからJSONを読み込む
        Dim cReader As New System.IO.StreamReader(filepath & "\" & filename, System.Text.Encoding.Default)


        jText = cReader.ReadToEnd


        ''文字列をJSONにデシリアライズ
        Dim jObj As Object = JsonConvert.DeserializeObject(jText)

        Dim 行数 = jObj.SelectToken("SC_BG_Startlist_選手").Count - 1

        '行数を基に子クラスを作成
        ReDim SC_BG_Startlist_選手(行数)
        For i = 1 To 行数
            SC_BG_Startlist_選手(i） = New SC_BG_Startlist_選手_C
        Next i


        For i = 1 To 行数
            If jObj.SelectToken("SC_BG_Startlist_選手")(i)("カテゴリ番号").value IsNot Nothing Then

                SC_BG_Startlist_選手(i).カテゴリ番号 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("カテゴリ番号").value
                SC_BG_Startlist_選手(i).カテゴリ名 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("カテゴリ名").value
                SC_BG_Startlist_選手(i).区分番号 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("区分番号").value
                SC_BG_Startlist_選手(i).選手番号 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("選手番号").value
                SC_BG_Startlist_選手(i).背番号 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("背番号").value
                SC_BG_Startlist_選手(i).リーダー名 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("リーダー名").value
                SC_BG_Startlist_選手(i).パートナー名 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("パートナー名").value
                SC_BG_Startlist_選手(i).所属 = jObj.SelectToken("SC_BG_Startlist_選手")(i)("所属").value
            End If


        Next i


    End Sub

    Public Function Get_出場者数(カテゴリ番号) As Integer

        Dim rc As Integer = 0

        If SC_BG_Startlist_選手 IsNot Nothing Then

            For i = 1 To UBound(SC_BG_Startlist_選手)
                If SC_BG_Startlist_選手(i).カテゴリ番号 = カテゴリ番号 Then
                    rc = rc + 1
                End If
            Next i

        Else
            MsgBox("カテゴリ番号「" & カテゴリ番号 & "」のStartListが作成されていません。")

        End If

        Return rc

    End Function



End Class



Public Class SC_BG_Startlist_選手_C

    Public Property カテゴリ番号 As String
    Public Property カテゴリ名 As String
    Public Property 区分番号 As String
    Public Property 選手番号 As Integer   '赤が１　青が２
    Public Property 背番号 As String
    Public Property リーダー名 As String
    Public Property パートナー名 As String
    Public Property 所属 As String






End Class