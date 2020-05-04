Public Class Form1
    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Me.Hide()
        Form2.Show()


    End Sub

    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit application
        Application.Exit()
    End Sub
End Class
