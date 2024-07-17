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
    public partial class frmDetallesCliente : Form
    {
        public frmDetallesCliente()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            clsPersonasid usu = new clsPersonasid();
            string usuarioId = usu.getcodUsu();

            DataTable carrito = ObtenerDatosCarrito(usuarioId);
            string nombreCliente = txtNombre.Text;
            string numeroIdentidad = txtIdentidad.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            // Insertar los datos en la tabla de Pedidos
            InsertarPedido(usuarioId, carrito, nombreCliente, numeroIdentidad, direccion, telefono);

            // Mostrar mensaje de éxito
            MessageBox.Show("Pedido enviado correctamente.");
            this.Hide();
        }

        private DataTable ObtenerDatosCarrito(string usuarioId)
        {
            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();

            string consulta = "SELECT Productos_ID, cantidad FROM Carritos WHERE Usuarios_ID = @UsuarioID AND estado = 1";
            SqlCommand comando = new SqlCommand(consulta, cn);
            comando.Parameters.AddWithValue("@UsuarioID", usuarioId);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            return dataTable;
        }

        private void InsertarPedido(string usuarioId, DataTable carrito, string nombreCliente, string numeroIdentidad, string direccion, string telefono)
        {
            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();

            foreach (DataRow row in carrito.Rows)
            {
                string consultaCarritoID = "SELECT TOP 1 Carrito_ID FROM Carritos WHERE Usuarios_ID = @UsuarioID AND estado = 1";
                SqlCommand comandoCarritoID = new SqlCommand(consultaCarritoID, cn);
                comandoCarritoID.Parameters.AddWithValue("@UsuarioID", usuarioId);
                int carritoID = (int)comandoCarritoID.ExecuteScalar();



                string consulta = @"INSERT INTO Pedidos 
                            (Nombre_Cliente, Numero_Identidad, Direccion, Telefono, Carrito_ID, Productos_ID, Usuarios_ID, Cantidad, Fecha, Estado) 
                            VALUES 
                            (@NombreCliente, @NumeroIdentidad, @Direccion, @Telefono, @CarritoID, @ProductoID, @UsuarioID, @Cantidad, @Fecha, @Estado)";
                SqlCommand comando = new SqlCommand(consulta, cn);
                comando.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                comando.Parameters.AddWithValue("@NumeroIdentidad", numeroIdentidad);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Telefono", telefono);
                comando.Parameters.AddWithValue("@CarritoID", carritoID);
                comando.Parameters.AddWithValue("@ProductoID", (int)row["Productos_ID"]);
                comando.Parameters.AddWithValue("@UsuarioID", usuarioId);
                comando.Parameters.AddWithValue("@Cantidad", (int)row["cantidad"]);
                comando.Parameters.AddWithValue("@Fecha", DateTime.Now);
                comando.Parameters.AddWithValue("@Estado", 1);

                comando.ExecuteNonQuery();
            }
        }

    }





}
