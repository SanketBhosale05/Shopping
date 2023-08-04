using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Shopping
    {
        int Pid;
        string pname;
        int pPrice;
        int qty;
        int bill;

        public void AcceptDetails(int Pid,string  pname , int pPrice , int qty, int bill)
        {
            this.Pid = Pid;
            this.pname = pname;
            this.pPrice = pPrice;
                
            this.qty = qty;
            this.bill = bill;

        }
        public void CalculateBill()
        {
            if (this.bill > 0)
            {
                bill = qty* pPrice;
                ShowDetails();
            }
            else
            {
                Console.WriteLine("qty must more than zero");
            }
        }
        public void ShowDetails()
        {
            Console.WriteLine(Pid);
            Console.WriteLine(pname);

            Console.WriteLine(qty);
            Console.WriteLine(bill);
            Console.WriteLine();
            

        }
    }
}
