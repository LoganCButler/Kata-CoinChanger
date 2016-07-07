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
        bool hasQuarters;
        bool hasDimes;
        bool hasNickles;
        bool hasPennies;

        public string ChangeCheck(double input)
        {
            if (input < pennieValue)
            {
                return changeAmoutString = "No Change";
            }
            else
            {
                return MakeChange(input);
            }
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

                switch (coinUnit)
                {
                    case 25:
                        hasQuarters = true;
                        break;
                    case 10:
                        hasDimes = true;
                        break;
                    case 5:
                        hasNickles = true;
                        break;
                    case 1:
                        hasPennies = true;
                        break;
                }
            }
        }


        private void makeChangeString()
        {
            if (hasQuarters)
            {
                changeAmoutString += "Quarters: " + changeArry[0].ToString() + "\n";
            }
            if (hasDimes)
            {
                changeAmoutString += "Dimes: " + changeArry[1].ToString() + "\n";
            }
            if (hasNickles)
            {
                changeAmoutString += "Nickles: " + changeArry[2].ToString() + "\n";
            }
            if (hasPennies)
            {
                changeAmoutString += "Pennies: " + changeArry[3].ToString() + "\n";
            }

        }

    }
}
