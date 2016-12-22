using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;

namespace OrderManagementSystem
{
    class Product
    {
        /*
         * Product class represents a product provided by the store which Customers may Order.
         * Associated with a list of stock Items that are used in the making of the product.
         * Identified by the id attribute.
        */

        private string id; //unique id, primary use in database
        private int productMulti = 1; //used when referenced by an order
        private ArrayList itemList;
        private double price;
        private string description;

        Product()
        {

        }

        //get attribute functions
        public string getId()
        {
            return id;
        }
        public int getProductMulti()
        {
            return productMulti;
        }
        public ArrayList getItemList()
        {
            return itemList;
        }
        public double getPrice()
        {
            return price;
        }
        public string getDescription()
        {
            return description;
        }

        //set attribute functions, returns void
        public void setId(string newId)
        {
            id = newId;
        }
        public void setProductMulti(int newProductMulti)
        {
            productMulti = newProductMulti;
        }
        public void setItemList(ArrayList newItemList)
        {
            itemList = newItemList;
        }
        public void setPrice(double newPrice)
        {
            price = newPrice;
        }
        public void setDescription(string newDescription)
        {
            description = newDescription;
        }

        //returns the product with the specified product id
        public static Product getProduct(string productId)
        {
            Product product = new Product();
            DataTable productTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacproduct WHERE id=\"" + productId + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(productTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in productTable.Rows)
            {
                product.id = row["id"].ToString();
                product.itemList = getProductItemList(product.id); 
                product.price = double.Parse(row["price"].ToString());
                product.description = row["description"].ToString();
            }
            return product;
        }

        //
        public void getProductMulti(string orderId)
        {
            int newProductMulti = 1;
            DataTable orderProductTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacorderproduct WHERE product_id=\"" + id + "\" AND order_id=\"" + orderId + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(orderProductTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in orderProductTable.Rows)
            {
                newProductMulti = int.Parse(row["product_multi"].ToString());
            }
            setProductMulti(newProductMulti);
        }

        //returns a list of the products items
        public static ArrayList getProductItemList(string productId)
        {
            ArrayList itemList = new ArrayList();
            DataTable productItemTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacproductitem WHERE product_id=\"" + productId + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(productItemTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (productItemTable.Rows.Count != 0)
            {
                foreach (DataRow row in productItemTable.Rows)
                {
                    Item item = Item.getItem(row["item_id"].ToString());
                    item.getItemQuantity(productId);
                    itemList.Add(item);
                }
            }
            return itemList;
        }
    }
}