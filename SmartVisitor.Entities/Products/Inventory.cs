
using Newtonsoft.Json;
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Products
{
    public class Inventory : BaseEntity<int>
    {
        public short ID_Warehouse { get; set; }

        public int ID_Product { get; set; }

        public int Quantity { get; set; }

    }
}
