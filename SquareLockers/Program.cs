using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLockers
{
    class Program
    {
        static void Main(string[] args)
        {
            // code not finished
            ///<Summary>
            ///N doors are closed. In the first pass, I open all of them. 
            ///In the second pass, I toggle every second door. 
            ///In the third pass, I toggle every third door. 
            ///I continue this until I have completed the Nth pass. 
            ///Find all the doors that will remain open after N passes.
            ///<Summary>

            var input = 100;
            Console.WriteLine("Lockers ");
            for (var i = 1; i<input;i++)
            {
                if (i > 1) 
                {
                    Console.Write(", " + (i*i).ToString()); 
                }
                else if (i = Math.Sqrt(j)) { Console.WriteLine(""); }
                else { Console.Write(i.ToString()); }
            }

        }
    }
}
