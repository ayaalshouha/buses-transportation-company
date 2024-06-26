﻿using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace data_layer
{
    public class monthlyExchange_data
    {
        public static bool getExchange(int ExchID, ref data_type_layer.stMonthlyExchange exchange)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"SELECT * FROM monthly_exchange
                                 WHERE ID = @ExchID;";

                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ExchID", ExchID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;
                    exchange.ID = (int)reader["ID"];
                    exchange.TotalAmountPerMonth = Convert.ToDouble(reader["total_amount"]);
                    exchange.BackupAmount = Convert.ToDouble(reader["backup_amount"]);
                    exchange.WorkerSalary = Convert.ToDouble(reader["worker_salary"]);
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
        public static bool getExchangeByMonthYear(int month, int year, ref data_type_layer.stMonthlyExchange exchange)
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
                    exchange.TotalAmountPerMonth = Convert.ToDouble(reader["total_amount"]);
                    exchange.BackupAmount = Convert.ToDouble(reader["backup_amount"]);
                    exchange.WorkerSalary = Convert.ToDouble(reader["worker_salary"]);
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
        public static int Add(data_type_layer.stMonthlyExchange exchange)
        {
            int newID = -1;

            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"INSERT INTO  
                        monthly_exchange(total_amount,backup_amount,worker_salary, date_time)
                        VALUES  (@totalAmount, @backupamount,@workersalary, @datetime);
                          SELECT SCOPE_IDENTITY();";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@totalAmount", exchange.TotalAmountPerMonth);
                Command.Parameters.AddWithValue("@backupamount", exchange.BackupAmount);
                Command.Parameters.AddWithValue("@datetime", exchange.Date);
                Command.Parameters.AddWithValue("@workersalary", exchange.WorkerSalary);
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
        public static bool Update(data_type_layer.stMonthlyExchange exchange)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"Update monthly_exchange
                                SET backup_amount = @backupamount,
                                    worker_salary = @workersalary
                                WHERE ID = @exchangeID;";

                SqlCommand Command = new SqlCommand(Query, Connection);
                //Command.Parameters.AddWithValue("@totalAmount", exchange.TotalAmountPerMonth);
                Command.Parameters.AddWithValue("@backupamount", exchange.BackupAmount);
                Command.Parameters.AddWithValue("@exchangeID", exchange.ID);
                Command.Parameters.AddWithValue("@workersalary", exchange.WorkerSalary);

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
        public static double AkefPercentPerMonth(int exchangeID)
        {
            double req_percent = 0;

            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);

            try
            {
                string query = @"select akef_percent from monthly_exchange 
                        where ID = @exchangeID;";

                Connection.Open();

                SqlCommand command = new SqlCommand(query, Connection);

                command.Parameters.AddWithValue("@exchangeID", exchangeID);

                object result = command.ExecuteScalar();

                if (result != null && double.TryParse(result.ToString(), out double value))
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
        public static double WaleedPercentPerMonth(int exchangeID)
        {
            double req_percent = 0;

            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);

            try
            {
                string query = @"select waleed_percent from monthly_exchange 
                        where ID = @exchangeID;";

                Connection.Open();

                SqlCommand command = new SqlCommand(query, Connection);

                command.Parameters.AddWithValue("@exchangeID", exchangeID);

                object result = command.ExecuteScalar();

                if (result != null && double.TryParse(result.ToString(), out double value))
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
        public static double khaldounPercentPerMonth(int exchangeID)
        {
            double req_percent = 0;

            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);

            try
            {
                string query = @"select khldoun_percent from monthly_exchange 
                        where ID = @exchangeID;";

                Connection.Open();

                SqlCommand command = new SqlCommand(query, Connection);

                command.Parameters.AddWithValue("@exchangeID", exchangeID);

                object result = command.ExecuteScalar();

                if (result != null && double.TryParse(result.ToString(), out double value))
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
        public static double getNetAmount(int exchangeID)
        {
            double NetAmount = -1;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {

                string query = "select net_amount from monthly_exchange where ID = @exchangeID;";

                SqlCommand command = new SqlCommand(@query, connection);
                command.Parameters.AddWithValue("@exchangeID", exchangeID);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && double.TryParse(result.ToString(), out double netamount))
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
        public static double getTotalPerMonth(int month, int year)
        {
            double totalAmount = 0;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string query = @"select sum(amount_left) from daily_exchange
                        WHERE MONTH(date_time) = @month and YEAR(date_time) = @year";

                SqlCommand command = new SqlCommand(@query, connection);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && double.TryParse(result.ToString(), out double netamount))
                {
                    totalAmount = netamount;
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

            return totalAmount;

        }
        public static DataTable getAllExchanges()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"SELECT * FROM monthly_exchange;";

                SqlCommand command = new SqlCommand(Query, Connection);

                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
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
            return dt;
        }
    }
}
