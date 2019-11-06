using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ServerChatapp.dal
{
    public class DataProvider
    {
        private static DataProvider instance;
        private readonly SqlConnection connection;

        private DataProvider()
        {
            try
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Chatapp"].ConnectionString);
                connection.Open();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Could not connect to database");
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }

            private set => instance = value;
        }

        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            DataTable data = new DataTable();
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (paramater != null)
                    {
                        string[] listParamater = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParamater)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i++]);
                            }
                        }
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not access to database");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (paramater != null)
                    {
                        string[] listParamater = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParamater)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i++]);
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not access to database");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] paramater = null)
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (paramater != null)
                    {
                        string[] listParamater = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParamater)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i++]);
                            }
                        }
                    }
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Could not access to database");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }
    }
}