
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class SC_BR_Result_C


    Public SC_BR_Result_結果() As SC_BR_Result_結果_C


    Sub New()

    End Sub

    Public Sub CSVRead(filepath As String)
        'SCファイルから読み込み

        Dim 登録済みレコード数 = 0

        Dim filename As String

        filename = "SC_BR_Result.csv"

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
            ReDim SC_BR_Result_結果(行数)
            For i = 1 To 行数
                SC_BR_Result_結果(i） = New SC_BR_Result_結果_C
            Next i


            '1行づつ読み込み
            '読み込みできる文字がなくなるまで繰り返す
            For rowCount As Integer = 0 To 行数

                Dim get行 As String = getCSV行(rowCount)
                ''空白行は飛ばす
                If get行 = "" Then Exit For

                Dim arBuffer = get行.Split(",")

                If rowCount > 0 Then

                    Me.SC_BR_Result_結果(rowCount).カテゴリ番号 = arBuffer(0)
                    Me.SC_BR_Result_結果(rowCount).カテゴリ名 = arBuffer(1)
                    Me.SC_BR_Result_結果(rowCount).区分番号 = arBuffer(2)
                    Me.SC_BR_Result_結果(rowCount).ラウンド番号 = arBuffer(3)
                    Me.SC_BR_Result_結果(rowCount).勝者背番号 = arBuffer(4)
                    Me.SC_BR_Result_結果(rowCount).勝者リーダー名 = arBuffer(5)
                    Me.SC_BR_Result_結果(rowCount).勝者パートナー名 = arBuffer(6)
                    Me.SC_BR_Result_結果(rowCount).勝者所属 = arBuffer(7)
                    Me.SC_BR_Result_結果(rowCount).勝者点数 = arBuffer(8)
                    Me.SC_BR_Result_結果(rowCount).敗者点数 = arBuffer(9)
                End If


            Next rowCount



            ' cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
            cReader.Close()


        End If



    End Sub

    Public Sub JSON書き出し(filepath As String)

        Dim filename = "SC_BR_Result.json"

        ''JSONにシリアライズする
        Dim jText = JsonConvert.SerializeObject(Me, Formatting.Indented)

        ''元のファイルに出力する
        Using writer = New System.IO.StreamWriter(filepath & "\" & filename, False, System.Text.Encoding.GetEncoding("shift-jis"))
            writer.WriteLine(jText)
        End Using

    End Sub

    Public Sub JSON読み込み(filepath As String)

        Dim filename = "SC_BR_Result.json"

        ''JSON読み込み用
        Dim jText As String = String.Empty

        ''ファイルからJSONを読み込む
        Dim cReader As New System.IO.StreamReader(filepath & "\" & filename, System.Text.Encoding.Default)


        ''CSVの全データ取得し、改行で区切
        'Dim getCSV行 = Split(cReader.ReadToEnd, vbCrLf)

        ''行数を取得
        'Dim 行数 As Integer = getCSV行.Count - 1


        jText = cReader.ReadToEnd


        ''文字列をJSONにデシリアライズ
        Dim jObj As Object = JsonConvert.DeserializeObject(jText)

        Dim 行数 = jObj.SelectToken("SC_BR_Result_結果").Count - 1

        '行数を基に子クラスを作成
        ReDim SC_BR_Result_結果(行数)
        For i = 1 To 行数
            SC_BR_Result_結果(i） = New SC_BR_Result_結果_C
        Next i


        For i = 1 To 行数
            If jObj.SelectToken("SC_BR_Result_結果")(i)("カテゴリ番号").value IsNot Nothing Then

                SC_BR_Result_結果(i).カテゴリ番号 = jObj.SelectToken("SC_BR_Result_結果")(i)("カテゴリ番号").value
                SC_BR_Result_結果(i).カテゴリ名 = jObj.SelectToken("SC_BR_Result_結果")(i)("カテゴリ名").value
                SC_BR_Result_結果(i).区分番号 = jObj.SelectToken("SC_BR_Result_結果")(i)("区分番号").value
                SC_BR_Result_結果(i).ラウンド番号 = jObj.SelectToken("SC_BR_Result_結果")(i)("ラウンド番号").value
                SC_BR_Result_結果(i).勝者背番号 = jObj.SelectToken("SC_BR_Result_結果")(i)("勝者背番号").value
                SC_BR_Result_結果(i).勝者リーダー名 = jObj.SelectToken("SC_BR_Result_結果")(i)("勝者リーダー名").value
                SC_BR_Result_結果(i).勝者パートナー名 = jObj.SelectToken("SC_BR_Result_結果")(i)("勝者パートナー名").value
                SC_BR_Result_結果(i).勝者所属 = jObj.SelectToken("SC_BR_Result_結果")(i)("勝者所属").value
                SC_BR_Result_結果(i).勝者点数 = jObj.SelectToken("SC_BR_Result_結果")(i)("勝者点数").value
                SC_BR_Result_結果(i).敗者点数 = jObj.SelectToken("SC_BR_Result_結果")(i)("敗者点数").value
            End If


        Next i


    End Sub


End Class


Public Class SC_BR_Result_結果_C

    Public Property カテゴリ番号 As String
    Public Property カテゴリ名 As String
    Public Property 区分番号 As String
    Public Property ラウンド番号 As String
    Public Property 勝者背番号 As String
    Public Property 勝者リーダー名 As String
    Public Property 勝者パートナー名 As String
    Public Property 勝者所属 As String
    Public Property 勝者点数 As String
    Public Property 敗者点数 As String





End Class
