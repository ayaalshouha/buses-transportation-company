using System;

namespace data_type_layer
{
    public enum enMode { add, update };
    public struct stDailyExchange
    {
        public int ID { get; set; }
        public double TotalAmount { get; set; }
        public double DailyRepair { get; set; }
        public double WorkerPay { get; set; }
        public double CompanyPay { get; set; }
        public int BusNumber { get; set; }
        public double DailyFuel { get; set; }
        public DateTime Date { get; set; }
        public double MiscCost { get; set; }
        public string RepairNotes { get; set; }
    }
    public struct stMonthlyExchange
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmountPerMonth { get; set; }
        public double WorkerSalary { get; set; }
        public double BackupAmount { get; set; }

    }
}
