using data_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisness_layer
{
    public class dailyExchange
    {
        private data_type_layer.enMode mode; 
        public int ID { get; set; }
        public double TotalAmount { get; set; }
        public double DailyRepair { get; set; }
        public double WorkerPay { get; set; }
        public double CompanyPay { get; set; }
        public int BusNumber { get; set; }
        public double DailyFuel { get; set; }
        public DateTime Date { get; set; }
        public double MiscCost {  get; set; }
        public string RepairNotes { get; set; }
        public double NetAmount
        {
            get
            {
                return dailyExchange_data.getNetAmount(this.ID); 
            }
        }

        private dailyExchange(data_type_layer.stDailyExchange exchange)
        {
            this.ID = exchange.ID;
            this.TotalAmount = exchange.TotalAmount; 
            this.DailyFuel = exchange.DailyFuel;
            this.WorkerPay = exchange.WorkerPay;
            this.CompanyPay = exchange.CompanyPay;
            this.DailyRepair = exchange.DailyRepair;
            this.Date = exchange.Date;
            this.MiscCost = exchange.MiscCost;
            this.BusNumber = exchange.BusNumber;
            this.RepairNotes = exchange.RepairNotes; 
            mode = data_type_layer.enMode.update; 
        }

        public dailyExchange()
        {
            this.ID = -1;
            this.TotalAmount = -1;
            this.DailyFuel = -1;
            this.WorkerPay = -1;
            this.CompanyPay = -1;
            this.BusNumber = -1;
            this.DailyRepair = -1;
            this.Date = DateTime.Now;
            this.MiscCost = -1;
            this.RepairNotes = string.Empty; 
            this.mode = data_type_layer.enMode.add;
        }

        public static dailyExchange Find(int ID)
        {
            data_type_layer.stDailyExchange exchange = new data_type_layer.stDailyExchange();
            if (dailyExchange_data.getExchange(ID, ref exchange))
                return new dailyExchange(exchange);
            else
                return null;
        }
        public static dailyExchange Find(DateTime date, int BusNumber)
        {
            data_type_layer.stDailyExchange exchange = new data_type_layer.stDailyExchange();
            if (dailyExchange_data.getExchangeByDate_BusNumber(date, BusNumber, ref exchange))
                return new dailyExchange(exchange);
            else
                return null;
        }
        private bool _Add()
        {
            data_type_layer.stDailyExchange exchange = new data_type_layer.stDailyExchange
            {
                ID = this.ID,
                TotalAmount = this.TotalAmount,
                DailyFuel = this.DailyFuel,
                WorkerPay = this.WorkerPay,
                CompanyPay = this.CompanyPay,
                BusNumber = this.BusNumber,
                DailyRepair = this.DailyRepair,
                MiscCost = this.MiscCost,
                RepairNotes = this.RepairNotes,
                Date= this.Date,
            };
            this.ID = dailyExchange_data.Add(exchange);
            return this.ID != -1; 
        }
        private bool _Update()
        {
            data_type_layer.stDailyExchange exchange = new data_type_layer.stDailyExchange
            {
                ID = this.ID,
                TotalAmount = this.TotalAmount,
                DailyFuel = this.DailyFuel,
                WorkerPay = this.WorkerPay,
                CompanyPay = this.CompanyPay,
                BusNumber = this.BusNumber,
                DailyRepair = this.DailyRepair,
                MiscCost = this.MiscCost,
                RepairNotes = this.RepairNotes, 
                Date = this.Date,
            };

            return dailyExchange_data.Update(exchange);
        }
        public bool Save()
        {
            switch (mode)
            {
                case data_type_layer.enMode.add:
                    if (_Add())
                    {
                        this.mode = data_type_layer.enMode.update;
                        return true;
                    }
                    break;
                case data_type_layer.enMode.update:
                    return _Update();
            }

            return false;
        }
        public static bool isExist(DateTime date, int BusNumber)
        {
            return dailyExchange_data.isExist_byDateAndBusNumber(date, BusNumber);
        }
        public bool Delete()
        {
            return dailyExchange_data.Delete(this.ID);
        }
        public bool Delete_ByDateAndBus()
        {
            return dailyExchange_data.Delete_byDateAndBusNumber(this.Date, this.BusNumber); ;
        }
        public static DataTable DailyExchangeData()
        {
            return dailyExchange_data.getAllExchanges();
        }
    }
}
