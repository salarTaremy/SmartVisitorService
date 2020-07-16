
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartVisitor.Entities.Visitor
{
    [Table("Visitors")]
    public class Visitor : BaseEntity<short>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Ssn { get; set; }

        public string Description { get; set; }

    }
}
