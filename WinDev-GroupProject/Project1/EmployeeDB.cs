using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public static class EmployeeDB
    {
        //Initializes a static and read-only list named employeesDB to store Employee objects.
        //  private static readonly List<Employee> employeesDB = new List<Employee>();

        // Connection string for Oracle database
        private static string connectionString = ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;


        public static bool AddEmployee(Employee employee)
        {
            // Check if the employee already exists
            if (ContainsEmployee(employee.Empid))
            {
                // Employee with this Empid already exists, handle this situation, e.g., return false or throw an exception
                return false; // Or any other handling mechanism
            }

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                       
                        // Set parameters as before
                        command.CommandText = "INSERT INTO Employees (Empid, Name, Dojoin, PayPerHour, PhoneNumber, Email, SinNum, Dobirth, Address, BankDetails, Status) VALUES (:Empid, :Name, :Dojoin, :PayPerHour, :PhoneNumber, :Email, :SinNum, :Dobirth, :Address, :BankDetails, :Status)";
                        command.Parameters.Add("Empid", employee.Empid);
                        command.Parameters.Add("Name", employee.Name);
                        command.Parameters.Add("Dojoin", employee.Dojoin);
                        command.Parameters.Add("PayPerHour", employee.PayPerHour);
                        command.Parameters.Add("PhoneNumber", employee.PhoneNumber);
                        command.Parameters.Add("Email", employee.Email);
                        command.Parameters.Add("SinNum", employee.SinNum);
                        command.Parameters.Add("Dobirth", employee.Dobirth);
                        command.Parameters.Add("Address", employee.Address);
                        command.Parameters.Add("BankDetails", employee.BankDetails);
                        command.Parameters.Add("Status", employee.Status.ToString());
                        int rowsaffected = command.ExecuteNonQuery();
                        if (rowsaffected == 0)
                        {
                            // Handle the situation when the insert operation did not insert any rows
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (OracleException ex)
            {
                // Handle potential Oracle exceptions here
                Console.WriteLine($"Oracle error: {ex.Message}");
                return false;
            }

        }

        public static bool DeleteEmployee(Employee employee)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Employees WHERE Empid = :Empid";
                    command.Parameters.Add("Empid", employee.Empid);
                    int rowsDeleted = command.ExecuteNonQuery();
                    if (rowsDeleted == 0)
                    {
                        // Handle the situation when the delete operation did not delete any rows
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool ContainsEmployee(Employee employee)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM Employees WHERE Empid = :Empid AND Name = :Name AND Dojoin = :Dojoin AND PayPerHour = :PayPerHour AND PhoneNumber = :PhoneNumber AND Email = :Email AND SinNum = :SinNum AND Dobirth = :Dobirth AND Address = :Address AND BankDetails = :BankDetails AND Status = :Status";
                    command.Parameters.Add("Empid", OracleDbType.Decimal, 7).Value = Convert.ToDecimal(employee.Empid);
                    command.Parameters.Add("Name", OracleDbType.Varchar2).Value = employee.Name;
                    command.Parameters.Add("Dojoin", OracleDbType.Date).Value = employee.Dojoin;
                    command.Parameters.Add("PayPerHour", OracleDbType.Decimal).Value = employee.PayPerHour;
                    command.Parameters.Add("PhoneNumber", OracleDbType.Varchar2).Value = employee.PhoneNumber;
                    command.Parameters.Add("Email", OracleDbType.Varchar2).Value = employee.Email;
                    command.Parameters.Add("SinNum", OracleDbType.Varchar2).Value = employee.SinNum;
                    command.Parameters.Add("Dobirth", OracleDbType.Date).Value = employee.Dobirth;
                    command.Parameters.Add("Address", OracleDbType.Varchar2).Value = employee.Address;
                    command.Parameters.Add("BankDetails", OracleDbType.Varchar2).Value = employee.BankDetails;
                    command.Parameters.Add("Status", OracleDbType.Varchar2).Value = employee.Status.ToString();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static bool ContainsEmployee(long empId)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM Employees WHERE Empid = :Empid";
                    command.Parameters.Add("Empid", OracleDbType.Decimal).Value = empId;
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public static Employee GetEmployee(long id)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Employees WHERE Empid = :Empid";
                    command.Parameters.Add("Empid", OracleDbType.Int64).Value = id;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Employee(
                                Convert.ToInt64(reader.GetDecimal(10)),
                                reader.GetString(0),
                                reader.GetDateTime(1),
                                reader.GetDecimal(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetDateTime(6),
                                reader.GetString(7),
                                reader.GetString(8),
                                (EmpStatus)Enum.Parse(typeof(EmpStatus), reader.GetString(9)));
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static bool UpdateEmployee(Employee employee)
        {
            Employee employeeToBeUpdated = GetEmployee(employee.Empid);
            if (employeeToBeUpdated != null)
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "UPDATE Employees SET Name = :Name, Dojoin = :Dojoin, PayPerHour = :PayPerHour, PhoneNumber = :PhoneNumber, Email = :Email, SinNum = :SinNum, Dobirth = :Dobirth, Address = :Address, BankDetails = :BankDetails, Status = :Status WHERE Empid = :Empid";
                        command.Parameters.Add("Name", OracleDbType.Varchar2).Value = employee.Name;
                        command.Parameters.Add("Dojoin", OracleDbType.Date).Value = employee.Dojoin;
                        command.Parameters.Add("PayPerHour", OracleDbType.Decimal).Value = employee.PayPerHour;
                        command.Parameters.Add("PhoneNumber", OracleDbType.Varchar2).Value = employee.PhoneNumber;
                        command.Parameters.Add("Email", OracleDbType.Varchar2).Value = employee.Email;
                        command.Parameters.Add("SinNum", OracleDbType.Varchar2).Value = employee.SinNum;
                        command.Parameters.Add("Dobirth", OracleDbType.Date).Value = employee.Dobirth;
                        command.Parameters.Add("Address", OracleDbType.Varchar2).Value = employee.Address;
                        command.Parameters.Add("BankDetails", OracleDbType.Varchar2).Value = employee.BankDetails;
                        command.Parameters.Add("Status", OracleDbType.Varchar2).Value = employee.Status.ToString();
                        command.Parameters.Add("Empid", OracleDbType.Decimal, 7).Value = Convert.ToDecimal(employee.Empid);
                        int rowsUpdated = command.ExecuteNonQuery();
                        if (rowsUpdated == 0)
                        {
                            // Handle the situation when the update operation did not update any rows
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand("SELECT * FROM Employees", connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                employees.Add(new Employee(
                                    Convert.ToInt64(reader.GetDecimal(10)), // Empid
                                    reader.GetString(0), // Name
                                    reader.GetDateTime(1), // Dojoin
                                    reader.GetDecimal(2), // PayPerHour
                                    reader.GetString(3), // PhoneNumber
                                    reader.GetString(4), // Email
                                    reader.GetString(5), // SinNum
                                    reader.GetDateTime(6), // Dobirth
                                    reader.GetString(7), // Address
                                    reader.GetString(8), // BankDetails
                                    (EmpStatus)Enum.Parse(typeof(EmpStatus), reader.GetString(9)) // Status
                                ));
                            }
                            catch (InvalidCastException ex)
                            {
                                // Handle the exception here
                                Console.WriteLine("Invalid data in the Employees table: " + ex.Message);
                            }
                        }
                    }
                }
            }

            return employees;
        }
    }
}
