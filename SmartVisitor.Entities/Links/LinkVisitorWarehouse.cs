
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Links
{
    public class LinkVisitorWarehouse : BaseEntity<int>
    {
        public short ID_Visitor { get; set; }

        public short ID_Warehouse { get; set; }

    }

}
