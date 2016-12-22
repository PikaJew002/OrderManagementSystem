using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            for (int i = year-5; i <= year+5; i++)
            {
                yearComboBox.Items.Add(i);
            }
            //month comboBox
            monthComboBox.Items.Clear();
            monthComboBox.Items.Add("Month");
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
            }
        }

        private void getBusinessVolume_Click(object sender, EventArgs e)
        {

        }
    }
}
