using System;
using System.Windows.Forms;
using CRUD.Modelo;
using CRUD.Objects;

namespace CRUD
{
    public partial class FormJardin : Form
    {
        private JardinConsultas jardinConsultas;

        public FormJardin()
        {
            InitializeComponent();
            jardinConsultas = new JardinConsultas();
        }

        private void FormJardin_Load(object sender, EventArgs e)
        {
            // Cargar la lista de jardines al cargar el formulario
            RefreshJardines();
        }

        private void RefreshJardines()
        {

            // Limpiar el DataGridView
            dgvJardines.DataSource = null;
            dgvJardines.Rows.Clear();

            // Volver a cargar la lista de jardines en el DataGridView
            dgvJardines.DataSource = jardinConsultas.consultarJardines(txtFiltro.Text);
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Agregar un nuevo jardín
            Jardin nuevoJardin = new Jardin
            {
                Nombre_jardin = txtNombre.Text,
                Direccion_j = txtDireccion.Text,
                Estado = txtEstado.Text
            };

            if (jardinConsultas.agregarJardin(nuevoJardin))
            {
                MessageBox.Show("Jardín agregado correctamente");
                RefreshJardines();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el jardín");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Modificar el jardín seleccionado
            if (dgvJardines.SelectedRows.Count > 0)
            {
                Jardin jardinSeleccionado = (Jardin)dgvJardines.SelectedRows[0].DataBoundItem;
                jardinSeleccionado.Nombre_jardin = txtNombre.Text;
                jardinSeleccionado.Direccion_j = txtDireccion.Text;
                jardinSeleccionado.Estado = txtEstado.Text;

                if (jardinConsultas.modificarJardin(jardinSeleccionado))
                {
                    MessageBox.Show("Jardín modificado correctamente");
                    RefreshJardines();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el jardín");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un jardín para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar el jardín seleccionado
            if (dgvJardines.SelectedRows.Count > 0)
            {
                Jardin jardinSeleccionado = (Jardin)dgvJardines.SelectedRows[0].DataBoundItem;

                if (jardinConsultas.eliminarJardin(jardinSeleccionado))
                {
                    MessageBox.Show("Jardín eliminado correctamente");
                    RefreshJardines();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el jardín");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un jardín para eliminar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";

        }

        private void dgvJardines_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvJardines.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                dgvJardines.Rows[hit.RowIndex].Selected = true;

                if (dgvJardines.SelectedRows.Count > 0)
                {
                    Jardin jardinSeleccionado = (Jardin)dgvJardines.SelectedRows[0].DataBoundItem;
                    txtNombre.Text = jardinSeleccionado.Nombre_jardin;
                    txtDireccion.Text = jardinSeleccionado.Direccion_j;
                    txtEstado.Text = jardinSeleccionado.Estado;
                }
            }
        }

        


    }
}
