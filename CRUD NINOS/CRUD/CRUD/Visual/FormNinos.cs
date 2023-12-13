using CRUD.Objects;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Visual
{
    public partial class FormNinos : Form

    {
        private NinosConsultas ninosConsultas;
        public FormNinos()
        {
            InitializeComponent();
            ninosConsultas = new NinosConsultas();
            // Cargar la lista de niños al cargar el formulario
            RefreshNinos();
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }




        private void RefreshNinos()
        {
            try
            {
                // Actualizar la lista de niños en el DataGridView
                dgvNinos.DataSource = null;
                dgvNinos.DataSource = ninosConsultas.consultarNinos(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la lista de niños: {ex.Message}");
            }
        }
        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            txtNombre.Text = "";
            dtpFechaNacimiento.Text = "";
            txtTipoSangre.Text = "";
            txtCiudadNacimiento.Text = "";
            txtIdentificacionAcudiente.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEPS.Text = "";
            // Agregar otros campos según tu diseño
        }

        

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Agregar un nuevo niño
            Ninos nuevoNino = new Ninos
            {
                Nombre_n = txtNombre.Text,
                Fecha_nacimiento = dtpFechaNacimiento.Text,
                Tipo_sangre = txtTipoSangre.Text,
                Ciudad_nacimiento = txtCiudadNacimiento.Text,
                Identificacion_acudiente = int.Parse(txtIdentificacionAcudiente.Text),
                Telefono = int.Parse(txtTelefono.Text),
                Direccion_n = txtDireccion.Text,
                EPS = txtEPS.Text,
                Identificador_Jardin = int.Parse(txtIdentificadorJardin.Text)
                
            };

            if (ninosConsultas.agregarNinos(nuevoNino))
            {
                MessageBox.Show("Niño agregado correctamente");
                RefreshNinos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el niño");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNinos_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvNinos.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                dgvNinos.Rows[hit.RowIndex].Selected = true;

                if (dgvNinos.SelectedRows.Count > 0)
                {
                    Ninos ninoSeleccionado = (Ninos)dgvNinos.SelectedRows[0].DataBoundItem;
                    txtRegistro.Text = ninoSeleccionado.Registro.ToString(); 
                    txtNombre.Text = ninoSeleccionado.Nombre_n;
                    dtpFechaNacimiento.Text = ninoSeleccionado.Fecha_nacimiento.ToString();  // Asegúrate de mostrar la fecha correctamente
                    txtTipoSangre.Text = ninoSeleccionado.Tipo_sangre;
                    txtCiudadNacimiento.Text = ninoSeleccionado.Ciudad_nacimiento;
                    txtIdentificacionAcudiente.Text = ninoSeleccionado.Identificacion_acudiente.ToString();  // Asegúrate de mostrar el tipo correctamente
                    txtTelefono.Text = ninoSeleccionado.Telefono.ToString();
                    txtDireccion.Text = ninoSeleccionado.Direccion_n;
                    txtEPS.Text = ninoSeleccionado.EPS;
                    txtIdentificadorJardin.Text = ninoSeleccionado.Identificador_Jardin.ToString();  // Muestra el campo Identificador_Jardin según tu diseño
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                // Modificar el niño seleccionado
                if (dgvNinos.SelectedRows.Count > 0)
                {
                    Ninos ninoSeleccionado = (Ninos)dgvNinos.SelectedRows[0].DataBoundItem;

                // Establecer los valores del niño a partir de los controles
                    ninoSeleccionado.Registro = int.Parse(txtRegistro.Text);
                    ninoSeleccionado.Nombre_n = txtNombre.Text;
                    ninoSeleccionado.Tipo_sangre = txtTipoSangre.Text;
                    ninoSeleccionado.Ciudad_nacimiento = txtCiudadNacimiento.Text;
                    ninoSeleccionado.Identificacion_acudiente = int.Parse(txtIdentificacionAcudiente.Text);
                    ninoSeleccionado.Telefono = int.Parse(txtTelefono.Text);
                    ninoSeleccionado.Direccion_n = txtDireccion.Text;
                    ninoSeleccionado.EPS = txtEPS.Text;
                    ninoSeleccionado.Identificador_Jardin = int.Parse(txtIdentificadorJardin.Text);

                    // Asignar la fecha del DateTimePicker al objeto Ninos
                    ninoSeleccionado.Fecha_nacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

                    if (ninosConsultas.modificarNinos(ninoSeleccionado))
                    {
                        MessageBox.Show("Niño modificado correctamente");
                        RefreshNinos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el niño");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un niño para modificar");
                }
            }







            private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar el niño seleccionado
            if (dgvNinos.SelectedRows.Count > 0)
            {
                Ninos ninoSeleccionado = (Ninos)dgvNinos.SelectedRows[0].DataBoundItem;

                if (ninosConsultas.eliminarNinos(ninoSeleccionado))
                {
                    MessageBox.Show("Niño eliminado correctamente");
                    RefreshNinos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el niño");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un niño para eliminar");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            LimpiarCampos();
        }

        private void FormNinos_Load_1(object sender, EventArgs e)
        {
                

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
