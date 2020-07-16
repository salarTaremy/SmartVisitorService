using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Entities
{
    public interface IDetail<TDetail>
    {
        ICollection<TDetail> Details { get; set; }
    }
}
