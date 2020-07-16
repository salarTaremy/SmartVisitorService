
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartVisitor.Entities.Customer
{
    public class Customer : BaseEntity<int>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string F_Name { get; set; }

        public string L_name { get; set; }

        public int IdType { get; set; }

        public int IdGroup { get; set; }

        public string Tel { get; set; }

        public string Mobile { get; set; }

        public int? OpenInvoice { get; set; }

        public long? Debt { get; set; }

        public int? rate { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }
        public string PathName { get; set; }

        public string x { get; set; }

        public string y { get; set; }
    }
}
