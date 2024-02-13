Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        lblScoreL = New Label()
        lblScoreR = New Label()
        btnMinusL = New Button()
        btnPlusL = New Button()
        btnMinusR = New Button()
        btnPlusR = New Button()
        Label3 = New Label()
        cbTeamsL = New ComboBox()
        Label4 = New Label()
        cbTeamsR = New ComboBox()
        btnReset = New Button()
        btnQtr = New Button()
        MenuStrip1 = New MenuStrip()
        preferences = New ToolStripMenuItem()
        alwaysOnTop = New ToolStripMenuItem()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblScoreL
        ' 
        lblScoreL.BackColor = Color.Transparent
        lblScoreL.FlatStyle = FlatStyle.Flat
        lblScoreL.Font = New Font("Digital-7", 72F, FontStyle.Regular, GraphicsUnit.Point)
        lblScoreL.Location = New Point(13, 133)
        lblScoreL.Name = "lblScoreL"
        lblScoreL.Size = New Size(244, 215)
        lblScoreL.TabIndex = 0
        lblScoreL.Tag = "342"
        lblScoreL.Text = "0"
        lblScoreL.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblScoreR
        ' 
        lblScoreR.Font = New Font("Digital-7", 72F, FontStyle.Regular, GraphicsUnit.Point)
        lblScoreR.Location = New Point(485, 133)
        lblScoreR.Name = "lblScoreR"
        lblScoreR.Size = New Size(244, 215)
        lblScoreR.TabIndex = 1
        lblScoreR.Text = "0"
        lblScoreR.TextAlign = ContentAlignment.MiddleLeft
        lblScoreR.UseMnemonic = False
        ' 
        ' btnMinusL
        ' 
        btnMinusL.Font = New Font("Digital-7", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btnMinusL.Location = New Point(241, 246)
        btnMinusL.Name = "btnMinusL"
        btnMinusL.Size = New Size(67, 67)
        btnMinusL.TabIndex = 2
        btnMinusL.Text = "-"
        btnMinusL.UseVisualStyleBackColor = True
        ' 
        ' btnPlusL
        ' 
        btnPlusL.Font = New Font("Digital-7", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btnPlusL.Location = New Point(241, 173)
        btnPlusL.Name = "btnPlusL"
        btnPlusL.Size = New Size(67, 67)
        btnPlusL.TabIndex = 3
        btnPlusL.Text = "+"
        btnPlusL.UseVisualStyleBackColor = True
        ' 
        ' btnMinusR
        ' 
        btnMinusR.Font = New Font("Digital-7", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btnMinusR.Location = New Point(424, 246)
        btnMinusR.Name = "btnMinusR"
        btnMinusR.Size = New Size(67, 67)
        btnMinusR.TabIndex = 4
        btnMinusR.Text = "-"
        btnMinusR.UseVisualStyleBackColor = True
        ' 
        ' btnPlusR
        ' 
        btnPlusR.Font = New Font("Digital-7", 24F, FontStyle.Regular, GraphicsUnit.Point)
        btnPlusR.Location = New Point(424, 173)
        btnPlusR.Name = "btnPlusR"
        btnPlusR.Size = New Size(67, 67)
        btnPlusR.TabIndex = 5
        btnPlusR.Text = "+"
        btnPlusR.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 6
        Label3.Text = "TEAM:"
        ' 
        ' cbTeamsL
        ' 
        cbTeamsL.FormattingEnabled = True
        cbTeamsL.Items.AddRange(New Object() {"ANITA", "BISTRO", "LADY SLASHERS", "RED'S PLACE", "SM NEIGHBORHOOD", "ORBIZT", "DREAMERS"})
        cbTeamsL.Location = New Point(115, 113)
        cbTeamsL.Name = "cbTeamsL"
        cbTeamsL.Size = New Size(193, 33)
        cbTeamsL.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(422, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 25)
        Label4.TabIndex = 8
        Label4.Text = "TEAM:"
        ' 
        ' cbTeamsR
        ' 
        cbTeamsR.FormattingEnabled = True
        cbTeamsR.Items.AddRange(New Object() {"ANITA", "BISTRO", "LADY SLASHERS", "RED'S PLACE", "SM NEIGHBORHOOD", "ORBIZT", "DREAMERS"})
        cbTeamsR.Location = New Point(485, 113)
        cbTeamsR.Name = "cbTeamsR"
        cbTeamsR.Size = New Size(195, 33)
        cbTeamsR.TabIndex = 9
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(424, 341)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(150, 52)
        btnReset.TabIndex = 10
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnQtr
        ' 
        btnQtr.Location = New Point(158, 341)
        btnQtr.Name = "btnQtr"
        btnQtr.Size = New Size(150, 52)
        btnQtr.TabIndex = 12
        btnQtr.Text = "QUARTER 1"
        btnQtr.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {preferences})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(741, 33)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' preferences
        ' 
        preferences.DropDownItems.AddRange(New ToolStripItem() {alwaysOnTop})
        preferences.Name = "preferences"
        preferences.Size = New Size(118, 29)
        preferences.Text = "Preferences"
        ' 
        ' alwaysOnTop
        ' 
        alwaysOnTop.Checked = True
        alwaysOnTop.CheckOnClick = True
        alwaysOnTop.CheckState = CheckState.Checked
        alwaysOnTop.Name = "alwaysOnTop"
        alwaysOnTop.Size = New Size(229, 34)
        alwaysOnTop.Text = "Always on Top"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Mont Heavy DEMO", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(717, 41)
        Label1.TabIndex = 14
        Label1.Text = "ISABELA WOMEN'S BASKETBALL LEAGUE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Untitled_1_copy
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(741, 448)
        Controls.Add(Label1)
        Controls.Add(btnQtr)
        Controls.Add(btnReset)
        Controls.Add(cbTeamsR)
        Controls.Add(Label4)
        Controls.Add(cbTeamsL)
        Controls.Add(Label3)
        Controls.Add(btnPlusR)
        Controls.Add(btnMinusR)
        Controls.Add(btnPlusL)
        Controls.Add(btnMinusL)
        Controls.Add(lblScoreR)
        Controls.Add(lblScoreL)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Scoreboard by JoSep"
        TopMost = True
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblScoreL As Label
    Friend WithEvents lblScoreR As Label
    Friend WithEvents btnMinusL As Button
    Friend WithEvents btnPlusL As Button
    Friend WithEvents btnMinusR As Button
    Friend WithEvents btnPlusR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTeamsL As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTeamsR As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnQtr As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents preferences As ToolStripMenuItem
    Friend WithEvents alwaysOnTop As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
