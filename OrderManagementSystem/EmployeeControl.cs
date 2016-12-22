using System;
using System.Windows.Forms;
using System.Collections;

namespace OrderManagementSystem
{
    public partial class EmployeeControl : UserControl
    {
        private static EmployeeControl _instance;
        public static EmployeeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeControl();
                return _instance;
            }
        }
        public EmployeeControl()
        {
            InitializeComponent();
        }

        private ArrayList employeeList = new ArrayList();
        private Employee selectedEmployee = new Employee();

        //populates the employee listBox
        public void populateEmployeeListBox()
        {
            employeeList.Clear();
            employeesListBox.Items.Clear();
            employeeList = Employee.getEmployeeList();
            foreach (Employee nextEmployee in employeeList)
            {
                employeesListBox.Items.Add(nextEmployee.getLastName() + ", " + nextEmployee.getFirstName() + " :" + nextEmployee.getId());
            }
        }

        //resets fields to defaults
        public void resetFields()
        {
            firstNameValueLabel.Text = "";
            firstNameValueLabel.Visible = true;
            firstNameTextBox.Text = "";
            firstNameTextBox.Visible = false;
            lastNameTextBox.Text = "";
            lastNameTextBox.Visible = false;
            positionValueLabel.Text = "";
            positionValueLabel.Visible = true;
            positionTextBox.Text = "";
            positionTextBox.Visible = false;
            clockInCheckBox.Checked = false;
            clockInCheckBox.Enabled = false;
            saveChangesButton.Visible = false;
            cancelButton.Visible = false;
            editEmployeeButton.Visible = true;
            employeePanel.Visible = false;
            employeesListBox.SelectedIndex = -1;
            selectedEmployee = new Employee();
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Visible = true;
            lastNameTextBox.Visible = true;
            firstNameValueLabel.Visible = false;
            positionTextBox.Visible = true;
            positionValueLabel.Visible = false;
            clockInCheckBox.Enabled = true;
            editEmployeeButton.Visible = false;
            saveChangesButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            //validates user input
            if(Employee.validateInput(firstNameTextBox.Text, lastNameTextBox.Text, positionTextBox.Text))
            {
                selectedEmployee.setFirstName(firstNameTextBox.Text);
                selectedEmployee.setLastName(lastNameTextBox.Text);
                selectedEmployee.setPosition(positionTextBox.Text);
                if (clockInCheckBox.Checked)
                    selectedEmployee.setIsClockedIn(1);
                else
                    selectedEmployee.setIsClockedIn(0);
                selectedEmployee.updateEmployeeInDatabase();
                resetFields();
                employeesListBox.Items.Clear();
                populateEmployeeListBox();
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void employeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeesListBox.SelectedIndex != -1)
            {
                char[] delimStr = { ':' };
                selectedEmployee = Employee.getEmployee(employeesListBox.SelectedItem.ToString().Split(delimStr)[1]);
                firstNameValueLabel.Text = selectedEmployee.getFirstName() + " " + selectedEmployee.getLastName();
                firstNameTextBox.Text = selectedEmployee.getFirstName();
                lastNameTextBox.Text = selectedEmployee.getLastName();
                positionValueLabel.Text = selectedEmployee.getPosition();
                positionTextBox.Text = selectedEmployee.getPosition();
                if (selectedEmployee.getIsClockedIn() == 0)
                {
                    clockInCheckBox.Checked = false;
                }
                else
                {
                    clockInCheckBox.Checked = true;
                }
                employeePanel.Visible = true;
            }
        }
    }
}
