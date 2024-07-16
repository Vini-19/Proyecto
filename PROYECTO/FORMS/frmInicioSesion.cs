using System;
using System.Data.SqlClient;
using System.Data;
using PROYECTO;
using PROYECTO.CLASES;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_de_desarrolo;
using Proyecto_de_desarrolo.Formularios;

namespace PROYECTO
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

      


       

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string cod;
            clsPersonasid per = new clsPersonasid();
            Cconexion conexion = new Cconexion();

            using (SqlConnection cn = conexion.leer())
            {
                // Consulta para obtener el ID del usuario
                string consulta = "Select Usuarios_ID from Usuarios where Nombre_Usuario = '" + txtUsuario.Text + "'";
                SqlCommand comando2 = new SqlCommand(consulta, cn);
                SqlDataAdapter DA = new SqlDataAdapter(comando2);
                DataTable dataTable = new DataTable();



                

            }

            string usuario = txtUsuario.Text;
            string pass = txtContra.Text;

            // Verificación de datos de entrada
            if (string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor ingresar los datos");
            }
            else
            {
                Cconexion objC = new Cconexion();
                SqlConnection cn = objC.leer();
                if (cn.State == ConnectionState.Open)
                {
                    try
                    {
                        // Llamada al procedimiento almacenado para obtener el rol del usuario
                        SqlCommand comando = new SqlCommand("PA_ObtenerRolUsuario", cn);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@pass", pass);
                        SqlDataReader rs = comando.ExecuteReader();

                        int rolesId = -1;

                        if (rs.HasRows)
                        {
                            while (rs.Read())
                            {
                                rolesId = rs.GetInt32(rs.GetOrdinal("roles_id"));
                            }

                            // Dependiendo del rol, mostrar el formulario correspondiente y pasar el nombre de usuario
                            switch (rolesId)
                            {
                                case 1:
                                    frmadmi frmPrincipal = new frmadmi();
                                    frmPrincipal.SetUsuarioLabel(usuario);
                                    MessageBox.Show("Bienvenido" + " " + usuario + " " + "Finca San Jose");
                                    frmPrincipal.Show();
                                    break;
                                case 2:
                                    frmPrincipalEmpleado frm = new frmPrincipalEmpleado();
                                    frm.SetUsuarioLabel(usuario);
                                    MessageBox.Show("Bienvenido" + " " + usuario + " " + "Finca San Jose");
                                    frm.Show();
                                    break;
                                case 3:
                                    frmPrincipalCliente frmPrincipalCliente = new frmPrincipalCliente();
                                    frmPrincipalCliente.SetUsuarioLabel(usuario);
                                    MessageBox.Show("Bienvenido" + " " + usuario + " " + "Finca San Jose");
                                    frmPrincipalCliente.Show();
                                    break;
                                default:
                                    MessageBox.Show("El usuario no tiene un rol válido.");
                                    break;
                            }

                            this.Hide();
                        }
                        else
                        {
                            txtUsuario.Text = "";
                            txtContra.Text = "";
                            MessageBox.Show("Datos incorrectos. Por favor revisar datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar conectar: " + ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error de conexión.");
                }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLRegistro_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro Reg = new frmRegistro();
            Reg.Show();
            this.Hide();
        }

        private void linkLRecuperacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperacion Rec = new frmRecuperacion();
            Rec.Show();
            frmEspecificacionesInicio Esp = new frmEspecificacionesInicio();
            Esp.Show();
        }
    }
}

