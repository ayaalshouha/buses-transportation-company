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

        //calculate total paid for certain section by month and bus number
       public static decimal TotalPerSectionAndBusNum(enSection section, int month, int year, int busNumber)
       {
            return total_data.getTotalOf_PerMonth(section, month, year, busNumber); 
       }
    
        public static decimal TotalBackupAccount()
        {
            return total_data.TotalBackupAmount();
        }
    }
}
