Public Class Form1
    Private Sub btnLook_Click(sender As Object, e As EventArgs) Handles btnLook.Click
        Dim vals(2) As Integer
        vals(0) = 4
        vals(1) = 7
        vals(2) = 9
        Dim found As Boolean = False
        Dim key As Integer = CInt(txt1.Text)

        For i = 0 To vals.Length - 1
            If (vals(i) = key) Then
                found = True

            End If
        Next
        txt2.Text = CStr(found)
    End Sub
End Class
