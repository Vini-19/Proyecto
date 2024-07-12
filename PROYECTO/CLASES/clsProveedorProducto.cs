using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO.CLASES
{
    public class clsProveedorProducto
    {

        public int Roles_ID { get; set; }
        public string Nombre { get; set; }



        public clsProveedorProducto(int roles_ID, string nombre)
        {
            Roles_ID = roles_ID;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }


    }
}
