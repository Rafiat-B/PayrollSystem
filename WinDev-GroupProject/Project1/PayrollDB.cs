using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public static class PayrollDB
    {
        // private static readonly List<Payroll> payrollsDB = new List<Payroll>();

        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;

        public static bool AddPayroll(Payroll payroll)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Payrolls (EmpId, PayrollDate, PayrollId, HourlyWage, HoursWorked, OvertimeHours, OvertimeRate, GrossTotal, OtherDeductions, NetTotal, ProvisionalTaxRate, FederalTaxRate, CPPPremium, TotalTaxes, InsuranceDeductions, ReguralDeductions, TotalDeductions, Status) VALUES (:EmpId, :PayrollDate, :PayrollId, :HourlyWage, :HoursWorked, :OvertimeHours, :OvertimeRate, :GrossTotal, :OtherDeductions, :NetTotal, :ProvisionalTaxRate, :FederalTaxRate, :CPPPremium, :TotalTaxes, :InsuranceDeductions, :ReguralDeductions, :TotalDeductions, :Status)";
                        command.Parameters.Add("EmpId", OracleDbType.Decimal).Value = payroll.EmpId;
                        command.Parameters.Add("PayrollDate", OracleDbType.Date).Value = payroll.PayrollDate;
                        command.Parameters.Add("PayrollId", OracleDbType.Varchar2).Value = payroll.PayrollId;
                        command.Parameters.Add("HourlyWage", OracleDbType.Decimal).Value = payroll.HourlyWage;
                        command.Parameters.Add("HoursWorked", OracleDbType.Decimal).Value = payroll.HoursWorked;
                        command.Parameters.Add("OvertimeHours", OracleDbType.Decimal).Value = payroll.OvertimeHours;
                        command.Parameters.Add("OvertimeRate", OracleDbType.Decimal).Value = payroll.OvertimeRate;
                        command.Parameters.Add("GrossTotal", OracleDbType.Decimal).Value = payroll.GrossTotal;
                        command.Parameters.Add("OtherDeductions", OracleDbType.Decimal).Value = payroll.OtherDeductions;
                        command.Parameters.Add("NetTotal", OracleDbType.Decimal).Value = payroll.NetTotal;
                        command.Parameters.Add("ProvisionalTaxRate", OracleDbType.Decimal).Value = payroll.ProvisionalTaxRate;
                        command.Parameters.Add("FederalTaxRate", OracleDbType.Decimal).Value = payroll.FederalTaxRate;
                        command.Parameters.Add("CPPPremium", OracleDbType.Decimal).Value = payroll.CPPPremium;
                        command.Parameters.Add("TotalTaxes", OracleDbType.Decimal).Value = payroll.TotalTaxes;
                        command.Parameters.Add("InsuranceDeductions", OracleDbType.Decimal).Value = payroll.InsuranceDeductions;
                        command.Parameters.Add("ReguralDeductions", OracleDbType.Decimal).Value = payroll.ReguralDeductions;
                        command.Parameters.Add("TotalDeductions", OracleDbType.Decimal).Value = payroll.TotalDeductions;
                        command.Parameters.Add("Status", OracleDbType.Varchar2).Value = payroll.Status.ToString();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Error adding payroll: " + ex.Message);
                return false;
            }
        }

        public static List<Payroll> GetPayrollsForEmpId(long empId)
        {
            List<Payroll> payrolls = new List<Payroll>();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Payrolls WHERE EmpId = :EmpId AND Status = 'PAID'";
                    command.Parameters.Add("EmpId", OracleDbType.Decimal).Value = empId;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                payrolls.Add(new Payroll(
                                    Convert.ToInt64(reader.GetDecimal(0)), // EmpId
                                    reader.GetDateTime(17), // PayrollDate
                                    reader.GetString(1), // PayrollId
                                    reader.GetDecimal(2), // HourlyWage
                                    reader.GetDecimal(3), // HoursWorked
                                    reader.GetDecimal(4), // OvertimeHours
                                    reader.GetDecimal(5), // OvertimeRate
                                    reader.GetDecimal(6), // GrossTotal
                                    reader.GetDecimal(7), // OtherDeductions
                                    reader.GetDecimal(8), // NetTotal
                                    reader.GetDecimal(9), // ProvisionalTaxRate
                                    reader.GetDecimal(10), // FederalTaxRate
                                    reader.GetDecimal(11), // CPPPremium
                                    reader.GetDecimal(12), // TotalTaxes
                                    reader.GetDecimal(13), // InsuranceDeductions
                                    reader.GetDecimal(14), // ReguralDeductions
                                    reader.GetDecimal(15), // TotalDeductions
                                    (PayRollStatus)Enum.Parse(typeof(PayRollStatus), reader.GetString(16))
                                ));
                            }
                            catch (InvalidCastException ex)
                            {
                                // Handle the exception here
                                Console.WriteLine("Invalid data in the Payrolls table: " + ex.Message);
                            }
                        }
                    }
                }
            }

            return payrolls;
        }

        public static Payroll GetPayrollForPayrollId(string payrollId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Payrolls WHERE PayrollId = :PayrollId";
                    command.Parameters.Add("PayrollId", OracleDbType.Varchar2).Value = payrollId;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Payroll(
                                Convert.ToInt64(reader.GetDecimal(0)), // EmpId
                                    reader.GetDateTime(17), // PayrollDate
                                    reader.GetString(1), // PayrollId
                                    reader.GetDecimal(2), // HourlyWage
                                    reader.GetDecimal(3), // HoursWorked
                                    reader.GetDecimal(4), // OvertimeHours
                                    reader.GetDecimal(5), // OvertimeRate
                                    reader.GetDecimal(6), // GrossTotal
                                    reader.GetDecimal(7), // OtherDeductions
                                    reader.GetDecimal(8), // NetTotal
                                    reader.GetDecimal(9), // ProvisionalTaxRate
                                    reader.GetDecimal(10), // FederalTaxRate
                                    reader.GetDecimal(11), // CPPPremium
                                    reader.GetDecimal(12), // TotalTaxes
                                    reader.GetDecimal(13), // InsuranceDeductions
                                    reader.GetDecimal(14), // ReguralDeductions
                                    reader.GetDecimal(15), // TotalDeductions
                                    (PayRollStatus)Enum.Parse(typeof(PayRollStatus), reader.GetString(16))
                            );
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

        }

        public static bool UpdatePayroll(Payroll payroll)
        {
            Payroll payrollToBeUpdated = GetPayrollForPayrollId(payroll.PayrollId);
            if (payrollToBeUpdated != null)
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "UPDATE Payrolls SET EmpId = :EmpId, PayrollDate = :PayrollDate, HourlyWage = :HourlyWage, HoursWorked = :HoursWorked, OvertimeHours = :OvertimeHours, OvertimeRate = :OvertimeRate, GrossTotal = :GrossTotal, OtherDeductions = :OtherDeductions, NetTotal = :NetTotal, ProvisionalTaxRate = :ProvisionalTaxRate, FederalTaxRate = :FederalTaxRate, CPPPremium = :CPPPremium, TotalTaxes = :TotalTaxes, InsuranceDeductions = :InsuranceDeductions, ReguralDeductions = :ReguralDeductions, TotalDeductions = :TotalDeductions, Status = :Status WHERE PayrollId = :PayrollId";
                        command.Parameters.Add("EmpId", OracleDbType.Decimal).Value = payroll.EmpId;
                        command.Parameters.Add("PayrollDate", OracleDbType.Date).Value = payroll.PayrollDate;
                        command.Parameters.Add("HourlyWage", OracleDbType.Decimal).Value = payroll.HourlyWage;
                        command.Parameters.Add("HoursWorked", OracleDbType.Decimal).Value = payroll.HoursWorked;
                        command.Parameters.Add("OvertimeHours", OracleDbType.Decimal).Value = payroll.OvertimeHours;
                        command.Parameters.Add("OvertimeRate", OracleDbType.Decimal).Value = payroll.OvertimeRate;
                        command.Parameters.Add("GrossTotal", OracleDbType.Decimal).Value = payroll.GrossTotal;
                        command.Parameters.Add("OtherDeductions", OracleDbType.Decimal).Value = payroll.OtherDeductions;
                        command.Parameters.Add("NetTotal", OracleDbType.Decimal).Value = payroll.NetTotal;
                        command.Parameters.Add("ProvisionalTaxRate", OracleDbType.Decimal).Value = payroll.ProvisionalTaxRate;
                        command.Parameters.Add("FederalTaxRate", OracleDbType.Decimal).Value = payroll.FederalTaxRate;
                        command.Parameters.Add("CPPPremium", OracleDbType.Decimal).Value = payroll.CPPPremium;
                        command.Parameters.Add("TotalTaxes", OracleDbType.Decimal).Value = payroll.TotalTaxes;
                        command.Parameters.Add("InsuranceDeductions", OracleDbType.Decimal).Value = payroll.InsuranceDeductions;
                        command.Parameters.Add("ReguralDeductions", OracleDbType.Decimal).Value = payroll.ReguralDeductions;
                        command.Parameters.Add("TotalDeductions", OracleDbType.Decimal).Value = payroll.TotalDeductions;
                        command.Parameters.Add("Status", OracleDbType.Varchar2).Value = payroll.Status.ToString();
                        command.Parameters.Add("PayrollId", OracleDbType.Varchar2).Value = payroll.PayrollId;

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public static bool RemovePayroll(Payroll payroll)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Payrolls WHERE PayrollId = :PayrollId";
                    command.Parameters.Add("PayrollId", OracleDbType.Varchar2).Value = payroll.PayrollId;
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
        public static List<Payroll> GetPayrolls()
        {
            List<Payroll> payrolls = new List<Payroll>();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Payrolls";
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                payrolls.Add(new Payroll(
                                   Convert.ToInt64(reader.GetDecimal(0)), // EmpId
                                    reader.GetDateTime(17), // PayrollDate
                                    reader.GetString(1), // PayrollId
                                    reader.GetDecimal(2), // HourlyWage
                                    reader.GetDecimal(3), // HoursWorked
                                    reader.GetDecimal(4), // OvertimeHours
                                    reader.GetDecimal(5), // OvertimeRate
                                    reader.GetDecimal(6), // GrossTotal
                                    reader.GetDecimal(7), // OtherDeductions
                                    reader.GetDecimal(8), // NetTotal
                                    reader.GetDecimal(9), // ProvisionalTaxRate
                                    reader.GetDecimal(10), // FederalTaxRate
                                    reader.GetDecimal(11), // CPPPremium
                                    reader.GetDecimal(12), // TotalTaxes
                                    reader.GetDecimal(13), // InsuranceDeductions
                                    reader.GetDecimal(14), // ReguralDeductions
                                    reader.GetDecimal(15), // TotalDeductions
                                    (PayRollStatus)Enum.Parse(typeof(PayRollStatus), reader.GetString(16))
                                ));
                            }
                            catch (InvalidCastException ex)
                            {
                                // Handle the exception here
                                Console.WriteLine("Invalid data in the Payrolls table: " + ex.Message);
                            }
                        }
                    }
                }
            }

            return payrolls;
        }
    }
}
