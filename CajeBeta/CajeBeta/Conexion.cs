using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace CajeBeta
{
    class Conexion
    {
        string cadena = "Data Source=LAPTOP-TRU4IDVJ;Initial Catalog='Cine Beta';Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            conectarbd.ConnectionString = cadena;
        }
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("conexion abierta");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
        public void cerrar()
        {
            conectarbd.Close();
        }

        public string insertar(int nit_Ci,string nombre,string apellido,int celular)
        {
            string salida = "Si se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Cliente(Nit_Ci,Nombre,Apellido,Celular)values("+nit_Ci+",'"+nombre+"','"+apellido+"',"+celular+")",conectarbd);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "no se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string PalabraInsertada(int nit_Ci)//palabra q ya se encuentra en la base de datos
        {
            int contator = 0;
            try
            {
                cmd = new SqlCommand("Select * from Cliente where Nit_Ci="+nit_Ci+"", conectarbd);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                salida = "no se conecto: " + ex.ToString();
            }
            return salida;
        }
    }
}
