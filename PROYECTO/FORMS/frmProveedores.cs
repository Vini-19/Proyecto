using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;
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
using System.Xml.Linq;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmProveedores : Form
    {


        public frmProveedores()
        {
            InitializeComponent();
            DataGridView();
            CargarCategoriaProveedor();
        }

        clsValidaciones val = new clsValidaciones();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RegistroProv()
        {
            clsProveedores proveedores = new clsProveedores();

            if (!int.TryParse(txtTelefono_Prov.Text, out int numTel))
            {
                MessageBox.Show("El número de teléfono no es válido.");
                return;
            }


            proveedores.setrtn(txtRTN_Prov.Text);
            proveedores.setdni(txtDNI_Prov.Text);
            proveedores.setnombre(txtNombre_Prov.Text);
            proveedores.settelefono(numTel);
            proveedores.setcorreo(txtCorreo_Prov.Text);
            proveedores.setdireccion(txtDireccion_Prov.Text);
            proveedores.setcategoria(cmbCategoria.Text);
            DateTime fechaInscripcion = DateTime.Today;

            if (string.IsNullOrWhiteSpace(proveedores.getrtn()) || string.IsNullOrWhiteSpace(proveedores.getdni()) || string.IsNullOrWhiteSpace(proveedores.getnombre()) || proveedores.gettelefono() == 0 || string.IsNullOrWhiteSpace(proveedores.getcorreo()) || string.IsNullOrWhiteSpace(proveedores.getdireccion()) || string.IsNullOrWhiteSpace(proveedores.getCategoria()))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }


            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();
                if (cn.State == ConnectionState.Open)
                {

                    SqlCommand comandoExisteProveedor = new SqlCommand("PA_ExisteProveedor", cn);
                    comandoExisteProveedor.CommandType = CommandType.StoredProcedure;

                    SqlCommand comando = new SqlCommand("PA_ExisteProveedor", cn);

                    comandoExisteProveedor.Parameters.AddWithValue("@dni", proveedores.getdni());

                    int count = (int)comandoExisteProveedor.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("No se puede registrar el proveedor porque ya existe un proveedor con ese DNI.");
                    }
                    else
                    {

                        SqlCommand insertar_prov = new SqlCommand("PA_InsertarProveedor", cn);
                        insertar_prov.CommandType = CommandType.StoredProcedure;

                        SqlCommand comandoInsertar = new SqlCommand("PA_InsertarProveedor", cn);
                        insertar_prov.Parameters.AddWithValue("@RTN", proveedores.getrtn());
                        insertar_prov.Parameters.AddWithValue("@DNI", proveedores.getdni());
                        insertar_prov.Parameters.AddWithValue("@nombre", proveedores.getnombre());
                        insertar_prov.Parameters.AddWithValue("@rol", proveedores.getrol());
                        insertar_prov.Parameters.AddWithValue("@estado", proveedores.getestado());
                        insertar_prov.Parameters.AddWithValue("@telefono", proveedores.gettelefono());
                        insertar_prov.Parameters.AddWithValue("@correo", proveedores.getcorreo());
                        insertar_prov.Parameters.AddWithValue("@direccion", proveedores.getdireccion());
                        insertar_prov.Parameters.AddWithValue("@fecha_Inscripcion", fechaInscripcion);
                        insertar_prov.Parameters.AddWithValue("@Categoria", proveedores.getCategoria());

                        insertar_prov.ExecuteNonQuery();


                        Limpiar();
                        errorProvider1.SetError(txtRTN_Prov, "");
                        errorProvider1.SetError(txtDNI_Prov, "");
                        errorProvider1.SetError(txtNombre_Prov, "");
                        errorProvider1.SetError(txtTelefono_Prov, "");
                        errorProvider1.SetError(txtCorreo_Prov, "");
                        MessageBox.Show("Proveedor registrado correctamente");

                        DataGridView();

                        txtRTN_Prov.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error de conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }

        public void DataGridView()
        {
            string consultaSql = "SELECT PersonasID,RTN_Persona, DNI_Persona, Roles_ID, Primer_Nombre, Estado, Numero_Telefono, Correo, Direccion, Fecha_Inscripcion, Categoria FROM Personas WHERE Roles_ID = 4";

            dgv_Prov.DataSource = null;
            dgv_Prov.Rows.Clear();

            try
            {
                Cconexion conexion = new Cconexion();
                SqlConnection cn = conexion.leer();

                SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, conexion.leer());
                DataSet dataSet = new DataSet();



                adaptador.Fill(dataSet, "Personas");

                dgv_Prov.DataSource = dataSet.Tables["Personas"];

                dgv_Prov.Columns["PersonasID"].HeaderText = "ID Proveedores";
                dgv_Prov.Columns["RTN_Persona"].HeaderText = "RTN";
                dgv_Prov.Columns["DNI_Persona"].HeaderText = "DNI";
                dgv_Prov.Columns["Roles_ID"].HeaderText = "Rol";
                dgv_Prov.Columns["Primer_Nombre"].HeaderText = "Nombre";
                dgv_Prov.Columns["Estado"].HeaderText = "Estado";
                dgv_Prov.Columns["Numero_Telefono"].HeaderText = "Telefono";
                dgv_Prov.Columns["Correo"].HeaderText = "Correo Electronico";
                dgv_Prov.Columns["Direccion"].HeaderText = "Direccion";
                dgv_Prov.Columns["Fecha_Inscripcion"].HeaderText = "Fecha Inscripcion";
                dgv_Prov.Columns["Categoria"].HeaderText = "Categoria";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }

            dgv_Prov.Refresh();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            if (txtRTN_Prov.Text == "" || txtDNI_Prov.Text == "" || txtNombre_Prov.Text == "" || txtTelefono_Prov.Text == "" || txtCorreo_Prov.Text == "" || txtDireccion_Prov.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {

                if (errorProvider1.GetError(txtRTN_Prov) == "" && errorProvider1.GetError(txtDNI_Prov) == "" && errorProvider1.GetError(txtNombre_Prov) == "" && errorProvider1.GetError(txtTelefono_Prov) == "" && errorProvider1.GetError(txtCorreo_Prov) == "")
                {
                    RegistroProv();
                    DataGridView();
                }
                else
                {
                    MessageBox.Show("Verifique los campos");
                }
            }
        }

        private void Limpiar()
        {
            txtRTN_Prov.Text = "";
            txtDNI_Prov.Text = "";
            txtNombre_Prov.Text = "";
            txtTelefono_Prov.Text = "";
            txtCorreo_Prov.Text = "";
            txtDireccion_Prov.Text = "";
            cmbCategoria.SelectedIndex = -1;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            errorProvider1.SetError(txtRTN_Prov, "");
            errorProvider1.SetError(txtDNI_Prov, "");
            errorProvider1.SetError(txtNombre_Prov, "");
            errorProvider1.SetError(txtTelefono_Prov, "");
            errorProvider1.SetError(txtCorreo_Prov, "");
            errorProvider1.SetError(txtDireccion_Prov, "");

            txtRTN_Prov.Focus();
        }

        public void Modificar_Prov()
        {
            clsProveedores proveedores = new clsProveedores();

            proveedores.setrtn(txtRTN_Prov.Text);
            proveedores.setdni(txtDNI_Prov.Text);
            proveedores.setnombre(txtNombre_Prov.Text);
            proveedores.settelefono(int.Parse(txtTelefono_Prov.Text));
            proveedores.setcorreo(txtCorreo_Prov.Text);
            proveedores.setdireccion(txtDireccion_Prov.Text);

            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();

                if (cn.State == ConnectionState.Open)
                {
                    if ((dgv_Prov.SelectedRows.Count > 0))
                    {
                        int ID_Proveedores = Convert.ToInt32(dgv_Prov.SelectedRows[0].Cells["PersonasID"].Value);

                        SqlCommand modificar_prov = new SqlCommand("PA_ModificarProveedor", cn);
                        modificar_prov.CommandType = CommandType.StoredProcedure;


                        SqlCommand comandoModificarprov = new SqlCommand("PA_ModificarProveedor", cn);
                        modificar_prov.Parameters.AddWithValue("@RTN", proveedores.getrtn());
                        modificar_prov.Parameters.AddWithValue("@DNI", proveedores.getdni());
                        modificar_prov.Parameters.AddWithValue("@nombre", proveedores.getnombre());
                        modificar_prov.Parameters.AddWithValue("@rol", proveedores.getrol());
                        modificar_prov.Parameters.AddWithValue("@estado", proveedores.getestado());
                        modificar_prov.Parameters.AddWithValue("@telefono", proveedores.gettelefono());
                        modificar_prov.Parameters.AddWithValue("@correo", proveedores.getcorreo());
                        modificar_prov.Parameters.AddWithValue("@direccion", proveedores.getdireccion());
                        modificar_prov.Parameters.AddWithValue("@ID_Proveedores", ID_Proveedores);

                        int Actualizacion = modificar_prov.ExecuteNonQuery();
                        DataGridView();

                        if (Actualizacion > 0)
                        {
                            Limpiar();
                            errorProvider1.SetError(txtRTN_Prov, "");
                            errorProvider1.SetError(txtDNI_Prov, "");
                            errorProvider1.SetError(txtNombre_Prov, "");
                            errorProvider1.SetError(txtTelefono_Prov, "");
                            errorProvider1.SetError(txtCorreo_Prov, "");
                            btnAgregar.Enabled = true;
                            MessageBox.Show("Proveedor modificado correctamente");

                            txtRTN_Prov.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el proveedor");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("Error de conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRTN_Prov.Text) || string.IsNullOrWhiteSpace(txtDNI_Prov.Text) || string.IsNullOrWhiteSpace(txtNombre_Prov.Text) || string.IsNullOrWhiteSpace(txtDireccion_Prov.Text) || (this.txtTelefono_Prov.Text == "0" || string.IsNullOrWhiteSpace(this.txtTelefono_Prov.Text)) || string.IsNullOrWhiteSpace(txtCorreo_Prov.Text) || string.IsNullOrWhiteSpace(txtDireccion_Prov.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Por favor, seleccione una fila del Data Grid View.");

                return;
            }
            else
            {
                if (errorProvider1.GetError(txtRTN_Prov) == "" && errorProvider1.GetError(txtDNI_Prov) == "" && errorProvider1.GetError(txtNombre_Prov) == "" && errorProvider1.GetError(txtTelefono_Prov) == "" && errorProvider1.GetError(txtCorreo_Prov) == "")
                {
                    Modificar_Prov();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }
                
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cconexion conexion = new Cconexion();

            try
            {
                SqlConnection cn = conexion.leer();

                if (cn.State == ConnectionState.Open)
                {
                    if ((dgv_Prov.SelectedRows.Count > 0))
                    {
                        int ID_Proveedores = Convert.ToInt32(dgv_Prov.SelectedRows[0].Cells["PersonasID"].Value);

                        SqlCommand eliminar_prov = new SqlCommand("PA_EliminarProveedor", cn);
                        eliminar_prov.CommandType = CommandType.StoredProcedure;



                        SqlCommand comandoEliminarprov = new SqlCommand("PA_EliminarProveedor", cn);

                        eliminar_prov.Parameters.AddWithValue("@ID_Proveedores", ID_Proveedores);

                        int Actualizacion = eliminar_prov.ExecuteNonQuery();


                        if (Actualizacion > 0)
                        {
                            Limpiar();
                            errorProvider1.SetError(txtRTN_Prov, "");
                            errorProvider1.SetError(txtDNI_Prov, "");
                            errorProvider1.SetError(txtNombre_Prov, "");
                            errorProvider1.SetError(txtTelefono_Prov, "");
                            errorProvider1.SetError(txtCorreo_Prov, "");
                            errorProvider1.SetError(txtDireccion_Prov, "");
                            btnAgregar.Enabled = true;
                            MessageBox.Show("Proveedor eliminado correctamente");
                            txtRTN_Prov.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el proveedor");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("Error de conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }

        private void dgv_Prov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRTN_Prov.Text = dgv_Prov.CurrentRow.Cells[1].Value.ToString();
            txtDNI_Prov.Text = dgv_Prov.CurrentRow.Cells[2].Value.ToString();
            txtNombre_Prov.Text = dgv_Prov.CurrentRow.Cells[4].Value.ToString();
            txtTelefono_Prov.Text = dgv_Prov.CurrentRow.Cells[6].Value.ToString();
            txtCorreo_Prov.Text = dgv_Prov.CurrentRow.Cells[7].Value.ToString();
            txtDireccion_Prov.Text = dgv_Prov.CurrentRow.Cells[8].Value.ToString();

            btnAgregar.Enabled = false;
        }

        public void CargarCategoriaProveedor()
        {
            Cconexion conexion = new Cconexion();

            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        string queryCategoria = "SELECT [NombreCategoria] FROM [dbo].[Categoria]";
                        using (SqlCommand comando = new SqlCommand(queryCategoria, cn))
                        {
                            using (SqlDataReader reader = comando.ExecuteReader())
                            {
                                cmbCategoria.Items.Clear();

                                while (reader.Read())
                                {
                                    string nombreCategoria = reader["NombreCategoria"].ToString();
                                    cmbCategoria.Items.Add(nombreCategoria);
                                }
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
            DataTable dt = (DataTable)dgv_Prov.DataSource;
            if (dt != null)
            {
                dgv_Prov.ClearSelection();

                if (!string.IsNullOrEmpty(texto))
                {
                    bool encontrado = false;

                    foreach (DataGridViewRow row in dgv_Prov.Rows)
                    {
                        if (row.Cells["Primer_Nombre"].Value != null && row.Cells["Primer_Nombre"].Value.ToString().ToLower().Contains(texto.ToLower()))
                        {
                            row.Selected = true;
                            dgv_Prov.FirstDisplayedScrollingRowIndex = row.Index;
                            encontrado = true;
                            break; // Selecciona la primera y termina
                        }
                    }
                    if (!encontrado)
                    {
                        dgv_Prov.ClearSelection();
                    }
                }
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {

            txtRTN_Prov.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }

        private void txtRTN_Prov_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRTN_Prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDNI_Prov_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtNombre_Prov_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTelefono_Prov_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_Prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCorreo_Prov_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtDNI_Prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

