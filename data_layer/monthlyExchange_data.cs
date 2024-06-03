using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace data_layer
{
    public class monthlyExchange_data
    {
        public static bool getExchangeByMonthYear(int month, int year, ref stMonthlyExchange exchange)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"SELECT * FROM monthly_exchange
                                 WHERE YEAR(date_time) = @year
                         AND MONTH(date_time) = @month;";

                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@month", month);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;
                    exchange.ID = (int)reader["ID"];
                    exchange.TotalAmountPerMonth = (decimal)reader["total_amount"];
                    exchange.BackupAmount = (decimal)reader["backup_amount"];
                    exchange.NetAmount = (decimal)reader["net_amount"];
                    exchange.AkefPercent = (decimal)reader["akef_percent"];
                    exchange.khaldounPercent = (decimal)reader["khldoun_percent"];
                    exchange.WaleedPercent = (int)reader["waleed_percent"];
                    exchange.Date = (DateTime)reader["date_time"];
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static int Add(stMonthlyExchange exchange)
        {
            int newID = -1;

            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"INSERT INTO  
                        monthly_exchanage  (total_amount, backup_amount, date_time)
                        VALUES  (@totalamount, @backupamount, @datetime);
                          SELECT SCOPE_IDENTITY();";

                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@totalamount", exchange.TotalAmountPerMonth);
                Command.Parameters.AddWithValue("@backupamount", exchange.BackupAmount);
                Command.Parameters.AddWithValue("@datetime", exchange.Date);

                Connection.Open();
                object result = Command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int LastID))
                {
                    newID = LastID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                //DataSettings.StoreUsingEventLogs(ex.Message.ToString());
            }
            finally
            {
                Connection.Close();
            }

            return newID;
        }

        public static bool Update(stMonthlyExchange exchange)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"Update monthy_exchange
                                SET total_amount = @totalamount,
                                    backup_amount = @backup_amount
                                WHERE ID = @exchangeID;";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@totalamount", exchange.TotalAmountPerMonth);
                Command.Parameters.AddWithValue("@backup_amount", exchange.BackupAmount);
                Command.Parameters.AddWithValue("@exchangeID", exchange.ID);

                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
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

            return RowAffected > 0;
        }
             
        public static bool isExist_ByMonth(int month)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"SELECT ID FROM monthly_exchange
                        WHERE MONTH(date_time) = @month;";

                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@month", month);
                Connection.Open();
                object result = command.ExecuteScalar();
                isFound = (result != null);
            }
            catch (Exception ex)
            {
                //DataSettings.StoreUsingEventLogs(ex.Message.ToString());
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return isFound;
        }

        public static bool Delete(int ExchangeID)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"DELETE FROM monthly_exchange
                        WHERE ID = @ExchangeID;";

                SqlCommand command = new SqlCommand(Query, Connection);

                command.Parameters.AddWithValue("@ExchangeID", ExchangeID);

                Connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //DataSettings.StoreUsingEventLogs(ex.Message.ToString());
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return RowAffected > 0;
        }

        public static decimal PersonPercentPerMonth(enPeople person, int exchangeID)
        {
            decimal req_percent = 0;
            var columnMapping = new Dictionary<enPeople, string>
            {
                { enPeople.waleed, "waleed_percent" },
                { enPeople.akef, "akef_percent" },
                { enPeople.khaldoun, "khldoun_percent" }
            };

            if (!columnMapping.TryGetValue(person, out string person_name))
            {
                throw new ArgumentException("Invalid person");
            }

            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);

            try
            {
                string query = @"select @personname from monthly_exchange 
                        where ID = @exchangeID;";

                Connection.Open();
                SqlCommand command = new SqlCommand(query, Connection);
                command.Parameters.AddWithValue("@exchangeID", exchangeID);

                object result = command.ExecuteScalar();
                if (result != null && decimal.TryParse(result.ToString(), out decimal value))
                {
                    req_percent = value;
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
            return req_percent;
        }

        public static decimal getNetAmount(int exchangeID)
        {
            decimal NetAmount = -1;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {

                string query = "select net_amount from monthly_exchange where ID = @exchangeID;";

                SqlCommand command = new SqlCommand(@query, connection);
                command.Parameters.AddWithValue("@exchangeID", exchangeID);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal netamount))
                {
                    NetAmount = netamount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return NetAmount;
        }


    }
}
