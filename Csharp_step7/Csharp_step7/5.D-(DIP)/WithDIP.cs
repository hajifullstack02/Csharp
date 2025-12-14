using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithDIP
{

    //Abstraction     --- Important topic  good logic
    interface IWorker
    {
        void DoWork();
    }

    class Employee : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Employee is doing assigned work...");
        }
    }

    class Intern : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Intern is learning and doing basic tasks...");
        }
    }

    class Contractor : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Contractor is completing project-based work...");
        }
    }

    class Manager
    {
        IWorker iworker; // Now depends on the abstraction.....

        public Manager(IWorker worker)
        {
            this.iworker = worker;
        }
        public void AssignWork()
        {
            Console.WriteLine("Manager assigning work...");
            iworker.DoWork();
        }
    }

    class Program
    {
        static void Main()
        {
            IWorker employee = new Employee();
            Manager manager1 = new Manager(employee);
            manager1.AssignWork();


            IWorker intern = new Intern();
            Manager manager2 = new Manager(intern);
            manager2.AssignWork();

        }
    }

}