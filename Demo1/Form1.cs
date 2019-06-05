using Demo1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    //Clic derecho en base de datos, Tasks, Backup, para guardar la base de datos
    //Database, clic derecho, Attach o return database, Device, Add, restauramos nuestra base de datos
    public partial class Form1 : Form
    {
        private Stack<Alumno> PilaAlumno = new Stack<Alumno>();

        Conexion con = new Conexion();


        // Metodo para actualizar datagridview
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.DGVAlumno, "Select * from Alumno");
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void agregarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var Agregar = new FormAgregarAlumno(this))
            {
                Agregar.ShowDialog();
            }
        }

    

        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editar = new FormEditarAlumno();
            editar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Actulziar datagrid
            con.ActualizarGrid(this.DGVAlumno, "Select * from Alumno");
        }

        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var buscar = new FormBuscarAlumno();
            buscar.ShowDialog();
        }
    }
}
