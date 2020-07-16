
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartVisitor.Entities.Products
{
    public class Product : BaseEntity<int>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int IdBrand { get; set; }

        public int IdGroup { get; set; }

        public int Count { get; set; }

        public int CountInBox { get; set; }

        public int Weight { get; set; }

        public string Detail { get; set; }

        public byte? rate { get; set; }

    }

}
