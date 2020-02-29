Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_get_data.Click
        'Ref:https : //stackoverflow.com/questions/5818116/how-to-get-the-source-code-of-a-html-page-using-vb-net
        Dim data_url As String = "https://data.nhi.gov.tw/Datasets/Download.ashx?rid=A21030000I-D50001-001&l=https://data.nhi.gov.tw/resource/mask/maskdata.csv"
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(data_url)
        btn_get_data.Text = "載入資料中..."
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())


        Dim line As String = vbNull
        Dim data_arr() As String
        Dim y As Integer
        sr.ReadLine() '標題列先讀出來丟掉
        While (sr.Peek() >= 0)
            line = sr.ReadLine()
            data_arr = line.Split(",")
            Int32.TryParse(data_arr(4), y)
            If (data_arr(2).IndexOf(tb_query.Text.Trim()) >= 0 And y > 0) Then
                tb_content.Text = tb_content.Text + data_arr(1) + ",成人口罩量:" + data_arr(4) + vbNewLine
            End If
        End While


        btn_get_data.Text = "取得口罩資料"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.CheckForIllegalCrossThreadCalls = False 'Ref:https://lionrex.pixnet.net/blog/post/82712165
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
