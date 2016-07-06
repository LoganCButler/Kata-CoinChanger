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
            getPennies();
            makeChangeString();
            return changeAmoutString;
        }

        private void makeChangeString()
        {
            if (penies > 0)
            {
                changeAmoutString = "Pennies: " + penies.ToString();
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
