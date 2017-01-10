using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankXml.code
{
    struct ATM 
    {
        public int BankCode { get; set; }
        public string BankName { get; set; }

        public int ATMCode { get; set; }
        public string ATMAddress { get; set; }
        public string City { get; set; }

       

        //public override bool Equals(object other)
        //{
        //    return this.ATMCode.CompareTo(((ATM)other).ATMCode)==0;
        //}

        //// If Equals() returns true for a pair of objects  
        //// then GetHashCode() must return the same value for these objects. 
        //public override int GetHashCode()
        //{
        //    return ATMCode.GetHashCode();
        //}


    }
}
