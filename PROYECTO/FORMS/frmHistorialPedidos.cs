﻿using PROYECTO.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO.FORMS
{
    public partial class frmHistorialPedidos : Form
    {
        public frmHistorialPedidos()
        {
            InitializeComponent();
        }

        int numpedido = 1;
        int estado = 1;
        string pedidosid;
        DataTable dtCount = new DataTable();        //declaracion del datatable para almacenar los datos
        public void ObtenerDatosCarritos()      //funcion para obtener los datos del carrito
        {
            DataTable dt = new DataTable();
            Cconexion conexion = new Cconexion();
            //declaracion de las clases necesarias
            clsPersonasid per = new clsPersonasid();

            SqlConnection cn = conexion.leer();
            SqlCommand CantPed = new SqlCommand("SELECT DISTINCT  p.Pedido_ID FROM Pedidos p INNER JOIN Carritos c ON p.Pedido_ID = c.Pedido_ID WHERE p.Estado = 1 AND c.Usuarios_ID = '"+per.getcodUsu()+"'", cn);
            SqlDataAdapter DACount = new SqlDataAdapter(CantPed);   //obtener solo la cantidad del pedido desde la tabla pedidos y carritos con el estado de aun no aceptado o igual a 1.
            dtCount.Clear();
            DACount.Fill(dtCount);
           if(dtCount.Rows.Count == 0)
            {
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = false;
                btnCancelar.Enabled = false;

            }
           else
            {
                btnSiguiente.Enabled = true;
                btnAnterior.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (dtCount.Rows.Count!=0)
            {
                lblNumPed.Text = numpedido.ToString() + " / " + dtCount.Rows.Count;

                if (numpedido < 2)
                {
                    btnAnterior.Visible = false;//muestra los botones necesarios y va cambiando segun sea el pedido.
                }
                else
                {
                    btnAnterior.Visible = true;
                }

                if (numpedido > dtCount.Rows.Count - 1)
                {
                    btnSiguiente.Visible = false;
                }
                else
                {
                    btnSiguiente.Visible = true;
                }

                try
                {

                    if (cn.State == ConnectionState.Open)
                    {


                        SqlCommand ExtraerPedido = new SqlCommand("ObtenerDatosCarritoCliente", cn);
                        //procedimiento almacenado para obtener los datos del carrito.
                        ExtraerPedido.CommandType = CommandType.StoredProcedure;
                        ExtraerPedido.Parameters.AddWithValue("@pedido ", numpedido);
                        ExtraerPedido.Parameters.AddWithValue("@estado ", estado);
                        ExtraerPedido.Parameters.AddWithValue("@usuarioID ", per.getcodUsu());


                        SqlDataAdapter da = new SqlDataAdapter(ExtraerPedido);
                        da.Fill(dt);
                        DataView data = new DataView(dt);

                        pedidosid = dt.Rows[0][0].ToString();
                        lblNombre_Cliente.Text = dt.Rows[0][1].ToString();
                        lblIdentidad.Text = dt.Rows[0][2].ToString();
                        lblDireccion.Text = dt.Rows[0][3].ToString();
                        lblTelefono.Text = dt.Rows[0][4].ToString();
                        lblFecha.Text = dt.Rows[0][5].ToString();

                        dataGridView1.DataSource = data.ToTable(false, "nombre_producto", "Precio", "cantidad");
                        //al data grid view se usan los datos del datatable para mostrar el pedido.
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
            else
            {
                DataTable dataTable = new DataTable();
                dataGridView1.DataSource=dataTable;
                lblNumPed.Text = "0" + " / " + "0";     //si no encuentra pedidos limpia todo slos campos y reinicia el contador de pedidos en el label.
                lblTelefono.Text = "";
                lblNombre_Cliente.Text = "";
                lblDireccion.Text = "";
                lblIdentidad.Text = "";
                lblFecha.Text = "";
            }
           
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();
            //para eliminar un pedido en caso de no ser apto a ojos del administrados
            //consulta sql para borrar el pedido de carritos y de pedidos.
            SqlCommand cancelarCarrito = new SqlCommand("Delete from Carritos where Pedido_ID='"+pedidosid+"'",cn);
            SqlCommand cancelarPedido = new SqlCommand("Delete from Pedidos where Pedido_ID='" + pedidosid + "'",cn);
            cancelarCarrito.ExecuteNonQuery();
            cancelarPedido.ExecuteNonQuery();
            lblNumPed.Text = "0" + " / " +"0";
            lblTelefono.Text = "";
            lblNombre_Cliente.Text = "";
            lblDireccion.Text = "";
            lblIdentidad.Text = "";
            lblFecha.Text = "";
            numpedido = 1;
            pedidosid = "";
            ObtenerDatosCarritos();     //limpia todos los campos y trata de obtener nuevos datos del carrito.

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            numpedido--;
            ObtenerDatosCarritos();
            lblNumPed.Text = numpedido.ToString() + " / " + dtCount.Rows.Count;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            numpedido++;
            ObtenerDatosCarritos();
            lblNumPed.Text = numpedido.ToString() + " / " + dtCount.Rows.Count;

        }

        private void frmHistorialPedidos_Load(object sender, EventArgs e)
        {
            lblNumPed.Text = "0" + " / " + "0";
            ObtenerDatosCarritos();
            
        }

        
    }
}
