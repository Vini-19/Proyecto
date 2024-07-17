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
using System.IO;
using System.Drawing.Imaging;
using PROYECTO.CLASES;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class Pedidos_Cliente : Form
    {

        int i = -1;

        int num_pag = 0;
        int cont_filas = 0;
        int cont_pag = 1;
        bool y = true;
        int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0;


        public Pedidos_Cliente()
        {
            InitializeComponent();
            cargar_pedido2();
        }

        private void Pedidos_Cliente_Load(object sender, EventArgs e)
        {

        }



        private void cargar_pedido2()
        {
            Cconexion conexion = new Cconexion();
            Button[] botone = new Button[6];





            using (SqlConnection cn = conexion.leer())
            {
                SqlCommand cmd = new SqlCommand("select imagen from Productos", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();


                da.Fill(DS, "Productos");

                cont_filas = DS.Tables["Productos"].Rows.Count;
                cont_filas = cont_filas - 1;



                string consulta = "Select Nombre_Producto,Precio from Productos";
                SqlCommand comando = new SqlCommand(consulta, cn);
                SqlDataAdapter DA = new SqlDataAdapter(comando);
                DataTable dataTable = new DataTable();


                DA.Fill(dataTable);





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
                    button1.Visible = true;
                    lblNombre1.Visible = true;
                    lblPrecio1.Visible = true;

                    byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[i]["imagen"]);
                    MemoryStream stm = new MemoryStream(bytedata);

                    button1.Image = Image.FromStream(stm);
                    lblNombre1.Text = dataTable.Rows[i][0].ToString();
                    lblPrecio1.Text = dataTable.Rows[i][1].ToString() + " Lps";
                }
                else
                {
                    button1.Visible = false;
                    lblNombre1.Visible = false;
                    lblPrecio1.Visible = false;
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

                    button2.Visible = true;
                    lblNombre2.Visible = true;
                    lblPrecio2.Visible = true;

                    byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[i]["imagen"]);
                    MemoryStream stm = new MemoryStream(bytedata);

                    button2.Image = Image.FromStream(stm);
                    lblNombre2.Text = dataTable.Rows[i][0].ToString();
                    lblPrecio2.Text = dataTable.Rows[i][1].ToString() + " Lps";

                }
                else
                {
                    button2.Visible = false;
                    lblNombre2.Visible = false;
                    lblPrecio2.Visible = false;
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
                    button3.Visible = true;
                    lblNombre3.Visible = true;
                    lblPrecio3.Visible = true;

                    byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[i]["imagen"]);
                    MemoryStream stm = new MemoryStream(bytedata);

                    button3.Image = Image.FromStream(stm);
                    lblNombre3.Text = dataTable.Rows[i][0].ToString();
                    lblPrecio3.Text = dataTable.Rows[i][1].ToString() + " Lps";
                }
                else
                {
                    button3.Visible = false;
                    lblNombre3.Visible = false;
                    lblPrecio3.Visible = false;
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
                    button4.Visible = true;
                    lblNombre4.Visible = true;
                    lblPrecio4.Visible = true;
                    byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[i]["imagen"]);
                    MemoryStream stm = new MemoryStream(bytedata);

                    button4.Image = Image.FromStream(stm);
                    lblNombre4.Text = dataTable.Rows[i][0].ToString();
                    lblPrecio4.Text = dataTable.Rows[i][1].ToString() + " Lps";
                }
                else
                {
                    button4.Visible = false;
                    lblNombre4.Visible = false;
                    lblPrecio4.Visible = false;
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
                    button5.Visible = true;
                    lblNombre5.Visible = true;
                    lblPrecio5.Visible = true;

                    byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[i]["imagen"]);
                    MemoryStream stm = new MemoryStream(bytedata);

                    button5.Image = Image.FromStream(stm);
                    lblNombre5.Text = dataTable.Rows[i][0].ToString();
                    lblPrecio5.Text = dataTable.Rows[i][1].ToString() + " Lps";

                }
                else
                {
                    button5.Visible = false;
                    lblNombre5.Visible = false;
                    lblPrecio5.Visible = false;
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

                    button6.Visible = true;
                    lblNombre6.Visible = true;
                    lblPrecio6.Visible = true;

                    byte[] bytedata = (byte[])(DS.Tables["Productos"].Rows[i]["imagen"]);
                    MemoryStream stm = new MemoryStream(bytedata);

                    button6.Image = Image.FromStream(stm);
                    lblNombre6.Text = dataTable.Rows[i][0].ToString();
                    lblPrecio6.Text = dataTable.Rows[i][1].ToString() + " Lps";
                }
                else
                {
                    button6.Visible = false;
                    lblNombre6.Visible = false;
                    lblPrecio6.Visible = false;

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

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cont_pag++;
            y = true;
            cargar_pedido2();

        }

        private void anterior_Click(object sender, EventArgs e)
        {
            cont_pag--;

            y = false;
            if (button1.Visible)
            {
                i--;
            }
            if (button2.Visible)
            {
                i--;
            }
            if (button3.Visible)
            {
                i--;
            }
            if (button4.Visible)
            {
                i--;
            }
            if (button5.Visible)
            {
                i--;
            }
            if (button6.Visible)
            {
                i--;
            }

            i = i - 6;



            cargar_pedido2();

        }
        string cod1;
        private void button1_Click(object sender, EventArgs e)
        {

            clsPersonasid per = new clsPersonasid();
            Cconexion conexion = new Cconexion();
            using (SqlConnection cn = conexion.leer())
            {
                string consulta = "Select Productos_ID from Productos where Nombre_Producto = '" + lblNombre1.Text + "'";
                SqlCommand comando2 = new SqlCommand(consulta, cn);
                SqlDataAdapter DA = new SqlDataAdapter(comando2);
                DataTable dataTable = new DataTable();


                DA.Fill(dataTable);
                cod1 = dataTable.Rows[0][0].ToString();

            }

            //RegistrarCarrito(lblCantidad1.Text);
        }
        private void RegistrarCarrito(string cant)
        {


            clsPersonasid per = new clsPersonasid();

            Cconexion conexion = new Cconexion();
            using (SqlConnection cn = conexion.leer())
            {

                string consulta = "INSERT INTO Carritos ([Productos_ID],[Usuarios_ID],[cantidad],[estado]) " +
                                                  "VALUES ('" + cod1 + "','" + per.getcodUsu() + "','" + cant + "', 'true');";


                SqlCommand comando = new SqlCommand(consulta, cn);




                comando.ExecuteNonQuery();

                MessageBox.Show("Pedido añadido al carrito");
            }

        }


        private void btnMenos1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenos1_Click_1(object sender, EventArgs e)
        {
            x1--;
            //lblCantidad1.Text = Convert.ToString(x1);
        }

        private void btnMas1_Click(object sender, EventArgs e)
        {
            x1++;


            //lblCantidad1.Text = Convert.ToString(x1);

        }

        private void btnMas2_Click(object sender, EventArgs e)
        {
            x2++;


            //lblCantidad2.Text = Convert.ToString(x2);

        }

        private void btnMas3_Click(object sender, EventArgs e)
        {
            x3++;


           // lblCantidad3.Text = Convert.ToString(x3);

        }

        private void btnMas4_Click(object sender, EventArgs e)
        {
            x4++;


            //lblCantidad4.Text = Convert.ToString(x4);

        }

        private void btnMas5_Click(object sender, EventArgs e)
        {
            x5++;


           // lblCantidad5.Text = Convert.ToString(x5);

        }

        private void btnMas6_Click(object sender, EventArgs e)
        {
            x6++;


           // lblCantidad6.Text = Convert.ToString(x6);

        }

        private void btnMenos2_Click(object sender, EventArgs e)
        {
            x2--;


            //lblCantidad2.Text = Convert.ToString(x2);

        }

        private void btnMenos3_Click(object sender, EventArgs e)
        {
            x3--;


            //lblCantidad3.Text = Convert.ToString(x3);

        }

        private void btnMenos4_Click(object sender, EventArgs e)
        {
            x4--;


           // lblCantidad4.Text = Convert.ToString(x4);

        }

        private void btnMenos5_Click(object sender, EventArgs e)
        {
            x5--;


            //lblCantidad5.Text = Convert.ToString(x5);
        }

        private void btnMenos6_Click(object sender, EventArgs e)
        {
            x6--;


            //lblCantidad6.Text = Convert.ToString(x6);
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            frmCarrito frmCarrito = new frmCarrito();
            frmCarrito.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void Pedidos_Cliente_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            clsPersonasid per = new clsPersonasid();
            Cconexion conexion = new Cconexion();
            using (SqlConnection cn = conexion.leer())
            {
                string consulta = "Select Productos_ID from Productos where Nombre_Producto = '" + lblNombre3.Text + "'";
                SqlCommand comando2 = new SqlCommand(consulta, cn);
                SqlDataAdapter DA = new SqlDataAdapter(comando2);
                DataTable dataTable = new DataTable();


                DA.Fill(dataTable);
                cod1 = dataTable.Rows[0][0].ToString();
            }

            //RegistrarCarrito(lblCantidad3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            clsPersonasid per = new clsPersonasid();
            Cconexion conexion = new Cconexion();
            using (SqlConnection cn = conexion.leer())
            {
                string consulta = "Select Productos_ID from Productos where Nombre_Producto = '" + lblNombre4.Text + "'";
                SqlCommand comando2 = new SqlCommand(consulta, cn);
                SqlDataAdapter DA = new SqlDataAdapter(comando2);
                DataTable dataTable = new DataTable();


                DA.Fill(dataTable);
                cod1 = dataTable.Rows[0][0].ToString();
            }

            //RegistrarCarrito(lblCantidad4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            clsPersonasid per = new clsPersonasid();
            Cconexion conexion = new Cconexion();
            using (SqlConnection cn = conexion.leer())
            {
                string consulta = "Select Productos_ID from Productos where Nombre_Producto = '" + lblNombre5.Text + "'";
                SqlCommand comando2 = new SqlCommand(consulta, cn);
                SqlDataAdapter DA = new SqlDataAdapter(comando2);
                DataTable dataTable = new DataTable();


                DA.Fill(dataTable);
                cod1 = dataTable.Rows[0][0].ToString();
            }

            //RegistrarCarrito(lblCantidad5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            clsPersonasid per = new clsPersonasid();
            Cconexion conexion = new Cconexion();
            using (SqlConnection cn = conexion.leer())
            {
                string consulta = "Select Productos_ID from Productos where Nombre_Producto = '" + lblNombre6.Text + "'";
                SqlCommand comando2 = new SqlCommand(consulta, cn);
                SqlDataAdapter DA = new SqlDataAdapter(comando2);
                DataTable dataTable = new DataTable();


                DA.Fill(dataTable);
                cod1 = dataTable.Rows[0][0].ToString();
            }

            //RegistrarCarrito(lblCantidad6.Text);
        }

        private void btnCarrito_Click_1(object sender, EventArgs e)
        {
            frmCarrito frmCarrito = new frmCarrito();
            frmCarrito.Show();
        }

        
     
    }
}
