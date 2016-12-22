using System;
using System.Windows.Forms;
using System.Collections;

namespace OrderManagementSystem
{
    public partial class OrdersControl : UserControl
    {
        private static OrdersControl _instance;
        public static OrdersControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OrdersControl();
                return _instance;
            }
        }
        public OrdersControl()
        {
            InitializeComponent();
        }

        private string selectedOrder = "";
        private string selectedEmployee = "";

        //populates active orders listBox
        public void populateActiveOrdersListBox()
        {
            activeOrdersListBox.Items.Clear();
            ArrayList activeOrdersList = Order.getActiveOrderList();
            foreach (Order nextOrder in activeOrdersList)
            {
                activeOrdersListBox.Items.Add("#" +int.Parse(nextOrder.getId()).ToString("D6"));
            }
            activeOrdersListBox.SelectedIndex = -1;
        }

        //populates active orders listBox
        public void populateProductListBox(string orderId)
        {
            orderProductListView.Items.Clear();
            Order newOrder = new Order(orderId);
            ArrayList productList = newOrder.getOrderProductList();
            foreach (Product nextOrder in productList)
            {
                orderProductListView.Items.Add(nextOrder.getId()+ ": " + nextOrder.getProductMulti());
            }
        }

        //clears the product listBox and hides the assign driver button
        public void resetFields()
        {
            orderProductListView.Items.Clear();
            employeeDriversListBox.Items.Clear();
            assignDriverButton.Visible = false;
            selectedEmployee = "";
            selectedOrder = "";
        }

        //populates the employee drivers listBox
        public void populateEmployeeDriversListBox()
        {
            employeeDriversListBox.Items.Clear();
            ArrayList driversList = Employee.getDriversWorkingList();
            foreach (Employee nextEmployee in driversList)
            {
                employeeDriversListBox.Items.Add(nextEmployee.getLastName() + ", " + nextEmployee.getFirstName() + " :"+nextEmployee.getId());
            }
        }

        private void activeOrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(activeOrdersListBox.SelectedIndex != -1)
            {
                selectedOrder = activeOrdersListBox.SelectedItem.ToString().Substring(1);
                populateProductListBox(selectedOrder);
                populateEmployeeDriversListBox();
            }
        }

        private void employeeDriversListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeDriversListBox.SelectedIndex != -1)
            {
                char[] delimStr = { ':' };
                selectedEmployee = employeeDriversListBox.SelectedItem.ToString().Split(delimStr)[1];
                assignDriverButton.Visible = true;
            }
        }

        private void assignDriverButton_Click(object sender, EventArgs e)
        {
            Order order = Order.getOrder(selectedOrder);
            order.setEmployee(Employee.getEmployee(selectedEmployee));
            order.setStatus("Completed");
            order.updateOrderInDatabase();
            //take out appropiate stock item quantity for each item in each product
            foreach (Product nextProduct in order.getProductList())
            {
                nextProduct.getProductMulti(order.getId());
                for (int i = 0; i < nextProduct.getProductMulti(); i++) {
                    foreach (Item nextItem in nextProduct.getItemList())
                    {
                        nextItem.getItemQuantity(nextProduct.getId());
                        nextItem.setStockVolume(nextItem.getStockVolume() - ((nextItem.getStockVolume()/nextItem.getUnitPerVolume())*nextItem.getItemQuantity()));
                        nextItem.updateItemInDatabase();
                    }
                }
            }
            //delete baccard table entry, if paymentType = 2
            if(order.getPaymentType() == 2)
            {
                Card card = order.getCard();
                card.deleteCardFromDatabase();
            }
            resetFields();
            populateActiveOrdersListBox();
        }
    }
}
