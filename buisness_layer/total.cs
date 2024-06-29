using data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace buisness_layer
{
    public static class total
    {
        public static double getSumTotalAmount(DateTime fromdate, DateTime todate, int busNumber)
        {
            string query = @"SELECT SUM(total_amount) FROM daily_exchange
                        WHERE date_time
                    BETWEEN @fromdate and @todate 
                    AND bus_number = @busNumber";

            return total_data.getSumOf(query, fromdate, todate, busNumber); 
        }
        public static double getSumFuelAmount(DateTime fromdate, DateTime todate, int busNumber)
        {
            string q = @"SELECT SUM(daily_fuel) FROM daily_exchange
                        WHERE date_time
                    BETWEEN @fromdate and @todate 
                    AND bus_number = @busNumber";

            return total_data.getSumOf(q, fromdate, todate, busNumber);
        }
        public static double getSumRepairAmount(DateTime fromdate, DateTime todate, int busNumber)
        {
            string q = @"SELECT SUM(daily_repair) FROM daily_exchange
                        WHERE date_time
                    BETWEEN @fromdate and @todate 
                    AND bus_number = @busNumber";

            return total_data.getSumOf(q, fromdate, todate, busNumber);
        }
        public static double getSumWorkerPayAmount(DateTime fromdate, DateTime todate, int busNumber)
        {
            string q = @"SELECT SUM(worker_pay) FROM daily_exchange
                        WHERE date_time
                    BETWEEN @fromdate and @todate 
                    AND bus_number = @busNumber";

            return total_data.getSumOf(q, fromdate, todate, busNumber);
        }
        public static double getSumCompanyPayAmount(DateTime fromdate, DateTime todate, int busNumber)
        {
            string q = @"SELECT SUM(company_pay) FROM daily_exchange
                        WHERE date_time
                    BETWEEN @fromdate and @todate 
                    AND bus_number = @busNumber";

            return total_data.getSumOf(q, fromdate, todate, busNumber);
        }
        public static double getSumNetAmount(DateTime fromdate, DateTime todate, int busNumber)
        {
            string q = @"SELECT SUM(amount_left) FROM daily_exchange
                        WHERE date_time
                    BETWEEN @fromdate and @todate 
                    AND bus_number = @busNumber";

            return total_data.getSumOf(q, fromdate, todate, busNumber);
        }
        public static double getSumMiscCost(DateTime fromdate, DateTime todate, int busNumber)
        {
            string q = @"SELECT SUM(misc_cost) FROM daily_exchange
                        WHERE date_time
                    BETWEEN @fromdate and @todate 
                    AND bus_number = @busNumber";

            return total_data.getSumOf(q, fromdate, todate, busNumber);
        }
        public static double TotalBackupAccount()
        {
            return total_data.TotalBackupAmount();
        }
    }
}
