using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples_WithoutISP
{
    interface IRestaurant
    {
        void Cook();
        void ManageAccounts();
        void CleanTables();
    }

    class Chef : IRestaurant
    {
        //Bad
        public void CleanTables()
        {
            throw new NotImplementedException();
        }

        //Good
        public void Cook()
        {
            throw new NotImplementedException();
        }


        //Bad
        public void ManageAccounts()
        {
            throw new NotImplementedException();
        }
    }

}