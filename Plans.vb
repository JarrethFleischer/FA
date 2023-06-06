Public Class Plans
    Private Sub WorkoutsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutsToolStripMenuItem.Click
        Workouts.Show()
        Me.Hide()
    End Sub

    Private Sub SocialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialToolStripMenuItem.Click
        Social.Show()
        Me.Hide()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PersonalInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalInfoToolStripMenuItem.Click
        Personal_Info.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class