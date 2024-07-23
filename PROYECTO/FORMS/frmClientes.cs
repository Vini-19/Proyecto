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

        


        public void DataGridView()      //funcion para llenar el data grid view de clientes.
        {
            string consultaSql = "SELECT RTN_Persona, DNI_Persona, Primer_Nombre, Estado, Numero_Telefono, Correo, Direccion, Fecha_Inscripcion FROM Personas WHERE Roles_ID = 3";
            //consulta select en sql para obtener todos los datos de la tabla personas pero solo de aquellos cuyo rol sea el de clientes que es 3.
            try
            {
                Cconexion conexion = new Cconexion();       //instancia de la calse de conexion.
                using (SqlConnection cn = conexion.leer())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, cn);
                    DataSet dataSet = new DataSet();
                    adaptador.Fill(dataSet, "Personas");

                    dgvCliente.DataSource = dataSet.Tables["Personas"];
                    //rellena el data grid view con columnas nuevas una para cada dato obtenido enla consulta sql. metemos igualado a las avriables anteriores.
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
                //mensaje de error en caso de qu eno pueda cargar los datos.
            }
        }

        

        public void limpiar()       //funcion para limpiar los texbox de los clientes.
        {
            txtRTN_Cliente.Text = "";
            txtDNI_Cliente.Text = "";
            txtNombre_Cliente.Text = "";
            txtTelefono_Cliente.Text = "";
            txtCorreo_Cliente.Text = "";
            txtDireccion_Cliente.Text = "";
        }


        public void Modificar_Cliente()
        {       //funcion para poder modificar un cliente que ya existe.
            clsClientes clientes = new clsClientes();

            clientes.setrtn(txtRTN_Cliente.Text);       //envia los datos con set a la clase de clientes para almacenarlos en atributos privados.
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
                        cn.Close();     //cierra y abre la conexio para evitar errores.
                        cn.Open();
                    }

                    if (cn.State == ConnectionState.Open)
                    {
                        int ID_Cliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells["PersonasID"].Value);

                        SqlCommand actualizarCliente = new SqlCommand("PA_ActualizarCliente", cn);      //prodecimientoa lmacenado en sql para actualizar el cliente.
                        actualizarCliente.CommandType = CommandType.StoredProcedure;
                        using (SqlCommand comando = new SqlCommand("PA_ActualizarCliente", cn))
                        {
                            actualizarCliente.Parameters.AddWithValue("@RTN", clientes.getrtn());       //obtenemos los datos guardados en los atributos privados de la clase clientes.
                            actualizarCliente.Parameters.AddWithValue("@DNI", clientes.getdni());
                            actualizarCliente.Parameters.AddWithValue("@nombre", clientes.getnombre());
                            actualizarCliente.Parameters.AddWithValue("@telefono", clientes.gettelefono());
                            actualizarCliente.Parameters.AddWithValue("@correo", clientes.getcorreo());
                            actualizarCliente.Parameters.AddWithValue("@direccion", clientes.getdireccion());
                            actualizarCliente.Parameters.AddWithValue("@clienteID", ID_Cliente);

                            int Actualizacion = actualizarCliente.ExecuteNonQuery();
                            DataGridView();     //actializamos los datos mostrados en el data gridview y lo llenamos de nuevo.

                            if (Actualizacion > 0)
                            {
                                limpiar();      //limpiamos todos los controles
                                btnAgregar.Enabled = true;
                                txtRTN_Cliente.Focus();     //damos focus en el primer control que pide que es el rtn.
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
                                MessageBox.Show("No se pudo modificar el proveedor");       //mensaje en caso de error de no poder modificar el proveedor,
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error de conexión.");      //erro de conexion en caso de tener probelmas para conectar con la base de datos
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);       //error de conexion en caso de tener problemas para conectars econ el servidor.
            }
        }
       

        

        private void FiltrarDatos(string texto)     //funcion para filtrar los datos del textbox buscar para mostrar y seleccionar el primeor al buscar y escribir.
        {
            DataTable dt = (DataTable)dgvCliente.DataSource;
            if (dt != null)
            {
                dgvCliente.ClearSelection();    //limpia la seleccion dek data grid view.

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
                        dgvCliente.ClearSelection();    //limpia la seleccion del data grid view.
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);       //llama a filtrar datos funcion cada que el texto cambia en el textbox buscar.
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

        private void btnAgregar_Click(object sender, EventArgs e)       //boton de agregar un nuevo cliente.
        {
            clsClientes clientes = new clsClientes();
            Cconexion conexion = new Cconexion();

            if (txtRTN_Cliente.Text == "" || txtDNI_Cliente.Text == "" || txtNombre_Cliente.Text == "" || txtTelefono_Cliente.Text == "" || txtCorreo_Cliente.Text == "" || txtDireccion_Cliente.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;     //validacion en caso de que los campos esten vacios.

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
                //validacion para modificar en caso de que quiera modificar y los campos esten vacios.
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
            errorProvider1.SetError(txtRTN_Cliente, "");        //muestra los botones de error parpadeantes
            errorProvider1.SetError(txtDNI_Cliente, "");
            errorProvider1.SetError(txtNombre_Cliente, "");
            errorProvider1.SetError(txtTelefono_Cliente, "");
            errorProvider1.SetError(txtCorreo_Cliente, "");
            errorProvider1.SetError(txtDireccion_Cliente, "");

            txtRTN_Cliente.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)      //eliminar marca al cliente como inactivo para mantener la integridad de la base de datos.
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
                        comandoEliminarCliente.CommandType = CommandType.StoredProcedure;//procedimiento almacenado para marcar el cliente como inactivo.
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

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCliente.Rows[e.RowIndex];

                txtRTN_Cliente.Text = row.Cells["RTN_Persona"].Value.ToString();
                txtDNI_Cliente.Text = row.Cells["DNI_Persona"].Value.ToString();
                txtNombre_Cliente.Text = row.Cells["Primer_Nombre"].Value.ToString();
                txtTelefono_Cliente.Text = row.Cells["Numero_Telefono"].Value.ToString();
                txtCorreo_Cliente.Text = row.Cells["Correo"].Value.ToString();
                txtDireccion_Cliente.Text = row.Cells["Direccion"].Value.ToString();
            }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
