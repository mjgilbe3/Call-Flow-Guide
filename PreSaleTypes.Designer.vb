<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreSaleTypes
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
        PostGreenButton = New Button()
        PreGreenButton = New Button()
        PartnershipButton = New Button()
        SuspendLayout()
        ' 
        ' PostGreenButton
        ' 
        PostGreenButton.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        PostGreenButton.Location = New Point(453, 12)
        PostGreenButton.Margin = New Padding(4, 3, 4, 3)
        PostGreenButton.Name = "PostGreenButton"
        PostGreenButton.Size = New Size(197, 119)
        PostGreenButton.TabIndex = 9
        PostGreenButton.Text = "Post-Green"
        PostGreenButton.UseVisualStyleBackColor = True
        ' 
        ' PreGreenButton
        ' 
        PreGreenButton.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        PreGreenButton.Location = New Point(231, 12)
        PreGreenButton.Margin = New Padding(4, 3, 4, 3)
        PreGreenButton.Name = "PreGreenButton"
        PreGreenButton.Size = New Size(197, 119)
        PreGreenButton.TabIndex = 8
        PreGreenButton.Text = "Pre-Green"
        PreGreenButton.UseVisualStyleBackColor = True
        ' 
        ' PartnershipButton
        ' 
        PartnershipButton.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        PartnershipButton.Location = New Point(11, 12)
        PartnershipButton.Margin = New Padding(4, 3, 4, 3)
        PartnershipButton.Name = "PartnershipButton"
        PartnershipButton.Size = New Size(197, 119)
        PartnershipButton.TabIndex = 7
        PartnershipButton.Text = "Partnership Lead"
        PartnershipButton.UseVisualStyleBackColor = True
        ' 
        ' PreSaleTypes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(666, 145)
        Controls.Add(PostGreenButton)
        Controls.Add(PreGreenButton)
        Controls.Add(PartnershipButton)
        Name = "PreSaleTypes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "What type of Pre-Sale call?"
        ResumeLayout(False)
    End Sub

    Friend WithEvents PostGreenButton As Button
    Friend WithEvents PreGreenButton As Button
    Friend WithEvents PartnershipButton As Button
End Class
