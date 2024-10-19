using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class PayrollCalculator : Form
    {
        //constant string for reuse for formating strings
        private const string PERCENT_FORMAT = "p2";
        private const string CURRENCY_FORMAT = "c";

        /*Payroll: Represents the payroll information for an employee.
            EmpName: Stores the name of the employee associated with the payroll.*/
        public Payroll Payroll { get; set; }
        public string EmpName { get; set; }
        public bool AddFlag { get; set; }
        public PayrollCalculator(Payroll payroll, string empName,bool addFlag=false)
        {
            //setting the payroll and emp name from emp or admin home
            InitializeComponent();
            Payroll = payroll;
            EmpName = empName;
            AddFlag = addFlag;
            if (AddFlag)
            {
                //if add flag is true then hide the update button
                btnUpdatePay.Text = "A&dd";
            }
        }

        private void BtnUpdatePay_Click(object sender, EventArgs e)
        {
            //parsing the combobox data to back into payrollstatus enum 
            Enum.TryParse<PayRollStatus>(cbxStatus.SelectedValue.ToString(), out PayRollStatus status);
            // creating update payroll object for updating
            Payroll updatedPayroll = new Payroll(
                Payroll.EmpId, Payroll.PayrollDate, Payroll.HourlyWage, numHrsWorked.Value,
                numOvertimeHrsWorked.Value, numOvertimeRate.Value, numOtherDeductions.Value,
                Payroll.ProvisionalTaxRate, Payroll.FederalTaxRate, Payroll.CPPPremium,
                Payroll.InsuranceDeductions, Payroll.ReguralDeductions, status
                );
            if (AddFlag)
            {
                //if add flag is true then add the payroll
                if (PayrollDB.AddPayroll(updatedPayroll))
                {
                    MessageBox.Show("Payroll Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                MessageBox.Show("Payroll Add Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //update the old payroll
            if(PayrollDB.UpdatePayroll( updatedPayroll))
            {
                RefreshPayrollData(updatedPayroll);
                MessageBox.Show("Payroll Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Payroll Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayrollCalculator_Load(object sender, EventArgs e)
        {
            /*This method is executed when the form is loaded. It refreshes the displayed payroll data based on the provided payroll information.*/
            RefreshPayrollData(Payroll);
        }

        private void RefreshPayrollData(Payroll payroll)
        {
            // refresh the payroll details on calculate or update
            PayRollStatus payRollStatus = payroll.Status;
            cbxStatus.DataSource = Enum.GetValues(typeof(PayRollStatus));
            // disable editing and update buttons if payroll already paid
            cbxStatus.DataSource = Enum.GetValues(typeof(PayRollStatus)); //Enum == fixed value
            if (payRollStatus == PayRollStatus.PAID)
            {
                numHrsWorked.ReadOnly = true;
                numOvertimeHrsWorked.ReadOnly = true;
                numOvertimeRate.ReadOnly = true;
                numOtherDeductions.ReadOnly = true;
                btnCalculate.Enabled = false;
                btnUpdatePay.Enabled = false;
                btnCalculate.Visible = false;
                btnUpdatePay.Visible = false;
                cbxStatus.Enabled = false;
            }
            //Then populate all the data like hours worked, wage, etc
            txtEmpId.Text = payroll.EmpId.ToString();
            txtName.Text = EmpName;
            txtHourlyWage.Text = payroll.HourlyWage.ToString(CURRENCY_FORMAT);
            numHrsWorked.Value = payroll.HoursWorked;
            numOvertimeHrsWorked.Value = payroll.OvertimeHours;
            numOvertimeRate.Value = payroll.OvertimeRate;
            txtGrossPay.Text = payroll.GrossTotal.ToString(CURRENCY_FORMAT);
            txtTaxNDdctns.Text = (payroll.TotalDeductions + payroll.TotalTaxes).ToString(CURRENCY_FORMAT);
            numOtherDeductions.Value = payroll.OtherDeductions;
            txtProvincialTax.Text = payroll.ProvisionalTaxRate.ToString(PERCENT_FORMAT);
            txtFdrlIncmTax.Text = payroll.FederalTaxRate.ToString(PERCENT_FORMAT);
            txtCppEiPrmum.Text = payroll.CPPPremium.ToString(PERCENT_FORMAT);
            txtTotalTax.Text = payroll.TotalTaxes.ToString(CURRENCY_FORMAT);
            txtInsrncDdctn.Text = payroll.InsuranceDeductions.ToString(CURRENCY_FORMAT);
            txtRglrDdctn.Text = payroll.ReguralDeductions.ToString(CURRENCY_FORMAT);
            txtTotalDdctn.Text = payroll.TotalDeductions.ToString(CURRENCY_FORMAT);
            txtNetPay.Text = payroll.NetTotal.ToString(CURRENCY_FORMAT);
            cbxStatus.SelectedIndex = cbxStatus.FindStringExact(payroll.Status.ToString());
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // populate the payroll details with temp payroll with new values
            Payroll updatedPayroll = new Payroll(
                Payroll.EmpId, Payroll.PayrollId, Payroll.HourlyWage, numHrsWorked.Value,
                numOvertimeHrsWorked.Value, numOvertimeRate.Value, numOtherDeductions.Value,
                Payroll.ProvisionalTaxRate, Payroll.FederalTaxRate, Payroll.CPPPremium,
                Payroll.InsuranceDeductions, Payroll.ReguralDeductions, Payroll.Status
                );
            RefreshPayrollData( updatedPayroll );
        }
    }
}
