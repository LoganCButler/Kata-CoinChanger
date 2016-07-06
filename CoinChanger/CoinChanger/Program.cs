using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace CoinChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.CoinChanger c = new Application.CoinChanger();
            Console.WriteLine("Please enter a monetary amount between $0.99 and $0.01");
            var hold = Convert.ToDouble(Console.ReadLine());
            c.ChangeCheck(hold);
            Console.WriteLine("The change is..." + c.changeAmoutString);
            Console.ReadLine();

        }
    }
}
