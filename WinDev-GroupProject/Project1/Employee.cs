using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public enum EmpStatus
    {
        RECRUIT,
        ACTIVE,
        INACTIVE
    }
    public class Employee
    {
        //Emp ID min and max value
        public static long EMPMINID = 100000;
        public static long EMPMAXID = 9999999;
        //Glodal emp ID to keep track of the employee ID generated
        private static long globalId = EMPMINID;

        public Employee(long empid, string name, DateTime dojoin, decimal payPerHour,
            string phoneNumber, string email, string sinNum,
            DateTime dobirth, string address, string bankDetails, EmpStatus status)
        {
            Empid = empid;
            Name = name;
            Dojoin = dojoin;
            PayPerHour = payPerHour;
            PhoneNumber = phoneNumber;
            Email = email;
            SinNum = sinNum;
            Dobirth = dobirth;
            Address = address;
            BankDetails = bankDetails;
            Status = status;
        }

        public Employee(string name, DateTime dojoin, decimal payPerHour,
            string phoneNumber, string email, string sinNum, 
            DateTime dobirth, string address, string bankDetails, EmpStatus status)
        {
            //use globalId to generate emp ID and then increment it
            Empid = globalId;
            globalId++;
            Name = name;
            Dojoin = dojoin;
            PayPerHour = payPerHour;
            PhoneNumber = phoneNumber;
            Email = email;
            SinNum = sinNum;
            Dobirth = dobirth;
            Address = address;
            BankDetails = bankDetails;
            Status = status;
        }

        public long Empid { get;}
        public string Name { get; set; }
        public DateTime Dojoin { get; set; }
        public decimal PayPerHour { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string SinNum { get; set; }
        public DateTime Dobirth { get; set; }
        public string Address { get; set; }
        public string BankDetails { get; set; }
        public EmpStatus Status { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   Empid == employee.Empid;
        }
        
    }
}
