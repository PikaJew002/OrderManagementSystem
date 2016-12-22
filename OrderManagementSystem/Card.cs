using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace OrderManagementSystem
{
    class Card
    {
        private string id;
        private string number;
        private string name;
        private string expDate;
        private string securityCode;
        private string billingAddress;
        private string merchant;
        private int type;

        Card()
        {

        }

        //get functions
        public string getId()
        {
            return id;
        }
        public string getNumber()
        {
            return number;
        }
        public string getName()
        {
            return name;
        }
        public string getExpDate()
        {
            return expDate;
        }
        public string getSecurityCode()
        {
            return securityCode;
        }
        public string getBillingAddress()
        {
            return billingAddress;
        }
        public string getType()
        {
            return merchant;
        }

        //set functions, return void
        public void setId(string newId)
        {
            id = newId;
        }
        public void setNumber(string newNumber)
        {
            number = newNumber;
        }
        public void setName(string newName)
        {
            name = newName;
        }
        public void setExpDate(string newExpDate)
        {
            expDate = newExpDate;
        }
        public void setSecurityCode(string newSecurityCode)
        {
            securityCode = newSecurityCode;
        }
        public void setBillingAddress(string newBillingAddress)
        {
            billingAddress = newBillingAddress;
        }
        public void setType(string newType)
        {
            merchant = newType;
        }

        //get card from database specific to card id provided
        public static Card getCard(string cardId)
        {
            Card card = new Card();
            DataTable cardTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM baccard WHERE id=\"" + cardId + "\"";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(cardTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in cardTable.Rows)
            {
                card.id = row["id"].ToString();
                card.number = row["number"].ToString();
                card.name = row["name"].ToString();
                card.expDate = row["exp_date"].ToString();
                card.securityCode = row["security_code"].ToString();
                card.billingAddress = row["billing_address"].ToString();
                card.merchant = row["merchant"].ToString();
            }
            return card;
        }

        //delete card in database
        public void deleteCardFromDatabase()
        {
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "DELETE FROM baccard WHERE id=\"" + id + "\"";
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
