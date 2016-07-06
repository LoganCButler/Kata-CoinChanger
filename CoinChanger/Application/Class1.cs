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
        public string changeAmoutString;
        int cents;

        public string ChangeCheck(double input)
        {
            if (input < 0.01) { return "No Change"; }
            else {return MakeChange(input); }
        }

        public string MakeChange(double input)
        {
            
            cents = Convert.ToInt32(input*100);
            GetQuarters();
            getDimes();
            getNickles();
            getPennies();      
            makeChangeString();
            return changeAmoutString;
        }

        private void GetQuarters()
        {
            for (var x = cents; x > 24; x -= 25)
            {
                quarters += 1;
                cents -= 25;
            }
        }

        private void getDimes()
        {
            for (var x = cents; x > 9; x -= 10)
            {
                dimes += 1;
                cents -= 10;
            }
        }

        
        private void getNickles()
        {
            for (var x = cents; x > 4; x -= 5)
            {
                nickles += 1;
                cents -= 5;
            }
        }

        private void getPennies()
        {
            for(var x = cents; x > 0; x--)
            {
                penies += 1;
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
