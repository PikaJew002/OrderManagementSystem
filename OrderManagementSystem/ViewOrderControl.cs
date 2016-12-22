using System.Windows.Forms;
using System.Collections;

namespace OrderManagementSystem
{
    public partial class ViewOrderControl : UserControl
    {
        private static ViewOrderControl _instance;
        public static ViewOrderControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewOrderControl();
                return _instance;
            }
        }
        public ViewOrderControl()
        {
            InitializeComponent();
        }

        //populate fields
        public void populateFields(string newDate, double newPrice, string newDriver, int newPayment, string newAddress, ArrayList productList)
        {
            dateValueLabel.Text = newDate;
            priceValueLabel.Text = "$" + newPrice;
            driverValueLabel.Text = newDriver;
            if (newPayment == 0)
            {
                paymentValueLabel.Text = "Cash";
            }
            else if (newPayment == 1)
            {
                paymentValueLabel.Text = "Credit Card (Saved)";
            }
            else if(newPayment == 2)
            {
                paymentValueLabel.Text = "Credit Card (Not Saved)";
            }
            addressValueLabel.Text = newAddress.Replace(",", "\n");
            foreach (Product nextProduct in productList)
            {
                orderHistoryListBox.Items.Add(nextProduct.getProductMulti() + " " + nextProduct.getId());
            }
        }

        //emptys all fields
        public void emptyFields()
        {
            dateValueLabel.Text = "";
            priceValueLabel.Text = "";
            driverValueLabel.Text = "";
            paymentValueLabel.Text = "";
            addressValueLabel.Text = "";
            orderHistoryListBox.Items.Clear();
        }
    }
}
