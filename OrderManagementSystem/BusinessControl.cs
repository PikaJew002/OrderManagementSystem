using System;
using System.Windows.Forms;
using System.Collections;

namespace OrderManagementSystem
{
    public partial class BusinessControl : UserControl
    {
        private static BusinessControl _instance;
        public static BusinessControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BusinessControl();
                return _instance;
            }
        }
        public BusinessControl()
        {
            InitializeComponent();
        }

        //populates date comboboxes
        public void populateDateComboBoxes()
        {
            DateTime now = DateTime.Now;
            //year comboBox
            yearComboBox.Items.Clear();
            yearComboBox.Items.Add("Year");
            int year = now.Year;
            for (int i = year-10; i <= year; i++)
            {
                yearComboBox.Items.Add(i);
            }
            yearComboBox.SelectedIndex = 0;
            //month comboBox
            monthComboBox.Items.Clear();
            monthComboBox.Items.Add("Month");
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
            }
            //day comboBox
            dayComboBox.Items.Clear();
            dayComboBox.Items.Add("Day");
        }

        private void getBusinessVolume_Click(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedIndex != 0 && monthComboBox.SelectedIndex != 0 && monthComboBox.SelectedIndex != -1)
            {
                double businessVolume = 0;
                char[] delimStr = { ' ' };
                ordersListBox.Items.Clear();
                ArrayList orderList;
                if (dayComboBox.SelectedIndex != 0 && dayComboBox.SelectedIndex != -1)
                    orderList = Order.getOrders(int.Parse(yearComboBox.SelectedItem.ToString()), int.Parse(monthComboBox.SelectedItem.ToString()), int.Parse(dayComboBox.SelectedItem.ToString()));
                else
                    orderList = Order.getOrders(int.Parse(yearComboBox.SelectedItem.ToString()), int.Parse(monthComboBox.SelectedItem.ToString()));
                
                foreach (Order nextOrder in orderList)
                {
                    businessVolume += nextOrder.getPrice();
                    ordersListBox.Items.Add(nextOrder.getDate().Split(delimStr)[0] + " : $" + nextOrder.getPrice());
                }
                businessVolumeValueLabel.Text = "$" + businessVolume;
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(yearComboBox.SelectedItem.ToString() != "Year")
            {
                monthComboBox.Enabled = true;
                monthComboBox.SelectedIndex = 0;
            }
            else
            {
                monthComboBox.Enabled = false;
                monthComboBox.SelectedIndex = -1;
                dayComboBox.Enabled = false;
                dayComboBox.SelectedIndex = -1;
            }
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex != -1)
            {
                if (monthComboBox.SelectedItem.ToString() != "Month")
                {
                    int endDay = DateTime.DaysInMonth(int.Parse(yearComboBox.SelectedItem.ToString()), int.Parse(monthComboBox.SelectedItem.ToString()));
                    for (int i = 1; i <= endDay; i++)
                    {
                        dayComboBox.Items.Add(i);
                    }
                    dayComboBox.Enabled = true;
                    dayComboBox.SelectedIndex = 0;
                }
                else
                {
                    dayComboBox.Enabled = false;
                    dayComboBox.SelectedIndex = -1;
                }
            }
        }
    }
}
