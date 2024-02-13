Imports System.Diagnostics.Eventing.Reader
Imports System.Diagnostics.Metrics
Imports System.IO
Imports System
Imports System.Threading
Imports OBSWebsocketDotNet
Imports OBSWebsocketDotNet.Communication

Public Class Form1
    Private WithEvents obs As OBSWebsocket
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        reset()
        obs = New OBSWebsocket()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.J Then
            btnPlusR.PerformClick()
        End If
        If e.KeyCode = Keys.M Then
            btnMinusR.PerformClick()
        End If
        If e.KeyCode = Keys.F Then
            btnPlusL.PerformClick()
        End If
        If e.KeyCode = Keys.V Then
            btnMinusL.PerformClick()
        End If
        If e.KeyCode = Keys.R Then
            cbTeamsL.DroppedDown = True
            cbTeamsL.Focus()
        End If
        If e.KeyCode = Keys.U Then
            cbTeamsR.DroppedDown = True
            cbTeamsR.Focus()
        End If
        If e.KeyCode = Keys.R Then
            cbTeamsL.DroppedDown = True
        End If
        If e.KeyCode = Keys.Q Then
            btnQtr.PerformClick()
        End If
        If e.KeyCode = Keys.Delete Then
            btnReset.PerformClick()
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        reset()
    End Sub


    Private Sub btnPlusL_Click(sender As Object, e As EventArgs) Handles btnPlusL.Click
        counterL += 1
        lblScoreL.Text = counterL
        write("\Overlay\scoreLeft.txt", counterL)
    End Sub

    Private Sub btnMinusL_Click(sender As Object, e As EventArgs) Handles btnMinusL.Click
        If Not counterL < 1 Then
            counterL -= 1
            lblScoreL.Text = counterL
            write("\Overlay\scoreLeft.txt", counterL)
        End If
    End Sub

    Private Sub btnPlusR_Click(sender As Object, e As EventArgs) Handles btnPlusR.Click
        counterR += 1
        lblScoreR.Text = counterR
        write("\Overlay\scoreRight.txt", counterR)
    End Sub

    Private Sub btnMinusR_Click(sender As Object, e As EventArgs) Handles btnMinusR.Click
        If Not counterR < 1 Then
            counterR -= 1
            lblScoreR.Text = counterR
            write("\Overlay\scoreRight.txt", counterR)
        End If
    End Sub

    Private Sub cbTeamL_DropDownClosed(sender As Object, e As EventArgs) Handles cbTeamsL.DropDownClosed
        teamL = checkCB(cbTeamsL)
        write("\Overlay\teamL.txt", teamL)
        lblScoreL.Focus()
        cbTeamsL.Enabled = False
    End Sub

    Private Sub cbTeamsR_DropDownClosed(sender As Object, e As EventArgs) Handles cbTeamsR.DropDownClosed
        teamR = checkCB(cbTeamsR)
        write("\Overlay\teamR.txt", teamR)
        lblScoreR.Focus()
        cbTeamsR.Enabled = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If MsgBox("Reset data?", vbQuestion + vbYesNo, "") = vbYes Then
            reset()
        End If
    End Sub


    Private Sub btnQtr_Click(sender As Object, e As EventArgs) Handles btnQtr.Click
        count += 1
        If count = 2 Then
            qtr = "QUARTER 2"
        ElseIf count = 3 Then
            qtr = "QUARTER 3"
        ElseIf count = 4 Then
            qtr = "QUARTER 4"
        End If
        btnQtr.Text = qtr
        write("\Overlay\qtr.txt", qtr)
    End Sub

    Private Sub btnQtr_MouseWheel(sender As Object, e As MouseEventArgs) Handles btnQtr.MouseWheel
        If Not count <= 1 Then
            count -= 1
            If count = 1 Then
                qtr = "QUARTER 1"
            ElseIf count = 2 Then
                qtr = "QUARTER 2"
            ElseIf count = 3 Then
                qtr = "QUARTER 3"
            ElseIf count = 4 Then
                qtr = "QUARTER 4"
            End If
            btnQtr.Text = qtr
            write("\Overlay\qtr.txt", qtr)
        End If
    End Sub

    Private Sub alwaysOnTop_CheckStateChanged(sender As Object, e As EventArgs) Handles alwaysOnTop.CheckStateChanged
        If alwaysOnTop.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub

    'for obs websocket
    '<Obsolete>
    'Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
    '    ' Connect to OBS Studio running on localhost
    '    obs.Connect("ws://localhost:4444", "")

    '    ' Wait until the connection is established (You can also use events for this)
    '    Thread.Sleep(1000)

    '    ' Execute some basic OBS actions
    '    If obs.IsConnected Then
    '        MsgBox("Connected")
    '    Else
    '        MessageBox.Show("Connection to OBS Studio failed.")
    '    End If
    'End Sub

    'Private Sub obs_Connected(sender As Object, e As EventArgs) Handles obs.Connected
    '    Console.WriteLine("Connected to OBS Studio.")
    'End Sub

    'Private Sub obs_Disconnected(sender As Object, e As ObsDisconnectionInfo) Handles obs.Disconnected
    '    Console.WriteLine("Disconnected from OBS Studio.")
    'End Sub

End Class
