using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO;
using PROYECTO.CLASES;
using Proyecto_de_desarrolo.Clases;

namespace Proyecto_de_desarrolo.Formularios
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;



        }

        clsValidaciones val = new clsValidaciones();


        private void button1_Click(object sender, EventArgs e)
        {
            frmInicioSesion InicioS = new frmInicioSesion();
            InicioS.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            val.validarcm(cmbPregunta.Text);
            if (txtUsuario.Text == "" || txtContra.Text == "" || txtRespuesta.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;

            }
            else
            {
                clsRegistro registro = new clsRegistro();
                Cconexion conexion = new Cconexion();
                if (errorProvider1.GetError(txtUsuario) == "" && errorProvider1.GetError(txtContra) == "" && errorProvider1.GetError(txtRespuesta) == "")
                {

                    registro.setUsu(txtUsuario.Text.Trim());
                    registro.setContra(txtContra.Text);
                    registro.setPregunta(cmbPregunta.Text);
                    registro.setRespuesta(txtRespuesta.Text);

                    if (conexion.VerificarUsuarioExistente(txtUsuario.Text))
                    {
                        MessageBox.Show("Ya existe este usuario");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(registro.getUsu()) || string.IsNullOrWhiteSpace(registro.getContra()) || string.IsNullOrWhiteSpace(registro.getPregunta()) || string.IsNullOrWhiteSpace(registro.getRespuesta()))
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }
                    conexion.RegistroUsu(registro.getContra(), registro.getPregunta(), registro.getRespuesta(), registro.getUsu(), 3);


                    frmInicioSesion frmInicioSesion = new frmInicioSesion();
                    frmInicioSesion.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos y cumplan con las especificaciones");
                }

            }
        }
    }
}
