
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Links
{
    public class LinkVisitorProductGroup : BaseEntity<int>
    {
        public short ID_Visitor { get; set; }

        public int ID_ProductGroup { get; set; }

    }

}
