Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.GetParentPath(My.Computer.FileSystem.CurrentDirectory)
        My.Computer.FileSystem.CurrentDirectory = My.Computer.FileSystem.GetParentPath(My.Computer.FileSystem.CurrentDirectory)
        Using MyReader As New FileIO.TextFieldParser("Test.txt")
            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.Delimiters = New String() {"\n"}
            Dim currLine As String
            While Not MyReader.EndOfData
                currLine = MyReader.ReadLine()
                lst1.Items.Add(currLine)
                currLine = ""
            End While


        End Using
        ' lst1.Items.Add(My.Computer.FileSystem.CurrentDirectory)
    End Sub
End Class
