using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class EmployeeForm : Form
    {
        //Constants: There are three constants defined for date format, hours format, and wage format.
        private const string DATE_FORMAT = "yyyy'-'MM'-'dd";
        private const string HOURS_FORMAT = "0.#";
        private const string WAGE_FORMAT = "0.##";
        private Employee employee;
        public EmployeeForm(long empId)
        {
            /*Consructor: The constructor initializes the EmployeeForm object. It takes an employee
            ID as a parameter, retrieves the employee details using the EmployeeDB.GetEmployee(empId) which searches for the employee*/
            InitializeComponent();
            employee = EmployeeDB.GetEmployee(empId);
            if (employee == null )
            {
                MessageBox.Show("Error No Employee","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("No Employee Found");
            }
        }

        private void ShowPayrollDetails()
        {
            /*This method retrieves the selected payroll details from a grid and 
            opens a new form (PayrollCalculator) to display the payroll information.*/
        
            //show payroll details form with the payroll
            string payRollId = (string)gridPayRoll.SelectedRows[0].Cells[0].Value;
            //gets the details from the payroll database by searching using the unique key, payrollid
            Payroll selectedPayroll = PayrollDB.GetPayrollForPayrollId(payRollId);  
            Form payrollDetails = new PayrollCalculator(selectedPayroll, employee.Name);
            payrollDetails.ShowDialog();
        }

        //These are event handlers, once the grid is double clicked it displays the payroll details
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridPayRoll.SelectedRows.Count > 0)
            {
                ShowPayrollDetails();
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            //Also event handler
            if (gridPayRoll.SelectedRows.Count > 0)
            {
                ShowPayrollDetails();
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Requires Exteral library", "Message Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //load data for the employee form the employee object
            txtName.Text = employee.Name;
            txtEmpId.Text = employee.Empid.ToString();
            txtEmail.Text = employee.Email;
            txtPhone.Text = employee.PhoneNumber;
            txtDoj.Text = employee.Dojoin.ToString(DATE_FORMAT);
            txtSin.Text = employee.SinNum;
            //populate the payroll grid
            foreach(Payroll payroll in PayrollDB.GetPayrollsForEmpId(employee.Empid))
            {
                gridPayRoll.Rows.Add(payroll.PayrollId, payroll.PayrollDate.ToString(DATE_FORMAT), payroll.HoursWorked.ToString(HOURS_FORMAT), payroll.HourlyWage.ToString(WAGE_FORMAT), 
                    payroll.OvertimeHours.ToString(HOURS_FORMAT), payroll.OvertimeRate.ToString(WAGE_FORMAT), payroll.NetTotal.ToString(WAGE_FORMAT));
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
