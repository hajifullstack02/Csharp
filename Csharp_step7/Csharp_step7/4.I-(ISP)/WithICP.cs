using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithISP
{
    interface ICook
    {
        void Cook();
    }

    interface IAccountant
    {
        void ManageAccounts();
    }

    interface ICleaner
    {
        void CleanTables();
    }


    class Chef : ICook
    {
        public void Cook()
        {
            Console.WriteLine("Preparing Food");
            //throw new NotImplementedException();
        }
    }

    class Cleaner : ICleaner
    {
        public void CleanTables()
        {
            Console.WriteLine("Cleaning tables...");
        }
    }

    class Accountant : IAccountant
    {
        public void ManageAccounts()
        {
            Console.WriteLine("Managing restaurant finances...");
        }
    }


    class Program
    {
        static void Main()
        {
            ICook chef = new Chef();
            chef.Cook();

            ICleaner cleaner = new Cleaner();
            cleaner.CleanTables();

            IAccountant accountant = new Accountant();
            accountant.ManageAccounts();
        }
    }

}