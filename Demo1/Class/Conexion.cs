using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1.Class
{
    class Conexion
    {
        SqlConnection conn;

        //Metodo para conectar con la base de datos
        public void Conectar()
        {
            conn = new SqlConnection("Data Source=DESKTOP-IO7SKIU\\SQLEXPRESS;Initial Catalog=UdeO;Integrated Security=True");
            conn.Open();
        }

        //Metodo para desconctar la base de datos
        public void Desconectar()
        {
            conn.Close();
        }

        //Metodo para realizar consultar a la base de datos
        public void EjecutarSql(String consulta)
        {
            // se crea una variable llama con que es de comando y aparte el conn que es la conexion a la base de datos

            SqlCommand con = new SqlCommand(consulta, conn);

            //aca se realiza un if para saber si los datos se agregaron a la base de datos
            int filasAfectadas = con.ExecuteNonQuery();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Operacion correcta", "La Base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Operacion Incorrecta", "La Base de Datos no ha sido Modificada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para actualizar en DataGridView
        public void ActualizarGrid(DataGridView dg, string consulta)
        {
            //llamo al metodo conectar que me da la conexion con la base de datos
            this.Conectar();

            //se Crea una referencia para los datos 
            //Para que se tome los datos de la base de datos y los jale en datagridview
            System.Data.DataSet ds = new System.Data.DataSet();



            //se crea un adaptador para los datos de la base de datos
            SqlDataAdapter da = new SqlDataAdapter(consulta, conn);



            //Se realiza una funcion de llenado para la tabla del datagridview
            da.Fill(ds, "Alumno");

            //se agregan las propiedades al datagridview
            dg.DataSource = ds;

            //esta fucnion va a traer todo el contenido de la tabla que mecionamos arriba
            dg.DataMember = "Alumno";

            this.Desconectar();
        }
    }
}
