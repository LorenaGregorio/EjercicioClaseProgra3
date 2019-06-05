using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Class
{
    public class Alumno
    {

        private int Carne;
        private string PrimerNombre;
        private string SegundoNombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private int Celular;
        private int TelefonoCasa;
        private string Direccion;

        public Alumno(int Carne, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, int Celular, int TelefonoCasa, string Direccion)
        {
            this.Carne = Carne;
            this.PrimerNombre = PrimerNombre;
            this.SegundoNombre = SegundoNombre;
            this.PrimerApellido = PrimerApellido;
            this.SegundoApellido = SegundoApellido;
            this.Celular = Celular;
            this.TelefonoCasa = TelefonoCasa;
            this.Direccion = Direccion;
        }

       


        public int carne
        {
            get
            {
                return Carne;
            }

            set
            {
                Carne = value;
            }
        }

        public string primernombre
        {
            get
            {
                return PrimerNombre;
            }

            set
            {
                PrimerNombre = value;
            }
        }
        public string segundonombre
        {
            get
            {
                return SegundoNombre;
            }

            set
            {
                SegundoNombre = value;
            }
        }

        public string primerapellido
        {
            get
            {
                return PrimerApellido;
            }

            set
            {
                PrimerApellido = value;
            }
        }
        public string segundoapellido
        {
            get
            {
                return SegundoApellido;
            }

            set
            {
                SegundoApellido = value;
            }
        }
        public int celular
        {
            get
            {
                return Celular;
            }

            set
            {
                Celular = value;
            }
        }
        public int telefonocasa
        {
            get
            {
                return TelefonoCasa;
            }

            set
            {
                TelefonoCasa = value;
            }
        }
        public string direccion
        {
            get
            {
                return Direccion;
            }

            set
            {
                Direccion = value;
            }
        }


    }
}
