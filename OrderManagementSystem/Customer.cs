using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;

namespace OrderManagementSystem
{
    class Customer
    {
        /*
         * Customer class represents a customer with a profile saved. Can be associated with an Order.
         * Identified by the email attribute.
        */

        private string email;
        private string firstName;
        private string lastName;
        private ArrayList orderHistory;
        private string address;
        private string phone;
        private Card card;

        Customer()
        {

        }
        
        //get functions
        public string getEmail()
        {
            return email;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public ArrayList getOrderHistory()
        {
            return orderHistory;
        }
        public string getAddress()
        {
            return address;
        }
        public string getPhone()
        {
            return phone;
        }
        public Card getCard()
        {
            return card;
        }

        //returns the customer specificed by the email provided
        public static Customer getCustomer(string email)
        {
            Customer customer = new Customer();
            DataTable customerTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM baccustomer WHERE email=\"" + email + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(customerTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (customerTable.Rows.Count != 0)
            {
                foreach (DataRow row in customerTable.Rows)
                {
                    customer.email = row["email"].ToString();
                    customer.firstName = row["first_name"].ToString();
                    customer.lastName = row["last_name"].ToString();
                    customer.orderHistory = Order.getOrderHistory(customer.email);
                    customer.address = row["address"].ToString();
                    customer.card = Card.getCard(row["card"].ToString());
                }
            }
            return customer;
        }

        //returns a list of all customers
        public static ArrayList getCustomerList()
        {
            ArrayList customerList = new ArrayList();
            DataTable customerTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM baccustomer ORDER BY email"; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(customerTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in customerTable.Rows)
            {
                Customer newCustomer = new Customer();
                newCustomer.email = row["email"].ToString();
                newCustomer.firstName = row["first_name"].ToString();
                newCustomer.lastName = row["last_name"].ToString();
                newCustomer.orderHistory = Order.getOrderHistory(newCustomer.email);
                newCustomer.address = row["address"].ToString();
                newCustomer.phone = row["phone"].ToString();
                newCustomer.card = Card.getCard(row["credit_card"].ToString());
                customerList.Add(newCustomer);
            }
            return customerList;
        }
    }
}
