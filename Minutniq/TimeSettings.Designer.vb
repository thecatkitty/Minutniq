<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.THrs = New System.Windows.Forms.NumericUpDown()
        Me.TMins = New System.Windows.Forms.NumericUpDown()
        Me.TSecs = New System.Windows.Forms.NumericUpDown()
        Me.LHrs = New System.Windows.Forms.Label()
        Me.LMins = New System.Windows.Forms.Label()
        Me.LSecs = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.THrs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSecs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.OK_Button, 3)
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(3, 28)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(141, 26)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.Cancel_Button, 3)
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.Location = New System.Drawing.Point(150, 28)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(146, 26)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Anuluj"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.Controls.Add(Me.OK_Button, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.THrs, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TMins, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TSecs, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LHrs, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LMins, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LSecs, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cancel_Button, 3, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(299, 57)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'THrs
        '
        Me.THrs.Location = New System.Drawing.Point(3, 3)
        Me.THrs.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.THrs.Name = "THrs"
        Me.THrs.Size = New System.Drawing.Size(43, 20)
        Me.THrs.TabIndex = 0
        '
        'TMins
        '
        Me.TMins.Location = New System.Drawing.Point(101, 3)
        Me.TMins.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.TMins.Name = "TMins"
        Me.TMins.Size = New System.Drawing.Size(43, 20)
        Me.TMins.TabIndex = 1
        Me.TMins.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TSecs
        '
        Me.TSecs.Location = New System.Drawing.Point(199, 3)
        Me.TSecs.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.TSecs.Name = "TSecs"
        Me.TSecs.Size = New System.Drawing.Size(43, 20)
        Me.TSecs.TabIndex = 2
        '
        'LHrs
        '
        Me.LHrs.AutoSize = True
        Me.LHrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LHrs.Location = New System.Drawing.Point(52, 0)
        Me.LHrs.Name = "LHrs"
        Me.LHrs.Size = New System.Drawing.Size(43, 25)
        Me.LHrs.TabIndex = 4
        Me.LHrs.Text = "h"
        Me.LHrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LMins
        '
        Me.LMins.AutoSize = True
        Me.LMins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LMins.Location = New System.Drawing.Point(150, 0)
        Me.LMins.Name = "LMins"
        Me.LMins.Size = New System.Drawing.Size(43, 25)
        Me.LMins.TabIndex = 5
        Me.LMins.Text = "min"
        Me.LMins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSecs
        '
        Me.LSecs.AutoSize = True
        Me.LSecs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LSecs.Location = New System.Drawing.Point(248, 0)
        Me.LSecs.Name = "LSecs"
        Me.LSecs.Size = New System.Drawing.Size(48, 25)
        Me.LSecs.TabIndex = 6
        Me.LSecs.Text = "s"
        Me.LSecs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(299, 57)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TimeSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ustaw czas odliczania"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.THrs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSecs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents THrs As System.Windows.Forms.NumericUpDown
    Friend WithEvents TMins As System.Windows.Forms.NumericUpDown
    Friend WithEvents TSecs As System.Windows.Forms.NumericUpDown
    Friend WithEvents LHrs As System.Windows.Forms.Label
    Friend WithEvents LMins As System.Windows.Forms.Label
    Friend WithEvents LSecs As System.Windows.Forms.Label

End Class
