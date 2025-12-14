using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithoutLSP
{
    class Staff
    {
        public virtual void PerformHelpTask()
        {
            Console.WriteLine("Performing a task...");
        }
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

    class Member : Staff
    {
        public override void PerformHelpTask()
        {
            throw new Exception("Customers or Members cannot clean or cook or any work of the Hotel");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Staff chef = new Chef();

            Staff cleaner = new Cleaner();
            Staff member = new Member();


            cleaner.PerformHelpTask();
            member.PerformHelpTask();

        }

    }

    abstract class Bird
    {
        public abstract void Fly();
        //{
        //    Console.WriteLine("it can fly");
        //}
    }


    class Peacock : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("it can fly");
        }
    }


    class Chicken
    {

    }

}