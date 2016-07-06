using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CoinChanger
    {
        int penies;
        int nickles;
        int dimes;
        int quarters;
        int cents;
        public string changeAmoutString;
        

        int pennieUnit = 1;
        double pennieValue = 0.01;
        int nickleUnit = 5;
        int dimesUnit = 10;
        int quarterUnit = 25;

        public string ChangeCheck(double input)
        {
            if (input < pennieValue) { return changeAmoutString = "No Change"; }
            else {return MakeChange(input); }
        }

        public string MakeChange(double input)
        {
            
            cents = Convert.ToInt32(input*100);
            CountCoins(ref quarters, quarterUnit);
            CountCoins(ref dimes, dimesUnit);
            CountCoins(ref nickles, nickleUnit);
            CountCoins(ref penies, pennieUnit);     
            makeChangeString();
            return changeAmoutString;
        }

        private void CountCoins(ref int coin, int coinUnit)
        {
            for (var x = cents; x >= coinUnit; x -= coinUnit)
            {
                coin += 1;
                cents -= coinUnit;
            }
        }

       

        private void makeChangeString()
        {
            if (quarters > 0)
            {
                changeAmoutString += "Quarters: " + quarters.ToString() + " ";
            }
            if (dimes > 0)
            {
                changeAmoutString += "Dimes: " + dimes.ToString() + " ";
            }
            if (nickles > 0)
            {
                changeAmoutString += "Nickles: " + nickles.ToString() + " ";
            }
            if (penies > 0)
            {
                changeAmoutString += "Pennies: " + penies.ToString() + " ";
            }

        }

    }
}
