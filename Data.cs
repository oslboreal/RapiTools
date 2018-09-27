using MySql.Data.MySqlClient;
using System;

/*
        Clase wrapper para la comunicación con Datos.
        26/09/18:16:57 - @Boreal_Arg
 */

namespace Rapitools
{
    public enum TipoOperacion
    {
        Entrada,
        Salida
    }
    public class MySql
    {
        public static MySql Instancia { get; set; }
        public string Password { get; set; } = "";
        public string User { get; set; } = "root";
        public string Server { get; set; } = "localhost";
        public string Database { get; set; } = "shadowless";
        public int LastAffectedRows { get; private set; } = 0;
        public string[] LastReaderContent { get; private set; } = null;
        public MySqlConnection Conexion { get; set; }

        private MySql()
        {

        }

        static MySql()
        {
            Instancia = new MySql();
        }

        /// <summary>
        /// Database Connection.
        /// </summary>
        /// <returns></returns>
        private bool Conectar()
        {
            try
            {
                MySqlConnectionStringBuilder cadena = new MySqlConnectionStringBuilder();
                cadena.Server = Instancia.Server;
                cadena.UserID = Instancia.User;
                cadena.Password = Instancia.Password;
                cadena.Database = Instancia.Database;
                cadena.SslMode = MySqlSslMode.None;

                MySqlConnection con = new MySqlConnection(cadena.ToString());
                Instancia.Conexion = con;

                Instancia.Conexion.Open();

                if (Conexion.State == System.Data.ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Data: Error a la hora de conectar a la base de datos.", ex);
            }

        }

        /// <summary>
        /// Query execution.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public bool EjecutarQuery(string query, TipoOperacion tipo)
        {
            try
            {
                bool respu = false;

                if (Instancia.Conexion.State == System.Data.ConnectionState.Closed)
                {
                    Instancia.Conectar();
                }

                if (Instancia.Conexion.State == System.Data.ConnectionState.Open)
                {
                    var cmd = new MySqlCommand(query, Conexion);
                    switch (tipo)
                    {
                        case TipoOperacion.Entrada:
                            LastAffectedRows = cmd.ExecuteNonQuery();
                            respu = true;
                            break;
                        case TipoOperacion.Salida:
                            var reader = cmd.ExecuteReader();
                            int cantidadColumnas = reader.FieldCount;
                            string[] resultado = new string[cantidadColumnas - 1];

                            while (reader.Read())
                            {
                                for (int i = 0; i < cantidadColumnas; i++)
                                {
                                    resultado[i] = reader.GetString(i);
                                }
                            }
                            LastReaderContent = resultado;
                            respu = true;
                            break;
                        default:
                            respu = false;
                            break;
                    }
                    Conexion.Close();
                }
                return respu;
            }
            catch (System.Exception ex)
            {
                throw new ApplicationException("Data: Error a la hora de ejecutar la Query.", ex);
            }
            finally
            {
                LastAffectedRows = 0;
                LastReaderContent = null;
            }
        }
    }
}