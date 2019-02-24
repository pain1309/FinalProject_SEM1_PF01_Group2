using System;
using DAL;
using Persistence;

namespace BL
{
    public class CustomerBL
    {
        private CustomerDAL customerDAL;
        public CustomerBL() {
            customerDAL = new CustomerDAL();
        }
        public Customer GetCustomerById(int cusID) {
            return customerDAL.GetCustomerById(cusID);
        }
    }
}
