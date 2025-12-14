using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiryaniZone_withoutSRP
{
    class RestaurantService
    {
        // This method is responsible for calling all the methods that perform the tasks.
        public void HandleRestaurantTasks()
        {
            CookMeals();
            ManageAccounting();
            CleanTables();
            TakeOrders();
            ServeFood();
        }

        // Here CookMeals method for cooking meals
        private void CookMeals()
        {
            Console.WriteLine("Cooking meals...");
        }


        // Here ManageAccounting method for managing accounting
        private void ManageAccounting()
        {
            Console.WriteLine("Handling accounting...");
        }

        // Here CleanTables method for cleaning tables
        private void CleanTables()
        {
            Console.WriteLine("Cleaning tables...");
        }


        // Here TakeOrders method for taking orders
        private void TakeOrders()
        {
            Console.WriteLine("Taking customer orders...");
        }


        // Here ServeFood method for serving food
        private void ServeFood()
        {
            Console.WriteLine("Serving food...");
        }



    }

    public class Program
    {
        static void Main()
        {
            RestaurantService service = new RestaurantService();
            service.HandleRestaurantTasks();
        }
    }
}