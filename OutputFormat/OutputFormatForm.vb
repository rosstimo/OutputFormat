Option Strict On
Option Explicit On

Public Class OutputFormatForm

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click

        'Display multi-line formatted text
        'DisplayLabel.Text = "1. Display a line of text" & vbNewLine _
        '                    & "2. Display a line of text" & vbNewLine _
        '                    & "3. Display a line of text" & vbNewLine _
        '                    & "4. Display a line of text"

        DisplayLabel.Text = Trim(StrReverse(FirstNameTextBox.Text)) & " " & Trim(StrReverse(LastNameTextBox.Text))
        AgeTextBox.Text = FirstNameTextBox.Text.ToLower & LastNameTextBox.Text.ToLower & "@acme.net"

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
