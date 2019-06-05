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
    public partial class FormEditarAlumno : Form
    {
        Conexion con = new Conexion();

        // se crea la variable Id que se utiliza en el boton de editar
        int IdAlumno;

        // Se crea una variable booleana como temporal para porder actualizar y no se guarde como un nuevo dato
        bool editar;

        public FormEditarAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void LlenarCamposForm(DataSet dsAlumno)
        {
            
        }

        // Metodo para actualizar datagridview
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1, "Select * from Alumno");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //La variable editar se agrega para que sea true
            editar = true;
            button1.Visible = true;
            // se agregan las campos de los datos por columna como un vector
            IdAlumno = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtCarne.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrimerNombre.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSegundoNombre.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrimerApellido.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSegundoApellido.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTelefonoCasa.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtDireccion.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void FormEditarAlumno_Load(object sender, EventArgs e)
        {
            // se llama al metodo actulizargrid
            this.ActualizarGrid();

            // se llama a la variable editar y se coloca false
            editar = false;
            button1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
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
                string consulta = "update Alumno set Carne = '" + a1.carne + "', PrimerNombre = '" + a1.primernombre + "', SegundoNombre = '" + a1.segundonombre + "', " +
                    "PrimerApellido = '" + a1.primerapellido + "', SegundoApellido = '" + a1.segundoapellido + "', Celular = " + a1.celular + ", TelefonoCasa = " + a1.telefonocasa + ", Direccion = '" + a1.direccion + "'  where IdAlumno = " + IdAlumno + " ;";
                con.EjecutarSql(consulta);
                // se llama al metodo actulizargrid
                this.ActualizarGrid();
                con.Desconectar();
                button1.Visible = false;
                editar = false;
            }
            else
            {
                con.Conectar();

                //Se crea una consulta para insertar los datos (Guardar)
                string consulta = "insert into Alumno (Carne,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Celular,TelefonoCasa,Direccion) values ('" + a1.carne + "','" + a1.primernombre + "','" + a1.segundonombre + "'," +
                    "'" + a1.primerapellido + "','" + a1.segundoapellido + "'," + a1.celular + "," + a1.telefonocasa + ",'" + a1.direccion + "' );";
                //con esta funcion ejecuto la consulta de arriba en codigo sql
                con.EjecutarSql(consulta);
                // se llama al metodo actulizargrid
                this.ActualizarGrid();
                con.Desconectar();
                button1.Visible = false;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // se agregan las campos de los datos por columna como un vector 
            IdAlumno = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var resultado = MessageBox.Show("¿Desea eliminar el dato", "Confirme si desea borrarlo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                con.Conectar();
                string consulta = "delete from Alumno where IdAlumno = '" + IdAlumno + "' ; ";
                con.EjecutarSql(consulta);
                this.ActualizarGrid();
                con.Desconectar();
            }
            else
            {
                return;
            }
        }
    }
}
