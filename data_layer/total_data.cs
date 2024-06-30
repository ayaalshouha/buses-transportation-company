using System;
using System.Data.SqlClient;

namespace data_layer
{
    public static class total_data
    {
        public static double getSumOf(string q, DateTime fromdate, DateTime todate, int busNumber)
        {
            double total = 0;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string query = q;

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fromdate", fromdate);
                command.Parameters.AddWithValue("@todate", todate);
                command.Parameters.AddWithValue("@busnumber", busNumber);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && double.TryParse(result.ToString(), out double value))
                {
                    total = value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return total;
        }
        public static double TotalBackupAmount()
        {
            double total_backup = 0;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = "select SUM(backup_amount) from monthly_exchange;";
                Connection.Open();

                SqlCommand command = new SqlCommand(Query, Connection);

                object result = command.ExecuteScalar();
                if (result != null && double.TryParse(result.ToString(), out double value))
                {
                    total_backup = value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return total_backup;
        }
    }
}
