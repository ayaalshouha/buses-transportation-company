using data_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace buisness_layer
{
    public class monthlyExchange
    {
        private data_type_layer.enMode mode;
        public int ID { get; set; }
        public double TotalAmount { get; set; }
        public double WorkerSalary { get; set; }
        public double BackupAmount { get; set; }
        public DateTime Date { get; set; }
        public double NetAmount 
        {
            get
            {
                return monthlyExchange_data.getNetAmount(this.ID);
            }
        }
        public double AkefPercent
        {
            get
            {
                return monthlyExchange_data.AkefPercentPerMonth(this.ID); 
            }
        }
        public double khaldounPercent
        {
            get
            {
                return monthlyExchange_data.khaldounPercentPerMonth(this.ID);
            }
        }
        public double WaleedPercent { 
            get 
            {
                return monthlyExchange_data.WaleedPercentPerMonth(this.ID);
            } 
        }

        private monthlyExchange(data_type_layer.stMonthlyExchange exchange)
        {
            this.ID = exchange.ID;
            this.TotalAmount = exchange.TotalAmountPerMonth; 
            this.BackupAmount = exchange.BackupAmount;
            this.Date = exchange.Date;
            this.WorkerSalary = exchange.WorkerSalary; 
            mode = data_type_layer.enMode.update; 
        }
        public monthlyExchange()
        {
            this.ID = -1;
            this.TotalAmount = -1;
            this.BackupAmount = -1;
            this.Date = DateTime.MinValue;
            this.WorkerSalary = -1;
            this.mode = data_type_layer.enMode.add; 
        }
        public static monthlyExchange Find(int exchID)
        {
            data_type_layer.stMonthlyExchange exchange = new data_type_layer.stMonthlyExchange();
            if (monthlyExchange_data.getExchange(exchID, ref exchange))
                return new monthlyExchange(exchange);
            else
                return null;
        }
        public static monthlyExchange Find(int month, int year )
        {
            data_type_layer.stMonthlyExchange exchange = new data_type_layer.stMonthlyExchange();
            if (monthlyExchange_data.getExchangeByMonthYear(month, year, ref exchange))
                return new monthlyExchange(exchange);
            else
                return null; 
        }
        private bool _Add()
        {
            data_type_layer.stMonthlyExchange exchange = new data_type_layer.stMonthlyExchange
            {
                ID = this.ID,
                BackupAmount = this.BackupAmount,
                TotalAmountPerMonth = this.TotalAmount,
                Date = this.Date,
                WorkerSalary = this.WorkerSalary
            };
            this.ID = monthlyExchange_data.Add(exchange);
            return this.ID != -1;
        }

        private bool _Update()
        {
            data_type_layer.stMonthlyExchange exchange = new data_type_layer.stMonthlyExchange
            {
                ID = this.ID,
                TotalAmountPerMonth = this.TotalAmount,
                BackupAmount = this.BackupAmount,
                Date = this.Date,
                WorkerSalary = this.WorkerSalary
            };

            return monthlyExchange_data.Update(exchange);
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

        public static bool isExist(int month)
        {
            return monthlyExchange_data.isExist_ByMonth(month);
        }

        public bool Delete()
        {
            return monthlyExchange_data.Delete(this.ID);
        }
        public static double TotalAmountPerMonth(DateTime date)
        {
            return monthlyExchange_data.getTotalPerMonth(date.Month, date.Year); 
        }

        public static DataTable MonthlyExchangeData()
        {
            return monthlyExchange_data.getAllExchanges();
        }
    }
}
