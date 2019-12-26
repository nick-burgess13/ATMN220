Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim sum As Integer
        For i = 2 To 10 Step 2
            sum += i
        Next
        txtOut.Text = CStr(sum)
    End Sub
End Class
