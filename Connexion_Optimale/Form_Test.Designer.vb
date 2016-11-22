<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Test
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxT_Aff = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxT_Aff
        '
        Me.TxT_Aff.Location = New System.Drawing.Point(12, 12)
        Me.TxT_Aff.Multiline = True
        Me.TxT_Aff.Name = "TxT_Aff"
        Me.TxT_Aff.Size = New System.Drawing.Size(258, 231)
        Me.TxT_Aff.TabIndex = 0
        '
        'Form_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.TxT_Aff)
        Me.Name = "Form_Test"
        Me.Text = "Form_Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxT_Aff As System.Windows.Forms.TextBox

End Class
