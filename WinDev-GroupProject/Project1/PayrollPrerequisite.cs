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
    public partial class PayrollPrerequisite : Form
    {
        public Employee Employee { get; set; }
        public DateTime PayrollDate { get; set; }
        public PayrollPrerequisite()
        {
            InitializeComponent();
        }

        // Load employees into the grid
        private void PayrollPrerequisite_Load(object sender, EventArgs e)
        {
            foreach(Employee employee in EmployeeDB.GetAllEmployees().OrderBy(x => x.Empid).ToList())
            {
                gridEmployeeList.Rows.Add(employee.Empid,employee.Name);
            }
        }

        //create payroll for employee and date
        private void BtnCreatePayroll_Click(object sender, EventArgs e)
        {
            int selectedRowCount = gridEmployeeList.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                long empId = (long)gridEmployeeList.SelectedRows[0].Cells[0].Value;
                //Get Employee from the employeeDB
                Employee selectedEmployee = EmployeeDB.GetEmployee(empId);
                if (selectedEmployee != null)
                {
                    Employee = selectedEmployee;
                }
            }
            else
            {
                MessageBox.Show("No employee selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PayrollDate = datePayDate.Value;
            this.Close();
        }
    }
}
