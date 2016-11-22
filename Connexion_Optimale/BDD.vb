
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class BDD
    Inherits Connexion
    Public cmd As SqlCommand
    Dim reader As SqlDataReader

    Public Sub connectSQL()
        'Fonction de connexion à la BD 
        Try
            cnn.Open()
        Catch ex As Exception
            MessageBox.Show("Aucune connexion avec le serveur SQL!")
        End Try
    End Sub

    Public Sub disconnectSQL()
        'Fonction de déconnexion à la BD
        Try
            cnn.Close()
        Catch
        End Try
    End Sub
    Public Function createSet(ByVal Table As String) As DataSet
        'Fonction de création d'un dataSet a partir d'une table 
        connectSQL()
        cmd = New SqlCommand("SELECT * FROM " + Table, cnn)
        Dim sadapt As New SqlDataAdapter(cmd)
        Dim mySet As New DataSet
        sadapt.Fill(mySet, Table)
        disconnectSQL()
        Return mySet
    End Function
    Public Function createView(ByVal table As String) As DataView
        'Fonction de création d'une vue à partir d'une table
        Dim myData As DataSet = New DataSet
        Dim myView As DataView = New DataView

        myData = createSet(table)
        myView = newView(myData, table)
        myData.Tables.Clear()

        Return myView
    End Function
    Public Function newView(ByVal data As DataSet, ByVal table As String) As DataView
        'Fonction de création d'une vue à partir d'un dataSet 
        Dim myView As New DataView(data.Tables(table))
        Return myView
    End Function
End Class


