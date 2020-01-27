using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace GUI_MODERNISTA
{
    class Conexion_Consulta
    {
        private string cadenaConexion = "Data Source=(localdb)\\Servidor;Initial Catalog=CineBD;Integrated Security=True";

        SqlConnection conexion;
        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.cadenaConexion);
            return this.conexion;
        }
        public bool PruebaConectar(string strComando)
        {
            try
            {

                SqlCommand comando = new SqlCommand();
                comando.CommandText = strComando;
                comando.Connection = this.EstablecerConexion();
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //////////FUNCIONES PARA CAJERO
        ///
        ///Funcion que obtiene una lista de peliculas, cada una con su respectiva
        ///informacion(id, nombre,genero...etc), que se exhibiran en un determinado día
        public ArrayList Buscar_Pelicula_C(string dia)
        {
            Pelicula infoPelicula;
            ArrayList ListaPeliculas = new ArrayList();

            string consulta = "Select DISTINCT p.Id,p.Nombre,p.Genero,c.Nombre " +
                              "from Pelicula as p,Funcion f,Clasificacion c " +
                               "where CONVERT(date,f.Hora_Fecha)='2020-01-21'  and p.Id=f.fk_Id_pelicula and p.fk_Id_Clasificacion=c.Id";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        infoPelicula = new Pelicula();

                        infoPelicula.id = reader.GetInt32(0);
                        infoPelicula.nombre = reader.GetString(1);
                        infoPelicula.genero = reader.GetString(2);
                        infoPelicula.clasificacion = reader.GetString(3);
                        ListaPeliculas.Add(infoPelicula);
                    }
                    reader.Close();

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return ListaPeliculas;
        }
        public byte[] Obtener_Imagen_C(int id)
        {
            byte[] datosImagen = new byte[0];
            string consulta = "Select Imagen " +
                              "from Pelicula " +
                               "where id=" + id + "";
            conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter dp = new SqlDataAdapter(comando);
            DataSet ds = new DataSet("Pelicula");

            dp.Fill(ds, "Pelicula");

            DataRow myRow = ds.Tables["Pelicula"].Rows[0];
            datosImagen = (byte[])myRow["Imagen"];

            return datosImagen;
        }

        public ArrayList Buscar_Funciones_Para_Una_Peli(int idPeli, DateTime dia)
        {
            ArrayList TodasLasFunciones = new ArrayList();
            Funcion_Sala funcionSala;

            string consulta = "Select Distinct fs.id, f.tipo,f.hora_fecha,s.nro,f.id " +
            "from Pelicula p,Funcion f, funcion_sala fs,sala s " +
            "where CONVERT(date, Hora_Fecha)= '" + dia + "'  and fk_Id_pelicula = " + idPeli + " and fs.fk_Id_Funcion = f.id and fs.fk_Nro_Sala = s.Nro " +
            "order by f.tipo, f.Hora_Fecha";

            conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                funcionSala = new Funcion_Sala();

                funcionSala.Id_FuncionSala = reader.GetInt32(0);
                funcionSala.Tipo = reader.GetString(1);
                funcionSala.Fecha_Hora = reader.GetDateTime(2);
                funcionSala.Nro_Sala = reader.GetInt32(3);
                funcionSala.Id_Funcion = reader.GetInt32(4);
                TodasLasFunciones.Add(funcionSala);
            }
            reader.Close();
            conexion.Close();

            return TodasLasFunciones;
        }
    }
}
