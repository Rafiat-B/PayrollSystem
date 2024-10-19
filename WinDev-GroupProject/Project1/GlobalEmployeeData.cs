using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    //Gobal data for all employees
    public static class GlobalEmployeeData
    {
        public static decimal ProvisionalTaxRate { get; set; } = (decimal)(9.15 / 100);
        public static decimal FederalTaxRate { get; set; } = (decimal)(20.50 / 100);
        public static decimal CPPPremium { get; set; } = (decimal)(5.70 / 100);
        public static decimal InsuranceDeductions { get; set; } = 550;
        public static decimal ReguralDeductions { get; set; } = 200;
    }
}
