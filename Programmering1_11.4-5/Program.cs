using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_11._4_5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Vad kostar varan? ");
            double price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vad ligger momsen på? ");
            double moms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyMoms(price, moms));
            Console.ReadLine();
        }

        //      METHOD TO CALCULATE SALES TAX
        static string MyMoms(double price, double moms) {
            double priceWithMoms = Math.Round(((moms / 100 + 1) * price)); 
                // moms/100+1 makes the precent into decimals. then multiplices with the price to get the result.
            string resultPriceMoms = "Priset med moms blir " + priceWithMoms;
            return resultPriceMoms;
        }
    }
}
