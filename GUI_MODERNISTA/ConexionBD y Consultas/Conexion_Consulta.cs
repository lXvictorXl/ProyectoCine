using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace GUI_MODERNISTA
{
    class Conexion_Consulta
    {
        private string cadenaConexion = "Data Source=localhost;Initial Catalog=CineBD;Persist Security Info=True;User ID=sa;Password=1234";

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
                               "where CONVERT(date,f.Hora_Fecha)='" + dia + "'  and p.Id=f.fk_Id_pelicula and p.fk_Id_Clasificacion=c.Id";

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

        public ArrayList Buscar_Funciones_Para_Una_Peli(int idPeli, String dia)
        {
            ArrayList TodasLasFunciones = new ArrayList();
            Funcion_Sala funcionSala;

            string consulta = "Select Distinct fs.id, f.tipo,f.hora_fecha,s.nro,f.id,p.nombre " +
            "from Pelicula p,Funcion f, funcion_sala fs,sala s " +
            "where CONVERT(date, Hora_Fecha)= '" + dia + "'  and fk_Id_pelicula = " + idPeli + " and fs.fk_Id_Funcion = f.id and fs.fk_Nro_Sala = s.Nro and p.Id=f.fk_Id_pelicula " +
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
                funcionSala.NombrePelicula = reader.GetString(5);
                TodasLasFunciones.Add(funcionSala);
            }
            reader.Close();
            conexion.Close();

            return TodasLasFunciones;
        }

        public ArrayList Butacas_Vendidas(int idFuncionSala)
        {
            ArrayList butacasVendidas = new ArrayList();
            string consulta = "select fk_nro_Butaca " +
                              "from Ticket " +
                              "where fk_Id_Funcion_Sala = " + idFuncionSala + "";

            conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);

            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                butacasVendidas.Add(reader.GetInt32(0));
            }
            reader.Close();
            conexion.Close();

            return butacasVendidas;
        }

        public decimal costoTicket(int idCostoTicket)
        {
            decimal costo = 0;

            string consulta = "select precio from costo_ticket where id=" + idCostoTicket + "";
            conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();


            if (reader.Read())
            {
                costo = reader.GetDecimal(0);
            }
            reader.Close();
            conexion.Close();

            return costo;
        }

        ///Consulta para obtener todos los nombres de la tarjetas
        ///
        public ArrayList ConsultaTarjetaCliente(string nit) 
        {
            ArrayList listaTarjetas = new ArrayList();
            Tarjeta tarjeta = new Tarjeta();

            string consulta = "select Distinct t.id,t.nombre,n.nro " +
                "from Cliente c, Tarjeta t,Nro_Tarjeta n, Tarjeta_Nro_Tarjeta tnt " +
                "where tnt.fk_Nit_Ci_Cliente='"+nit+"' and t.Id=tnt.fk_Id_Tarjeta and tnt.fk_Nro_Tarjeta=n.Nro";

            conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                tarjeta = new Tarjeta();

                tarjeta.Id = reader.GetInt32(0);
                tarjeta.Nombre= reader.GetString(1);
                tarjeta.Numero = reader.GetString(2);

                listaTarjetas.Add(tarjeta);
            }
            reader.Close();
            conexion.Close();
            return listaTarjetas;
        }

        //Consuta Promociones
        public ArrayList consultaPromociones(string nombreTarjeta)
        {
            ArrayList listaPromociones = new ArrayList();
            PromocionTicket promocion = new PromocionTicket();

            string consulta = "select * from Promocion where Nombre='"+nombreTarjeta+"'";

            conexion = new SqlConnection(cadenaConexion);
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                promocion = new PromocionTicket();

                promocion.id = reader.GetInt32(0);
                promocion.Nombre = reader.GetString(1);
                promocion.Dia = reader.GetString(2);
                promocion.Descuento = reader.GetDecimal(3);

                listaPromociones.Add(promocion);
            }
            reader.Close();
            conexion.Close();
            return listaPromociones;
        }

        //Insertar Factura a la BD
        public int insertarFactura(FacturaCliente factura)
        {
            int idFactura = 0;

            string consulta = "DECLARE @UltimoID INT " +
                "insert into Factura (Fecha_Emision,Total,fk_Id_Tipo_Pago,fk_Id_Empleado,fk_Nit_Ci_Cliente) " +
                "SELECT "+factura.FechaEmision+","+factura.Total+","+factura.fkIdTipoPago+","+factura.fkIdEmpleado+ ","+factura.fkNitCiCliente+" " +
                "SELECT @UltimoID = SCOPE_IDENTITY()";


            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);
                command.Parameters.AddWithValue("@UltimoID", idFactura);
                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();

                    conexion.Close();
                   
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return idFactura;
        }

        /////////FUNCIONES PARA ADMINISTRADOR DE CARTELERA
        ///
        public Pelicula InfoPelicula(string nombrePelicula)
        {
            Pelicula pelicula = new Pelicula();

            string query = "select p.Id, p.Nombre, p.Genero, CONVERT(datetime,p.Duracion), p.Fecha_Estreno,p.Estado,c.nombre " +
                "from Pelicula as p,Clasificacion as c where p.nombre= '" + nombrePelicula + "' and c.Id=p.fk_id_clasificacion";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        pelicula.id = reader.GetInt32(0);
                        pelicula.nombre = reader.GetString(1);
                        pelicula.genero = reader.GetString(2);
                        pelicula.duracion = reader.GetDateTime(3);
                        pelicula.fechaEstreno = reader.GetDateTime(4);
                        pelicula.estado = reader.GetString(5);
                        pelicula.clasificacion = reader.GetString(6);
                    }
                    reader.Close();
                    conexion.Close();


                }
                catch (Exception ex)
                {
                    throw new Exception("Se he detectado un problema " + ex.Message);
                }

            }
            return pelicula;
        }
        public bool insertarPeliculaBD(Pelicula pelicula, string ruta)
        {
            int idClasificacion = 0;
            bool registrado = false;
            switch (pelicula.clasificacion)
            {
                case "A":
                    idClasificacion = 1;
                    break;
                case "A+13":
                    idClasificacion = 2;
                    break;
                case "A+16":
                    idClasificacion = 3;
                    break;
                case "A+18":
                    idClasificacion = 4;
                    break;


            }
            string consulta = "insert into Pelicula (Nombre,Genero,Duracion,Fecha_Estreno,Estado,fk_Id_Clasificacion,Imagen) " +
                "SELECT '" + pelicula.nombre + "','" + pelicula.genero + "','" + pelicula.duracion.TimeOfDay + "','" + pelicula.fechaEstreno.Date.ToString("yyyy-MM-dd") + "','" + pelicula.estado + "'," + idClasificacion + ",* " +
                "from OpenRowset(Bulk '" + ruta + "',Single_Blob)As Imagen";


            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();

                    conexion.Close();
                    registrado = true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return registrado;
        }
        public bool modificarPeliculaBD(Pelicula pelicula)
        {
            int idClasificacion = 0;
            bool modificado = false;
            switch (pelicula.clasificacion)
            {
                case "A":
                    idClasificacion = 1;
                    break;
                case "A+13":
                    idClasificacion = 2;
                    break;
                case "A+16":
                    idClasificacion = 3;
                    break;
                case "A+18":
                    idClasificacion = 4;
                    break;
            }
            string consulta = "update Pelicula " +
                "set Nombre='" + pelicula.nombre + "',Genero='" + pelicula.genero + "',Duracion='" + pelicula.duracion.TimeOfDay + "',Fecha_Estreno = '" + pelicula.fechaEstreno + "',Estado = '" + pelicula.estado + "',fk_Id_Clasificacion = " + idClasificacion + " " +
                " where Nombre='" + pelicula.nombre + "'";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();

                    conexion.Close();
                    modificado = true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return modificado;
        }

        public List<ClassCartelera> GetFunciones()
        {
            List<ClassCartelera> dgvcartelera = new List<ClassCartelera>();
            string consulta = "Select  p.Id, p.nombre, p.Genero, p.Fecha_Estreno, p.Estado, c.Nombre" +
                " From Pelicula p, Clasificacion c" +
                " where c.Id = fk_Id_Clasificacion and p.estado = 'ACTIVO'";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        ClassCartelera pelicula = new ClassCartelera();
                        pelicula.id = reader.GetInt32(0);
                        pelicula.nombre = reader.GetString(1);
                        pelicula.genero = reader.GetString(2);
                        pelicula.fechaEstreno = reader.GetDateTime(3);
                        pelicula.clasificacion = reader.GetString(4);
                        dgvcartelera.Add(pelicula);

                    }
                    reader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un problema con la base de datos" + ex.ToString());
                }
            }
            return dgvcartelera;
        }




        ////FUNCIONES PARA INICIO DE SESION
        public Empleado devolverEmpleado(string ci, string password, string cargo)
        {
            Empleado empleado = new Empleado();
            string consulta = "select e.id,e.ci,e.nombre,e.apellido_Paterno,e.Apellido_materno,e.Fecha_Nac,e.Celular,e.Direccion,e.Password,e.Estado,c.id,c.nombre " +
                "from empleado e, cargo c, empleado_cargo ec " +
                "where e.ci = '" + ci + "' and e.password = '" + password + "' and ec.fk_Id_Empleado = e.Id and ec.fk_Id_Cargo = c.Id and c.Nombre = '" + cargo + "'and e.Estado=1";
            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        empleado.id = reader.GetInt32(0);
                        empleado.ci = reader.GetString(1);
                        empleado.nombre = reader.GetString(2);
                        empleado.apPaterno = reader.GetString(3);
                        empleado.apMaterno = reader.GetString(4);
                        empleado.fechaNac = reader.GetDateTime(5);
                        empleado.cel = reader.GetInt32(6);
                        empleado.direccion = reader.GetString(7);
                        empleado.password = reader.GetString(8);
                        empleado.estado = reader.GetBoolean(9);
                        empleado.idCargo = reader.GetInt32(10);
                        empleado.cargo = reader.GetString(11);
                    }
                    reader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Se he detectado un problema " + ex.Message);
                }

            }
            return empleado;
        }

        //FUNCIONES PARA EL ADMINISTRADOR DE CAJEROS
        public List<Cajero> Get()
        {
            List<Cajero> empleado = new List<Cajero>();
            string consulta = "select distinct e.Id,e.Nombre,e.Apellido_paterno,e.Apellido_Materno " +
                "from Empleado e, Cargo c, Empleado_Cargo ec " +
                " where e.Id = ec.fk_Id_Empleado and ec.fk_Id_Cargo = 3";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        Cajero cajero = new Cajero();
                        cajero.id = reader.GetInt32(0);
                        cajero.nombre = reader.GetString(1);
                        cajero.apPaterno = reader.GetString(2);
                        cajero.apMaterno = reader.GetString(3);
                        empleado.Add(cajero);

                    }
                    reader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un problema con la Base de Datos" + ex.ToString());
                }
            }
            return empleado;
        }

        public Empleado cajeroID(string ID)
        {
            Empleado empleado = new Empleado();
            string consulta = "select distinct e.Nombre, e.Apellido_Paterno, e.Apellido_Materno, e.Ci, e.Celular, e.Direccion, e.Password " +
                "from Empleado e, Cargo c, Empleado_Cargo ec " +
                " where e.Id = ec.fk_Id_Empleado and ec.fk_Id_Cargo = 3 and e.Id='" + ID + "' and e.Estado=1";
            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        empleado.nombre = reader.GetString(0);
                        empleado.apPaterno = reader.GetString(1);
                        empleado.apMaterno = reader.GetString(2);
                        empleado.ci = reader.GetString(3);
                        empleado.cel = reader.GetInt32(4);
                        empleado.direccion = reader.GetString(5);
                        empleado.password = reader.GetString(6);
                    }
                    reader.Close();
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hay un problema con la Base de Datos" + ex.ToString());
                }
            }
            return empleado;
        }

        public bool modificarCajero(Empleado empleado, int ID)
        {
            bool registrado = false;
            string consulta =
            "update Empleado set Nombre='" + empleado.nombre + "', Apellido_Paterno='" + empleado.apPaterno + "', Apellido_Materno='" + empleado.apMaterno + "', Ci='" + empleado.ci + "', Celular=" + empleado.cel + ", Direccion='" + empleado.direccion + "', Password='" + empleado.password + "'" +
            " where Id='" + ID + "' and Estado=1";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();

                    conexion.Close();
                    registrado = true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return registrado;
        }

        public bool insertarCajero(Empleado empleado)
        {
            bool registrado = false;
            string consulta = "insert into Empleado (Ci, Nombre, Apellido_Paterno, Apellido_Materno, Fecha_Nac, Celular, Direccion, Password, Estado)" +
                " values('" + empleado.ci + "', '" + empleado.nombre + "', '" + empleado.apPaterno + "', '" + empleado.apMaterno + "', '" + empleado.fechaNac + "', " + empleado.cel + ", '" + empleado.direccion + "', '" + empleado.password + "', 1)";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();

                    conexion.Close();
                    registrado = true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return registrado;
        }

        public bool eliminarCuenta(Empleado empleado, int ID)
        {
            bool registrado = true;
            string consulta = "update Empleado set Estado=0 where Id=" + ID + "";

            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();

                    conexion.Close();
                    registrado = false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return registrado;
        }

       // public void ImprimirCajaChica(ConsultaCajas cajachica, int id)
        //{

        //}


        // FUNCION PARA MODIFICACION DE PERFIL
        public bool modificarPerfil(Empleado empleado)
        {

            bool modificado = false;
            string consulta = "UPDATE  Empleado  " +
                "set Celular=" + empleado.cel + ",Direccion='" + empleado.direccion + "',Password='" + empleado.password + "' " +
                "where Ci = '" + empleado.ci + "' ";
            using (conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    command.ExecuteNonQuery();

                    conexion.Close();
                    modificado = true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
            return modificado;
        }

    }
}
