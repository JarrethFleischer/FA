Public Class Workouts
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim duration As Decimal = Val(tbDuration.Text)
        Dim reps As Decimal = Val(tbReps.Text)

        Dim calories As Decimal
        calories = (duration * reps) * 1.375
        lblCalories.Text = calories.ToString()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub PersonalInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalInfoToolStripMenuItem.Click
        Personal_Info.Show()
        Me.Hide()

    End Sub

    Private Sub WorkoutFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutFormToolStripMenuItem.Click
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub PlansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlansToolStripMenuItem.Click
        Plans.Show()
        Me.Hide()

    End Sub

    Private Sub SocialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialToolStripMenuItem.Click
        Social.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class