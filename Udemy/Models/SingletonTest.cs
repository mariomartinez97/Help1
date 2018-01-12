using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Udemy.Models
{
    public class SingletonTest
    {
        private static SingletonTest instance;
        private List<Customer> customerList = null;        
        private SingletonTest()
        {
            if(customerList == null)
                customerList = new List<Customer>();
        }

        public static SingletonTest Instance()
        {
            if (instance == null)
            {
                instance = new SingletonTest();
            }

            return instance;
        }

        public void AddE(Customer test)
        {
            customerList.Add(test);
        }

    }
}