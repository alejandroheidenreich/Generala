using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Jugador
    {
        private int id;
        private int[] dados;
        private string nombre;

        public Jugador()
        {
        }
        public Jugador(string nombre)
        {
            dados = new int[5];
            this.nombre = nombre;

            //TODO: nombre invitado;
        }

        public Jugador(int id, string nombre):this(nombre)
        {
            this.id = id;


            //TODO: nombre invitado;
        }

        public int[] Dados
        {
            get => dados;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        public void TirarDados()
        {
            Random rnd = new Random();
            for (int i = 0; i < this.dados.Length; i++)
            {  
                this.dados[i] = rnd.Next(1, 7);
            }
        }
        public void TirarDados(int indexDado1, int indexDado2, int indexDado3, int indexDado4, int indexDado5)
        {
            Random rnd = new Random();
            for (int i = 0; i < this.dados.Length; i++)
            {
                if (i == indexDado1 ||
                    i == indexDado2 ||
                    i == indexDado3 ||
                    i == indexDado4 ||
                    i == indexDado5)
                {
                    this.dados[i] = rnd.Next(1, 7);
                }
            }
        }

        public string MostrarDados()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{dados[0]} - ");
            sb.Append($"{dados[1]} - ");
            sb.Append($"{dados[2]} - ");
            sb.Append($"{dados[3]} - ");
            sb.AppendLine($"{dados[4]}");
            return sb.ToString();
        }

        public int CalcularPuntaje()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            Jugador jugador = obj as Jugador; 
            return jugador is not null && this.id == jugador.Id;
        }
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
