Imports System.Windows.Forms

Public Class TimeSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        GlobalData.Time.t = (THrs.Value * 60 + TMins.Value) * 60 + TSecs.Value

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private SkipS = False
    Private Sub TSecs_ValueChanged(sender As Object, e As EventArgs) Handles TSecs.ValueChanged
        If SkipS Then
            Return
        End If
        SkipS = True
        If TSecs.Value = 60 Then
            TSecs.Value = 0
            TMins.Value += 1
        End If
        SkipS = False
    End Sub

    Private SkipM = False
    Private Sub TMins_ValueChanged(sender As Object, e As EventArgs) Handles TMins.ValueChanged
        If SkipM Then
            Return
        End If
        SkipM = True
        If TMins.Value = 60 Then
            TMins.Value = 0
            THrs.Value += 1
        End If
        SkipM = False
    End Sub
End Class
