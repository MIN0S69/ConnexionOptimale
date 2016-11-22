Public Class Form_Test
    Dim Con As BDD = New BDD
    Dim myView As DataView = New DataView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myView = Con.createView("TestConnection")
        Me.TxT_Aff.Text = ""
        For Each Ligne As DataRowView In myView
            Me.TxT_Aff.Text = Me.TxT_Aff.Text & vbCrLf & Ligne("PersonID") & " - " & Ligne("FirstName") & " - " & Ligne("LastName") & " - " & Ligne("ModifiedDate")
        Next
    End Sub
End Class
