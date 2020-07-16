
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Links
{
    public class LinkVisitorProductBrand : BaseEntity<int>
    {
        public short ID_Visitor { get; set; }

        public int ID_ProductBrand { get; set; }

    }

}
