Imports System.IO
Imports Scoreboard.Form1
Module Module1
    Public counterL As Integer
    Public counterR As Integer
    Public teamL As String
    Public teamR As String
    Public qtr As String
    Public count As Integer = 1

    Public Function checkCB(ByRef cb As ComboBox) As String
        If cb.SelectedIndex = 0 Then
            Return "ANT"
        ElseIf cb.SelectedIndex = 1 Then
            Return "BTR"
        ElseIf cb.SelectedIndex = 2 Then
            Return "LDY"
        ElseIf cb.SelectedIndex = 3 Then
            Return "RED"
        ElseIf cb.SelectedIndex = 4 Then
            Return "SMN"
        ElseIf cb.SelectedIndex = 5 Then
            Return "ORB"
        ElseIf cb.SelectedIndex = 6 Then
            Return "DRM"
        Else
            Return ""
        End If
    End Function

    Public Sub write(ByRef filename As String, ByRef value As String)
        Dim filePath As String = Application.StartupPath & filename
        Dim contents As String = value

        File.WriteAllText(filePath, contents)
    End Sub

    Public Sub reset()
        counterL = 0
        Form1.lblScoreL.Text = counterL
        counterR = 0
        Form1.lblScoreR.Text = counterR
        Form1.cbTeamsL.SelectedIndex = -1
        Form1.cbTeamsR.SelectedIndex = -1
        teamL = ""
        teamR = ""
        qtr = "QUARTER 1"
        count = 1
        Form1.btnQtr.Text = qtr
        Form1.cbTeamsL.Enabled = True
        Form1.cbTeamsR.Enabled = True
        write("\Overlay\scoreLeft.txt", counterL)
        write("\Overlay\scoreRight.txt", counterR)
        write("\Overlay\teamL.txt", teamL)
        write("\Overlay\teamR.txt", teamR)
        write("\Overlay\qtr.txt", qtr)
    End Sub

    Public Sub RenameFile(oldFilePath As String, newFileName As String)
        Try
            ' Check if the file exists before renaming it
            If File.Exists(oldFilePath) Then
                ' Get the directory path of the old file
                Dim directoryPath As String = Path.GetDirectoryName(oldFilePath)

                ' Combine the directory path and the new file name to create the new file path
                Dim newFilePath As String = Path.Combine(directoryPath, newFileName)

                ' Rename the file by moving it to the new file path
                File.Move(oldFilePath, newFilePath)

                ' Display a success message if required
                MessageBox.Show("File renamed successfully.")
            Else
                MessageBox.Show("File does not exist.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error while finding the file: " & ex.Message)
        End Try
    End Sub

    '' Usage example:
    'Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
    '    Dim oldFilePath As String = "C:\path\to\oldfile.txt" ' Replace this with the path of the old file
    '    Dim newFileName As String = "newfile.txt" ' Replace this with the new file name

    '    RenameFile(oldFilePath, newFileName)
    'End Sub

End Module


'make a preset where you can make or save your current setting
'preset includes the name of the league, the teams, the category and the images


