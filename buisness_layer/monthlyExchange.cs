using data_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace buisness_layer
{
    public class monthlyExchange
    {
        private enum enMode { add, update }
        private enMode mode = enMode.add; 
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal BackupAmount { get; set; }
        public decimal WorkerSalary { get; set; }
        public decimal TotalAmount 
        { 
            get
            {
                return monthlyExchange_data.getTotalPerMonth(this.Date.Month, this.Date.Year);
            } 
        }
        public decimal NetAmount 
        {
            get
            {
                return monthlyExchange_data.getNetAmount(this.ID);
            }
        }
        public decimal AkefPercent
        {
            get
            {
                return monthlyExchange_data.PersonPercentPerMonth(enPeople.akef, this.ID); 
            }
        }
        public decimal khaldounPercent
        {
            get
            {
                return monthlyExchange_data.PersonPercentPerMonth(enPeople.khaldoun, this.ID);
            }
        }
        public decimal WaleedPercent { 
            get 
            {
                return monthlyExchange_data.PersonPercentPerMonth(enPeople.waleed, this.ID);
            } 
        }

        private monthlyExchange(stMonthlyExchange exchange)
        {
            this.ID = exchange.ID;
            this.BackupAmount = exchange.BackupAmount;
            this.Date = exchange.Date;
            this.WorkerSalary = exchange.WorkerSalary; 
            mode = enMode.update; 
        }
        public monthlyExchange()
        {
            this.ID = -1;
            this.BackupAmount = -1;
            this.Date = DateTime.MinValue;
            this.WorkerSalary = -1;
            this.mode = enMode.add; 
        }

        public static monthlyExchange Find(int month, int year )
        {
            stMonthlyExchange exchange = new stMonthlyExchange();
            if (monthlyExchange_data.getExchangeByMonthYear(month, year, ref exchange))
                return new monthlyExchange(exchange);
            else
                return null; 
        }
        private bool _Add()
        {
            stMonthlyExchange exchange = new stMonthlyExchange
            {
                ID = this.ID,
                BackupAmount = this.BackupAmount,
                Date = this.Date,
                WorkerSalary = this.WorkerSalary
            };
            this.ID = monthlyExchange_data.Add(exchange);
            return this.ID != -1;
        }

        private bool _Update()
        {
            stMonthlyExchange exchange = new stMonthlyExchange
            {
                ID = this.ID,
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

        public static bool isExist(int month)
        {
            return monthlyExchange_data.isExist_ByMonth(month);
        }

        public bool Delete()
        {
            return dailyExchange_data.Delete(this.ID);
        }

        public static decimal TotalAmountPerMonth(DateTime date)
        {
            return monthlyExchange_data.getTotalPerMonth(date.Month, date.Year); 
        }
    }
}
