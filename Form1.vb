Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Form1

    Private Const strKAHOOTFILE As String = "vbchapter5kahoot.json"
    Private answers As New List(Of ...)


    Dim time As Integer = lblTimer.Text = Timer.ToString



    Private Class LoadDataFileFromFile


        Dim reader As New IO.StreamReader(strKAHOOTFILE)
        Dim STR As String = reader.ReadToEnd

        'converting json file to collection of objects 

        answers = jsonconvert.deserializebject(of list)()


    End Class

    Public Class 

End Class
