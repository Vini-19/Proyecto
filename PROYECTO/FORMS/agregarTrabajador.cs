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
            DataGridView(); //llamada a la funcion de llenado del data grid view. Siempre al inicializar el formulario.
        }

        clsValidaciones val = new clsValidaciones();    //declaracion de la clase de validaciones.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsTrabajadores Trabajador = new clsTrabajadores();
            clsRegistro registro = new clsRegistro();

            Cconexion conexion = new Cconexion();       //declaracion de la clase de conexion para conectar a la base de datos.

            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return; //encaso de que los campos esten vacios no pernitira agregar un nuevo trabajador.

            }
            else
            {
                Trabajador.setrtn(txtRTN_Trabajador.Text);      //lamado al set de cada dato mediante la clase clsTrabajadores y sus atributos privados.
                Trabajador.setdni(txtDNI_Trabajador.Text);
                Trabajador.setnombre(txtNombre_Trabajador.Text);
                Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
                Trabajador.setcorreo(txtCorreo_Trabajador.Text);
                Trabajador.setdireccion(txtDireccion_Trabajador.Text);
                registro.setUsu(txtUsuario.Text);
                registro.setContra(txtContra.Text);
                registro.setPregunta("Escriba su codigo de empleado");
                registro.setRespuesta(txtCodigo.Text);


                DateTime fechaInscripcion = DateTime.Today;     //saca la fecha actual para registrarla correctamente.
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "")
                {

                    if (conexion.VerificarClienteExistente(Trabajador.getdni()))
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador con ese DNI.");   //si es DNI esta repetido no permite ingresar el trabajador.
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(Trabajador.getrtn()) | string.IsNullOrWhiteSpace(Trabajador.getdni()) || string.IsNullOrWhiteSpace(Trabajador.getnombre()) || string.IsNullOrWhiteSpace(Trabajador.gettelefono().ToString()) || string.IsNullOrWhiteSpace(Trabajador.getcorreo()) || string.IsNullOrWhiteSpace(Trabajador.getdireccion()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");  //si es null o esta en blanco el if no permite pasar.
                        return;
                    }

                    conexion.RegistroCliente(Trabajador.getrtn(), Trabajador.getdni(), Trabajador.getnombre(), Trabajador.getrol(), Trabajador.getestado(), Trabajador.gettelefono(), Trabajador.getcorreo(), Trabajador.getdireccion(), fechaInscripcion);
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 2);
                    //llamada a las funciones de registro de cliente y registro de usuario, enviamos los datos para que se almacenen en los datos privados.

                    limpiar();  //llamada a la funcion limpiar que limpia los textbox y otros campos.
                    errorProvider1.SetError(txtCodigo, "");
                    MessageBox.Show("Se registro correctamente.");
                    DataGridView();
                    txtRTN_Trabajador.Focus();      //focus al textbox del rtn en caso de que se haya registrado correctamente todos los datos.
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
        }



        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)    //si el rowindex es distinto de cero, es decir si hay datos se agregaran al data grid view.
            {
                DataGridViewRow row = dgvTrabajador.Rows[e.RowIndex];

                txtRTN_Trabajador.Text = row.Cells["RTN_Persona"].Value.ToString();     //agregamos las filas del data grid.
                txtDNI_Trabajador.Text = row.Cells["DNI_Persona"].Value.ToString();
                txtNombre_Trabajador.Text = row.Cells["Primer_Nombre"].Value.ToString();
                txtTelefono_Trabajador.Text = row.Cells["Numero_Telefono"].Value.ToString();
                txtCorreo_Trabajador.Text = row.Cells["Correo"].Value.ToString();
                txtDireccion_Trabajador.Text = row.Cells["Direccion"].Value.ToString();

                btnAgregar.Enabled = false;
            }
        }

        private void FiltrarDatos(string texto)     //funcion para el boton buscar, filtra los datos en base al primer nombre del trabajdor.
        {
            DataTable dt = (DataTable)dgvTrabajador.DataSource;
            if (dt != null)
            {
                dgvTrabajador.ClearSelection(); //borra la selecicon de las celdas seleciconadas en caso de que no haya datos en el campo.

                if (!string.IsNullOrEmpty(texto))
                {
                    bool encontrado = false;    //variable booleana para verificar si se encuentra el trabajdor buscado.

                    foreach (DataGridViewRow row in dgvTrabajador.Rows)
                    {
                        if (row.Cells["Primer_Nombre"].Value != null && row.Cells["Primer_Nombre"].Value.ToString().ToLower().Contains(texto.ToLower()))
                        {
                            row.Selected = true;
                            dgvTrabajador.FirstDisplayedScrollingRowIndex = row.Index;      //muestra y selecciona el primer indice encontrado.
                            encontrado = true;
                            break; // Selecciona la primera y termina
                        }
                    }
                    if (!encontrado)
                    {
                        dgvTrabajador.ClearSelection();     //si no encuentra uno quita las filas seleccionadas y deja en blanco
                    }
                }
            }
        }



        public void DataGridView()  //funcion para llenar nuestro data grid view del formulario de Personas.
        {
            string consultaSql = "SELECT PersonasID, RTN_Persona, DNI_Persona, Primer_Nombre, Estado, Numero_Telefono, Correo, Direccion, Fecha_Inscripcion FROM Personas WHERE Roles_ID = 2";
            //consulta select sql para poder seleccionar los datos de la tabla Personas para llenar el data grid view.

            try
            {
                Cconexion conexion = new Cconexion();   //delcaracion de la clase conexion.
                using (SqlConnection cn = conexion.leer())      //utilizando la clase cionexion se llama al metodo leer.
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consultaSql, cn);     //sql adapter para almacenar los datos recibidos de la consulta sql.
                    DataSet dataSet = new DataSet();
                    adaptador.Fill(dataSet, "Personas"); //llena el data set denominado como personas con los datos recbidos del sql.

                    dgvTrabajador.DataSource = dataSet.Tables["Personas"];      //enviamos al data grid view llamado dgvTrabajador los datos obtenidos en el dataset Personas.


                    dgvTrabajador.Columns["PersonasID"].HeaderText = "Personas ID";         //Todos los datos obtenidos tienen su mismo nombre de headers en las columnas.
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
                MessageBox.Show("Error al cargar datos: " + ex.Message);    //catch con mensaje de error en caso de que la accion no se complete correctamente.
            }
        }
        private void agregarTrabajador_Load(object sender, EventArgs e)
        {
            txtRTN_Trabajador.Focus();      //al cargar el formulario por predeterminado el focus sera en el primer campo de trabajador, que es el RTN
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();      //FUNCION para llamar al boton de limpiar para limpiar los campos actuales y dejarlo en blanco.

           
        }
        public void limpiar()       //funcion limpiar   para limpiar los campos actuales y dejarlo en blanco
        {
            txtRTN_Trabajador.Text = "";        //declaracion de todos los campos en blanco, en este caso todos los textbox.
            txtDNI_Trabajador.Text = "";
            txtNombre_Trabajador.Text = "";
            txtTelefono_Trabajador.Text = "";
            txtCorreo_Trabajador.Text = "";
            txtDireccion_Trabajador.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
            txtCodigo.Text = "";


            errorProvider1.SetError(txtRTN_Trabajador, "");     //error provider para dar un mensaje de error en caso de que las validaciones no se cumplan.
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
            //evento textchanged del rtn con error provider para identificar errores que no coincidanc con las validaciones.
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos(txtBuscar.Text);   //al momento de que cambie el texto escrito en el txtBuscar, se llama a filtrar datos para ir buscando mientras se escribe.
        }

        public void Modificar_Trab()    //funcion para modificar un trabajador
        {
            clsTrabajadores Trabajador = new clsTrabajadores(); //llamado nuevamente a la clase trabajadores.

            Trabajador.setrtn(txtRTN_Trabajador.Text);      //enviamos con set a la clase trabajadores con atributos privados el contenido de los textbox.
            Trabajador.setdni(txtDNI_Trabajador.Text);
            Trabajador.setnombre(txtNombre_Trabajador.Text);
            Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
            Trabajador.setcorreo(txtCorreo_Trabajador.Text);
            Trabajador.setdireccion(txtDireccion_Trabajador.Text);
            Cconexion conexion = new Cconexion();

            try
            {
                using (SqlConnection cn = conexion.leer())      //abre y cierra la conexion para evitar errores de conectividad con formularios anteriores.
                {
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();     //cierra la conexion
                        cn.Open();      //la abre la conexion nuevamente.
                    }

                    if (cn.State == ConnectionState.Open)       //si la conexion esta abierta
                    {
                        int ID_Trabajador = Convert.ToInt32(dgvTrabajador.SelectedRows[0].Cells["PersonasID"].Value);   //sacamos el id del trabajdor y lo almacenamos para buscar en PersonasID.

                        SqlCommand actualizarTrabajador = new SqlCommand("PA_ActualizarCliente", cn);       //dictamos que enviaremos un comando sql.
                        actualizarTrabajador.CommandType = CommandType.StoredProcedure;         //ese comando sera identificado como un procedimiento almacenado.
                        using (SqlCommand comando = new SqlCommand("PA_ActualizarCliente", cn))         //nombre del procedimiento almacenado para actualizar
                        {
                            actualizarTrabajador.Parameters.AddWithValue("@RTN", Trabajador.getrtn());      //obtenemos los datos guardados en la clase de trabajador en sus atributos privados.
                            actualizarTrabajador.Parameters.AddWithValue("@DNI", Trabajador.getdni());
                            actualizarTrabajador.Parameters.AddWithValue("@nombre", Trabajador.getnombre());
                            actualizarTrabajador.Parameters.AddWithValue("@telefono", Trabajador.gettelefono());
                            actualizarTrabajador.Parameters.AddWithValue("@correo", Trabajador.getcorreo());
                            actualizarTrabajador.Parameters.AddWithValue("@direccion", Trabajador.getdireccion());
                            actualizarTrabajador.Parameters.AddWithValue("@ClienteID", ID_Trabajador);

                            int Actualizacion = actualizarTrabajador.ExecuteNonQuery();
                            DataGridView();     //llamada a la funcion para actualizar ese data grid view.

                            if (Actualizacion > 0)      //si si se actualizo algo
                            {
                                limpiar();      //limpia todos los textbox
                                btnAgregar.Enabled = true;      //permite usar el boton de agregar.
                                MessageBox.Show("Trabajador modificado correctamente");  //mensake de confimracion de que el trabajdor se modifico correctamente.
                                txtRTN_Trabajador.Focus();          //focus al textbox de rtn por si se requiere agregar o modificar otro trabajdor.
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el trabajador");      //mensaje de error en caso de que haya habido problemas modificando el trabajador
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error de conexión.");      //mensaje en caso de que por algun motivo no se haya podido establecer conexion con la base de datos y el servidor.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message); //mensaje en caso de que por algun motivo no se haya podido establecer conexion con la base de datos y el servidor.
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)     //instancia del evento click del boton modificar.
        {
            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un trabajador antes de poder ejecutar la acción.");  //si estan vacios los campos no permite avanzar.

                return;
            }
            else
            {
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "" && errorProvider1.GetError(txtDireccion_Trabajador) == "")
                {
                    Modificar_Trab();       //si todos lso campos estan llenos y no se encuentran errores en las validaciones, permite llamar a la funcion modificar.
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                    //mensaje en caos de que los campos si esten llenos pero no cumplan con las especificaciones de las validaciones.
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)      //evento click del boton eliminar.
        {
            if (dgvTrabajador.SelectedRows.Count > 0)
            {
                int TrabajadorID = Convert.ToInt32(dgvTrabajador.SelectedRows[0].Cells["PersonasID"].Value);        //obtenermos el id del trabajador

                Cconexion conexion = new Cconexion();       //instancia de la clase conexion.

                try
                {
                    using (SqlConnection cn = conexion.leer())
                    {
                        if (cn.State == ConnectionState.Closed)
                        {
                            cn.Open();      //abrimos la conexion nuevamente con el servidor y con la base de datos.
                        }

                        SqlCommand comandoEliminarTrabajador = new SqlCommand("PA_MarcarClienteInactivo", cn);      //procedimeinto almacenado para marcar como inactivo un trabajdor.
                        comandoEliminarTrabajador.CommandType = CommandType.StoredProcedure;        //instancia que lo enviado es un procedimeinto almacenado.
                        comandoEliminarTrabajador.Parameters.AddWithValue("@clienteID", TrabajadorID);

                        comandoEliminarTrabajador.ExecuteNonQuery();

                        MessageBox.Show("Trabajador marcado como inactivo correctamente");  //los trabajdores eliminados se marcan como inactivos.


                        DataGridView();     //se actualiza el data grid view desde la base de datos.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar conectar: " + ex.Message);       //error de conexion mientras se hacian los cambios.
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un trabajador para marcar como inactivo.");      //en caso de no haber seleccionado en el data grid view.    
            }
        }

        private void txtDNI_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDNI_Trabajador, val.txt_vacio(txtDNI_Trabajador.Text) + val.espacio_inicio_final(txtDNI_Trabajador.Text) + val.rango_13(txtDNI_Trabajador.Text) + val.espacio(txtDNI_Trabajador.Text) + val.validar_dni(txtDNI_Trabajador.Text));
            //validacion de error en caso de cambios en el textbox
        }

        private void txtNombre_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre_Trabajador, val.txt_vacio(txtNombre_Trabajador.Text) + val.espacio_inicio_final(txtNombre_Trabajador.Text) + val.rango_nombre(txtNombre_Trabajador.Text) + val.validarletra_espacio(txtNombre_Trabajador.Text));
            //validacion de error en caso de cambios en el textbox
        }

        private void txtDireccion_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDireccion_Trabajador, val.txt_vacio(txtDireccion_Trabajador.Text) + val.espacio_inicio_final(txtDireccion_Trabajador.Text));
            //validacion de error en caso de cambios en el textbox
        }

        private void txtTelefono_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTelefono_Trabajador, val.txt_vacio(txtTelefono_Trabajador.Text) + val.espacio_inicio_final(txtTelefono_Trabajador.Text) + val.validarnumerotell(txtTelefono_Trabajador.Text) + val.rango_8(txtTelefono_Trabajador.Text));
            //validacion de error en caso de cambios en el textbox
        }

        private void txtCorreo_Trabajador_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCorreo_Trabajador, val.txt_vacio(txtCorreo_Trabajador.Text) + val.espacio_inicio_final(txtCorreo_Trabajador.Text));
            //validacion de error en caso de cambios en el textbox
        }

        private void txtRTN_Trabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
            //validacion de error en caso de cambios en el textbox
        }

        private void txtDNI_Trabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
            //validacion de error en caso de cambios en el textbox
        }

        private void txtTelefono_Trabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
            //validacion de error en caso de cambios en el textbox
        }

        private void dgvTrabajador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRTN_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[1].Value.ToString();        //seleccionar los datos del data grid view.
            txtDNI_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[2].Value.ToString();
            txtNombre_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[3].Value.ToString();
            txtTelefono_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[4].Value.ToString();
            txtCorreo_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[5].Value.ToString();
            txtDireccion_Trabajador.Text = dgvTrabajador.CurrentRow.Cells[6].Value.ToString();

            btnAgregar.Enabled = false;     //deshabilita el boton de agregar,
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsTrabajadores Trabajador = new clsTrabajadores();     //instancia de la clase de trabajador.
            clsRegistro registro = new clsRegistro();           //instancia de la clase de registro.

            Cconexion conexion = new Cconexion();       //instancia de la clase de conexion.

            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");      //validacion para verificar campos en blanco.
                return;

            }
            else
            {
                Trabajador.setrtn(txtRTN_Trabajador.Text);      //utiliza el set para mandar los datos de los textbox a las variables privadas de la clase trabajador.
                Trabajador.setdni(txtDNI_Trabajador.Text);//utiliza el set para mandar los datos de los textbox a las variables privadas de la clase trabajador.
                Trabajador.setnombre(txtNombre_Trabajador.Text);//utiliza el set para mandar los datos de los textbox a las variables privadas de la clase trabajador.
                Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
                Trabajador.setcorreo(txtCorreo_Trabajador.Text);
                Trabajador.setdireccion(txtDireccion_Trabajador.Text);//utiliza el set para mandar los datos de los textbox a las variables privadas de la clase trabajador.
                registro.setUsu(txtUsuario.Text);
                registro.setContra(txtContra.Text);//utiliza el set para mandar los datos de los textbox a las variables privadas de la clase trabajador.
                registro.setPregunta("Escriba su codigo de empleado");
                registro.setRespuesta(txtCodigo.Text);


                DateTime fechaInscripcion = DateTime.Today;     //obtiene la fecha del dia actual.
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "")
                {

                    if (conexion.VerificarClienteExistente(Trabajador.getdni()))        //verifica si el trabajador ya existe porque tiene el mismo dni.
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador con ese DNI.");
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(Trabajador.getrtn()) | string.IsNullOrWhiteSpace(Trabajador.getdni()) || string.IsNullOrWhiteSpace(Trabajador.getnombre()) || string.IsNullOrWhiteSpace(Trabajador.gettelefono().ToString()) || string.IsNullOrWhiteSpace(Trabajador.getcorreo()) || string.IsNullOrWhiteSpace(Trabajador.getdireccion()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;     //si los campos estan en blanco o las variables privadas no contienen datos no permite pasar.
                    }

                    conexion.RegistroCliente(Trabajador.getrtn(), Trabajador.getdni(), Trabajador.getnombre(), Trabajador.getrol(), Trabajador.getestado(), Trabajador.gettelefono(), Trabajador.getcorreo(), Trabajador.getdireccion(), fechaInscripcion);
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 2);      //saca los datos de las variables privadas de la clase trabajador y la clase de registro.

                    limpiar();      //funcion para limpiar los textbox
                    MessageBox.Show("Se registro correctamente.");  //mensaje de confirmacion que se registraron los datos.
                    DataGridView();     //lama a la funcion de llenado del data grid view desde la base de datos para actualizarlo.
                    txtRTN_Trabajador.Focus();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                    //en caso de que los campos no cumplan las especificaciones y validacions.
                }

            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRTN_Trabajador.Text) || string.IsNullOrWhiteSpace(txtDNI_Trabajador.Text) || string.IsNullOrWhiteSpace(txtNombre_Trabajador.Text) || string.IsNullOrWhiteSpace(txtDireccion_Trabajador.Text) || (this.txtTelefono_Trabajador.Text == "0" || string.IsNullOrWhiteSpace(this.txtTelefono_Trabajador.Text)) || string.IsNullOrWhiteSpace(txtCorreo_Trabajador.Text))
            {
                MessageBox.Show("Por favor, seleccione un trabajador antes de poder ejecutar la acción.");
                //en caso de que no haya ningun trabajador seleccionado desde el data grid
                return;
            }
            else
            {
                Modificar_Trab();       //funcion para modificar el trabajador y sus datos.
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();      //lamada a la funcion de limpiar los textbox al darle click al boton de limpiar.
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)        //evento click del boton eliminar.
        {
            if (dgvTrabajador.SelectedRows.Count > 0)
            {
                int TrabajadorID = Convert.ToInt32(dgvTrabajador.SelectedRows[0].Cells["PersonasID"].Value);    //saca el personas id del trabajdor.

                Cconexion conexion = new Cconexion();

                try
                {
                    using (SqlConnection cn = conexion.leer())      //usando la conexion sql.
                    {
                        if (cn.State == ConnectionState.Closed)
                        {
                            cn.Open();      //abre la conexion
                        }

                        SqlCommand comandoEliminarTrabajador = new SqlCommand("PA_MarcarClienteInactivo", cn);  //usa el procedimeinto almacenado para marcar el cliente como inactivo.
                        comandoEliminarTrabajador.CommandType = CommandType.StoredProcedure;
                        comandoEliminarTrabajador.Parameters.AddWithValue("@clienteID", TrabajadorID);  //le enviamos el parametro de trabajador id.

                        comandoEliminarTrabajador.ExecuteNonQuery();

                        MessageBox.Show("Cliente marcado como inactivo correctamente");
                        //mensaje de exito en caso de marcar el cliente como inactivo.

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
                //en caso de que el cliente aun no haya sido seleccionado.
            }
        }

        private void btnAgregar_Click_2(object sender, EventArgs e)     //evento click del boton agregar.
        {
            clsTrabajadores Trabajador = new clsTrabajadores();     //declaracion de la clase de trabajador
            clsRegistro registro = new clsRegistro();       //declaracion de la clase de registro.

            Cconexion conexion = new Cconexion();       //declaracion de la clase de conexion.

            if (txtRTN_Trabajador.Text == "" || txtDNI_Trabajador.Text == "" || txtNombre_Trabajador.Text == "" || txtTelefono_Trabajador.Text == "" || txtCorreo_Trabajador.Text == "" || txtDireccion_Trabajador.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;     //validacion en caso de que los datos de los textbox esten en blanco.

            }
            else
            {
                Trabajador.setrtn(txtRTN_Trabajador.Text);      //para agregar al trabajador envia los datos de los textbox a la clase de trabajdor a sus argumentos privados.
                Trabajador.setdni(txtDNI_Trabajador.Text);
                Trabajador.setnombre(txtNombre_Trabajador.Text);
                Trabajador.settelefono(int.Parse(txtTelefono_Trabajador.Text));
                Trabajador.setcorreo(txtCorreo_Trabajador.Text);
                Trabajador.setdireccion(txtDireccion_Trabajador.Text);
                registro.setUsu(txtUsuario.Text);
                registro.setContra(txtContra.Text);
                registro.setPregunta("Escriba su codigo de empleado");
                registro.setRespuesta(txtCodigo.Text);


                DateTime fechaInscripcion = DateTime.Today; //obtiene la fecha actual.
                if (errorProvider1.GetError(txtRTN_Trabajador) == "" && errorProvider1.GetError(txtDNI_Trabajador) == "" && errorProvider1.GetError(txtNombre_Trabajador) == "" && errorProvider1.GetError(txtTelefono_Trabajador) == "" && errorProvider1.GetError(txtCorreo_Trabajador) == "")
                {
                    //verificacion de los errores brindados por las validaciones.
                    if (conexion.VerificarClienteExistente(Trabajador.getdni()))
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador con ese DNI.");   //verifica si el trabajdor ya existe con el mismo dni
                        return;
                    }

                    if (conexion.VerificarUsuarioExistente(registro.getUsu()))
                    {
                        MessageBox.Show("No se puede agregar el trabajador porque ya existe un trabajador o Usuario con el mismo nombre."); //verifica si existe un trabajador con el mismo nombre de usuario.
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(Trabajador.getrtn()) | string.IsNullOrWhiteSpace(Trabajador.getdni()) || string.IsNullOrWhiteSpace(Trabajador.getnombre()) || string.IsNullOrWhiteSpace(Trabajador.gettelefono().ToString()) || string.IsNullOrWhiteSpace(Trabajador.getcorreo()) || string.IsNullOrWhiteSpace(Trabajador.getdireccion()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");      //encaso de dejar espacios en blanco no deja pasar.
                        return;
                    }

                    conexion.RegistroCliente(Trabajador.getrtn(), Trabajador.getdni(), Trabajador.getnombre(), Trabajador.getrol(), Trabajador.getestado(), Trabajador.gettelefono(), Trabajador.getcorreo(), Trabajador.getdireccion(), fechaInscripcion);
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 2);

                    limpiar();      //limpia los textbox luego de registrar correctamente.
                    MessageBox.Show("Se registro correctamente.");
                    DataGridView();     //llama a la funcion para actualizar el data grid view.
                    txtRTN_Trabajador.Focus();      //lleva el cursor focus al trabajador.
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
                //en caso de tener campos en blanco no permite avanzar.
                return;
            }
            else
            {
                Modificar_Trab();   //llama a la funcion de modificar el trabajador.
            }
        }

        private void btnLimpiar_Click_2(object sender, EventArgs e)
        {
            limpiar();      //llama a la funcion de limpiar
        }

        private void btnEliminar_Click_2(object sender, EventArgs e)
        {
            if (dgvTrabajador.SelectedRows.Count > 0)       //si hay almenos 1 fila seleccionada.
            {
                int TrabajadorID = Convert.ToInt32(dgvTrabajador.SelectedRows[0].Cells["PersonasID"].Value);        //saca el id de la persona y lo convierte a int.

                Cconexion conexion = new Cconexion();       //declaracion de la clase de conexion.

                try
                {
                    using (SqlConnection cn = conexion.leer())
                    {
                        if (cn.State == ConnectionState.Closed)
                        {
                            cn.Open();      //abre la conexion.
                        }

                        SqlCommand comandoEliminarTrabajador = new SqlCommand("PA_MarcarClienteInactivo", cn);      //llamada al procedimiento almacenado para marcar el trabajador como inactivo.
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
