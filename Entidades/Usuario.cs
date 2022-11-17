using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombreDeUsuario;
        private string password;
        private int id;


        public Usuario(string nombreDeUsuario, string password)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
        }

        public Usuario(int id, string usuario, string password)
        {
            this.id = id;
            this.nombreDeUsuario = usuario;
            this.password = password;
        }

        public string NombreDeUsuario
        {
            get => nombreDeUsuario;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        public bool VerificarPassword(string passwordActual)
        {
            if (passwordActual == this.password)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1 is not null && u2 is not null && u1.nombreDeUsuario == u2.nombreDeUsuario && u1.password == u2.password;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario is not null && this == usuario;
        }

        private static void ValidarString(string strAValidar, out string strValidado, string msjError)
        {
            strValidado = String.Empty;
            if (strAValidar is not null)
            {
                strValidado = strAValidar;
            }
            else
            {
                throw new ArgumentNullException(msjError);
            }
        }

        private static void ValidarPassword(string passwordAValidar, out string passwordValidado)
        {
            passwordValidado = string.Empty;

            if (passwordAValidar is null)
            {
                throw new ArgumentNullException("La contraseña no puede ser nula");
            }
            else if (passwordAValidar.Length < 8)
            {
                throw new FormatException("La contraseña debe tener un largo de 8 caracteres");
            }
            else if (!ValidarContieneMinus(passwordAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos una Minuscula");
            }
            else if (!ValidarContieneMayus(passwordAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos una Mayuscula");
            }
            else if (!ValidarContieneNumerico(passwordAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos un Numero");
            }
            else if (!ValidarContieneSimbolo(passwordAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos un Simbolo");
            }
            else
            {
                passwordValidado = passwordAValidar;
            }
        }

        private static bool ValidarContieneMinus(string password)
        {
            char[] passwordArray = password.ToArray();

            foreach (char item in passwordArray)
            {
                if (Char.IsLower(item))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool ValidarContieneMayus(string password)
        {
            char[] passwordArray = password.ToArray();

            foreach (char item in passwordArray)
            {
                if (Char.IsUpper(item))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidarContieneNumerico(string password)
        {
            char[] passwordArray = password.ToArray();

            foreach (char item in passwordArray)
            {
                if (Char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidarContieneSimbolo(string password)
        {
            char[] passwordArray = password.ToArray();

            foreach (char item in passwordArray)
            {
                if (item > 32 && item < 127 && !Char.IsDigit(item) && !Char.IsUpper(item))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Bienvenido {this.nombreDeUsuario}";
        }
    }
}
