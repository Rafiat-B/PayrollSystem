using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class EmployeeRegistrationForm : Form
    {
        public Employee Employee {  get; set; } 
        public EmployeeRegistrationForm(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }
        private void EmployeeRegistrationForm_Load(object sender, EventArgs e)
        {
            //Load data of emp in the emp form
            DateTime today = DateTime.Now;
            datePickerDob.MaxDate = today.AddYears(-18);
            datePickerDoj.MaxDate = today.AddMonths(6);
            if(Employee != null)
            {
                txtEmpId.Text = Employee.Empid.ToString();
                txtName.Text = Employee.Name.ToString();
                datePickerDoj.Value = Employee.Dojoin;
                numSalaryPerHr.Value = Employee.PayPerHour;
                txtPhone.Text = Employee.PhoneNumber;
                txtEmail.Text = Employee.Email;
                txtSinNum.Text = Employee.SinNum.ToString();
                datePickerDob.Value = Employee.Dobirth;
                txtAddress.Text = Employee.Address;
                txtBankDetails.Text = Employee.BankDetails;
                btnAddEmp.Enabled = false;
            }
            else
            {
                btnEmpRmv.Enabled = false;
                btnEmpUpdate.Enabled = false;
            }
        }

        //Validate entered data
        private bool ValidateEmpData()
        {

            bool validData = true;
            //validate name data
            Regex nameRegex = new Regex("^[\\w ]*$");
            if (!nameRegex.IsMatch(txtName.Text) || String.IsNullOrEmpty(txtName.Text))
            {
                errProvider.SetError(txtName, "Name must contain only Letters or numbers");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtName, String.Empty);
            }
            // validate phone data 10 digit
            Regex phoneRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");
            if (!phoneRegex.IsMatch(txtPhone.Text) || String.IsNullOrEmpty(txtPhone.Text))
            {
                errProvider.SetError(txtPhone, "Please enter a valid 10 digit phone number");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtPhone, String.Empty);
            }
            //Validate Email
            if (!IsValidEmail(txtEmail.Text))
            {
                errProvider.SetError(txtEmail, "Please enter a valid email");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtEmail, String.Empty);
            }
            // Validate 9 digit number for sin
            Regex sinRegex = new Regex("[\\d]{9}");
            if (!sinRegex.IsMatch(txtSinNum.Text) || String.IsNullOrEmpty(txtSinNum.Text))
            {
                errProvider.SetError(txtSinNum, "Please enter a 9 digit valid sin number");
                validData = false;
            }
            else
            {
                errProvider.SetError(txtSinNum, String.Empty);
            }
            return validData;
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            //using inbuilt MailAddress class to validate the email
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            // validate the input data
            if (!ValidateEmpData())
            {
                return;
            }
            Employee newEmployee = new Employee(txtName.Text,datePickerDoj.Value,numSalaryPerHr.Value, txtPhone.Text, txtEmail.Text,txtSinNum.Text,datePickerDob.Value, txtAddress.Text, txtBankDetails.Text, EmpStatus.ACTIVE);
            if (EmployeeDB.AddEmployee(newEmployee))
            {
                DialogResult d = MessageBox.Show($"Employee was created successfully", "Successfully Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    this.Close();
                }
                return;
            }
            MessageBox.Show("Failed to Add Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEmpRmv_Click(object sender, EventArgs e)
        {
            if (EmployeeDB.DeleteEmployee(Employee))
            {
                DialogResult d = MessageBox.Show("Employee was removed successfully", "Successfully Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(d == DialogResult.OK)
                {
                    this.Close();
                }
                return;
            }
            MessageBox.Show("Failed to Remove Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEmpUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateEmpData())
            {
                return;
            }
            Employee newEmployee = new Employee(Employee.Empid,txtName.Text, datePickerDoj.Value, numSalaryPerHr.Value, txtPhone.Text, txtEmail.Text, txtSinNum.Text, datePickerDob.Value, txtAddress.Text, txtBankDetails.Text, EmpStatus.ACTIVE);
            if (EmployeeDB.UpdateEmployee(newEmployee))
            {
                MessageBox.Show("Employee was updated successfully", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Employee was not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnEmpClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtSinNum.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtBankDetails.Text = string.Empty;
            numSalaryPerHr.Value = numSalaryPerHr.Minimum;
            datePickerDoj.Value = DateTime.Now;
            datePickerDob.Value = datePickerDob.MaxDate;
        }

    }
}
