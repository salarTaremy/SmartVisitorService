
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Order
{
    public class OrderItem : BaseEntity<int>
    {
        public int ID_order { get; set; }
        public int Id_Product { get; set; }
        public int Qty { get; set; }
        public int? Offer { get; set; }
    }
}
