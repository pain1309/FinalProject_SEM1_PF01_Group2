using System;
using BL;
using Persistence;

namespace PL_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int cusId;
            Console.Clear();
            Console.Write("Please enter an employee's id: ");
            cusId = Convert.ToInt32(Console.ReadLine());

            CustomerBL customerBl = new CustomerBL();

            Customer customer = customerBl.GetCustomerById(cusId);
            if(customer != null) {
                Console.WriteLine("Customer ID: " + customer.CustomerId);
                Console.WriteLine("Customer Name: " + customer.Customer_Name);
                Console.WriteLine("Customer Address: " + customer.Customer_Address);
                Console.WriteLine("Customer Identity Card: " + customer.Customer_Identity_Card);
                Console.WriteLine("Customer Email: " + customer.Customer_Email);
                Console.WriteLine("Customer Number Phone: " + customer.Customer_Number_Phone);
            }
        }
    }
}
