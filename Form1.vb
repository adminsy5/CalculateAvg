Public Class Form1
    Dim s1, s2, s3, s4, s5 As Integer
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        s1 = Val(sub1t.Text)
        s2 = Val(sub2t.Text)
        s3 = Val(sub3t.Text)
        s4 = Val(sub4t.Text)
        s5 = Val(sub5t.Text)

        totalt.Text = (s1 + s2 + s3 + s4 + s5)
        avgt.Text = totalt.Text / 5

        ' Dim per As Integer = Convert.ToInt32(avgt.Text)
        Try
            Select Case avgt.Text
                Case avgt.Text
                    If avgt.Text >= 70 Then
                        MsgBox("Distinction")
                        Return
                    ElseIf avgt.Text >= 60 Then
                        MsgBox("First Class")
                        Return
                    ElseIf avgt.Text >= 50 Then
                        MsgBox("Second Class")
                        Return
                    ElseIf avgt.Text >= 40 Then
                        MsgBox("Pass")
                        Return
                    Else
                        MsgBox("You Are Fail !")
                        Return
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
