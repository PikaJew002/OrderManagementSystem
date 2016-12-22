using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;

namespace OrderManagementSystem
{
    class Order
    {
        /*
         * Order class represents an order made by a Customer. 
         * Associated with Products as well as the Employee assigned to deliever the order 
         * in addition to the customer who placed the order and the Card used to play (if a Card was used).
         * Identified by the id attribute.
        */

        private string id; //identifier primarily for database
        private string customerEmail;
        private ArrayList productList;
        private double price;
        private Employee employee;
        private int paymentType;
        private string address;
        private string status;
        private string date;
        private Card card;

        Order()
        {

        }

        public Order(string newId)
        {
            setId(newId);
        }

        //get functions, returns attributes
        public string getId()
        {
            return id;
        }
        public string getCustomerEmail()
        {
            return customerEmail;
        }
        public ArrayList getProductList()
        {
            return productList;
        }
        public double getPrice()
        {
            return price;
        }
        public Employee getEmployee()
        {
            return employee;
        }
        public int getPaymentType()
        {
            return paymentType;
        }
        public string getAddress()
        {
            return address;
        }
        public string getStatus()
        {
            return status;
        }
        public string getDate()
        {
            return date;
        }
        public Card getCard()
        {
            return card;
        }

        //set functions, returns void
        public void setId(string newId)
        {
            id = newId;
        }
        public void setCustomerEmail(string newCustomerEmail)
        {
            customerEmail = newCustomerEmail;
        }
        public void setProductList(ArrayList newProductList)
        {
            productList = newProductList;
        }
        public void setPrice(double newPrice)
        {
            price = newPrice;
        }
        public void setEmployee(Employee newEmployee)
        {
            employee = newEmployee;
        }
        public void setPaymentType(int newPaymentType)
        {
            paymentType = newPaymentType;
        }
        public void setAddress(string newAddress)
        {
            address = newAddress;
        }
        public void setStatus(string newStatus)
        {
            status = newStatus;
        }
        public void setDate(string newDate)
        {
            date = newDate;
        }
        public void setCard(Card newCard)
        {
            card = newCard;
        }

        //returns a list of orders that are active (status == "Being Cooked")
        public static ArrayList getActiveOrderList()
        {
            ArrayList orderList = new ArrayList();
            DataTable orderTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacorder WHERE status=\"Being Cooked\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(orderTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach(DataRow row in orderTable.Rows)
            {
                Order newOrder = new Order();
                newOrder.id = row["id"].ToString();
                newOrder.customerEmail = row["customer_email"].ToString();
                newOrder.productList = newOrder.getOrderProductList();//gets list of products in order
                newOrder.price = double.Parse(row["price"].ToString());
                newOrder.employee = Employee.getEmployee(row["employee"].ToString());
                newOrder.paymentType = int.Parse(row["payment_type"].ToString());
                newOrder.address = row["address"].ToString();
                newOrder.status = row["status"].ToString();
                newOrder.card = Card.getCard(row["card_id"].ToString());
                newOrder.date = row["date"].ToString();
                orderList.Add(newOrder);
            }
            return orderList;
        }

        //returns a list of products associated with provided order id
        public ArrayList getOrderProductList()
        {
            ArrayList productList = new ArrayList();
            DataTable orderProductTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT product_id FROM bacorderproduct WHERE order_id=\"" + id + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(orderProductTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in orderProductTable.Rows)
            {
                Product newProduct = Product.getProduct(row["product_id"].ToString());
                newProduct.getProductMulti(id);
                productList.Add(newProduct);
            }
            return productList;
        }

        //returns a list of orders associated with provided customer email
        public static ArrayList getOrderHistory(string email)
        {
            ArrayList orderList = new ArrayList();
            DataTable orderTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacorder WHERE customer_email=\"" + email + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(orderTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (orderTable.Rows.Count != 0) {
                foreach (DataRow row in orderTable.Rows)
                {
                    Order newOrder = getOrder(row["id"].ToString());
                    orderList.Add(newOrder);
                }
            }
            return orderList;
        }

        //returns a list of orders by year and month
        public static ArrayList getOrders(int year, int month, int day)
        {
            ArrayList orderList = new ArrayList();
            DataTable orderTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "";
                if (day == 0)
                    sql = "SELECT * FROM bacorder WHERE date >=\"" + year + "-" + month + "-1 00:00:00\" and date <\"" + year + "-" + (month + 1) + "-1 00:00:00\"";
                else
                    sql = "SELECT * FROM bacorder WHERE date >=\"" + year + "-" + month + "-" + day + " 00:00:00\" and date <\"" + year + "-" + month + "-" + (day+1) + " 00:00:00\"";
                Console.WriteLine("query: "+sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(orderTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in orderTable.Rows)
            {
                Order newOrder = new Order();
                newOrder.id = row["id"].ToString();
                newOrder.customerEmail = row["customer_email"].ToString();
                newOrder.productList = newOrder.getOrderProductList();//gets list of products in order
                newOrder.price = double.Parse(row["price"].ToString());
                Console.WriteLine(row["employee"].ToString());
                newOrder.employee = Employee.getEmployee(row["employee"].ToString());
                newOrder.paymentType = int.Parse(row["payment_type"].ToString());
                newOrder.address = row["address"].ToString();
                newOrder.status = row["status"].ToString();
                newOrder.card = Card.getCard(row["card_id"].ToString());
                newOrder.date = row["date"].ToString();
                orderList.Add(newOrder);
            }
            return orderList;
        }

        //returns a list of orders by year, month, and day
        public static ArrayList getOrders(int year, int month)
        {
            return getOrders(year, month, 0);
        }

        //returns the order with the specified order id
        public static Order getOrder(string orderId)
        {
            Order order = new Order();
            DataTable orderTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacorder WHERE id=\"" + orderId + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(orderTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (orderTable.Rows.Count != 0) {
                foreach (DataRow row in orderTable.Rows)
                {
                    order.id = row["id"].ToString();
                    order.customerEmail = row["customer_email"].ToString();
                    order.productList = order.getOrderProductList();//gets list of products in order
                    order.price = double.Parse(row["price"].ToString());
                    order.employee = Employee.getEmployee(row["employee"].ToString());
                    order.paymentType = int.Parse(row["payment_type"].ToString());
                    order.address = row["address"].ToString();
                    order.status = row["status"].ToString();
                    order.card = Card.getCard(row["card_id"].ToString());
                    order.date = row["date"].ToString();
                }
            }
            return order;
        }

        //updates order in database
        public void updateOrderInDatabase()
        {
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE bacorder SET price=\"" + price + "\", employee=\"" + employee.getId() + "\", payment_type=\"" + paymentType + "\", address=\"" + address + "\", status=\"" + status + "\" WHERE id=\"" + id + "\"";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}