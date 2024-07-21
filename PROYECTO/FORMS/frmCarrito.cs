using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmCarrito : Form
    {
        public frmCarrito()
        {
            InitializeComponent();

        }
        int i = -1;

        int num_pag = 0;
        int cont_filas = 0;
        int cont_pag = 1;
        bool y = true;
        string codP;
        float total = 0;
        int j1 = -4, j2 = -3, j3 = -2, j4 = -1;

        public void frmCarrito_Load(object sender, EventArgs e)
        {

            Cargarpedido();
            Obtenertotal();
           
        }

        public void Actualizar()
        {
            Cargarpedido();
            Obtenertotal();
            MessageBox.Show("ola");
        }

        private void Obtenertotal()
        {
            if (pictureBox1.Visible == true)
            {
                Cconexion conexion = new Cconexion();
                SqlConnection cn = conexion.leer();
                clsPersonasid usuario = new clsPersonasid();

                SqlCommand comandoObtenertotal = new SqlCommand("ObtenerTotalValorProductosPorUsuario", cn);
                comandoObtenertotal.CommandType = CommandType.StoredProcedure;
                comandoObtenertotal.Parameters.AddWithValue("@UsuarioID", usuario.getcodUsu());
                double tot = (double)comandoObtenertotal.ExecuteScalar();
                lblTotal.Text = tot.ToString();
            }
            else
            {
                lblTotal.Text = "0";
            }



        }


        private void Cargarpedido()
        {


            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();
            clsPersonasid usu = new clsPersonasid();

            string consulta = "Select Productos_ID,cantidad from Carritos where Usuarios_ID= '" + usu.getcodUsu() + "' and estado=1";
            SqlCommand comando = new SqlCommand(consulta, cn);
            SqlDataAdapter DA = new SqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            DA.Fill(dataTable);


 







            cont_filas = dataTable.Rows.Count;
            cont_filas = cont_filas - 1;




            if (cont_pag == 1)
            {
                anterior.Visible = false;
            }
            else
            {
                anterior.Visible = true;
            }

            if (cont_filas != i)
            {

                if (y)
                {

                    i++;

                }
                else
                {

                    i++;


                }
                pictureBox1.Visible = true;
                lblNombre1.Visible = true;
                lblPrecio1.Visible = true;
                btnQuitar1.Visible = true;
                j1 = j1 + 4; j2 = j2 + 4; j3 = j3 + 4; j4 = j4 + 4;

                codP = dataTable.Rows[i][0].ToString();

                SqlCommand cmd = new SqlCommand("select imagen from Productos where Productos_ID='" + codP + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                da.Fill(DS, "Productos");
               
                string consulta2 = "Select Nombre_Producto,Precio from Productos where Productos_ID='" + codP + "'";
                SqlCommand comando2 = new SqlCommand(consulta2, cn);
                SqlDataAdapter DA2 = new SqlDataAdapter(comando2);
                DataTable dataTable2 = new DataTable();
                DA2.Fill(dataTable2);

                lblNombre1.Text = dataTable2.Rows[0][0].ToString();
                lblPrecio1.Text = dataTable2.Rows[0][1].ToString();
                lblCantidad1.Text = dataTable.Rows[i][1].ToString();

                byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[0]["imagen"]);
                MemoryStream stm = new MemoryStream(bytedata);

                pictureBox1.Image = Image.FromStream(stm);
            }
            else
            {
                pictureBox1.Visible = false;
                lblNombre1.Visible = false;
                lblPrecio1.Visible = false;
                lblCantidad1.Visible = false;
                btnQuitar1.Visible = false;
            }

            if (cont_filas != i)
            {
                if (y)
                {

                    i++;

                }
                else
                {

                    i++;


                }
                pictureBox2.Visible = true;
                lblNombre2.Visible = true;
                lblPrecio2.Visible = true;
                btnQuitar2.Visible = true;


                codP = dataTable.Rows[i][0].ToString();

                SqlCommand cmd = new SqlCommand("select imagen from Productos where Productos_ID='" + codP + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                da.Fill(DS, "Productos");

                string consulta2 = "Select Nombre_Producto,Precio from Productos where Productos_ID='" + codP + "'";
                SqlCommand comando2 = new SqlCommand(consulta2, cn);
                SqlDataAdapter DA2 = new SqlDataAdapter(comando2);
                DataTable dataTable2 = new DataTable();
                DA2.Fill(dataTable2);

                lblNombre2.Text = dataTable2.Rows[0][0].ToString();
                lblPrecio2.Text = dataTable2.Rows[0][1].ToString();
                lblCantidad2.Text = dataTable.Rows[i][1].ToString();

                byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[0]["imagen"]);
                MemoryStream stm = new MemoryStream(bytedata);

                pictureBox2.Image = Image.FromStream(stm);
            }
            else
            {
                pictureBox2.Visible = false;
                lblNombre2.Visible = false;
                lblPrecio2.Visible = false;
                lblCantidad2.Visible = false;
                btnQuitar2.Visible = false;
            }

            if (cont_filas != i)
            {
                if (y)
                {

                    i++;

                }
                else
                {

                    i++;


                }
                pictureBox3.Visible = true;
                lblNombre3.Visible = true;
                lblPrecio3.Visible = true;
                btnQuitar3.Visible = true;

                codP = dataTable.Rows[i][0].ToString();

                SqlCommand cmd = new SqlCommand("select imagen from Productos where Productos_ID='" + codP + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                da.Fill(DS, "Productos");

                string consulta2 = "Select Nombre_Producto,Precio from Productos where Productos_ID='" + codP + "'";
                SqlCommand comando2 = new SqlCommand(consulta2, cn);
                SqlDataAdapter DA2 = new SqlDataAdapter(comando2);
                DataTable dataTable2 = new DataTable();
                DA2.Fill(dataTable2);

                lblNombre3.Text = dataTable2.Rows[0][0].ToString();
                lblPrecio3.Text = dataTable2.Rows[0][1].ToString();
                lblCantidad3.Text = dataTable.Rows[i][1].ToString();

                byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[0]["imagen"]);
                MemoryStream stm = new MemoryStream(bytedata);

                pictureBox3.Image = Image.FromStream(stm);
            }
            else
            {
                pictureBox3.Visible = false;
                lblNombre3.Visible = false;
                lblPrecio3.Visible = false;
                lblCantidad3.Visible = false;
                btnQuitar3.Visible = false;
            }

            if (cont_filas != i)
            {
                if (y)
                {

                    i++;

                }
                else
                {

                    i++;


                }
                pictureBox4.Visible = true;
                lblNombre4.Visible = true;
                lblPrecio4.Visible = true;
                lblCantidad4.Visible = true;
                btnQuitar4.Visible = true;

                codP = dataTable.Rows[i][0].ToString();

                SqlCommand cmd = new SqlCommand("select imagen from Productos where Productos_ID='" + codP + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                da.Fill(DS, "Productos");

                string consulta2 = "Select Nombre_Producto,Precio from Productos where Productos_ID='" + codP + "'";
                SqlCommand comando2 = new SqlCommand(consulta2, cn);
                SqlDataAdapter DA2 = new SqlDataAdapter(comando2);
                DataTable dataTable2 = new DataTable();
                DA2.Fill(dataTable2);

                lblNombre4.Text = dataTable2.Rows[0][0].ToString();
                lblPrecio4.Text = dataTable2.Rows[0][1].ToString();
                lblCantidad4.Text = dataTable.Rows[i][1].ToString();

                byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[0]["imagen"]);
                MemoryStream stm = new MemoryStream(bytedata);

                pictureBox4.Image = Image.FromStream(stm);
            }
            else
            {
                pictureBox4.Visible = false;
                lblNombre4.Visible = false;
                lblPrecio4.Visible = false;
                lblCantidad4.Visible = false;
                btnQuitar4.Visible = false;
            }
            if (cont_filas == i)
            {
                btnsiguiente.Visible = false;

            }
            else
            {
                btnsiguiente.Visible = true;

            }




        }

        private void anterior_Click(object sender, EventArgs e)
        {
            cont_pag--;

            y = false;
            if (pictureBox1.Visible)
            {
                i--;

            }
            j1 = j1 - 8;
            if (pictureBox2.Visible)
            {
                i--;

            }
            j2 = j2 - 8;
            if (pictureBox3.Visible)
            {
                i--;

            }
            j3 = j3 - 8;
            if (pictureBox4.Visible)
            {
                i--;

            }
            j4 = j4 - 8;


            i = i - 4;



            Cargarpedido();
        }

        private void frmCarrito_Load_1(object sender, EventArgs e)
        {
            
        }

        private void btnsiguiente_Click_1(object sender, EventArgs e)
        {
            cont_pag++;
            y = true;
            Cargarpedido();
        }
        public void eliminarcompra(int posicion)
        {
            clsPersonasid id = new clsPersonasid();
            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();
            string consulta2 = "Select Carrito_ID from Carritos where Usuarios_ID='" + id.getcodUsu() + "'";
            SqlCommand comando2 = new SqlCommand(consulta2, cn);
            SqlDataAdapter DA2 = new SqlDataAdapter(comando2);
            DataTable dataTable2 = new DataTable();
            DA2.Fill(dataTable2);

            string eliminar = "Delete from Carritos where Carrito_ID='" + dataTable2.Rows[posicion][0] + "'";
            SqlCommand comandoeliminar = new SqlCommand(eliminar, cn);
            comandoeliminar.ExecuteNonQuery();
            MessageBox.Show("Se elimino correctamente");
            i = -1;
            cont_pag = 1;



        }

        private void btnQuitar1_Click(object sender, EventArgs e)
        {
            eliminarcompra(j1);
            j1 = -4; j2 = -3; j3 = -2; j4 = -1;
            Cargarpedido();
            Obtenertotal();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar2_Click(object sender, EventArgs e)
        {
            eliminarcompra(j2);
            j1 = -4; j2 = -3; j3 = -2; j4 = -1;
            Cargarpedido();
            Obtenertotal();
        }

        private void btnQuitar3_Click(object sender, EventArgs e)
        {
            eliminarcompra(j3);
            j1 = -4; j2 = -3; j3 = -2; j4 = -1;
            Cargarpedido();
            Obtenertotal();
        }

        private void btnQuitar4_Click(object sender, EventArgs e)
        {
            eliminarcompra(j4);
            j1 = -4; j2 = -3; j3 = -2; j4 = -1;
            Cargarpedido();
            Obtenertotal();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            frmDetallesCliente frmdetalles = new frmDetallesCliente(this);
            frmdetalles.Show();
        }
    }
}




