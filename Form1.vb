Imports System.Windows.Forms.VisualStyles
Imports Newtonsoft.Json

Public Class Form1


    Private questionList As New List(Of Question)

    Private Sub LoadDataFileFromFile(filename As String)

        questionList.Clear()
        Dim reader As New IO.StreamReader(filename)
        Dim STR As String = reader.ReadToEnd
        'converting json file to collection of objects 

        questionList = JsonConvert.DeserializeObject(Of List(Of Question))(STR)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataFileFromFile("vbchapter5kahoot.json")

        test()
    End Sub
    Private Sub test()
        For i As Integer = 0 To questionList.Count - 1
            Dim currentQuestion As Question = questionList(i)
            'Console.WriteLine(questionList(i))
            Console.WriteLine(currentQuestion.question)
            Console.WriteLine(currentQuestion.answers(currentQuestion.correct))
            Console.WriteLine()
        Next
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click


    End Sub
    Sub loadquestions(filename As String)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        openQuestionJson.DefaultExt = "json"
        openQuestionJson.Filter = "json files|*.json"
        openQuestionJson.Title = "Select your question files"
        If openQuestionJson.ShowDialog = DialogResult.OK Then
            'MsgBox(openQuestionJson.FileName)
            loadquestions(openQuestionJson.FileName)
        End If
    End Sub
End Class

Public Class Question
    Public question As String
    Public time As Integer
    Public answers As List(Of String)
    Public correct As Integer
End Class