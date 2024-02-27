using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EFCore_1.Models
{
    public class AcctCompanyInfo
    {
        public int idAcct { get; set; }
        public string acctCustomerName { get; set; }
        public string acctVATCode { get; set; }
        public string acctAddress { get; set; }
    }
}
