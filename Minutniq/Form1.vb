Public Class Form1

    Private Sub BSettings_Click(sender As Object, e As EventArgs) Handles BSettings.Click
        MSettings.Show(BSettings, 0, BSettings.Height)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        GlobalData.Time.t = 600
        GlobalData.Reset()
        LTime.Text = GlobalData.ToString()
        LTime.ForeColor = Color.Green
    End Sub

    Private Sub OTimer_Tick(sender As Object, e As EventArgs) Handles OTimer.Tick
        If Not GlobalData.Backtick() Then
            OTimer.Enabled = False
            BStart.Text = "▶"
            Beep()
        End If

        LTime.Text = GlobalData.ToString()
        If LTime.ForeColor = Color.Red Then
            Return
        ElseIf GlobalData.Time.t / 8 > GlobalData.Left.t Then
            LTime.ForeColor = Color.Red
        ElseIf LTime.ForeColor = Color.Orange Then
            Return
        ElseIf GlobalData.Time.t / 4 > GlobalData.Left.t Then
            LTime.ForeColor = Color.Orange
        ElseIf LTime.ForeColor = Color.Gold Then
            Return
        ElseIf GlobalData.Time.t / 2 > GlobalData.Left.t Then
            LTime.ForeColor = Color.Gold
        End If
    End Sub

    Private Sub BStart_Click(sender As Object, e As EventArgs) Handles BStart.Click
        If OTimer.Enabled Then
            OTimer.Enabled = False
            BStart.Text = "▶"
        Else
            OTimer.Enabled = True
            LTime.ForeColor = Color.Green
            BStart.Text = "❚❚"
        End If
    End Sub

    Private Sub CTime_Click(sender As Object, e As EventArgs) Handles CTime.Click
        Me.TopMost = False
        If TimeSettings.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GlobalData.Reset()
            LTime.Text = GlobalData.ToString()
        End If
        Me.TopMost = True
    End Sub

    Private Sub CReset_Click(sender As Object, e As EventArgs) Handles CReset.Click
        OTimer.Enabled = False
        GlobalData.Reset()
        LTime.ForeColor = Color.Green
        LTime.Text = GlobalData.ToString()
        BStart.Text = "▶"
    End Sub

    Private Sub CFont_Click(sender As Object, e As EventArgs) Handles CFont.Click
        DFont.Font = LTime.Font
        If DFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LTime.Font = DFont.Font
        End If
    End Sub

    Private Sub CAbout_Click(sender As Object, e As EventArgs) Handles CAbout.Click
        MessageBox.Show(
            "Matriksoft Minutniq" + Environment.NewLine + "wersja 0.95" + Environment.NewLine + Environment.NewLine + "© 2015 Mateusz Karcz, UKLO Tczew." + Environment.NewLine + "Na zlecenie pani Bożeny Klein.",
            "Matriksoft Minutniq",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub
End Class
