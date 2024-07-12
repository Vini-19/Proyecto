using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.CLASES
{



    public class clsRegistro
    {
        private string usu;
        private string contra;
        private string pregunta;
        private string respuesta;

       


        public clsRegistro()
        {
            usu = string.Empty;
            contra = string.Empty;
            pregunta = string.Empty;
            respuesta = string.Empty;
        }

        public clsRegistro(string usu, string contra, string pregunta, string respuesta)
        {
            this.usu = usu;
            this.contra = contra;
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }
        public string getUsu() { return usu; }
        public void setUsu (string text) { usu = text; }
        public string getContra() { return contra; }
        public void setContra(string text) { contra = text; }
        public string getPregunta() { return pregunta; }
        public void setPregunta(string text) { pregunta = text; }
        public string getRespuesta() { return respuesta; }
        public void setRespuesta(string value) { respuesta = value; }
    }
}
