using data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisness_layer
{
    public class dailyExchange
    {
        private enum enMode { add, update }
        private enMode mode = enMode.add; 
        public int ID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DailyRepair { get; set; }
        public decimal WorkerPay { get; set; }
        public decimal CompanyPay { get; set; }
        public int BusNumber { get; set; }
        public decimal DailyFuel { get; set; }
        public DateTime Date { get; set; }
        public decimal MiscCost {  get; set; }
        public decimal NetAmount
        {
            get
            {
                return dailyExchange_data.getNetAmount(this.ID); 
            }
        }

        private dailyExchange(stDailyExchange exchange)
        {
            this.ID = exchange.ID;
            this.TotalAmount = exchange.TotalAmount; 
            this.DailyFuel = exchange.DailyFuel;
            this.WorkerPay = exchange.WorkerPay;
            this.CompanyPay = exchange.CompanyPay;
            this.DailyRepair = exchange.DailyRepair;
            this.Date = exchange.Date;
            this.MiscCost = exchange.MiscCost;
            mode = enMode.update; 
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
            this.mode = enMode.add;
        }

        public static dailyExchange Find(DateTime date, int BusNumber)
        {   
            stDailyExchange exchange = new stDailyExchange();
            if (dailyExchange_data.getExchangeByDate_BusNumber(date, BusNumber, ref exchange))
                return new dailyExchange(exchange);
            else
                return null;
        }

        private bool _Add()
        {
            stDailyExchange exchange = new stDailyExchange
            {
                ID = this.ID,
                TotalAmount = this.TotalAmount,
                DailyFuel = this.DailyFuel,
                WorkerPay = this.WorkerPay,
                CompanyPay = this.CompanyPay,
                BusNumber = this.BusNumber,
                DailyRepair = this.DailyRepair,
                MiscCost = this.MiscCost,
                Date= this.Date,
            };
            this.ID = dailyExchange_data.Add(exchange);
            return this.ID != -1; 
        }

        private bool _Update()
        {
            stDailyExchange exchange = new stDailyExchange
            {
                ID = this.ID,
                TotalAmount = this.TotalAmount,
                DailyFuel = this.DailyFuel,
                WorkerPay = this.WorkerPay,
                CompanyPay = this.CompanyPay,
                BusNumber = this.BusNumber,
                DailyRepair = this.DailyRepair,
                MiscCost = this.MiscCost,
                Date = this.Date,
            };

            return dailyExchange_data.Update(exchange);
        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.add:
                    if (_Add())
                    {
                        this.mode = enMode.update;
                        return true;
                    }
                    break;
                case enMode.update:
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
    }
}
