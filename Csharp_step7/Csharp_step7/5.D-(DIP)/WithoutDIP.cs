using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithoutDIP
{

    //Lower level
    class Employee
    {
        public void DoWork()
        {
            Console.WriteLine("Employee is doing assigned work...");
        }
    }

    class Intern
    {
        public void DoWork()
        {
            Console.WriteLine("Intern is doing assigned work...");
        }
    }

    class Contractor
    {
        public void DoWork()
        {
            Console.WriteLine("Contractor is doing assigned work...");
        }
    }

    class Tester
    {
        public void DoWork()
        {
            Console.WriteLine("Contractor is doing assigned work...");
        }
    }



    //Lets break the chanin


    //Higher level
    class Manager
    {

        // depneds on the abstractions   

        //YUOu are taking the lowwer level classes over here.... thats problrm.
        private Employee perminentemployee = new Employee();
        private Intern Internemployee = new Intern();
        private Contractor contractnemployee = new Contractor();


        public void AssignWork()
        {
            Console.WriteLine("Manager assigning work...");
            perminentemployee.DoWork();
            contractnemployee.DoWork();
            Internemployee.DoWork();
        }

    }



    class Program
    {
        static void Main()
        {
            Manager manager = new Manager();
            manager.AssignWork();
        }
    }


}