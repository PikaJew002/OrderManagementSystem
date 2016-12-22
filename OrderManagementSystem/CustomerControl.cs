using System;
using System.Windows.Forms;
using System.Collections;

namespace OrderManagementSystem
{
    public partial class CustomerControl : UserControl
    {
        private static CustomerControl _instance;
        public static CustomerControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomerControl();
                return _instance;
            }
        }
        public CustomerControl()
        {
            InitializeComponent();

            //view order history control
            orderHistoryPanel.Controls.Add(ViewOrderControl.Instance);
            ViewOrderControl.Instance.Dock = DockStyle.Fill;
            ViewOrderControl.Instance.Visible = false;
            //view order history listBox
            orderHistoryPanel.Controls.Add(orderHistoryListBox);
            orderHistoryListBox.BringToFront();
        }

        private ArrayList customerList = new ArrayList();

        //populates customerListBox
        public void populateCustomerListBox()
        {
            customerList.Clear();
            customerListBox.Items.Clear();
            customerList = Customer.getCustomerList();
            foreach (Customer nextCustomer in customerList)
            {
                customerListBox.Items.Add(nextCustomer.getLastName() + ", " + nextCustomer.getFirstName() + " :" + nextCustomer.getEmail());
            }
        }

        //populate customer info fields
        public void populateCustomerInfoFields(string email)
        {
            foreach (Customer nextCustomer in customerList)
            {
                if(nextCustomer.getEmail() == email)
                {
                    nameValueLabel.Text = nextCustomer.getFirstName() + " " + nextCustomer.getLastName();
                    emailValueLabel.Text = nextCustomer.getEmail();
                    address1ValueLabel.Text = nextCustomer.getAddress().Replace(",", "\n");
                    if (nextCustomer.getPhone() != "")
                    {
                        phoneValueLabel.Text = formatPhone(nextCustomer.getPhone());
                    }
                    else
                    {
                        phoneValueLabel.Text = "";
                    }
                    break;
                }
            }
        }

        //resets fields
        public void resetFields()
        {
            customerInfoPanel.Visible = false;
            customerInfoLabel.Visible = false;
            orderHistoryListBox.Visible = false;
            ViewOrderControl.Instance.Visible = false;
            orderHistoryLabel.Visible = false;
            viewOrderButton.Visible = false;
            goBackButton.Visible = false;
        }

        //formats a 11 digit phone number
        private string formatPhone(string oldPhone)
        {
            return (oldPhone.Substring(0, 1) + " (" + oldPhone.Substring(1, 3) + ") " + oldPhone.Substring(4, 3) + "-"+ oldPhone.Substring(7));
        }

        private void viewCustomerInfoButton_Click(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex != -1)
            {
                char[] delimChar = { ':' };
                string email = customerListBox.SelectedItem.ToString().Split(delimChar)[1]; //parse email
                populateCustomerInfoFields(email);
                customerInfoPanel.Visible = true;
                customerInfoLabel.Visible = true;
                ViewOrderControl.Instance.Visible = false;
                orderHistoryListBox.Items.Clear();
                orderHistoryListBox.Visible = false;
                viewOrderButton.Visible = false;
                goBackButton.Visible = false;
                ArrayList orderList = Order.getOrderHistory(email);
                if (orderList.Count != 0) {
                    char[] delimStr = { ' ' };
                    foreach (Order nextOrder in orderList)
                    {
                        orderHistoryListBox.Items.Add(nextOrder.getDate().Split(delimStr)[0] + " $" + nextOrder.getPrice() + " :"+nextOrder.getId());
                    }
                    orderHistoryListBox.Visible = true;
                    viewOrderButton.Visible = true;
                }
                orderHistoryLabel.Visible = true;
            }
        }

        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            if (orderHistoryListBox.SelectedIndex != -1)
            {
                char[] delimStr = { ':' };
                Order order = Order.getOrder(orderHistoryListBox.SelectedItem.ToString().Split(delimStr)[1]);
                ViewOrderControl.Instance.populateFields(order.getDate(), order.getPrice(), order.getEmployee().getId(), order.getPaymentType(), order.getAddress(), order.getProductList());
                ViewOrderControl.Instance.BringToFront();
                ViewOrderControl.Instance.Visible = true;
                viewOrderButton.Visible = false;
                goBackButton.Visible = true;
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            ViewOrderControl.Instance.emptyFields();
            ViewOrderControl.Instance.Visible = false;
            orderHistoryListBox.BringToFront();
            orderHistoryListBox.SelectedIndex = -1;
            viewOrderButton.Visible = true;
            goBackButton.Visible = false;
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
