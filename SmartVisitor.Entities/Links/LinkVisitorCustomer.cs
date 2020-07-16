
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Links
{
    public class LinkVisitorCustomer : BaseEntity<int>
    {
        public short ID_Visitor { get; set; }

        public int ID_CustomerType { get; set; }

        public int ID_CustomerGroup { get; set; }

    }
}
