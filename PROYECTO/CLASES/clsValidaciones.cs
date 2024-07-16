using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_desarrolo.Clases
{
    public class clsValidaciones
    {
        public string doble_espacio(string texto)
        {
            int x = 0;

            if (texto.Contains("  "))
            {
                return "No se aceptan espacios dobles \n";
            }
            else
            {
                return "";
            }
        }

        public void validarletra(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        public string validarcm(string texto)
        {
            if (texto == "")
            {
                return "Este campo es obligatorio \n";
            }
            else
            {
                return "";
            }
        }

        public string espacio(string texto)
        {
            int x = 0;

            if (texto.Contains(" "))
            {
                return " No se aceptan espacios \n";
            }
            else
            {
                return "";
            }
        }

        public string espacio_inicio_final(string texto)
        {
            string mensaje = "";

            int x = texto.Length;
            if (texto.Length > 0)
            {
                if (texto[0] == ' ' || texto[x - 1] == ' ')
                {
                    mensaje = "No se aceptan espacios al inicio y al final \n";
                }
                else
                {
                    mensaje = "";
                }
            }

            return mensaje;
        }


        public string txt_vacio(string texto)
        {
            if (texto == "")
            {
                return " Rellenar Campos \n";
            }
            else
            {

                return "";
            }

        }
        /* public string triple_caracter(string texto)
         {
             for(int i = 0; i < texto.Length; i++) 
             {

             }

             if (texto.Contains())
                 {
                 return "Rellenar Campos";
                 }

         }*/

        public string rango_12(string texto)
        {
            if (texto.Length == 12)
            {
                return "";
            }
            else
            {
                return "\n El código debe contener 12 dígitos";
            }
        }

        public void validarnum(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public string rango_14(string texto)
        {
            if (texto.Length == 14)
            {
                return "";
            }
            else
            {
                return "\n El RTN debe contener 14 dígitos";
            }
        }

        public string rango_13(string texto)
        {
            if (texto.Length == 13)
            {
                return "";
            }
            else
            {
                return "\n El DNI debe contener 13 dígitos";
            }
        }

        public string rango(string texto, int rango)
        {
            if (texto.Length == rango)
            {
                return "";
            }
            else
            {
                return "\n Debe contener " + rango + "  dígitos";
            }
        }

        /*public bool caracteres(string texto)
        {
            string caracter = @"[!@#$%^&*()\[\]{};:'\""\\|,.<>/?`~]";

           if(Regex.IsMatch(texto, caracter))
           {
                return true;
           }
           else
           {
                return false;
           }
        }*/

        public string caracteres(string texto)
        {
            string caracter = @"[!@#$%^&*()\[\]{};:'\""\\|,.<>/?`~]";

            if (Regex.IsMatch(texto, caracter))
            {
                return "";
            }
            else
            {
                return "\n No se admiten carácteres especiales";
            }
        }


        public string validar_correo(string texto)
        {
            if (texto.EndsWith("@gmail.com") || texto.EndsWith("@yahoo.com"))
            {
                return "";
            }
            else
            {
                return "\n EL correo debe contener la siguiente sintaxis: @gmail.com o @yahoo.com";
            }
        }

        public string validarnumerotell(string texto)
        {
            string mensaje = "";

            if (texto.Length != 0)
            {
                if (texto[0] == '3' || texto[0] == '8' || texto[0] == '9')
                {
                    mensaje = "";
                }
                else
                {
                    mensaje = "El número debe de iniciar con 3,8 o 9";
                }

            }
            return mensaje;
        }

        public string rango_8(string texto)
        {
            if (texto.Length == 8)
            {
                return "";
            }
            else
            {
                return "\n El número telefónico debe contener 8 dígitos";
            }
        }

        public string rango_nombre(string texto)
        {
            if (texto.Length >= 3 && texto.Length <= 30)
            {
                return "";
            }
            else
            {
                return "\n El nombre mínimo 3 carácteres y máximo 30";
            }
        }
        public string rango_direccion(string texto)
        {
            if (texto.Length >= 10 && texto.Length <= 50)
            {
                return "";
            }
            else
            {
                return "\n La direccion debe tener mínimo 10 carácteres y máximo 50";
            }
        }

        public string rango_usuario(string texto)
        {
            if (texto.Length >= 8 && texto.Length <= 16)
            {
                return "";
            }
            else
            {
                return "\n El usuario debe contener mínimo 8 carácteres y máximo 16";
            }
        }

        public string rango_contra(string texto)
        {
            if (texto.Length >= 8 && texto.Length <= 16)
            {
                return "";
            }
            else
            {
                return "\n La contraseña debe contener mínimo 8 carácteres y máximo 16";
            }
        }
        public string validarletra_espacio(string texto)
        {
            string mensaje = "";

            for (int i = 0; i < texto.Length; i++)
            {

                char t = texto[i];
                string o = t.ToString();
                string vali = "[a-zA-Z' 'ñ]";
                if (Regex.IsMatch(o, vali))
                {
                    mensaje = "";

                }
                else
                {
                    mensaje = "solo se aceptan letras";

                }

            }
            return mensaje;
        }

        public string validar_precio(string texto)
        {
            float precio;
            string num = "[0-9]";

            if (Regex.IsMatch(texto, num))
            {



                if (texto != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(texto, @"[^\w\s]"))
                    {

                        return "No pueden contener caracteres especiales";
                    }
                    else
                    {

                        precio = float.Parse(texto);

                        if (precio < 201 && precio > 19)
                        {
                            return "";
                        }
                        else
                        {
                            return "El precio tiene que estar entre 20LP y 200LP";
                        }
                    }
                }
                else
                {
                    return "El precio tiene que estar entre 20LP y 200LP";
                }
            }
            else
            {
                return "Solo se acepan numeros";
            }
        }

        public string validar_peso(string texto)
        {
            int peso;
            string num = "[0-9]";

            if (Regex.IsMatch(texto, num))
            {
                if (texto != "")
                {
                    peso = int.Parse(texto);

                    if (peso < 1000 && peso > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "El peso no puede ser menor a 0 y mayor a 1000";
                    }
                }
                else
                {
                    return "El precio no puede ser menor a 0 y mayor a 1000";
                }
            }
            else
            {
                return "Solo se acepan números";
            }
        }

        public int validar_pesoPedidos(string texto)
        {
            int peso;
            string num = "[0-9]";

            if (Regex.IsMatch(texto, num))
            {
                if (texto != "")
                {
                    peso = int.Parse(texto);

                    if (peso < 500 && peso > 0)
                    {
                        return 5;
                    }
                    else if (peso <= 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 500;
                    }
                }
                else
                {
                    return 5;
                }
            }
            else
            {
                return 0;
            }
        }

        public string validarnumenteros(string texto)
        {
            int x = 0;
            for (int i = 0; i < texto.Length; i++)
            {

                char t = texto[i];
                string o = t.ToString();
                string vali = "[0-9]";
                if (Regex.IsMatch(o, vali))
                {


                }
                else
                {
                    x++;
                }

            }
            if (x > 0)
            {

                return "Solo se aceptan numeros enteros";
            }
            else
            {

                return "";
            }
        }

        public string validarcontra(string texto)
        {

            string vali = "[a-zA-Z]";
            string val = @"[@""!""""#$%&'()*+,-./:;<=>?@[\]^_`{|}~¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿×÷""]";

            string can = "", num = "", let = "", esp = "", espacio = "";

            for (int i = 0; i < texto.Length; i++)
            {

                if (texto.Contains(" "))
                {
                    espacio = "la contraseña no tiene que contener espacios \n";

                }
                else
                {
                    espacio = "";
                }

                if (i < 8)
                {
                    can = "la contraseña tiene que tener mas de 8 caracteres \n";
                }
                else if (i > 16)
                {
                    can = "la contraseña tiene que tener menos de 16 caracteres \n";
                }
                else
                {
                    can = "";
                }
            }
            if (Regex.IsMatch(texto, @"\d"))
            {
                num = "";
            }
            else
            {
                num = "la contraseña tiene que contener un numero \n";
            }


            if (Regex.IsMatch(texto, vali))
            {
                let = "";
            }
            else
            {
                let = "la contraseña tiene que contener una letra \n";
            }
            if (Regex.IsMatch(texto, val))
            {
                esp = "";
            }
            else
            {
                esp = "la contraseña tiene que contener un caracter especial \n";
            }

            if (let == "" && num == "" && esp == "" && can == "" && espacio == "")
            {
                return "";
            }
            else
            {
                return let + num + can + esp + espacio;
            }


        }

        public string validar_dni(string texto)
        {
            string departamento;

            int muni;
            string mensage = "";

            int añorefe = DateTime.Now.Year - 100;
            int añorefe2 = DateTime.Now.Year;
            int año = 0;
            char x = '0';
            if (texto.Length == 13)
            {
                departamento = texto.Substring(0, 2);
                muni = int.Parse(texto.Substring(2, 2));
                año = int.Parse(texto.Substring(4, 4));

                añorefe2 = añorefe2 - año;
                if (texto[0] == '0' || texto[0] == '1')
                {
                    if (texto[0] == '1')
                    {
                        x = '0';
                    }
                    else
                    {
                        x = '1';
                    }
                    if (texto[1] == x || texto[1] == '1' || texto[1] == '2' || texto[1] == '3' || texto[1] == '4' || texto[1] == '5' || texto[1] == '6' || texto[1] == '7' || texto[1] == '8')
                    {
                        switch (departamento)
                        {
                            case "01":
                                if (muni > 0 && muni <= 8)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }

                                break;
                            case "02":
                                if (muni > 0 && muni <= 10)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "03":
                                if (muni > 0 && muni <= 21)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "04":
                                if (muni > 0 && muni <= 23)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "05":
                                if (muni > 0 && muni <= 12)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "06":
                                if (muni > 0 && muni <= 16)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "07":
                                if (muni > 0 && muni <= 19)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "08":
                                if (muni > 0 && muni <= 28)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "09":
                                if (muni > 0 && muni <= 5)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "10":
                                if (muni > 0 && muni <= 17)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "11":
                                if (muni > 0 && muni <= 4)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "12":
                                if (muni > 0 && muni <= 19)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "13":
                                if (muni > 0 && muni <= 28)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "14":
                                if (muni > 0 && muni <= 23)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "15":
                                if (muni > 0 && muni <= 23)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "16":
                                if (muni > 0 && muni <= 28)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "17":
                                if (muni > 0 && muni <= 9)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                            case "18":
                                if (muni > 0 && muni <= 12)
                                {
                                    mensage = "";
                                }
                                else
                                {
                                    mensage = "el dni tiene que ser correcto";
                                }
                                break;
                        }

                    }
                    else
                    {
                        mensage = "el dni tiene que ser correcto";
                    }
                }
                else
                {
                    mensage = "el dni tiene que ser correcto";
                }
                if (mensage == "")
                {
                    if (año < añorefe || añorefe2 < 18)
                    {
                        mensage = "el dni tiene que ser correcto";
                    }
                    else
                    {
                        mensage = "";
                    }
                }
                if (mensage == "")
                {
                    if (texto.EndsWith("0000"))
                    {
                        mensage = "el dni tiene que ser correcto";
                    }
                    else
                    {
                        mensage = "";
                    }
                }
            }
            else
            {
                mensage = "";
            }

            return mensage;
        }
    }
}
