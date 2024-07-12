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
    public partial class frmRecuperacion : Form
    {
        public frmRecuperacion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

       public string Usuario { get; set; }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nuevaContraseña1 = txtNueva_Contraseña1.Text;
            string nuevaContraseña2 = txtNueva_Contraseña2.Text;

            if (nuevaContraseña1 != nuevaContraseña2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                try
                {
                    clsRegistro registro = new clsRegistro();
                    Cconexion objC = new Cconexion();
                    using (SqlConnection cn = objC.leer())
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }

                        cn.Open();

                        SqlCommand comandoRecuperarContra = new SqlCommand("PA_ActualizarContraseña", cn);
                        comandoRecuperarContra.CommandType = CommandType.StoredProcedure;

                        comandoRecuperarContra.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña2);
                        comandoRecuperarContra.Parameters.AddWithValue("@usuario", Usuario);

                        int filasAfectadas = comandoRecuperarContra.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada correctamente");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la contraseña");
                        }

                        cn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
