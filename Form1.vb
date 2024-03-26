Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports Newtonsoft.Json

Public Class Form1



    Private questionList As New List(Of Question)
    ' Private filename As String = "C:\Users\CMP_HoGoodwill\Downloads\vbchapter5kahoot.json"
    Private Sub writeout()

        For i As Integer = 0 To questionList.Count - 1

            Console.WriteLine(questionList(i))

        Next

    End Sub

    Private Sub LoadDataFileFromFile(filename As String)

        questionList.Clear()
        Dim reader As New IO.StreamReader(filename)
        Dim STR As String = reader.ReadToEnd

        'converting json file to collection of objects 

        questionList = JsonConvert.DeserializeObject(Of List(Of Question))(STR)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataFileFromFile("vbchapter5kahoot.json")

    End Sub

End Class

Public Class Question

    Public question As String
    Public time As Integer
    Public answers As List(Of String)
    Public correct As Integer

End Class

