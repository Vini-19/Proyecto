using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmDetallesCliente : Form
    {
        public frmDetallesCliente()
        {
            InitializeComponent();
            CenterToScreen();
        }

        clsValidaciones val = new clsValidaciones();
        private void btnEnviar_Click(object sender, EventArgs e)
        {


        }
        private frmCarrito Formulario1;
        public frmDetallesCliente(frmCarrito form1)
        {
            InitializeComponent();
            this.Formulario1 = form1; // Asignamos la referencia recibida a nuestra variable local
        }

        // Método para llamar a actualizar en Formulario1
        private void LlamarActualizarFormulario1()
        {
            if (Formulario1 != null)
            {
                Formulario1.Actualizar(); // Llamamos al método actualizar en la instancia de Formulario1
            }
            
        }


        private DataTable ObtenerDatosCarrito(string usuarioId)     //saca los datos del carrito.
        {
            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();

            string consulta = "SELECT Productos_ID, cantidad FROM Carritos WHERE Usuarios_ID = @UsuarioID AND estado = 1";
            SqlCommand comando = new SqlCommand(consulta, cn);      //consulta sql para sacar los datos de prodycotos id y carritos donde el estado sea 1 o inactivo.
            comando.Parameters.AddWithValue("@UsuarioID", usuarioId);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);     //llena el datatable con los datos de la consulta sql.

            return dataTable;
        }

        private void InsertarPedido(string usuarioId, DataTable carrito, string nombreCliente, string numeroIdentidad, string direccion, string telefono)
        {
            Cconexion conexion = new Cconexion(); 
            clsPersonasid usuario =new clsPersonasid();
           

            try
            {
                using (SqlConnection cn = conexion.leer())
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand comandoMandarPedido = new SqlCommand("CrearPedido", cn); //comando para crear un nuevo pedido con los detalles de cliente.
                  
                    comandoMandarPedido.CommandType = CommandType.StoredProcedure;
                    comandoMandarPedido.Parameters.AddWithValue("@NombreCliente",nombreCliente);
                    comandoMandarPedido.Parameters.AddWithValue("@numeroIdentidad", numeroIdentidad);
                    comandoMandarPedido.Parameters.AddWithValue("@Direccion",direccion);
                    comandoMandarPedido.Parameters.AddWithValue("@telefono", telefono);
                    comandoMandarPedido.Parameters.AddWithValue("@usuarioID", usuario.getcodUsu());

                    comandoMandarPedido.ExecuteNonQuery();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar: " + ex.Message);
            }
        }


       
        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNombre, val.txt_vacio(txtNombre.Text) + val.espacio_inicio_final(txtNombre.Text) + val.validarletra_espacio(txtNombre.Text) + val.rango_nombre(txtNombre.Text) + val.doble_espacio(txtNombre.Text) + val.validar_tripleCaracter(txtNombre.Text));
        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtIdentidad, val.txt_vacio(txtIdentidad.Text) + val.espacio_inicio_final(txtIdentidad.Text) + val.rango_13(txtIdentidad.Text) + val.espacio(txtIdentidad.Text) + val.validar_dni(txtIdentidad.Text));
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDireccion, val.txt_vacio(txtDireccion.Text) + val.espacio_inicio_final(txtDireccion.Text) + val.rango_direccion(txtDireccion.Text) + val.doble_espacio(txtDireccion.Text) + val.validar_tripleCaracter(txtDireccion.Text));
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTelefono, val.txt_vacio(txtTelefono.Text) + val.espacio_inicio_final(txtTelefono.Text) + val.validarnumerotell(txtTelefono.Text) + val.rango_8(txtTelefono.Text)+val.validar4ceros(txtTelefono.Text));
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            clsPersonasid usu = new clsPersonasid();
            string usuarioId = usu.getcodUsu();
           

            if (txtNombre.Text == "" || txtIdentidad.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                DataTable carrito = ObtenerDatosCarrito(usuarioId);     //saca los datos de los cortes del carrito.
                string nombreCliente = txtNombre.Text;
                string numeroIdentidad = txtIdentidad.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;

                if (errorProvider1.GetError(txtNombre) == "" && errorProvider1.GetError(txtIdentidad) == "" && errorProvider1.GetError(txtDireccion) == "" && errorProvider1.GetError(txtTelefono) == "")
                {
                    // Insertar los datos en la tabla de Pedidos
                    InsertarPedido(usuarioId, carrito, nombreCliente, numeroIdentidad, direccion, telefono);

                    // Mostrar mensaje de éxito
                    
                    string mensaje = "Su pedido fue enviado correctamente a D' La Finca San José.\n\n" +
                                    "Si desea contactar con nosotros por algún cambio puede hacerlo marcando al 33797136.\n\n" +
                                    "También puede encontrarnos en redes sociales como D' La Finca San José.\n\n" +
                                    "Puede realizar su pago vía transferencia a la cuenta No. 744763621 de BAC.\n\n" +
                                    "También incluimos pago contra entrega en efectivo.";

                    MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }
                

            }
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

       
    }

}






