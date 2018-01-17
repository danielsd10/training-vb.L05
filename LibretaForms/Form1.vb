Imports System.Configuration
Imports AccesoDatos
Imports Entidades

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Contactos
        Dim lst As List(Of Persona)

        c = New Contactos()
        lst = c.ListarPersonas()

        ListBox1.DataSource = lst
        ListBox1.DisplayMember = "Nombre"
        ListBox1.ValueMember = "Id"
    End Sub
End Class
