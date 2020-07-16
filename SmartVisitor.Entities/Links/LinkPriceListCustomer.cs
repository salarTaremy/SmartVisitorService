
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Links
{
    public class LinkPriceListCustomer : BaseEntity<int>
    {
        public int ID_PriceList { get; set; }

        public int ID_CustomerType { get; set; }

        public int ID_CustomerGroup { get; set; }

    }

}
