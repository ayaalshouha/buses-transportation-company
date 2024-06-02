using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_layer
{
    public struct stailyExchange
    {
        int ID {  get; set; }
        decimal TotalAmount { get; set; }
        decimal DailyRepair {  get; set; }
        decimal WorkerPay { get; set; }
        decimal CompanyPay { get; set; }
        int BusNumber { get; set; }
        decimal DailyFuel { get; set; }
        DateTime Date { get; set; }
        decimal NetAmount { get; set; }
    }

    public struct stMonthlyExchange
    {
        int ID { get; set; }
        int Year { get; set; }
        int Month { get; set; }
        decimal TotalAmountPerMonth { get; set; }
        decimal BackupAmount { get; set; }
        decimal NetAmount { get; set; }

        decimal AkefPercent { get; set; }
        decimal khaldounPercent { get; set; }
        decimal WaleedPercent {  get; set; }
    }

    public class DataSetting
    {
        public static string ConnectionString = "server=.; database=Alshouha_Company; user id=sa; password=sa123456;"; 
    }
}
