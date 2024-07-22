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

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class agregarTrabajador : Form
    {
        public agregarTrabajador()
        {
            InitializeComponent();
            DataGridView();
        }

        clsValidaciones val = new clsValidaciones();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsTrabajadores Trabajador = new clsTrabajadores();
            clsRegistro registro = new clsRegistro();

            Cconexion conexion = new Cconexion();

            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                Trabajador.setrtn(txtRTN_Trabajador.Text);
                Trabajador.setdni(txtDNI_Trabajador.Text);
                Trabajador.setnombre(txtNombre_Trabajador.Text);
                Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
                Trabajador.setcorreo(txtCorreo_Trabajador.Text);
                Trabajador.setdireccion(txtDireccion_Trabajador.Text);
                registro.setUsu(txtUsuario.Text);
                registro.setContra(txtContra.Text);
                registro.setPregunta("Escriba su codigo de empleado");
                registro.setRespuesta(txtCodigo.Text);


                DateTime fechaInscripcion = DateTime.Today;
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "")
                {

                    if (conexion.VerificarClienteExistente(Trabajador.getdni()))
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador con ese DNI.");
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(Trabajador.getrtn()) | string.IsNullOrWhiteSpace(Trabajador.getdni()) || string.IsNullOrWhiteSpace(Trabajador.getnombre()) || string.IsNullOrWhiteSpace(Trabajador.gettelefono().ToString()) || string.IsNullOrWhiteSpace(Trabajador.getcorreo()) || string.IsNullOrWhiteSpace(Trabajador.getdireccion()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }

                    conexion.RegistroCliente(Trabajador.getrtn(), Trabajador.getdni(), Trabajador.getnombre(), Trabajador.getrol(), Trabajador.getestado(), Trabajador.gettelefono(), Trabajador.getcorreo(), Trabajador.getdireccion(), fechaInscripcion);
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 2);

                    limpiar();
                    errorProvider1.SetError(txtCodigo, "");
                    MessageBox.Show("Se registro correctamente.");
                    DataGridView();
                    txtRTN_Trabajador.Focus();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
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
            string consultaSql = "SELECT PersonasID, RTN_Persona, DNI_Persona, Primer_Nombre, Estado, Numero_Telefono, Correo, Direccion, Fecha_Inscripcion FROM Personas WHERE Roles_ID = 2";

            try
            {
                Cconexion conexion = new Cconexion();
                using (SqlConnection cn = conexion.leer())
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, cn);
                    DataSet dataSet = new DataSet();
                    adaptador.Fill(dataSet, "Personas");

                    dgvTrabajador.DataSource = dataSet.Tables["Personas"];


                    dgvTrabajador.Columns["PersonasID"].HeaderText = "Personas ID";
                    dgvTrabajador.Columns["RTN_Persona"].HeaderText = "RTN";
                    dgvTrabajador.Columns["DNI_Persona"].HeaderText = "DNI";
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
            txtUsuario.Text = "";
            txtContra.Text = "";
            txtCodigo.Text = "";


            errorProvider1.SetError(txtRTN_Trabajador, "");
            errorProvider1.SetError(txtDNI_Trabajador, "");
            errorProvider1.SetError(txtNombre_Trabajador, "");
            errorProvider1.SetError(txtTelefono_Trabajador, "");
            errorProvider1.SetError(txtCorreo_Trabajador, "");
            errorProvider1.SetError(txtDireccion_Trabajador, "");
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtContra, "");
            errorProvider1.SetError(txtCodigo, "");

            txtRTN_Trabajador.Focus();
        }
        private void txtRTN_Cliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtRTN_Trabajador, val.txt_vacio(txtRTN_Trabajador.Text) + val.espacio_inicio_final(txtRTN_Trabajador.Text) + val.rango_14(txtRTN_Trabajador.Text) + val.espacio(txtRTN_Trabajador.Text));

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
                            actualizarTrabajador.Parameters.AddWithValue("@ClienteID", ID_Trabajador);

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
            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un trabajador antes de poder ejecutar la acción.");

                return;
            }
            else
            {
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "" && errorProvider1.GetError(txtDireccion_Trabajador) == "")
                {
                    Modificar_Trab();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }
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

                        MessageBox.Show("Trabajador marcado como inactivo correctamente");


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
                MessageBox.Show("Por favor, seleccione un trabajador para marcar como inactivo.");
            }
        }

        private void txtDNI_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDNI_Trabajador, val.txt_vacio(txtDNI_Trabajador.Text) + val.espacio_inicio_final(txtDNI_Trabajador.Text) + val.rango_13(txtDNI_Trabajador.Text) + val.espacio(txtDNI_Trabajador.Text) + val.validar_dni(txtDNI_Trabajador.Text));

        }

        private void txtNombre_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre_Trabajador, val.txt_vacio(txtNombre_Trabajador.Text) + val.espacio_inicio_final(txtNombre_Trabajador.Text) + val.rango_nombre(txtNombre_Trabajador.Text) + val.validarletra_espacio(txtNombre_Trabajador.Text));

        }

        private void txtDireccion_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDireccion_Trabajador, val.txt_vacio(txtDireccion_Trabajador.Text) + val.espacio_inicio_final(txtDireccion_Trabajador.Text));
        }

        private void txtTelefono_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTelefono_Trabajador, val.txt_vacio(txtTelefono_Trabajador.Text) + val.espacio_inicio_final(txtTelefono_Trabajador.Text) + val.validarnumerotell(txtTelefono_Trabajador.Text) + val.rango_8(txtTelefono_Trabajador.Text));

        }

        private void txtCorreo_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCorreo_Trabajador, val.txt_vacio(txtCorreo_Trabajador.Text) + val.espacio_inicio_final(txtCorreo_Trabajador.Text));
        }

        private void txtRTN_Trabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtDNI_Trabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtTelefono_Trabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void dgvTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRTN_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[1].Value.ToString();
            txtDNI_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[2].Value.ToString();
            txtNombre_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[3].Value.ToString();
            txtTelefono_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[4].Value.ToString();
            txtCorreo_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[5].Value.ToString();
            txtDireccion_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[6].Value.ToString();

            btnAgregar.Enabled = false;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsTrabajadores Trabajador = new clsTrabajadores();
            clsRegistro registro = new clsRegistro();

            Cconexion conexion = new Cconexion();

            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                Trabajador.setrtn(txtRTN_Trabajador.Text);
                Trabajador.setdni(txtDNI_Trabajador.Text);
                Trabajador.setnombre(txtNombre_Trabajador.Text);
                Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
                Trabajador.setcorreo(txtCorreo_Trabajador.Text);
                Trabajador.setdireccion(txtDireccion_Trabajador.Text);
                registro.setUsu(txtUsuario.Text);
                registro.setContra(txtContra.Text);
                registro.setPregunta("Escriba su codigo de empleado");
                registro.setRespuesta(txtCodigo.Text);


                DateTime fechaInscripcion = DateTime.Today;
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "")
                {

                    if (conexion.VerificarClienteExistente(Trabajador.getdni()))
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador con ese DNI.");
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(Trabajador.getrtn()) | string.IsNullOrWhiteSpace(Trabajador.getdni()) || string.IsNullOrWhiteSpace(Trabajador.getnombre()) || string.IsNullOrWhiteSpace(Trabajador.gettelefono().ToString()) || string.IsNullOrWhiteSpace(Trabajador.getcorreo()) || string.IsNullOrWhiteSpace(Trabajador.getdireccion()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }

                    conexion.RegistroCliente(Trabajador.getrtn(), Trabajador.getdni(), Trabajador.getnombre(), Trabajador.getrol(), Trabajador.getestado(), Trabajador.gettelefono(), Trabajador.getcorreo(), Trabajador.getdireccion(), fechaInscripcion);
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 2);

                    limpiar();
                    MessageBox.Show("Se registro correctamente.");
                    DataGridView();
                    txtRTN_Trabajador.Focus();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
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

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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

        private void btnAgregar_Click_2(object sender, EventArgs e)
        {
            clsTrabajadores Trabajador = new clsTrabajadores();
            clsRegistro registro = new clsRegistro();

            Cconexion conexion = new Cconexion();

            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                Trabajador.setrtn(txtRTN_Trabajador.Text);
                Trabajador.setdni(txtDNI_Trabajador.Text);
                Trabajador.setnombre(txtNombre_Trabajador.Text);
                Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
                Trabajador.setcorreo(txtCorreo_Trabajador.Text);
                Trabajador.setdireccion(txtDireccion_Trabajador.Text);
                registro.setUsu(txtUsuario.Text);
                registro.setContra(txtContra.Text);
                registro.setPregunta("Escriba su codigo de empleado");
                registro.setRespuesta(txtCodigo.Text);


                DateTime fechaInscripcion = DateTime.Today;
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "")
                {

                    if (conexion.VerificarClienteExistente(Trabajador.getdni()))
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador con ese DNI.");
                        return;
                    }

                    if (conexion.VerificarUsuarioExistente(registro.getUsu()))
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador o Usuario con el mismo nombre.");
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(Trabajador.getrtn()) | string.IsNullOrWhiteSpace(Trabajador.getdni()) || string.IsNullOrWhiteSpace(Trabajador.getnombre()) || string.IsNullOrWhiteSpace(Trabajador.gettelefono().ToString()) || string.IsNullOrWhiteSpace(Trabajador.getcorreo()) || string.IsNullOrWhiteSpace(Trabajador.getdireccion()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }

                    conexion.RegistroCliente(Trabajador.getrtn(), Trabajador.getdni(), Trabajador.getnombre(), Trabajador.getrol(), Trabajador.getestado(), Trabajador.gettelefono(), Trabajador.getcorreo(), Trabajador.getdireccion(), fechaInscripcion);
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 2);

                    limpiar();
                    MessageBox.Show("Se registro correctamente.");
                    DataGridView();
                    txtRTN_Trabajador.Focus();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
        }

        private void btnModificar_Click_2(object sender, EventArgs e)
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

        private void btnLimpiar_Click_2(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click_2(object sender, EventArgs e)
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

        private void txtRTN_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtRTN_Trabajador, val.txt_vacio(txtRTN_Trabajador.Text) + val.espacio_inicio_final(txtRTN_Trabajador.Text) + val.rango_14(txtRTN_Trabajador.Text) + val.espacio(txtRTN_Trabajador.Text));
        }

        private void txtDNI_Trabajador_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDNI_Trabajador, val.txt_vacio(txtDNI_Trabajador.Text) + val.espacio_inicio_final(txtDNI_Trabajador.Text) + val.rango_13(txtDNI_Trabajador.Text) + val.espacio(txtDNI_Trabajador.Text) + val.validar_dni(txtDNI_Trabajador.Text));

        }

        private void txtDireccion_Trabajador_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDireccion_Trabajador, val.txt_vacio(txtDireccion_Trabajador.Text) + val.espacio_inicio_final(txtDireccion_Trabajador.Text) + val.rango_direccion(txtDireccion_Trabajador.Text) + val.doble_espacio(txtDireccion_Trabajador.Text) + val.validar_tripleCaracter(txtDireccion_Trabajador.Text));
        }

        private void txtTelefono_Trabajador_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTelefono_Trabajador, val.txt_vacio(txtTelefono_Trabajador.Text) + val.espacio_inicio_final(txtTelefono_Trabajador.Text) + val.validarnumerotell(txtTelefono_Trabajador.Text) + val.rango_8(txtTelefono_Trabajador.Text));
        }

        private void txtCorreo_Trabajador_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCorreo_Trabajador, val.txt_vacio(txtCorreo_Trabajador.Text) + val.espacio_inicio_final(txtCorreo_Trabajador.Text) + val.validar_correo(txtCorreo_Trabajador.Text));
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtUsuario, val.txt_vacio(txtUsuario.Text) + val.rango_usuario(txtUsuario.Text) + val.espacio_inicio_final(txtUsuario.Text) + val.espacio(txtUsuario.Text));
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtContra, val.validarcontra(txtContra.Text));
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCodigo, val.rango_8(txtCodigo.Text));
        }

        private void dgvTrabajador_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void txtRTN_Trabajador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtDNI_Trabajador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtTelefono_Trabajador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtNombre_Trabajador_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre_Trabajador, val.txt_vacio(txtNombre_Trabajador.Text) + val.espacio_inicio_final(txtNombre_Trabajador.Text) + val.validarletra_espacio(txtNombre_Trabajador.Text) + val.rango_nombre(txtNombre_Trabajador.Text) + val.doble_espacio(txtNombre_Trabajador.Text) + val.validar_tripleCaracter(txtNombre_Trabajador.Text));
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);
        }

        private void agregarTrabajador_Load_1(object sender, EventArgs e)
        {

        }
    }
}
