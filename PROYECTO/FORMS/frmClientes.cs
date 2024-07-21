using Microsoft.Win32;
using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;
using Proyecto_de_desarrolo.Formularios;
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

namespace Proyecto_de_desarrolo
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            DataGridView();
        }
        clsValidaciones val = new clsValidaciones();

        


        public void DataGridView()
        {
            string consultaSql = "SELECT RTN_Persona, DNI_Persona, Primer_Nombre, Estado, Numero_Telefono, Correo, Direccion, Fecha_Inscripcion FROM Personas WHERE Roles_ID = 3";

            try
            {
                Cconexion conexion = new Cconexion();
                using (SqlConnection cn = conexion.leer())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, cn);
                    DataSet dataSet = new DataSet();
                    adaptador.Fill(dataSet, "Personas");

                    dgvCliente.DataSource = dataSet.Tables["Personas"];

                    dgvCliente.Columns["RTN_Persona"].HeaderText = "RTN";
                    dgvCliente.Columns["DNI_Persona"].HeaderText = "DNI";
                    dgvCliente.Columns["Primer_Nombre"].HeaderText = "Nombre";
                    dgvCliente.Columns["Estado"].HeaderText = "Estado";
                    dgvCliente.Columns["Numero_Telefono"].HeaderText = "Teléfono";
                    dgvCliente.Columns["Correo"].HeaderText = "Correo Electrónico";
                    dgvCliente.Columns["Direccion"].HeaderText = "Dirección";
                    dgvCliente.Columns["Fecha_Inscripcion"].HeaderText = "Fecha Inscripción";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        

        public void limpiar()
        {
            txtRTN_Cliente.Text = "";
            txtDNI_Cliente.Text = "";
            txtNombre_Cliente.Text = "";
            txtTelefono_Cliente.Text = "";
            txtCorreo_Cliente.Text = "";
            txtDireccion_Cliente.Text = "";
        }


        public void Modificar_Cliente()
        {
            clsClientes clientes = new clsClientes();

            clientes.setrtn(txtRTN_Cliente.Text);
            clientes.setdni(txtDNI_Cliente.Text);
            clientes.setnombre(txtNombre_Cliente.Text);
            clientes.settelefono(int.Parse(txtTelefono_Cliente.Text));
            clientes.setcorreo(txtCorreo_Cliente.Text);
            clientes.setdireccion(txtDireccion_Cliente.Text);
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
                        int ID_Cliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells["PersonasID"].Value);

                        SqlCommand actualizarCliente = new SqlCommand("PA_ActualizarCliente", cn);
                        actualizarCliente.CommandType = CommandType.StoredProcedure;
                        using (SqlCommand comando = new SqlCommand("PA_ActualizarCliente", cn))
                        {
                            actualizarCliente.Parameters.AddWithValue("@RTN", clientes.getrtn());
                            actualizarCliente.Parameters.AddWithValue("@DNI", clientes.getdni());
                            actualizarCliente.Parameters.AddWithValue("@nombre", clientes.getnombre());
                            actualizarCliente.Parameters.AddWithValue("@telefono", clientes.gettelefono());
                            actualizarCliente.Parameters.AddWithValue("@correo", clientes.getcorreo());
                            actualizarCliente.Parameters.AddWithValue("@direccion", clientes.getdireccion());
                            actualizarCliente.Parameters.AddWithValue("@clienteID", ID_Cliente);

                            int Actualizacion = actualizarCliente.ExecuteNonQuery();
                            DataGridView();

                            if (Actualizacion > 0)
                            {
                                limpiar();
                                btnAgregar.Enabled = true;
                                txtRTN_Cliente.Focus();
                                errorProvider1.SetError(txtRTN_Cliente, "");
                                errorProvider1.SetError(txtDNI_Cliente, "");
                                errorProvider1.SetError(txtNombre_Cliente, "");
                                errorProvider1.SetError(txtTelefono_Cliente, "");
                                errorProvider1.SetError(txtCorreo_Cliente, "");
                                MessageBox.Show("Proveedor modificado correctamente");

                                txtRTN_Cliente.Focus();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el proveedor");
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
       

        

        private void FiltrarDatos(string texto)
        {
            DataTable dt = (DataTable)dgvCliente.DataSource;
            if (dt != null)
            {
                dgvCliente.ClearSelection();

                if (!string.IsNullOrEmpty(texto))
                {
                    bool encontrado = false;

                    foreach (DataGridViewRow row in dgvCliente.Rows)
                    {
                        if (row.Cells["Primer_Nombre"].Value != null && row.Cells["Primer_Nombre"].Value.ToString().ToLower().Contains(texto.ToLower()))
                        {
                            row.Selected = true;
                            dgvCliente.FirstDisplayedScrollingRowIndex = row.Index;
                            encontrado = true;
                            break; // Selecciona la primera y termina
                        }
                    }
                    if (!encontrado)
                    {
                        dgvCliente.ClearSelection();
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }

        private void txtRTN_Cliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRTN_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDNI_Cliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDNI_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNombre_Cliente_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtNombre_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTelefono_Cliente_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtTelefono_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCorreo_Cliente_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsClientes clientes = new clsClientes();
            Cconexion conexion = new Cconexion();

            if (txtRTN_Cliente.Text == "" || txtDNI_Cliente.Text == "" || txtNombre_Cliente.Text == "" || txtTelefono_Cliente.Text == "" || txtCorreo_Cliente.Text == "" || txtDireccion_Cliente.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                clientes.setrtn(txtRTN_Cliente.Text);
                clientes.setdni(txtDNI_Cliente.Text);
                clientes.setnombre(txtNombre_Cliente.Text);
                clientes.settelefono(int.Parse(txtTelefono_Cliente.Text));
                clientes.setcorreo(txtCorreo_Cliente.Text);
                clientes.setdireccion(txtDireccion_Cliente.Text);

                DateTime fechaInscripcion = DateTime.Today;

                if (errorProvider1.GetError(txtRTN_Cliente) == "" && errorProvider1.GetError(txtDNI_Cliente) == "" && errorProvider1.GetError(txtNombre_Cliente) == "" && errorProvider1.GetError(txtTelefono_Cliente) == "" && errorProvider1.GetError(txtCorreo_Cliente) == "" && errorProvider1.GetError(txtDireccion_Cliente) == "")
                {

                    if (conexion.VerificarClienteExistente(clientes.getdni()))
                    {
                        MessageBox.Show("No se puede agregar el cliente porque ya existe un cliente con ese DNI.");
                        return;
                    }

                    conexion.RegistroCliente(clientes.getrtn(), clientes.getdni(), clientes.getnombre(), clientes.getrol(), clientes.getestado(), clientes.gettelefono(), clientes.getcorreo(), clientes.getdireccion(), fechaInscripcion);
                    limpiar();
                    txtRTN_Cliente.Focus();
                    errorProvider1.SetError(txtRTN_Cliente, "");
                    errorProvider1.SetError(txtDNI_Cliente, "");
                    errorProvider1.SetError(txtNombre_Cliente, "");
                    errorProvider1.SetError(txtTelefono_Cliente, "");
                    errorProvider1.SetError(txtCorreo_Cliente, "");
                    errorProvider1.SetError(txtDireccion_Cliente, "");

                    MessageBox.Show("Se registro correctamente.");
                    DataGridView();

                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

            if (txtRTN_Cliente.Text == "" || txtDNI_Cliente.Text == "" || txtNombre_Cliente.Text == "" || txtTelefono_Cliente.Text == "" || txtCorreo_Cliente.Text == "" || txtDireccion_Cliente.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de poder ejecutar la acción.");

                return;
            }
            else
            {

                if (errorProvider1.GetError(txtRTN_Cliente) == "" && errorProvider1.GetError(txtDNI_Cliente) == "" && errorProvider1.GetError(txtNombre_Cliente) == "" && errorProvider1.GetError(txtTelefono_Cliente) == "" && errorProvider1.GetError(txtCorreo_Cliente) == "" && errorProvider1.GetError(txtDireccion_Cliente) == "")
                {
                    Modificar_Cliente();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            errorProvider1.SetError(txtRTN_Cliente, "");
            errorProvider1.SetError(txtDNI_Cliente, "");
            errorProvider1.SetError(txtNombre_Cliente, "");
            errorProvider1.SetError(txtTelefono_Cliente, "");
            errorProvider1.SetError(txtCorreo_Cliente, "");
            errorProvider1.SetError(txtDireccion_Cliente, "");

            txtRTN_Cliente.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                int clienteID = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells["PersonasID"].Value);

                Cconexion conexion = new Cconexion();

                try
                {
                    using (SqlConnection cn = conexion.leer())
                    {
                        if (cn.State == ConnectionState.Closed)
                        {
                            cn.Open();
                        }
                        SqlCommand comandoEliminarCliente = new SqlCommand("PA_MarcarClienteInactivo", cn);
                        comandoEliminarCliente.CommandType = CommandType.StoredProcedure;
                        comandoEliminarCliente.Parameters.AddWithValue("@clienteID", clienteID);

                        comandoEliminarCliente.ExecuteNonQuery();

                        limpiar();
                        errorProvider1.SetError(txtRTN_Cliente, "");
                        errorProvider1.SetError(txtDNI_Cliente, "");
                        errorProvider1.SetError(txtNombre_Cliente, "");
                        errorProvider1.SetError(txtTelefono_Cliente, "");
                        errorProvider1.SetError(txtCorreo_Cliente, "");
                        btnAgregar.Enabled = true;

                        MessageBox.Show("Cliente marcado como inactivo correctamente");

                        DataGridView();

                        txtRTN_Cliente.Focus();
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

        private void txtRTN_Cliente_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtRTN_Cliente, val.txt_vacio(txtRTN_Cliente.Text) + val.espacio_inicio_final(txtRTN_Cliente.Text) + val.rango_14(txtRTN_Cliente.Text) + val.espacio(txtRTN_Cliente.Text));
        }

        private void txtDNI_Cliente_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDNI_Cliente, val.txt_vacio(txtDNI_Cliente.Text) + val.espacio_inicio_final(txtDNI_Cliente.Text) + val.rango_13(txtDNI_Cliente.Text) + val.espacio(txtDNI_Cliente.Text) + val.validar_dni(txtDNI_Cliente.Text));
        }

        private void txtNombre_Cliente_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre_Cliente, val.txt_vacio(txtNombre_Cliente.Text) + val.espacio_inicio_final(txtNombre_Cliente.Text) + val.validarletra_espacio(txtNombre_Cliente.Text) + val.rango_nombre(txtNombre_Cliente.Text) + val.doble_espacio(txtNombre_Cliente.Text) + val.validar_tripleCaracter(txtNombre_Cliente.Text));
        }

        private void txtDireccion_Cliente_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDireccion_Cliente, val.txt_vacio(txtDireccion_Cliente.Text) + val.espacio_inicio_final(txtDireccion_Cliente.Text) + val.rango_direccion(txtDireccion_Cliente.Text) + val.doble_espacio(txtDireccion_Cliente.Text) + val.validar_tripleCaracter(txtDireccion_Cliente.Text));
        }

        private void txtTelefono_Cliente_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTelefono_Cliente, val.txt_vacio(txtTelefono_Cliente.Text) + val.espacio_inicio_final(txtTelefono_Cliente.Text) + val.validarnumerotell(txtTelefono_Cliente.Text) + val.rango_8(txtTelefono_Cliente.Text));
        }

        private void txtCorreo_Cliente_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCorreo_Cliente, val.txt_vacio(txtCorreo_Cliente.Text) + val.espacio_inicio_final(txtCorreo_Cliente.Text) + val.validar_correo(txtCorreo_Cliente.Text) + val.doble_espacio(txtCorreo_Cliente.Text));
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtRTN_Cliente.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtDNI_Cliente.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtNombre_Cliente.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtTelefono_Cliente.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtCorreo_Cliente.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            txtDireccion_Cliente.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();

            btnAgregar.Enabled = false;

        }

        private void txtRTN_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtDNI_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtTelefono_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }
    }

}
