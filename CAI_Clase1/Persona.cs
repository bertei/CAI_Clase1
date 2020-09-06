using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Clase1
{
    class Persona
    {
        //variables
        private string _nombre;
        private int _edad;
        private string _apellido;

        //propiedades de la clase
        private int cantidadPiernas;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return this._nombre + " " + this._apellido;
            }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        //constructor sin parametros
        public Persona()
        {
            this.cantidadPiernas = 2;
        }

        //constructor con tres parametros
        public Persona(string nombre, string apellido, int edad)
        {
            this.cantidadPiernas = 2;
            this._edad = edad;
            this._nombre = nombre;
        }

        //constructor con dos parametros
        public Persona(string nombre, int edad)
        {
            this.cantidadPiernas = 2;
            this._edad = edad;
            this._nombre = nombre;
        }

        public Persona(int nombre, string edad)
        {

        }

        //metodos de la clase
        public void SumarEdad(int algo)
        {
            this._edad += algo;
        }

        public int SumarUnoAlaEdad()
        {
            this._edad = this._edad + 1;
            return this._edad;
        }

        public void Correr()
        {
            if(this.cantidadPiernas == 2)
            {
                Console.WriteLine("Puedo correr.");
            }
            else
            {
                Console.WriteLine("No puedo correr.");
            }
        }
    }
}
