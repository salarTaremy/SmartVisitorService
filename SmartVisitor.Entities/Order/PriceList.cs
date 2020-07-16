
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartVisitor.Entities.Order
{
    public class PriceList : BaseEntity<int>,IDetail<PriceListDetail>
    {
        public PriceList()
        {
            Details = new HashSet<PriceListDetail>(); // you may also use List<PriceListDetail>, but HashSet will guarantee that you are not adding the same PriceListDetail mistakenly twice
        }
        public int BeginDate { get; set; }

        public int EndDate { get; set; }

        public string Description { get; set; }


        //[ForeignKey("ID_PriceList")]
        //public virtual ICollection<PriceListDetail> PriceListDetails { get; set; }

        [ForeignKey("ID_PriceList")]
        public  ICollection<PriceListDetail> Details { get; set; }
    }

}
