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
        int x1 = 0, x2 = 0, x3 = 0, x4 = 0;
        string codP;
        float total = 0;

        private void frmCarrito_Load(object sender, EventArgs e)
        {



        }

        private double Obtenertotal()
        {

            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();
            clsPersonasid usuario = new clsPersonasid();

            SqlCommand comandoObtenertotal = new SqlCommand("ObtenerTotalValorProductosPorUsuario", cn);
            comandoObtenertotal.CommandType = CommandType.StoredProcedure;
            comandoObtenertotal.Parameters.AddWithValue("@UsuarioID", usuario.getcodUsu());
            return (double)comandoObtenertotal.ExecuteScalar();

        }


        private void Cargarpedido()
        {


            Cconexion conexion = new Cconexion();
            SqlConnection cn = conexion.leer();
            clsPersonasid usu = new clsPersonasid();

            string consulta = "Select Productos_ID,cantidad from Carritos where Usuarios_ID= '" + usu.getcodUsu() + "'";
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
            if (pictureBox2.Visible)
            {
                i--;
            }
            if (pictureBox3.Visible)
            {
                i--;
            }
            if (pictureBox4.Visible)
            {
                i--;
            }


            i = i - 4;



            Cargarpedido();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCarrito_Load_1(object sender, EventArgs e)
        {
            Cargarpedido();
            lblTotal.Text = Obtenertotal().ToString();

        }

        private void btnsiguiente_Click_1(object sender, EventArgs e)
        {
            cont_pag++;
            y = true;
            Cargarpedido();
        }
    }
}




