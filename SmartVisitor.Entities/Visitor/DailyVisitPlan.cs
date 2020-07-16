
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartVisitor.Entities.Visitor
{
    public class DailyVisitPlan : BaseEntity<long>
    {
        public short ID_Visitor { get; set; }

        public int PrDay { get; set; }




        [ForeignKey("ID_Plan")]
        public virtual ICollection<DailyVisitPlanDetail> DailyVisitPlanDetails { get; set; }

    }

}
