using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
            RefreshPayrollDataGridView();
            RefreshEmployeelDataGridView();
        }

        private void AddShowEmpDetails(bool newEmp)
        {

            int selectedRowCount = gridEmpTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Employee selectedEmployee = null;
            if (!newEmp && selectedRowCount > 0)
            {
                string empId = (string)gridEmpTable.SelectedRows[0].Cells[0].Value;
                selectedEmployee = EmployeeDB.GetEmployee(long.Parse(empId));
            }
            Form employeeRegistration = new EmployeeRegistrationForm(selectedEmployee);
            employeeRegistration.ShowDialog();
            RefreshEmployeelDataGridView();
        }

        private void ShowPayrollDetails()
        {
            string payRollId = (string)gridPayrollTable.SelectedRows[0].Cells[0].Value;
            Payroll selectedPayroll = PayrollDB.GetPayrollForPayrollId(payRollId);
            Form payrollDetails = new PayrollCalculator(selectedPayroll, (string)gridPayrollTable.SelectedRows[0].Cells[3].Value);
            payrollDetails.ShowDialog();
            RefreshPayrollDataGridView();
        }

        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {
            AddShowEmpDetails(false);
        }

        private void BtnPayrollDetails_Click(object sender, EventArgs e)
        {
            ShowPayrollDetails();
        }

        private void GridEmpTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddShowEmpDetails(false);
        }

        private void GridPayrollTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowPayrollDetails();
        }

        private void BtnPayrollSearch_Click(object sender, EventArgs e)
        {
            gridPayrollTable.ClearSelection();
            string searchValue = txtPayrollSearch.Text;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in gridPayrollTable.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            gridPayrollTable.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txtPayrollSearch.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnEmployeeSearch_Click(object sender, EventArgs e)
        {
            // The emp data grid for the text and highlight by selecting text
            gridEmpTable.ClearSelection();
            string searchValue = txtEmployeeSearch.Text;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in gridEmpTable.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            gridEmpTable.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txtEmployeeSearch.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void RefreshEmployeelDataGridView()
        {
            //order the employee grid according to the emp Id
            gridEmpTable.Rows.Clear();
            foreach (Employee employee in EmployeeDB.GetAllEmployees().OrderBy(x => x.Empid).ToList())
            {
                gridEmpTable.Rows.Add(employee.Empid.ToString(), employee.Name, employee.PayPerHour.ToString(), employee.PhoneNumber, employee.Email, employee.Dojoin.ToString("yyyy'-'MM'-'dd"));
            }
        }

        private void RefreshPayrollDataGridView()
        {
            // order the payroll grid according to pending status first then the date and then the empID
            gridPayrollTable.Rows.Clear();

            var payrolls = PayrollDB.GetPayrolls()
                .OrderByDescending(x => x.Status)
                .ThenByDescending(x => x.PayrollDate.Date)
                .ThenBy(x => x.PayrollId)
                .Join(EmployeeDB.GetAllEmployees(),
                    payroll => payroll.EmpId,
                    employee => employee.Empid,
                    (payroll, employee) => new
                    {
                        Payroll = payroll,
                        EmployeeName = employee.Name
                    });

            foreach (var payroll in payrolls)
            {
                gridPayrollTable.Rows.Add(
                    payroll.Payroll.PayrollId,
                    payroll.Payroll.PayrollDate.ToString("yyyy'-'MM'-'dd"),
                    payroll.Payroll.EmpId.ToString(),
                    payroll.EmployeeName,
                    payroll.Payroll.HoursWorked.ToString("0.#"),
                    payroll.Payroll.HourlyWage.ToString("0.##"),
                    payroll.Payroll.OvertimeHours.ToString("0.#"),
                    payroll.Payroll.OvertimeRate.ToString("0.##"),
                    payroll.Payroll.NetTotal.ToString("0.##"),
                    payroll.Payroll.Status.ToString()
                );
            }
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            AddShowEmpDetails(true);
        }

        private void BtnCreatePayroll_Click(object sender, EventArgs e)
        {
            bool addFlag = true;
            PayrollPrerequisite payrollPrerequisite = new PayrollPrerequisite();
            payrollPrerequisite.ShowDialog();
            if (payrollPrerequisite.Employee != null && payrollPrerequisite.PayrollDate != null)
            {
                Employee employee = payrollPrerequisite.Employee;
                Payroll newPayroll = new Payroll(employee.Empid, payrollPrerequisite.PayrollDate, employee.PayPerHour,
                    0, 0, 0, 0, GlobalEmployeeData.ProvisionalTaxRate, GlobalEmployeeData.FederalTaxRate,
                    GlobalEmployeeData.CPPPremium, GlobalEmployeeData.InsuranceDeductions, GlobalEmployeeData.ReguralDeductions, PayRollStatus.PENDING);
                if (PayrollDB.GetPayrollForPayrollId(newPayroll.PayrollId) != null)
                {
                    MessageBox.Show("Payroll already exists for this employee and date, please update instead", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newPayroll = PayrollDB.GetPayrollForPayrollId(newPayroll.PayrollId);
                    addFlag = false;
                }
                PayrollCalculator payrollDetails = new PayrollCalculator(newPayroll, employee.Name,addFlag);
                payrollDetails.ShowDialog();
                RefreshPayrollDataGridView();
            }
        }

        private void BtnDeletePayroll_Click(object sender, EventArgs e)
        {
            string payRollId = (string)gridPayrollTable.SelectedRows[0].Cells[0].Value;
            Payroll selectedPayroll = PayrollDB.GetPayrollForPayrollId(payRollId);
            PayrollDB.RemovePayroll(selectedPayroll);
            RefreshPayrollDataGridView();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
