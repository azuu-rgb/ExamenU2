using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;


namespace ExamenU2
{
    internal class ClassdDAT
    {

        String cadenaConex = "Data Source=VWNC71429;" +
                            "integrated security=true;initial catalog=Agenda;encrypt=false";

        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConex);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL ABRIR LA CONEXION" + ex.Message);
                return null;
            }
        }

        public DataSet Consulta(String consulta)
        {
            try
            {
                DataSet consultaConexion = new DataSet();
                SqlDataAdapter consultaAdapter = new SqlDataAdapter(consulta, abrirConexion());
                consultaAdapter.Fill(consultaConexion);
                return consultaConexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public bool comando(string consulta)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(consulta, abrirConexion());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


    }
}
