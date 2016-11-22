Imports System.Data.OleDb
Imports System.Data.SqlClient
Public MustInherit Class Connexion
    'Classe abstraite (non-instanciable) innitiatrice de la connexion à la BDD
    Public cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim cnnString As String
    Public Sub New()
        cnnString = "Data Source = " + datasource + ";Database = " + database + "; User ID = " + user_ID + ";Password = " + pwd
        cnn = New SqlConnection(cnnString)
    End Sub

    Public Function sqlTransaction(ByVal sql) As Boolean
        'Fonction de test du fonctionnement de l'échange avec la BDD
        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            cnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
