using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithLSP
{
    abstract class Staff
    {
        public abstract void PerformHelpTask();
    }

    class Chef : Staff
    {
        public override void PerformHelpTask()
        {
            Console.WriteLine("Cooking food...");
        }
    }

    class Cleaner : Staff
    {
        public override void PerformHelpTask()
        {
            Console.WriteLine("Cleaning Desk...");
        }
    }

    class Member
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place order...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Staff chef = new Chef();

            Staff cleaner = new Cleaner();
            Member cus = new Member();


            cleaner.PerformHelpTask();
            cus.PlaceOrder();

        }
    }
}