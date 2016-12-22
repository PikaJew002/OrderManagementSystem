using System;
using System.Windows.Forms;

namespace OrderManagementSystem
{
    public partial class ButtonsControl : UserControl
    {
        private static ButtonsControl _instance;
        public static ButtonsControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ButtonsControl();
                return _instance;
            }
        }
        public ButtonsControl()
        {
            InitializeComponent();
        }

        private void hideAllUserControl()
        {
            OrdersControl.Instance.Visible = false;
            CustomerControl.Instance.Visible = false;
            EmployeeControl.Instance.Visible = false;
            BusinessControl.Instance.Visible = false;
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrdersControl.Instance.resetFields();
            OrdersControl.Instance.populateActiveOrdersListBox();
            hideAllUserControl();
            OrdersControl.Instance.BringToFront();
            OrdersControl.Instance.Visible = true;
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            CustomerControl.Instance.populateCustomerListBox();
            CustomerControl.Instance.resetFields();
            hideAllUserControl();
            CustomerControl.Instance.BringToFront();
            CustomerControl.Instance.Visible = true;
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeControl.Instance.populateEmployeeListBox();
            EmployeeControl.Instance.resetFields();
            hideAllUserControl();
            EmployeeControl.Instance.BringToFront();
            EmployeeControl.Instance.Visible = true;
        }

        private void businessButton_Click(object sender, EventArgs e)
        {
            BusinessControl.Instance.populateDateComboBoxes();
            hideAllUserControl();
            BusinessControl.Instance.BringToFront();
            BusinessControl.Instance.Visible = true;
        }
    }
}
