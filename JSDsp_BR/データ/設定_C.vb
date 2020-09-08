Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class 設定_C

    Private システムPATH_ As String
    Public Property システムPATH As String
        Get
            Return システムPATH_
        End Get
        Set(value As String)
            If Strings.Right(value, 1) = "\" Then
                システムPATH_ = Strings.Left(value, Strings.Len(value) - 1)
            Else
                システムPATH_ = value
            End If
        End Set
    End Property

    Private IMGPATH_ As String
    Public Property IMGPATH As String
        Get
            Return IMGPATH_
        End Get
        Set(value As String)
            If Strings.Right(value, 1) = "\" Then
                IMGPATH_ = Strings.Left(value, Strings.Len(value) - 1)
            Else
                IMGPATH_ = value
            End If
        End Set
    End Property

    Private SCファイルPATH_ As String
    Public Property SCファイルPATH As String
        Get
            Return SCファイルPATH_
        End Get
        Set(value As String)
            If Strings.Right(value, 1) = "\" Then
                SCファイルPATH_ = Strings.Left(value, Strings.Len(value) - 1)
            Else
                SCファイルPATH_ = value
            End If
        End Set
    End Property


    Private 選手写真IMGPATH_ As String
    Public Property 選手写真IMGPATH As String
        Get
            Return 選手写真IMGPATH_
        End Get
        Set(value As String)
            If Strings.Right(value, 1) = "\" Then
                選手写真IMGPATH_ = Strings.Left(value, Strings.Len(value) - 1)
            Else
                選手写真IMGPATH_ = value
            End If
        End Set
    End Property


    Public Property トーナメント1_人数 As String
    Public Property トーナメント1_カテゴリ番号 As String
    Public Property トーナメント2_人数 As String
    Public Property トーナメント2_カテゴリ番号 As String

    Public Property トーナメント3_人数 As String
    Public Property トーナメント3_カテゴリ番号 As String

    Public Property トーナメント4_人数 As String
    Public Property トーナメント4_カテゴリ番号 As String


    Public Sub JSON書き出し(filepath As String)

        Dim filename = "JS_Disp_BR.json"

        If filepath = "" Then
            filepath = System.Environment.CurrentDirectory
        End If



        ''JSONにシリアライズする
        Dim jText = JsonConvert.SerializeObject(Me, Formatting.Indented)

        ''元のファイルに出力する
        Using writer = New System.IO.StreamWriter(filepath & "\" & filename, False, System.Text.Encoding.GetEncoding("shift-jis"))
            writer.WriteLine(jText)
        End Using

    End Sub


    Public Function JSON読み込み(filepath As String) As Integer
        'ファイルが存在しない時は、１を返す。正常時は 0を返す。

        Dim rc As Integer = 0

        Dim filename = "JS_Disp_BR.json"

        If filepath = "" Then
            filepath = System.Environment.CurrentDirectory
        End If

        If Dir(filepath & "\" & filename).ToUpper <> filename.ToUpper Then
            'ファイルが存在しない
            rc = 1

        Else
            'ファイルが存在した
            rc = 0

            ''JSON読み込み用
            Dim jText As String = String.Empty

            ''ファイルからJSONを読み込む
            Dim cReader As New System.IO.StreamReader(filepath & "\" & filename, System.Text.Encoding.Default)


            jText = cReader.ReadToEnd


            ''文字列をJSONにデシリアライズ
            Dim jObj As Object = JsonConvert.DeserializeObject(jText)


            Me.システムPATH = jObj.SelectToken("システムPATH").value
            Me.IMGPATH = jObj.SelectToken("IMGPATH").value
            Me.SCファイルPATH = jObj.SelectToken("SCファイルPATH").value
            Me.選手写真IMGPATH = jObj.SelectToken("選手写真IMGPATH").value
            Me.システムPATH = jObj.SelectToken("システムPATH").value

            Me.トーナメント1_人数 = jObj.SelectToken("トーナメント1_人数").value
            Me.トーナメント1_カテゴリ番号 = jObj.SelectToken("トーナメント1_カテゴリ番号").value

            Me.トーナメント2_人数 = jObj.SelectToken("トーナメント2_人数").value
            Me.トーナメント2_カテゴリ番号 = jObj.SelectToken("トーナメント2_カテゴリ番号").value

            Me.トーナメント3_人数 = jObj.SelectToken("トーナメント3_人数").value
            Me.トーナメント3_カテゴリ番号 = jObj.SelectToken("トーナメント3_カテゴリ番号").value

            Me.トーナメント4_人数 = jObj.SelectToken("トーナメント4_人数").value
            Me.トーナメント4_カテゴリ番号 = jObj.SelectToken("トーナメント4_カテゴリ番号").value
        End If

        Return rc

    End Function

End Class
