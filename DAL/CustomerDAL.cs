using System;
using Persistence;
using MySql.Data.MySqlClient;

namespace DAL {
    public class CustomerDAL
    {
        private string query;
        private MySqlDataReader reader;
        public Customer GetCustomerById(int cusID) {
            query = @"select * from customer where customerID = " + cusID + ";";

            // Mở kết nối đến csdl
            DBHelper.OpenConnection();
            reader = DBHelper.ExecQuery(query);
            Customer customer = null;
            if(reader.Read()) {
                customer = GetCustomerInfo(reader);
            }
            DBHelper.CloseConnection();
            return customer;
        }

        private Customer GetCustomerInfo(MySqlDataReader reader) {
            Customer cus = new Customer();
            cus.CustomerId = reader.GetInt32("customerID");
            cus.Customer_Name = reader.GetString("customer_name");
            cus.Customer_Address = reader.GetString("customer_address");
            cus.Customer_Identity_Card = reader.GetString("identity_card");
            cus.Customer_Number_Phone = reader.GetString("number_phone");
            cus.Customer_Email = reader.GetString("customer_email");
            return cus;
        }
    }
}