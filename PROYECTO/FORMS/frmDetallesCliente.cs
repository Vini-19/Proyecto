﻿using Proyecto_de_desarrolo.Clases;
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

        clsValidaciones val = new clsValidaciones();
        private void btnEnviar_Click(object sender, EventArgs e)
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
                DataTable carrito = ObtenerDatosCarrito(usuarioId);
                string nombreCliente = txtNombre.Text;
                string numeroIdentidad = txtIdentidad.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;

                if (errorProvider1.GetError(txtNombre) == "" && errorProvider1.GetError(txtIdentidad) == "" && errorProvider1.GetError(txtDireccion) == "" && errorProvider1.GetError(txtTelefono) == "")
                {
                    // Insertar los datos en la tabla de Pedidos
                    InsertarPedido(usuarioId, carrito, nombreCliente, numeroIdentidad, direccion, telefono);

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Pedido enviado correctamente.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }


            }



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

        private void txtNombre_TextChanged(object sender, EventArgs e)
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
            errorProvider1.SetError(txtTelefono, val.txt_vacio(txtTelefono.Text) + val.espacio_inicio_final(txtTelefono.Text) + val.validarnumerotell(txtTelefono.Text) + val.rango_8(txtTelefono.Text));

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.validarnum(e);
        }
    }

}





