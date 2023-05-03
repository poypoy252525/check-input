Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles input.TextChanged
        If input.Text = "a" Or input.Text = "A" Then
            output.Text = "It's a vowel!"
        ElseIf input.Text = "e" Or input.Text = "E" Then
            output.Text = "It's a vowel!"
        ElseIf input.Text = "i" Or input.Text = "I" Then
            output.Text = "It's a vowel!"
        ElseIf input.Text = "o" Or input.Text = "O" Then
            output.Text = "It's a vowel!"
        ElseIf input.Text = "u" Or input.Text = "U" Then
            output.Text = "It's a vowel!"
        Else
            output.Text = "It's a consonant!"
        End If

    End Sub
End Class
