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

       

       

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            val.validarcm(cmbCategoria.Text);

            if (txtRTN_Prov.Text == "" || txtDNI_Prov.Text == "" || txtNombre_Prov.Text == "" || txtTelefono_Prov.Text == "" || txtCorreo_Prov.Text == "" || txtDireccion_Prov.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {

                if (errorProvider1.GetError(txtRTN_Prov) == "" && errorProvider1.GetError(txtDNI_Prov) == "" && errorProvider1.GetError(txtNombre_Prov) == "" && errorProvider1.GetError(txtTelefono_Prov) == "" && errorProvider1.GetError(txtCorreo_Prov) == "" && errorProvider1.GetError(txtDireccion_Prov) == "")
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRTN_Prov.Text) || string.IsNullOrWhiteSpace(txtDNI_Prov.Text) || string.IsNullOrWhiteSpace(txtNombre_Prov.Text) || string.IsNullOrWhiteSpace(txtDireccion_Prov.Text) || (this.txtTelefono_Prov.Text == "0" || string.IsNullOrWhiteSpace(this.txtTelefono_Prov.Text)) || string.IsNullOrWhiteSpace(txtCorreo_Prov.Text) || string.IsNullOrWhiteSpace(txtDireccion_Prov.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text))
            {
                MessageBox.Show("Por favor, seleccione una fila del Data Grid View.");

                return;
            }
            else
            {
                if (errorProvider1.GetError(txtRTN_Prov) == "" && errorProvider1.GetError(txtDNI_Prov) == "" && errorProvider1.GetError(txtNombre_Prov) == "" && errorProvider1.GetError(txtTelefono_Prov) == "" && errorProvider1.GetError(txtCorreo_Prov) == "" && errorProvider1.GetError(txtDireccion_Prov) == "")
                {
                    Modificar_Prov();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            errorProvider1.SetError(txtRTN_Prov, "");
            errorProvider1.SetError(txtDNI_Prov, "");
            errorProvider1.SetError(txtNombre_Prov, "");
            errorProvider1.SetError(txtTelefono_Prov, "");
            errorProvider1.SetError(txtCorreo_Prov, "");
            errorProvider1.SetError(txtDireccion_Prov, "");

            btnAgregar.Enabled = true;
            txtRTN_Prov.Focus();
            dgv_Prov.ClearSelection();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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

        private void txtCorreo_Prov_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCorreo_Prov, val.txt_vacio(txtCorreo_Prov.Text) + val.espacio_inicio_final(txtCorreo_Prov.Text) + val.validar_correo(txtCorreo_Prov.Text) + val.doble_espacio(txtCorreo_Prov.Text));
        }

        private void txtTelefono_Prov_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTelefono_Prov, val.txt_vacio(txtTelefono_Prov.Text) + val.espacio_inicio_final(txtTelefono_Prov.Text) + val.validarnumerotell(txtTelefono_Prov.Text) + val.rango_8(txtTelefono_Prov.Text));
        }

        private void txtNombre_Prov_TextChanged_1(object sender, EventArgs e)
        {
            //errorProvider1.SetError(txtNombre_Prov, val.txt_vacio(txtNombre_Prov.Text) + val.espacio_inicio_final(txtNombre_Prov.Text) + val.validarletra_espacio(txtNombre_Prov.Text) + val.rango_nombre(txtNombre_Prov.Text) + val.doble_espacio(txtNombre_Prov.Text) + val.validar_tripleCaracter(txtNombre_Prov.Text));
        }

        private void txtDNI_Prov_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDNI_Prov, val.txt_vacio(txtDNI_Prov.Text) + val.espacio_inicio_final(txtDNI_Prov.Text) + val.rango_13(txtDNI_Prov.Text) + val.espacio(txtDNI_Prov.Text) + val.validar_dni(txtDNI_Prov.Text));
        }

        private void txtRTN_Prov_TextChanged_1(object sender, EventArgs e)
        {
            //errorProvider1.SetError(txtRTN_Prov, val.txt_vacio(txtRTN_Prov.Text) + val.espacio_inicio_final(txtRTN_Prov.Text) + val.rango_14(txtRTN_Prov.Text) + val.espacio(txtRTN_Prov.Text));
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }
    }
}

