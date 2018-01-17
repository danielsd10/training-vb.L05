Imports AccesoDatos
Imports Entidades

Public Class frmContactos
    Private lPersonas As List(Of Persona)
    Private adContactos As Contactos

    Private Sub frmContactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adContactos = New Contactos()
        lPersonas = adContactos.ListarPersonas()

        For Each objPersona As Persona In lPersonas
            lstPersonas.Items.Add(objPersona)
        Next
        lstPersonas.DataSource = lPersonas
        lstPersonas.DisplayMember = "NombreCompleto"
        lstPersonas.ValueMember = "Id"
    End Sub

    Private Sub btnAgregarPersona_Click(sender As Object, e As EventArgs) Handles btnAgregarPersona.Click
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDNI.Text = ""
        txtDirec.Text = ""
        dtpFecNac.Value = DateTime.Now
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        lstPersonas.SelectedIndex = -1
        txtNombre.Focus()
    End Sub

    Private Sub lstPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPersonas.SelectedIndexChanged, lstPersonas.SelectedIndexChanged
        Dim objPersona As Persona
        If lstPersonas.SelectedIndex > -1 Then
            objPersona = lPersonas(lstPersonas.SelectedIndex)
            txtNombre.Text = objPersona.Nombre
            txtApellido.Text = objPersona.Apellido
            txtDNI.Text = objPersona.DNI
            txtDirec.Text = objPersona.Direccion
            dtpFecNac.Value = objPersona.FechaNacimiento
            btnGuardar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim objPersona As New Persona
        objPersona.Nombre = txtNombre.Text
        objPersona.Apellido = txtApellido.Text
        objPersona.DNI = txtDNI.Text
        objPersona.Direccion = txtDirec.Text
        objPersona.FechaNacimiento = dtpFecNac.Value

        If adContactos.RegistrarPersona(objPersona) Then
            lPersonas = adContactos.ListarPersonas()
            lstPersonas.DataSource = lPersonas
            lstPersonas.Refresh()
            MessageBox.Show("Se creó un nuevo contacto", "Nuevo Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se pudo crear el contacto", "Nuevo Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim objPersona As Persona

        If MessageBox.Show("¿Está seguro que desea eliminar el contacto?", "Eliminar Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            objPersona = lPersonas(lstPersonas.SelectedIndex)
            If adContactos.EliminarContacto(objPersona.Id) Then
                lPersonas = adContactos.ListarPersonas()
                lstPersonas.DataSource = lPersonas
                lstPersonas.Refresh()
                MessageBox.Show("Se eliminó el contacto", "Eliminar Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo eliminar el contacto", "Eliminar Contacto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class
