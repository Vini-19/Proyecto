using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.CLASES
{
    public class clsClientes
    {
        private string rtn;
        private string dni;
        private string nombre;
        private int rol;
        private bool estado;
        private int telefono;
        private string correo;
        private string direccion;

        public clsClientes()
        {
            rtn = string.Empty;
            dni = string.Empty;
            nombre = string.Empty;
            rol = 3;
            estado = true;
            telefono = 0;
            correo = string.Empty;
            direccion = string.Empty;
        }


        public clsClientes(string rtn, string dni, string nombre, int rol, bool estado, int telefono, string correo, string direccion)
        {
            this.rtn = rtn;
            this.dni = dni;
            this.nombre = nombre;
            this.rol = rol;
            this.estado = estado;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
        }

        public string getrtn() { return rtn; }
        public void setrtn(string text) { rtn = text; }
        public string getdni() { return dni; }
        public void setdni(string text) { dni = text; }
        public string getnombre() { return nombre; }
        public void setnombre(string text) { nombre = text; }
        public int getrol() { return rol; }
        public void setrol(int value) { rol = value; }
        public bool getestado() { return estado; }
        public void setestado(bool text) { estado = text; }
        public int gettelefono() { return telefono; }
        public void settelefono(int value) { telefono = value; }
        public string getcorreo() { return correo; }
        public void setcorreo(string text) { correo = text; }
        public string getdireccion() { return direccion; }
        public void setdireccion(string text) { direccion = text; }


        

    }
}
