
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartVisitor.Entities.Order
{
     public class Order : BaseEntity<int>
    {
        public Order()
        {
            //this.Items = new List<OrderItem>();
        }
        public int ID_Customer { get; set; }
        public short ID_Visitor { get; set; }
        public DateTime DateTime { get; set; }
        public int ClientDate { get; set; }
        public int ClientTime { get; set; }
        public string  Description { get; set; }
        //public virtual  List<OrderItem> Items { get; set; }


        [ForeignKey("ID_order")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}
