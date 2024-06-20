using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_layer
{
    public enum enPeople { waleed, akef, khaldoun }
    public enum enSection : int { repair, worker, company, fuel, net, total }

    public struct stDailyExchange
    {
        public int ID {  get; set; }
        public double TotalAmount { get; set; }
        public double DailyRepair {  get; set; }
        public double WorkerPay { get; set; }
        public double CompanyPay { get; set; }
        public int BusNumber { get; set; }
        public double DailyFuel { get; set; }
        public DateTime Date { get; set; }
        public double MiscCost {  get; set; }
    }
    public struct stMonthlyExchange
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmountPerMonth { get; set; }
        public double WorkerSalary {  get; set; }
        public double BackupAmount { get; set; }
      
    }
    public class DataSetting
    {
        public static string ConnectionString = "server=.; database=Alshouha_Company; user id=sa; password=sa123456;";

        public static void StoreUsingEventLogs(string message)
        {
            string sourceName = "Transportion_App";

            if (!EventLog.SourceExists(sourceName))
                EventLog.CreateEventSource(sourceName, "Application");

            EventLog.WriteEntry(sourceName, message, EventLogEntryType.Error);
        }

    }
}
