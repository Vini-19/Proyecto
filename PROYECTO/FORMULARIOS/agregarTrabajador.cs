using PROYECTO.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class agregarTrabajador : Form
    {
        public agregarTrabajador()
        {
            InitializeComponent();
            DataGridView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsTrabajadores Trabajador = new clsTrabajadores();
            Cconexion conexion = new Cconexion();

            Trabajador.setrtn(txtRTN_Trabajador.Text);
            Trabajador.setdni(txtDNI_Trabajador.Text);
            Trabajador.setnombre(txtNombre_Trabajador.Text);
            Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
            Trabajador.setcorreo(txtCorreo_Trabajador.Text);
            Trabajador.setdireccion(txtDireccion_Trabajador.Text);

            DateTime fechaInscripcion = DateTime.Today;

            if (conexion.VerificarClienteExistente(Trabajador.getnombre()))
            {
                MessageBox.Show("Ya existe un trabajador con ese nombre. Por favor, elija otro nombre.");
                return;
            }


            if (string.IsNullOrWhiteSpace(Trabajador.getrtn()) | string.IsNullOrWhiteSpace(Trabajador.getdni()) || string.IsNullOrWhiteSpace(Trabajador.getnombre()) || string.IsNullOrWhiteSpace(Trabajador.gettelefono().ToString()) || string.IsNullOrWhiteSpace(Trabajador.getcorreo()) || string.IsNullOrWhiteSpace(Trabajador.getdireccion()))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            conexion.RegistroCliente(Trabajador.getrtn(), Trabajador.getdni(), Trabajador.getnombre(), Trabajador.getrol(), Trabajador.getestado(), Trabajador.gettelefono(), Trabajador.getcorreo(), Trabajador.getdireccion(), fechaInscripcion);
            limpiar();
            MessageBox.Show("Se registro correctamente.");
            DataGridView();
            txtRTN_Trabajador.Focus();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTrabajador.Rows[e.RowIndex];

                txtRTN_Trabajador.Text = row.Cells["RTN_Persona"].Value.ToString();
                txtDNI_Trabajador.Text = row.Cells["DNI_Persona"].Value.ToString();
                txtNombre_Trabajador.Text = row.Cells["Primer_Nombre"].Value.ToString();
                txtTelefono_Trabajador.Text = row.Cells["Numero_Telefono"].Value.ToString();
                txtCorreo_Trabajador.Text = row.Cells["Correo"].Value.ToString();
                txtDireccion_Trabajador.Text = row.Cells["Direccion"].Value.ToString();

                btnAgregar.Enabled = false;
            }
        }

        private void FiltrarDatos(string texto)
        {
            DataTable dt = (DataTable)dgvTrabajador.DataSource;
            if (dt != null)
            {
                dgvTrabajador.ClearSelection();

                if (!string.IsNullOrEmpty(texto))
                {
                    bool encontrado = false;

                    foreach (DataGridViewRow row in dgvTrabajador.Rows)
                    {
                        if (row.Cells["Primer_Nombre"].Value != null && row.Cells["Primer_Nombre"].Value.ToString().ToLower().Contains(texto.ToLower()))
                        {
                            row.Selected = true;
                            dgvTrabajador.FirstDisplayedScrollingRowIndex = row.Index;
                            encontrado = true;
                            break; // Selecciona la primera y termina
                        }
                    }
                    if (!encontrado)
                    {
                        dgvTrabajador.ClearSelection();
                    }
                }
            }
        }



        public void DataGridView()
        {
            string consultaSql = "SELECT PersonasID, RTN_Persona, DNI_Persona, Roles_ID, Primer_Nombre, Estado, Numero_Telefono, Correo, Direccion, Fecha_Inscripcion FROM Personas WHERE Roles_ID = 2";

            try
            {
                Cconexion conexion = new Cconexion();
                using (SqlConnection cn = conexion.leer())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, cn);
                    DataSet dataSet = new DataSet();
                    adaptador.Fill(dataSet, "Personas");

                    dgvTrabajador.DataSource = dataSet.Tables["Personas"];

                    dgvTrabajador.Columns["PersonasID"].HeaderText = "ID Cliente";
                    dgvTrabajador.Columns["RTN_Persona"].HeaderText = "RTN";
                    dgvTrabajador.Columns["DNI_Persona"].HeaderText = "DNI";
                    dgvTrabajador.Columns["Roles_ID"].HeaderText = "Rol";
                    dgvTrabajador.Columns["Primer_Nombre"].HeaderText = "Nombre";
                    dgvTrabajador.Columns["Estado"].HeaderText = "Estado";
                    dgvTrabajador.Columns["Numero_Telefono"].HeaderText = "Teléfono";
                    dgvTrabajador.Columns["Correo"].HeaderText = "Correo Electrónico";
                    dgvTrabajador.Columns["Direccion"].HeaderText = "Dirección";
                    dgvTrabajador.Columns["Fecha_Inscripcion"].HeaderText = "Fecha Inscripción";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void agregarTrabajador_Load(object sender, EventArgs e)
        {
            txtRTN_Trabajador.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        public void limpiar()
        {
            txtRTN_Trabajador.Text = "";
            txtDNI_Trabajador.Text = "";
            txtNombre_Trabajador.Text = "";
            txtTelefono_Trabajador.Text = "";
            txtCorreo_Trabajador.Text = "";
            txtDireccion_Trabajador.Text = "";
        }
        private void txtRTN_Cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }

        public void Modificar_Trab()
        {
            clsTrabajadores Trabajador = new clsTrabajadores();

            Trabajador.setrtn(txtRTN_Trabajador.Text);
            Trabajador.setdni(txtDNI_Trabajador.Text);
            Trabajador.setnombre(txtNombre_Trabajador.Text);
            Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
            Trabajador.setcorreo(txtCorreo_Trabajador.Text);
            Trabajador.setdireccion(txtDireccion_Trabajador.Text);
            Cconexion conexion = new Cconexion();

            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                        cn.Open();
                    }

                    if (cn.State == ConnectionState.Open)
                    {
                        int ID_Trabajador = Convert.ToInt32(dgvTrabajador.SelectedRows[0].Cells["PersonasID"].Value);

                        SqlCommand actualizarTrabajador = new SqlCommand("PA_ActualizarCliente", cn);
                        actualizarTrabajador.CommandType = CommandType.StoredProcedure;
                        using (SqlCommand comando = new SqlCommand("PA_ActualizarCliente", cn))
                        {
                            actualizarTrabajador.Parameters.AddWithValue("@RTN", Trabajador.getrtn());
                            actualizarTrabajador.Parameters.AddWithValue("@DNI", Trabajador.getdni());
                            actualizarTrabajador.Parameters.AddWithValue("@nombre", Trabajador.getnombre());
                            actualizarTrabajador.Parameters.AddWithValue("@telefono", Trabajador.gettelefono());
                            actualizarTrabajador.Parameters.AddWithValue("@correo", Trabajador.getcorreo());
                            actualizarTrabajador.Parameters.AddWithValue("@direccion", Trabajador.getdireccion());
                            actualizarTrabajador.Parameters.AddWithValue("@TrabajadorID", ID_Trabajador);

                            int Actualizacion = actualizarTrabajador.ExecuteNonQuery();
                            DataGridView();

                            if (Actualizacion > 0)
                            {
                                limpiar();
                                btnAgregar.Enabled = true;
                                MessageBox.Show("Trabajador modificado correctamente");
                                txtRTN_Trabajador.Focus();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el trabajador");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error de conexión.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRTN_Trabajador.Text) || string.IsNullOrWhiteSpace(txtDNI_Trabajador.Text) || string.IsNullOrWhiteSpace(txtNombre_Trabajador.Text) || string.IsNullOrWhiteSpace(txtDireccion_Trabajador.Text) || (this.txtTelefono_Trabajador.Text == "0" || string.IsNullOrWhiteSpace(this.txtTelefono_Trabajador.Text)) || string.IsNullOrWhiteSpace(txtCorreo_Trabajador.Text))
            {
                MessageBox.Show("Por favor, seleccione un trabajador antes de poder ejecutar la acción.");

                return;
            }
            else
            {
                Modificar_Trab();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTrabajador.SelectedRows.Count > 0)
            {
                int TrabajadorID = Convert.ToInt32(dgvTrabajador.SelectedRows[0].Cells["PersonasID"].Value);

                Cconexion conexion = new Cconexion();

                try
                {
                    using (SqlConnection cn = conexion.leer())
                    {
                        if (cn.State == ConnectionState.Closed)
                        {
                            cn.Open();
                        }

                        SqlCommand comandoEliminarTrabajador = new SqlCommand("PA_MarcarClienteInactivo", cn);
                        comandoEliminarTrabajador.CommandType = CommandType.StoredProcedure;
                        comandoEliminarTrabajador.Parameters.AddWithValue("@clienteID", TrabajadorID);

                        comandoEliminarTrabajador.ExecuteNonQuery();

                        MessageBox.Show("Cliente marcado como inactivo correctamente");


                        DataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar conectar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para marcar como inactivo.");
            }
        }

        private void agregarTrabajador_Load_1(object sender, EventArgs e)
        {

        }
    }
}
