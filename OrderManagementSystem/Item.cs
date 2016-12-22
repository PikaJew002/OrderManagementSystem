using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace OrderManagementSystem
{
    class Item
    {
        private string itemName;
        private double itemQuantity = 0; //used when referenced by a product in an order
        private string description;
        private double stockVolume;
        private string stockVolumeUnits;
        private double unitPerVolume;
        private string unitPerVolumeUnits;
        private double minVolume;

        Item()
        {

        }

        //get functions
        public string getItemName()
        {
            return itemName;
        }
        public double getItemQuantity()
        {
            return itemQuantity;
        }
        public string getDescription()
        {
            return description;
        }
        public double getStockVolume()
        {
            return stockVolume;
        }
        public string getStockVolumeUnits()
        {
            return stockVolumeUnits;
        }
        public double getUnitPerVolume()
        {
            return unitPerVolume;
        }
        public string getUnitPerVolumeUnits()
        {
            return unitPerVolumeUnits;
        }
        public double getMinVolume()
        {
            return minVolume;
        }

        //set functions, return void
        public void setItemName(string newItemName)
        {
            itemName = newItemName;
        }
        public void setItemQuantity(double newItemQuantity)
        {
            itemQuantity = newItemQuantity;
        }
        public void setDescription(string newDescription)
        {
            description = newDescription;
        }
        public void setStockVolume(double newStockVolume)
        {
            stockVolume = newStockVolume;
        }
        public void setStockVolumeUnits(string newStockVolumeUnits)
        {
            stockVolumeUnits = newStockVolumeUnits;
        }
        public void setUnitPerVolume(double newUnitPerVolume)
        {
            unitPerVolume = newUnitPerVolume;
        }
        public void setUnitPerVolumeUnits(string newUnitPerVolumeUnits)
        {
            unitPerVolumeUnits = newUnitPerVolumeUnits;
        }
        public void setMinVolume(double newMinVolume)
        {
            minVolume = newMinVolume;
        }

        //returns item specified by item name
        public static Item getItem(string newItemName)
        {
            Item item = new Item();
            DataTable itemTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM eisenbergitem WHERE item_name=\"" + newItemName + "\"";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(itemTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (itemTable.Rows.Count != 0) {
                foreach (DataRow row in itemTable.Rows)
                {
                    item.itemName = row["item_name"].ToString();
                    item.description = row["description"].ToString();
                    item.stockVolume = double.Parse(row["stock_volume"].ToString());
                    item.stockVolumeUnits = row["stock_volume_units"].ToString();
                    item.unitPerVolume = double.Parse(row["unit_per_volume"].ToString());
                    item.unitPerVolumeUnits = row["unit_per_volume_units"].ToString();
                    item.minVolume = double.Parse(row["min_volume"].ToString());
                    
                }
            }
            return item;
        }

        public void getItemQuantity(string productId)
        {
            double newItemQuantity = 1.0;
            DataTable productItemTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacproductitem WHERE item_id=\"" + itemName + "\" AND product_id=\"" + productId + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(productItemTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in productItemTable.Rows)
            {
                newItemQuantity = double.Parse(row["item_quantity"].ToString());
            }
            setItemQuantity(newItemQuantity);
        }

        //update item in database
        public void updateItemInDatabase()
        {
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE eisenbergitem SET stock_volume=\"" + stockVolume + "\" WHERE item_name=\"" + itemName + "\"";
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
