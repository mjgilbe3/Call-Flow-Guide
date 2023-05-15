<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notepad
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
        Label1 = New Label()
        Notes = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(156, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 47)
        Label1.TabIndex = 0
        Label1.Text = "Notes:"
        ' 
        ' Notes
        ' 
        Notes.AcceptsReturn = True
        Notes.AcceptsTab = True
        Notes.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Notes.Location = New Point(12, 59)
        Notes.Multiline = True
        Notes.Name = "Notes"
        Notes.Size = New Size(422, 536)
        Notes.TabIndex = 1
        ' 
        ' Notepad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(448, 620)
        Controls.Add(Notes)
        Controls.Add(Label1)
        Name = "Notepad"
        StartPosition = FormStartPosition.Manual
        Text = "Notepad"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Notes As TextBox
End Class
