<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        DeliveryPush = New Button()
        PostSale = New Button()
        PreSale = New Button()
        SuspendLayout()
        ' 
        ' DeliveryPush
        ' 
        DeliveryPush.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        DeliveryPush.Location = New Point(455, 12)
        DeliveryPush.Margin = New Padding(4, 3, 4, 3)
        DeliveryPush.Name = "DeliveryPush"
        DeliveryPush.Size = New Size(197, 119)
        DeliveryPush.TabIndex = 12
        DeliveryPush.Text = "Delivery Push"
        DeliveryPush.UseVisualStyleBackColor = True
        ' 
        ' PostSale
        ' 
        PostSale.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        PostSale.Location = New Point(233, 12)
        PostSale.Margin = New Padding(4, 3, 4, 3)
        PostSale.Name = "PostSale"
        PostSale.Size = New Size(197, 119)
        PostSale.TabIndex = 11
        PostSale.Text = "Post-Sale"
        PostSale.UseVisualStyleBackColor = True
        ' 
        ' PreSale
        ' 
        PreSale.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        PreSale.Location = New Point(13, 12)
        PreSale.Margin = New Padding(4, 3, 4, 3)
        PreSale.Name = "PreSale"
        PreSale.Size = New Size(197, 119)
        PreSale.TabIndex = 10
        PreSale.Text = "Pre-Sale"
        PreSale.UseVisualStyleBackColor = True
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(666, 145)
        Controls.Add(DeliveryPush)
        Controls.Add(PostSale)
        Controls.Add(PreSale)
        Name = "MainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Menu"
        ResumeLayout(False)
    End Sub

    Friend WithEvents DeliveryPush As Button
    Friend WithEvents PostSale As Button
    Friend WithEvents PreSale As Button
End Class
