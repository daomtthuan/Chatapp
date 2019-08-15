using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data
{
    /// <summary>
    /// Data provider
    /// </summary>
    class Provider
    {
        #region Properties
        /// <summary>
        /// Instance variable
        /// </summary>
        private static Provider instance;
        #endregion

        #region Constructors
        /// <summary>
        /// Provider Constructor
        /// </summary>
        private Provider() { }
        #endregion

        #region Methods
        /// <summary>
        /// <para>
        /// Excute query string SQL with @paramater is replaced by element in paramater array
        /// </para>
        /// <para>
        /// Return DataTable is result of executing this query string
        /// </para>
        /// </summary>
        /// <param name="query">Query string</param>
        /// <param name="paramater">Paramater array</param>
        /// <returns>DataTable</returns>
        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            DataTable data = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Config.ConnectString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParamater)
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not connect to Database");
                Console.WriteLine(ex.Message);
            }
            return data;
        }

        /// <summary>
        /// <para>
        /// Excute query string SQL with @paramater is replaced by element in paramater array
        /// </para>
        /// <para>
        /// Return number of rows affected
        /// </para>
        /// </summary>
        /// <param name="query">Query string</param>
        /// <param name="paramater">Paramater array</param>
        /// <returns>int</returns>
        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;
            try
            {
                SqlConnection connection = new SqlConnection(Config.ConnectString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParamater)

                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }

                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not connect to Database");
                Console.WriteLine(ex.Message);
            }
            return data;
        }

        /// <summary>
        /// <para>
        /// Excute query string SQL with @paramater is replaced by element in paramater array
        /// </para>
        /// <para>
        /// Return first columnm of first row in result excuted table
        /// </para>
        /// </summary>
        /// <param name="query">Query string</param>
        /// <param name="paramater">Paramater array</param>
        /// <returns>object</returns>
        public object ExecuteScalar(string query, object[] paramater = null)
        {
            object data = 0;
            try
            {
                SqlConnection connection = new SqlConnection(Config.ConnectString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string item in listParamater)
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not connect to Database");
                Console.WriteLine(ex.Message);
            }
            return data;
        }
        #endregion

        #region Getter Setter
        /// <summary>
        /// Get Instance variable
        /// </summary>
        public static Provider Instance { get => instance ?? new Provider(); private set => instance = value; }
        #endregion
    }
}
