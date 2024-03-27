Imports System.Windows.Forms.VisualStyles
Imports Newtonsoft.Json

Public Class Form1


    Private questionList As New List(Of Question)

    Private Sub LoadDataFileFromFile(filename As String)
        'clear the list
        questionList.Clear()
        'populate the list with questions from the file
        Dim reader As New IO.StreamReader(filename)
        Dim str As String = reader.ReadToEnd
        'NEW
        'Convert json file to collection of objects
        questionList = JsonConvert.DeserializeObject(Of List(Of Question))(str)
        reader.Close()
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


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        openQuestionJson.DefaultExt = "json"
        openQuestionJson.Filter = "json files|*.json|All files|*.*"
        openQuestionJson.Title = "Select your question JSON"
        If openQuestionJson.ShowDialog = DialogResult.OK Then
            'MsgBox(OpenQuestionJSON.FileName)
            LoadDataFileFromFile(openQuestionJson.FileName)
            'printQuestions()
        End If
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        PrintQuestionsToConsole()
    End Sub
    Sub PrintQuestionsToConsole()
        'loop through the question list and print the question and the correct answer
        For i As Integer = 0 To questionList.Count - 1
            Dim currentQuestion As Question = questionList(i)
            Console.WriteLine(currentQuestion.question)
            Console.WriteLine(currentQuestion.answers(currentQuestion.correct))
            Console.WriteLine()
        Next
    End Sub
End Class

Public Class Question

    Public question As String
    Public time As Integer
    Public answers As List(Of String)
    Public correct As Integer
End Class