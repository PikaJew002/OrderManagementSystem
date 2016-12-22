using System.Windows.Forms;

namespace OrderManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //buttons controls
            buttonsPanel.Controls.Add(ButtonsControl.Instance);
            ButtonsControl.Instance.Dock = DockStyle.Fill;

            //orders controls
            contentPanel.Controls.Add(OrdersControl.Instance);
            OrdersControl.Instance.Dock = DockStyle.Fill;
            OrdersControl.Instance.Visible = false;

            //customer controls
            contentPanel.Controls.Add(CustomerControl.Instance);
            CustomerControl.Instance.Dock = DockStyle.Fill;
            CustomerControl.Instance.Visible = false;

            //business controls
            contentPanel.Controls.Add(BusinessControl.Instance);
            BusinessControl.Instance.Dock = DockStyle.Fill;
            BusinessControl.Instance.Visible = false;

            //employee controls
            contentPanel.Controls.Add(EmployeeControl.Instance);
            EmployeeControl.Instance.Dock = DockStyle.Fill;
            EmployeeControl.Instance.Visible = false;
        }
    }
}