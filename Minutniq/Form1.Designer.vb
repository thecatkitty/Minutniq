<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BStart = New System.Windows.Forms.Button()
        Me.BSettings = New System.Windows.Forms.Button()
        Me.LTime = New System.Windows.Forms.Label()
        Me.MSettings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.CReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.S1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.DFont = New System.Windows.Forms.FontDialog()
        Me.OTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout
        Me.MSettings.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.BStart, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BSettings, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LTime, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 61)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BStart
        '
        Me.BStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BStart.Location = New System.Drawing.Point(3, 3)
        Me.BStart.Name = "BStart"
        Me.BStart.Size = New System.Drawing.Size(44, 24)
        Me.BStart.TabIndex = 0
        Me.BStart.Text = "▶"
        Me.BStart.UseVisualStyleBackColor = True
        '
        'BSettings
        '
        Me.BSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BSettings.Location = New System.Drawing.Point(3, 33)
        Me.BSettings.Name = "BSettings"
        Me.BSettings.Size = New System.Drawing.Size(44, 25)
        Me.BSettings.TabIndex = 1
        Me.BSettings.Text = "⏰"
        Me.BSettings.UseVisualStyleBackColor = True
        '
        'LTime
        '
        Me.LTime.AutoSize = True
        Me.LTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTime.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTime.Location = New System.Drawing.Point(53, 0)
        Me.LTime.Name = "LTime"
        Me.TableLayoutPanel1.SetRowSpan(Me.LTime, 2)
        Me.LTime.Size = New System.Drawing.Size(228, 61)
        Me.LTime.TabIndex = 2
        Me.LTime.Text = "Label1"
        Me.LTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSettings
        '
        Me.MSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTime, Me.CReset, Me.S1, Me.CFont, Me.CAbout})
        Me.MSettings.Name = "MSettings"
        Me.MSettings.ShowImageMargin = False
        Me.MSettings.Size = New System.Drawing.Size(126, 98)
        Me.MSettings.Text = "Ustawienia"
        '
        'CTime
        '
        Me.CTime.Name = "CTime"
        Me.CTime.Size = New System.Drawing.Size(125, 22)
        Me.CTime.Text = "Ustaw czas"
        '
        'CReset
        '
        Me.CReset.Name = "CReset"
        Me.CReset.Size = New System.Drawing.Size(125, 22)
        Me.CReset.Text = "Resetuj"
        '
        'S1
        '
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(122, 6)
        '
        'CFont
        '
        Me.CFont.Name = "CFont"
        Me.CFont.Size = New System.Drawing.Size(125, 22)
        Me.CFont.Text = "Czcionka"
        '
        'CAbout
        '
        Me.CAbout.Name = "CAbout"
        Me.CAbout.Size = New System.Drawing.Size(125, 22)
        Me.CAbout.Text = "O programie..."
        '
        'OTimer
        '
        Me.OTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 61)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = false
        Me.MinimumSize = New System.Drawing.Size(300, 100)
        Me.Name = "Form1"
        Me.Text = "Odliczanie"
        Me.TopMost = true
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.MSettings.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BStart As System.Windows.Forms.Button
    Friend WithEvents BSettings As System.Windows.Forms.Button
    Friend WithEvents LTime As System.Windows.Forms.Label
    Friend WithEvents MSettings As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DFont As System.Windows.Forms.FontDialog
    Friend WithEvents OTimer As System.Windows.Forms.Timer

End Class
