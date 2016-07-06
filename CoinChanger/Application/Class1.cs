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
        string changeAmoutString;
        int cents;

        public string MakeChange(double input)
        {
            
            cents = Convert.ToInt32(input*100);
            getNickles();
            getPennies();      
            makeChangeString();
            return changeAmoutString;
        }

        

        private void makeChangeString()
        {
            if (penies > 0)
            {
                changeAmoutString += "Pennies: " + penies.ToString();
            }
            if (nickles > 0)
            {
                changeAmoutString += "Nickles: " + nickles.ToString();
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
        
    }
}
