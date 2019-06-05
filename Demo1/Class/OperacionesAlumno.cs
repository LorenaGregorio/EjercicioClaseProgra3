using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Class
{
    public class OperacionesAlumno
    {
        //TUPLA: fila
        //DATA SET: esquema de datos que puede contener muchas tablas
        public DataSet BuscarAlumnoPorCarne(int Carne)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = "Server=DESKTOP - IO7SKIU\\SQLEXPRESS;Database=UdeO;Trusted_Connection=true";
                    conn.Open();
                    

                      //Indica qué tabla (ALUMNO) y luego el condicional
                      var select = "SELECT * FROM Alumno WHERE Carne =" + Carne;

                    //Procesa un comando en un dataset
                    //Pasamos primero la instrucción y luego la conexión
                    var dataAdapter = new SqlDataAdapter(select, conn);

                    //Construcción del comando para ejecutarlo
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);

                    var ds = new DataSet();
                    //Llenamos el dataset
                    dataAdapter.Fill(ds);
                    //Retornamos el dataset
                    return ds;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
