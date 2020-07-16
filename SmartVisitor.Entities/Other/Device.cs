
using SmartVisitor.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartVisitor.Entities.Other
{
    [Table("Devices")]
    public class Device : BaseEntity<short>
    {
        public string IMEI { get; set; }

        public short? ID_Visitor { get; set; }

    }
}
