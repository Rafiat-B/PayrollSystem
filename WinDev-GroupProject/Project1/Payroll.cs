using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public enum PayRollStatus
    {
        PAID,
        PENDING
    }
    public class Payroll
    {


        public Payroll(long empId, string payrollId, decimal hourlyWage, decimal hoursWorked,
            decimal overtimeHours, decimal overtimeRate, decimal otherDeductions,
            decimal provisionalTaxRate, decimal federalTaxRate, decimal cPPPremium,
            decimal insuranceDeductions, decimal reguralDeductions, PayRollStatus status)
        {
            EmpId = empId;
            PayrollId = payrollId;
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
            OvertimeHours = overtimeHours;
            OvertimeRate = overtimeRate;
            OtherDeductions = otherDeductions;
            ProvisionalTaxRate = provisionalTaxRate;
            FederalTaxRate = federalTaxRate;
            CPPPremium = cPPPremium;
            InsuranceDeductions = insuranceDeductions;
            ReguralDeductions = reguralDeductions;
            Status = status;
            this.CalculateGrossTotal();
        }

        public Payroll(long empId, DateTime payrollDate, decimal hourlyWage, decimal hoursWorked,
            decimal overtimeHours, decimal overtimeRate, decimal otherDeductions,
            decimal provisionalTaxRate, decimal federalTaxRate, decimal cPPPremium,
            decimal insuranceDeductions, decimal reguralDeductions, PayRollStatus status)
        {
            EmpId = empId;
            PayrollDate = payrollDate;
            PayrollId = payrollDate.ToString("yyyy'_'MM'_'dd") + "_" + empId.ToString();
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
            OvertimeHours = overtimeHours;
            OvertimeRate = overtimeRate;
            OtherDeductions = otherDeductions;
            ProvisionalTaxRate = provisionalTaxRate;
            FederalTaxRate = federalTaxRate;
            CPPPremium = cPPPremium;
            InsuranceDeductions = insuranceDeductions;
            ReguralDeductions = reguralDeductions;
            Status = status;
            this.CalculateGrossTotal();
        }

        public Payroll(long empId, DateTime payrollDate,
            string payrollId, decimal hourlyWage, decimal hoursWorked,
            decimal overtimeHours, decimal overtimeRate, decimal grossTotal,
            decimal otherDeductions, decimal netTotal, decimal provisionalTaxRate,
            decimal federalTaxRate, decimal cPPPremium, decimal totalTaxes,
            decimal insuranceDeductions, decimal reguralDeductions,
            decimal totalDeductions, PayRollStatus status)
        {
            EmpId = empId;
            PayrollDate = payrollDate;
            PayrollId = payrollId;
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
            OvertimeHours = overtimeHours;
            OvertimeRate = overtimeRate;
            GrossTotal = grossTotal;
            OtherDeductions = otherDeductions;
            NetTotal = netTotal;
            ProvisionalTaxRate = provisionalTaxRate;
            FederalTaxRate = federalTaxRate;
            CPPPremium = cPPPremium;
            TotalTaxes = totalTaxes;
            InsuranceDeductions = insuranceDeductions;
            ReguralDeductions = reguralDeductions;
            TotalDeductions = totalDeductions;
            Status = status;
        }

        public long EmpId { get; set; }
        public DateTime PayrollDate { get; set; }
        public string PayrollId { get; set; }
        public decimal HourlyWage { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal OvertimeRate { get; set; }
        public decimal GrossTotal { get; set; }
        public decimal OtherDeductions { get; set; }
        public decimal NetTotal { get; set; }
        public decimal ProvisionalTaxRate { get; set; }
        public decimal FederalTaxRate { get; set; }
        public decimal CPPPremium { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal InsuranceDeductions { get; set; }
        public decimal ReguralDeductions { get; set; }
        public decimal TotalDeductions { get; set; }
        public PayRollStatus Status { get; set; }
        private decimal CalculateTotalBeforeTax()
        {
            this.GrossTotal = (HourlyWage * HoursWorked) + (OvertimeRate * OvertimeHours);
            return this.GrossTotal;
        }
        private decimal CalculateTotalRegularDeductions()
        {
            TotalDeductions = InsuranceDeductions + ReguralDeductions;
            return TotalDeductions;
        }

        private decimal CalculateTotalTaxes()
        {
            this.TotalTaxes = this.GrossTotal * (this.ProvisionalTaxRate + this.FederalTaxRate + this.CPPPremium);
            return this.TotalTaxes;
        }

        public decimal CalculateGrossTotal()
        {
            this.NetTotal = CalculateTotalBeforeTax() - CalculateTotalTaxes() - CalculateTotalRegularDeductions() - this.OtherDeductions;
            return this.NetTotal;
        }
    }
}
