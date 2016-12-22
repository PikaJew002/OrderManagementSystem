using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace OrderManagementSystem
{
    public class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private string position;
        private int isClockedIn;

        //constructor
        public Employee()
        {
            id = "";
            firstName = "";
            lastName = "";
            position = "";
            isClockedIn = 0;
        }

        //get functions
        public string getId()
        {
            return id;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getPosition()
        {
            return position;
        }
        public int getIsClockedIn()
        {
            return isClockedIn;
        }

        //set functions
        public void setId(string newId)
        {
            id = newId;
        }
        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }
        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }
        public void setPosition(string newPosition)
        {
            position = newPosition;
        }
        public void setIsClockedIn(int newIsClockedIn)
        {
            isClockedIn = newIsClockedIn;
        }

        //returns list of all employees
        public static ArrayList getEmployeeList()
        {
            ArrayList employeeList = new ArrayList();
            DataTable employeeTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacemployee";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(employeeTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in employeeTable.Rows)
            {
                Employee newEmployee = new Employee();
                newEmployee.id = row["id"].ToString();
                newEmployee.firstName = row["first_name"].ToString();
                newEmployee.lastName = row["last_name"].ToString();
                newEmployee.position = row["position"].ToString();
                newEmployee.isClockedIn = int.Parse(row["is_clocked_in"].ToString());
                employeeList.Add(newEmployee);
            }
            return employeeList;
        }

        //returns the employee with the specified employee id
        public static Employee getEmployee(string employeeId)
        {
            Employee employee = new Employee();
            DataTable employeeTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacemployee WHERE id=\"" + employeeId + "\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(employeeTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            if (employeeTable.Rows.Count != 0)
            {
                foreach (DataRow row in employeeTable.Rows)
                {
                    employee.id = row["id"].ToString();
                    employee.firstName = row["first_name"].ToString();
                    employee.lastName = row["last_name"].ToString();
                    employee.position = row["position"].ToString();
                    employee.isClockedIn = int.Parse(row["is_clocked_in"].ToString());
                }
            }
            return employee;
        }

        //validates user inputed Employee data
        public static bool validateInput(string newFirstName, string newLastName, string newPosition)
        {
            //checks for empty fields
            if(newFirstName != "" && newLastName != "" && newPosition != "")
            {
                //input is valid: procede with database query
                return true;
            }
            else //if any fields are empty
            {
                MessageBox.Show("Some of the fields are not filled. Please make sure all fields are filled.");
            }
            //any of the conditions fail, return false
            return false;
        }

        //returns list of drivers clocked in (working at the moment)
        public static ArrayList getDriversWorkingList()
        {
            ArrayList employeeList = new ArrayList();
            DataTable employeeTable = new DataTable();
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT * FROM bacemployee WHERE position=\"Driver\" AND is_clocked_in=\"1\""; //query
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(employeeTable);
                Console.WriteLine("Table is ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            foreach (DataRow row in employeeTable.Rows)
            {
                Employee newEmployee = new Employee();
                newEmployee.id = row["id"].ToString();
                newEmployee.firstName = row["first_name"].ToString();
                newEmployee.lastName = row["last_name"].ToString();
                newEmployee.position = row["position"].ToString();
                newEmployee.isClockedIn = int.Parse(row["is_clocked_in"].ToString());
                employeeList.Add(newEmployee);
            }
            return employeeList;
        }

        //

        //updates employee in database
        public void updateEmployeeInDatabase()
        {
            string connStr = "server=csshrpt.eku.edu;user=csc834;database=csc834;port=3306;password=CSC834student;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE bacemployee SET first_name=\"" + firstName + "\", last_name=\"" + lastName + "\", position=\"" + position + "\", is_clocked_in=\"" + isClockedIn + "\" WHERE id=\"" + id + "\"";
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
