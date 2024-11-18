using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Taller2
{
    public class ConnectMySQL
    {
        private MySqlConnection connection;

        // Se crea una instancia de tipo privada al compilar el proyecto
        // esto implica que ninguna clase fuera de ella tiene acceso a esto
        private static ConnectMySQL _instance = new ConnectMySQL();

        // Existe un atributo público y estático, el cual retorna la instancia creada en un comienzo
        // esto quiere decir, que desde cualquier punto de la aplicación puedo referenciar el atributo
        // Instance y que me devuelva la instancia creada en un comienzo, sin embargo, no puedo crear
        // una instancia nueva ya que _instance es privado, por lo que no se tiene acceso a ella
        public static ConnectMySQL Instance => _instance;

        private string server;
        private string database;
        private string username;
        private string password;

        private ConnectMySQL()
        {
            server = "localhost";
            database = "taller22";
            username = "root";
            password = "root";

            string connectionString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }


        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // Abre la conexión con la base de datos
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Cierra la conexión con la base de datos
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Ejecuta una consulta en la base de datos (insert, update, delete) con parámetros.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <param name="parameters">Los parámetros de la consulta.</param>
        public void ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand(query, connection);

            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.AddRange(parameters);
            }

            command.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// Ejecuta una consulta SELECT en la base de datos y devuelve un valor escalar como resultado.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <param name="values">Los valores de los parámetros de la consulta.</param>
        /// <returns>Un valor escalar como resultado de la consulta.</returns>
        public string SelectQueryScalar(string query, params string[] values)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                MySqlConnection connection = ConnectMySQL.Instance.GetConnection();
                cmd.Connection = connection;
                cmd.CommandText = query;

                for (int pos = 0; pos < values.Length; pos += 2)
                {
                    cmd.Parameters.AddWithValue(values[pos], values[pos + 1]);
                }

                connection.Open();
                object resultObj = cmd.ExecuteScalar();
                string result = resultObj != null ? resultObj.ToString() : null;

                connection.Close();

                return result;
            }
        }


        /// <summary>
        /// Ejecuta una consulta SELECT en la base de datos y devuelve los resultados en un objeto DataTable.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <param name="values">Los valores de los parámetros de la consulta.</param>
        /// <returns>Un objeto DataTable que contiene los resultados de la consulta.</returns>

        public DataTable SelectQuery(string query, params string[] values)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                MySqlConnection connection = ConnectMySQL.Instance.GetConnection();
                cmd.Connection = connection;
                cmd.CommandText = query;

                for (int pos = 0; pos < values.Length; pos += 2)
                {
                    cmd.Parameters.AddWithValue(values[pos], values[pos + 1]);
                }

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                connection.Close();

                return dt;
            }
        }

    }

}
