<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintTC
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
        Me.crtc = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crtc
        '
        Me.crtc.ActiveViewIndex = -1
        Me.crtc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crtc.DisplayGroupTree = False
        Me.crtc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crtc.Location = New System.Drawing.Point(0, 0)
        Me.crtc.Name = "crtc"
        Me.crtc.SelectionFormula = ""
        Me.crtc.Size = New System.Drawing.Size(763, 481)
        Me.crtc.TabIndex = 0
        Me.crtc.ViewTimeSelectionFormula = ""
        '
        'frmPrintTC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 481)
        Me.Controls.Add(Me.crtc)
        Me.Name = "frmPrintTC"
        Me.Text = "frmPrintTC"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crtc As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
