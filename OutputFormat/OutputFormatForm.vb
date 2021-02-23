Option Strict On
Option Explicit On

Public Class OutputFormatForm

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ValidateFeilds()
        'Display multi-line formatted text
        'DisplayLabel.Text = "1. Display a line of text" & vbNewLine _
        '                    & "2. Display a line of text" & vbNewLine _
        '                    & "3. Display a line of text" & vbNewLine _
        '                    & "4. Display a line of text"

        'DisplayLabel.Text = Trim(StrReverse(FirstNameTextBox.Text)) & " " & Trim(StrReverse(LastNameTextBox.Text))
        'AgeTextBox.Text = FirstNameTextBox.Text.ToLower & LastNameTextBox.Text.ToLower & "@acme.net"

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        AgeTextBox.Text = ""
        EmailTextBox.Text = ""
        ZipTextBox.Text = ""
        DisplayLabel.Text = ""
    End Sub

    Function ValidateFeilds() As Boolean
        Dim problemMessage As String

        'If AgeTextBox.Text = "" Then
        'problemMessage &= "Age is required" & vbNewLine
        'AgeTextBox.Focus()
        'Else
        Try
            If CInt(AgeTextBox.Text) > 42 Then
                problemMessage &= "You are too old!" & vbNewLine
            End If
        Catch ex As Exception
            problemMessage &= "Age should be a number" & vbNewLine
            AgeTextBox.Focus()
        End Try
        'End If

        If LastNameTextBox.Text = "" Then
            problemMessage &= "Last name is required" & vbNewLine
            LastNameTextBox.Focus()
        End If

        If FirstNameTextBox.Text = "" Then
            problemMessage &= "First name is required" & vbNewLine
            FirstNameTextBox.Focus()
        End If

        If problemMessage <> "" Then
            MsgBox(problemMessage)
        End If



        Return True
    End Function


End Class
