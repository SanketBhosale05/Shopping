using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shopping s1= new Shopping();
            s1.AcceptDetails(1, "pen", 20, 10, 11);
          // s1.ShowDetails();
            s1.CalculateBill();
        }
    }
}
