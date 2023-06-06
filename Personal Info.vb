Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Personal_Info
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connectionString As String = "Data Source =  Z4P5-062; Initial Catalog = FA; Trusted_Connection = True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "INSERT INTO PersonalInfo (name, age, occupation, email, health, weight, height) VALUES (@name, @age, @occupation, @email, @health, @weight, @height)"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@name", tbName.Text)
        command.Parameters.AddWithValue("@age", tbAge.Text)
        command.Parameters.AddWithValue("@occupation", tbOccupation.Text)
        command.Parameters.AddWithValue("@email", tbEmail.Text)
        command.Parameters.AddWithValue("@health", tbHealth.Text)
        command.Parameters.AddWithValue("@height", tbHeight.Text)
        command.Parameters.AddWithValue("@weight", tbWeight.Text)
        command.ExecuteNonQuery()
        MsgBox("Saved Succesfully")
        connection.Close()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim connectionString As String = "Data Source =  Z4P5-062; Initial Catalog = FA; Trusted_Connection = True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "UPDATE PersonalInfo SET name = @Searchname"
        Dim command As New SqlCommand(query, connection)


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connectionString As String = "Data Source =  Z4P5-062; Initial Catalog = FA; Trusted_Connection = True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "SELECT * FROM PersonalInfo WHERE name = @Searchname"
        Dim command As New SqlCommand(query, connection)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            tbName.Text = reader("Searchname").ToString()
            tbAge.Text = reader("age").ToString()
            tbEmail.Text = reader("email").ToString()
            tbOccupation.Text = reader("occupation").ToString()
            tbHealth.Text = reader("health").ToString()
            tbWeight.Text = reader("weight").ToString()
            tbHeight.Text = reader("height").ToString()

        End While
        connection.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim weight As Decimal = Val(tbWeight.Text)
        Dim height As Decimal = Val(tbHeight.Text)

        Dim bmi As Decimal
        bmi = (weight / height) * 703
        tbBMI.Text = bmi.ToString()

        If bmi < 18.5 Then
            MsgBox("Underweight")
        ElseIf bmi >= 18.5 And bmi <= 24.9 Then
            MsgBox("Normal weight")
        ElseIf bmi > 25 And bmi < 30 Then
            MsgBox("Overweigt")
        ElseIf bmi > 30 Then
            MsgBox("Overweight")
        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim connectionString As String = "Data Source =  Z4P5-062; Initial Catalog = FA; Trusted_Connection = True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()

        Dim query As String = "DELETE FROM PersonalInfo WHERE name = @name"
        Dim command As New SqlCommand(query, connection)

        Dim rowsAffected As Integer
        If rowsAffected > 0 Then
            MsgBox("Successfully deleted")
        Else
            MsgBox("Enter again")
        End If
        connection.Close()
    End Sub

    Private Sub WorkoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutToolStripMenuItem.Click
        Workouts.Show()
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