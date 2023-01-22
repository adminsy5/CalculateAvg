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

    End Sub
End Class
