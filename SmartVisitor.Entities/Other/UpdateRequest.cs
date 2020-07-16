using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Other
{
    public class UpdateRequest :BaseEntity<short>
    {
        public string Description { get; set; }
        public ICollection<short> RequestCodes { get; set; }
    }
}
