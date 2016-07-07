using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CoinChanger
    {
        
        int cents;
        double pennieValue = 0.01;
        public string changeAmoutString;
        int [] changeArry = {0,0,0,0};
        int[] coinUnitValue = {25, 10, 5, 1};

        public string ChangeCheck(double input)
        {
            if (input < pennieValue) { return changeAmoutString = "No Change"; }
            else {return MakeChange(input); }
        }

        public string MakeChange(double input)
        {
            cents = Convert.ToInt32(input*100);

            for (var i = 0; i < changeArry.Length; i++)
            {
                CountCoins(ref changeArry[i], coinUnitValue[i]);
            }   
              
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
            if (changeArry[0] > 0)
            {
                changeAmoutString += "Quarters: " + changeArry[0].ToString() + "\n";
            }
            if (changeArry[1] > 0)
            {
                changeAmoutString += "Dimes: " + changeArry[1].ToString() + "\n";
            }
            if (changeArry[2] > 0)
            {
                changeAmoutString += "Nickles: " + changeArry[2].ToString() + "\n";
            }
            if (changeArry[3] > 0)
            {
                changeAmoutString += "Pennies: " + changeArry[3].ToString() + "\n";
            }

        }

    }
}
