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
        public decimal TotalAmount { get; set; }
        public decimal DailyRepair {  get; set; }
        public decimal WorkerPay { get; set; }
        public decimal CompanyPay { get; set; }
        public int BusNumber { get; set; }
        public decimal DailyFuel { get; set; }
        public DateTime Date { get; set; }
        //public decimal NetAmount { get; set; }

        public decimal MiscCost {  get; set; }
    }
    public struct stMonthlyExchange
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmountPerMonth { get; set; }
        public decimal WorkerSalary {  get; set; }
        public decimal BackupAmount { get; set; }
      
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
