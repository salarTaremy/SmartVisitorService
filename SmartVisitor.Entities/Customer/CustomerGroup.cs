
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartVisitor.Entities.Customer
{
    public class CustomerGroup : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
