using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_layer
{
    public class total_data
    {
        public static decimal getTotalOf_PerMonth(enSection section, int month, int year, int busNumber)
        {
            decimal total = -1;

            var columnMapping = new Dictionary<enSection, string>
            {
                { enSection.total, "worker_pay" },
                {enSection.net, "amount_left" },
                { enSection.repair, "daily_repair" },
                    { enSection.fuel, "daily_fuel" },
                    { enSection.worker, "worker_pay" },
                    { enSection.company, "company_pay" },

            };

            if (!columnMapping.TryGetValue(section, out string sectionName))
            {
                throw new ArgumentException("Invalid section");
            }

            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string query = @"SELECT SUM(sectionName) FROM daily_exchange
                    WHERE year(date_time) = @year
                     AND month(date_time) = @month 
                     AND bus_number = @busnumber;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@sectionName", sectionName);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@busnumber", busNumber);

                object result = command.ExecuteScalar();
                if (result != null && decimal.TryParse(result.ToString(), out decimal value))
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

        public static decimal TotalBackupAmount()
        {
            decimal total_backup = 0;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = "select SUM(backup_amount) from monthly_exchange;";
                Connection.Open();

                SqlCommand command = new SqlCommand(Query, Connection);

                object result = command.ExecuteScalar();
                if (result != null && decimal.TryParse(result.ToString(), out decimal value))
                {
                    total_backup = value;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //DataSettings.StoreUsingEventLogs(ex.Message.ToString());
            }
            finally
            {
                Connection.Close();
            }
            return total_backup;
        }
   
        
    }
}
