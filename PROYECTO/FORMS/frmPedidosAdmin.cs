using PROYECTO.CLASES;
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
    public partial class frmPedidosAdmin : Form
    {
        public frmPedidosAdmin()
        {
            InitializeComponent();
        }

        int numpedido=1;
        int estado=1;
        string pedidosid;
        DataTable dtCount = new DataTable();

        private void frmPedidosAdmin_Load(object sender, EventArgs e)
        {
      
            ObtenerDatosCarritos();

        }

        public DataTable ObtenerDatosCarritos()
        {
            DataTable dt = new DataTable();
            Cconexion conexion = new Cconexion();

   
            SqlConnection cn = conexion.leer();
            SqlCommand CantPed = new SqlCommand("Select Pedido_ID from Pedidos where Estado='" + estado + "'", cn);
            SqlDataAdapter DACount = new SqlDataAdapter(CantPed);
            dtCount.Clear();
            DACount.Fill(dtCount);
            if (dtCount.Rows.Count == 0)
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
            if (dtCount.Rows.Count != 0)
            {
                lblNumPed.Text = numpedido.ToString() + " / " + dtCount.Rows.Count;

            if (numpedido < 2)
            {
                btnAnterior.Visible = false;
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
                   

                    SqlCommand ExtraerPedido = new SqlCommand("ObtenerDatosCarritoPorPedidoID", cn);

                    ExtraerPedido.CommandType = CommandType.StoredProcedure;
                    ExtraerPedido.Parameters.AddWithValue("@pedido ", numpedido-1);
                    ExtraerPedido.Parameters.AddWithValue("@estado ", estado);

                    SqlDataAdapter da = new SqlDataAdapter(ExtraerPedido);
                    da.Fill(dt);
                    DataView data = new DataView(dt);

                    pedidosid= dt.Rows[0][0].ToString();
                    lblPedido.Text = dt.Rows[0][0].ToString();
                    lblNombre_Cliente.Text = dt.Rows[0][1].ToString();
                    lblIdentidad.Text = dt.Rows[0][2].ToString();
                    lblDireccion.Text = dt.Rows[0][3].ToString();
                    lblTelefono.Text = dt.Rows[0][4].ToString();
                    lblFecha.Text = dt.Rows[0][5].ToString();

                    dataGridView1.DataSource = data.ToTable(false,"nombre_producto","Precio","cantidad");

                        dataGridView1.Columns["nombre_producto"].HeaderText = "Nombre Producto";
                        dataGridView1.Columns["Precio"].HeaderText = "Precio";
                        dataGridView1.Columns["cantidad"].HeaderText = "Cantidad";

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
                dataGridView1.DataSource = dataTable;
                btnConfirmar.Visible = true;
                lblNumPed.Text = "0" + " / " + "0";
                lblTelefono.Text = "";
                lblNombre_Cliente.Text = "";
                lblDireccion.Text = "";
                lblIdentidad.Text = "";
                lblFecha.Text = "";
                numpedido = 1;
                lblPedido.Text = "";
            }
            return dt;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();

            SqlCommand ConfirmarPedido = new SqlCommand("Update Pedidos set Estado = 0 where Pedido_ID='" + lblPedido.Text + "'", cn);
            ConfirmarPedido.ExecuteNonQuery();
            ObtenerDatosCarritos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            numpedido--;
            ObtenerDatosCarritos();
            lblNumPed.Text = numpedido.ToString() + " / "+ dtCount.Rows.Count; 

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            numpedido++;
            ObtenerDatosCarritos();
            lblNumPed.Text = numpedido.ToString() + " / " + dtCount.Rows.Count;

        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            estado = 1;
            numpedido = 1;
            btnConfirmar.Visible = true;
            lblNumPed.Text = "0" + " / " + "0";
            lblTelefono.Text = "";
            lblNombre_Cliente.Text = "";
            lblDireccion.Text = "";
            lblIdentidad.Text = "";
            lblFecha.Text = "";
            numpedido = 1;
            btnCancelar.Visible = true;
            lblPedido.Text = "";
            ObtenerDatosCarritos();
        }

        private void btnAceptados_Click(object sender, EventArgs e)
        {
            estado = 0;
            numpedido = 1;
            btnConfirmar.Visible = false;
            ObtenerDatosCarritos();
            btnCancelar.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblPedido_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void lblIdentidad_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();

            SqlCommand cancelarCarrito = new SqlCommand("Delete from Carritos where Pedido_ID='" + pedidosid + "'", cn);
            SqlCommand cancelarPedido = new SqlCommand("Delete from Pedidos where Pedido_ID='" + pedidosid + "'", cn);
            cancelarCarrito.ExecuteNonQuery();
            cancelarPedido.ExecuteNonQuery();
            lblNumPed.Text = "0" + " / " + "0";
            lblTelefono.Text = "";
            lblNombre_Cliente.Text = "";
            lblDireccion.Text = "";
            lblIdentidad.Text = "";
            lblFecha.Text = "";
            numpedido = 1;
            lblPedido.Text = "";
            ObtenerDatosCarritos();

        }
    }
}
