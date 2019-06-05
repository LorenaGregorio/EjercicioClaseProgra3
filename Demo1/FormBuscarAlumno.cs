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
    public partial class FormBuscarAlumno : Form
    {
        public FormBuscarAlumno()
        {
            InitializeComponent();
        }
        // Se crea el objeto conexion para que se obtegan los datos
        Conexion con = new Conexion();

        // se crea la variable Id que se utiliza en el boton de editar
        int Id;

        private void button1_Click(object sender, EventArgs e)
        {
            con.ActualizarGrid(this.dataGridView1, "select *  from Alumno where Carne like '" + textBox1.Text + "%'; ");
        }
        // Metodo para actualizar datagridview
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1, "Select * from Alumno");
        }


        private void FormBuscarAlumno_Load(object sender, EventArgs e)
        {
            // se llama al metodo actulizargrid
            this.ActualizarGrid();
        }
    }
}
