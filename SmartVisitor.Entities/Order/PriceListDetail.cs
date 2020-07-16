using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SmartVisitor.Entities.Common;

namespace SmartVisitor.Entities.Order
{
    public class PriceListDetail: BaseEntity<long>
    {
        //[JsonProperty(PropertyName = "id_pr")]
        public int ID_PriceList { get; set; }

        public int ID_Product { get; set; }

        public long Price { get; set; }

        public long ConsumerPrice { get; set; }

        public byte Tax { get; set; }

        public int? Duration { get; set; }

        //[ForeignKey("ID_PriceList")]
        //public virtual PriceList PriceList { get; set; }

    }

}
