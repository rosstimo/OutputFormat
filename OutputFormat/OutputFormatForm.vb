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
        Dim status As Boolean = True

        Try
            If CInt(AgeTextBox.Text) > 42 Then
                problemMessage &= "You are too old!" & vbNewLine
            End If
        Catch ex As Exception
            problemMessage &= "Age should be a number" & vbNewLine
            status = False
            'AgeTextBox.Focus()
        End Try

        If LastNameTextBox.Text = "" Then
            problemMessage &= "Last name is required" & vbNewLine
            status = False
            'LastNameTextBox.Focus()
        End If

        If FirstNameTextBox.Text = "" Then
            problemMessage &= "First name is required" & vbNewLine
            status = False
            FirstNameTextBox.BackColor = Color.LightYellow
            'FirstNameTextBox.Focus()
        Else
            FirstNameTextBox.BackColor = Color.White
        End If

        If problemMessage <> "" Then
            status = False
            'MsgBox(problemMessage)
        End If

        Return status
    End Function

    Private Sub OutputFormatForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        DisplayButton.Enabled = False

    End Sub

    Private Sub FirstNameTextBox_Leave(sender As Object, e As EventArgs) Handles FirstNameTextBox.Leave,
                                                                                    LastNameTextBox.Leave,
                                                                                    AgeTextBox.Leave

        'MsgBox("We got it")

        If ValidateFeilds() Then
            DisplayButton.Enabled = True
        Else
            DisplayButton.Enabled = False
        End If

    End Sub
End Class
