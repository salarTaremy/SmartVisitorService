
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities.Visitor
{
    public class DailyVisitPlanDetail : BaseEntity<long>
    {
        public long ID_Plan { get; set; }

        public int ID_Customer { get; set; }

    }

}
