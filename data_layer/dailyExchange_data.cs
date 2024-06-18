using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace data_layer
{
    public static class dailyExchange_data
    {
        public static bool getExchange(int ExchID, ref stDailyExchange exchange)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = "SELECT * FROM daily_exchange WHERE ID = @ExchID;";

                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ExchID", ExchID);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;
                    exchange.ID = (int)reader["ID"];
                    exchange.TotalAmount = Convert.ToDouble(reader["total_amount"]); 
                    exchange.DailyRepair = Convert.ToDouble(reader["daily_repair"]);
                    exchange.WorkerPay = Convert.ToDouble(reader["worker_pay"]);
                    exchange.CompanyPay = Convert.ToDouble(reader["company_pay"]);
                    exchange.DailyFuel = Convert.ToDouble(reader["daily_fuel"]);
                    exchange.BusNumber = (int)reader["bus_number"];
                    exchange.Date = (DateTime)reader["date_time"];
                    exchange.MiscCost = Convert.ToDouble(reader["misc_cost"]);
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
        public static bool getExchangeByDate_BusNumber(DateTime date, int busNumber, ref stDailyExchange exchange)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"SELECT * FROM daily_exchange
                                 WHERE date_time = @date
                         AND bus_number = @busNumber;";

                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@busNumber", busNumber);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    isFound = true;
                    exchange.ID = (int)reader["ID"];
                    exchange.TotalAmount = Convert.ToDouble(reader["total_amount"]);
                    exchange.DailyRepair = Convert.ToDouble(reader["daily_repair"]);
                    exchange.WorkerPay = Convert.ToDouble(reader["worker_pay"]);
                    exchange.CompanyPay = Convert.ToDouble(reader["company_pay"]);
                    exchange.DailyFuel = Convert.ToDouble(reader["daily_fuel"]);
                    exchange.BusNumber = (int)reader["bus_number"];
                    exchange.Date = (DateTime)reader["date_time"];
                    exchange.MiscCost = Convert.ToDouble(reader["misc_cost"]); 
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
        public static int Add(stDailyExchange exchange)
        {
            int newID = -1;

            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"DECLARE @_ID int; 
                            EXEC sp_AddDailyExchange
                                 @totalamount,
                                 @dailyrepair,
                                 @workerpay,
                                 @companypay,
                                 @dailyfuel,
                                 @busnumber,
                                 @datetime,
                                 @misccost,
                                 @moveID = @_ID output;
                               SELECT @_ID;";
                
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@totalamount", exchange.TotalAmount);
                Command.Parameters.AddWithValue("@dailyrepair", exchange.DailyRepair);
                Command.Parameters.AddWithValue("@workerpay", exchange.WorkerPay);
                Command.Parameters.AddWithValue("@companypay", exchange.CompanyPay);
                Command.Parameters.AddWithValue("@dailyfuel", exchange.DailyFuel);
                Command.Parameters.AddWithValue("@busnumber", exchange.BusNumber);
                Command.Parameters.AddWithValue("@datetime", exchange.Date);

                if (exchange.MiscCost == -1)
                    Command.Parameters.AddWithValue("@misccost", 0);
                else
                    Command.Parameters.AddWithValue("@misccost", exchange.MiscCost); 

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
            }
            finally
            {
                Connection.Close();
            }

            return newID;
        }
        public static bool Update(stDailyExchange exchange)
        {
            int RowAffected = 0;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"Update daily_exchange
                    SET total_amount = @totalamount,
                        daily_repair = @dailyrepair, 
                        worker_pay = @workerpay, 
                        company_pay = @companypay,
                        daily_fuel = @dailyfuel, 
                        bus_number = @busnumber,
                        date_time = @datetime,
                        misc_cost = @misccost
                        WHERE ID = @exchangeID;";


                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@exchangeID", exchange.ID);
                Command.Parameters.AddWithValue("@totalamount", exchange.TotalAmount);
                Command.Parameters.AddWithValue("@dailyrepair", exchange.DailyRepair);
                Command.Parameters.AddWithValue("@workerpay", exchange.WorkerPay);
                Command.Parameters.AddWithValue("@companypay", exchange.CompanyPay);
                Command.Parameters.AddWithValue("@dailyfuel", exchange.DailyFuel);
                Command.Parameters.AddWithValue("@busnumber", exchange.BusNumber);
                Command.Parameters.AddWithValue("@datetime", exchange.Date);
                Command.Parameters.AddWithValue("@misccost", exchange.MiscCost);
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
        public static double getNetAmount(int exchangeID)
        {
            double NetAmount = -1; 
            SqlConnection connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
               
                string query = "select amount_left from daily_exchange where ID = @exchangeID;";
                
                SqlCommand command =  new SqlCommand(@query, connection);
                command.Parameters.AddWithValue("@exchangeID", exchangeID);

                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && double.TryParse(result.ToString(), out double netamount))
                {
                    NetAmount = netamount;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); 
            }
            finally
            {
                connection.Close();
            }

            return NetAmount;
        }
        public static bool isExist_byDateAndBusNumber(DateTime date, int Busnumber)
        {
            bool isFound = false;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"SELECT ID FROM daily_exchange
                        WHERE date_time = @date AND bus_number = @Busnumber;";
                SqlCommand command = new SqlCommand(Query, Connection);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@Busnumber", Busnumber);
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
                string Query = @"DELETE FROM daily_exchange
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
        public static bool Delete_byDateAndBusNumber(DateTime date, int Busnumber)
        {
            int RowAffected = -1;
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"DELETE FROM daily_exchange
                        WHERE date_time = @date AND bus_number = @Busnumber;";

                SqlCommand command = new SqlCommand(Query, Connection);

                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@Busnumber", Busnumber);

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
        public static DataTable getAllExchanges()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(DataSetting.ConnectionString);
            try
            {
                string Query = @"SELECT * FROM daily_exchange;";

                SqlCommand command = new SqlCommand(Query, Connection);

                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dt.Load(reader);
                }
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
