using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GUI_MODERNISTA
{
    public class Modificar
    {
        private string connectionString
              = "Data Source=(localdb)\\Servidor;Initial Catalog=CineBD;Integrated Security=True";
        public bool Ok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public ModificarBD Get(int Id)
        {
            string query = "select Id,Ci,Nombre,Apellido_paterno,Apellido_Materno,Edad,Celular,Direccion,Password" +
                "from Empleado where id=@id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    ModificarBD oModificar = new ModificarBD();
                    oModificar.Id = reader.GetInt32(0);
                    oModificar.Ci = reader.GetString(1);
                    oModificar.Nombre = reader.GetString(2);
                    oModificar.Apellido_Paterno = reader.GetString(3);
                    oModificar.Apellido_Materno = reader.GetString(4);
                    oModificar.Edad = reader.GetInt32(5);
                    oModificar.Celular = reader.GetInt32(6);
                    oModificar.Direccion = reader.GetString(7);
                    oModificar.Password = reader.GetString(8);

                    reader.Close();

                    connection.Close();
                    return oModificar;
                }
                catch (Exception ex)
                {
                    throw new Exception("Existe un error en la Base de Datos" + ex.Message);
                }
            }
        }

    }

    public class ModificarBD
    {
        public int Id { get; set; }
        public string Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public int Edad { get; set; }
        public int Celular { get; set; }
        public string Direccion { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }

    }
}
