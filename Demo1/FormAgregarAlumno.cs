using Demo1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class FormAgregarAlumno : Form
    {
        Conexion con = new Conexion();

        // se crea la variable Id que se utiliza en el boton de editar
        int Id;

        // Se crea una variable booleana como temporal para porder actualizar y no se guarde como un nuevo dato
        bool editar;


        //Constructor
        //Agregaremos el tipo del Formulario 1
        private Form1 Form1;
        public FormAgregarAlumno(Form1 form1)
        {
            InitializeComponent();
            //this, lo que está en la clase
            //.Form1, la propiedad
            this.Form1 = form1;
        }

        private void FormAgregarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            AgregarNuevoAlumno();
        }

      
        private void AgregarNuevoAlumno()
        {
            Alumno a1 = new Alumno(

                 Convert.ToInt32(txtCarne.Text),
                 txtPrimerNombre.Text,
                 txtSegundoNombre.Text,
                 txtPrimerApellido.Text,
                 txtSegundoApellido.Text,
                 Convert.ToInt32(txtCelular.Text),
                 Convert.ToInt32(txtTelefonoCasa.Text),
                 txtDireccion.Text

          );
            // se  crea un if para ver si el usuario seleciono la opcion de guardar o editar
            if (editar)
            {
                //Se realiza un update
                con.Conectar();
                string consulta = "update Alumno set Carne = '" +a1.carne  + "', PrimerNombre = '" + a1.primernombre + "', SegundoNombre = '" + a1.segundonombre +"', " +
                    "PrimerApellido = '" + a1.primerapellido + "', SegundoApellido = '" + a1.segundoapellido + "', Celular = " + a1.celular+ ", TelefonoCasa = " + a1.telefonocasa + ", Direccion = '" + a1.direccion + "'  where Id = " + Id + " ;";
                con.EjecutarSql(consulta);
                
                con.Desconectar();
           
                editar = false;
            }
            else
            {
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into Alumno (Carne,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Celular,TelefonoCasa,Direccion) values ('" + a1.carne + "','"+a1.primernombre+ "','"+a1.segundonombre+ "'," +
                    "'"+a1.primerapellido+ "','"+a1.segundoapellido+ "',"+a1.celular+ ","+a1.telefonocasa+ ",'"+a1.direccion+"' );";
                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
         
                con.Desconectar();
            
            }

        }
    }
}
