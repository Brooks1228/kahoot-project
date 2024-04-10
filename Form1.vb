Imports System.Windows.Forms.VisualStyles
Imports Newtonsoft.Json

Public Class Form1

    Private questionList As New List(Of Question)
    Private questionIndex As Integer = 0
    Private Const CORRECTTAG As String = "Correct"
    Private timeleft As Integer = 0
    Private score As Integer = 0
    Private totalQuestions As Integer

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
        totalQuestions = questionList.Count
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataFileFromFile("vbchapter5kahoot.json")

        resetGame()
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

    Sub resetGame()
        questionIndex = 0
        LoadQuestion()
    End Sub



    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        openQuestionJson.DefaultExt = "json"
        openQuestionJson.Filter = "json files|*.json|All files|*.*"
        openQuestionJson.Title = "Select your question JSON"
        If openQuestionJson.ShowDialog = DialogResult.OK Then
            'MsgBox(OpenQuestionJSON.FileName)
            LoadDataFileFromFile(openQuestionJson.FileName)
            'printQuestions()
            resetGame()
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
    Sub LoadQuestion()
        Timer1.Stop()
        pnlAnswers.Controls.Clear()
        Dim currentQuestion As Question = questionList(questionIndex)
        lblQuestion.Text = currentQuestion.question
        Dim totalbuttons As Integer = currentQuestion.answers.Count
        Dim buttonWidth As Integer = pnlAnswers.Width / 2
        Dim buttonHeight As Integer = pnlAnswers.Height / Math.Ceiling(totalbuttons / 2.0)
        For i As Integer = 0 To totalbuttons - 1

            Dim answerButton = New Button With {
                .Text = currentQuestion.answers(i),
                .Location = New Point((i Mod 2) * buttonWidth, Math.Floor((i) / 2.0) * buttonHeight),
                .Width = buttonWidth,
                .Height = buttonHeight}
            If currentQuestion.correct = i Then
                answerButton.Tag = CORRECTTAG

            End If

            AddHandler answerButton.Click, AddressOf HandleAnswerButton
            pnlAnswers.Controls.Add(answerButton)

        Next
        timeleft = currentQuestion.time
        lblTimer.Text = timeleft.ToString
        Timer1.Start()

    End Sub
    Private Sub HandleAnswerButton(sender As Button, e As EventArgs)
        Timer1.Stop()

        If sender.Tag = CORRECTTAG Then
            MsgBox("You got it!")
            score += 1
            lblScore.Text = score.ToString
        Else
            MsgBox("Wrong!")

        End If

        questionIndex += 1

        If questionIndex < questionList.Count Then
            LoadQuestion()
        Else
            MsgBox($"you got {score}/{totalQuestions} right!")
        End If
    End Sub

    Private Sub ResetGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetGameToolStripMenuItem.Click
        resetGame()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeleft -= 1
        lblTimer.Text = timeleft.ToString

        If timeleft <= 0 Then

            Timer1.Stop()
            MsgBox("out of time!")
            questionIndex += 1
            If questionIndex < questionList.Count Then
                LoadQuestion()
            Else
                MsgBox($"you got {score}/{totalQuestions} right!")
            End If
        End If
    End Sub
End Class

Public Class Question

    Public question As String
    Public time As Integer
    Public answers As List(Of String)
    Public correct As Integer
End Class