using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartVisitor.Entities.Common
{
    public class BaseEntity<TKey> 
    {
        [Key]
        public TKey ID { get; set; }

        public static System.Type GetKeyType() {
            return typeof(TKey);
        }

    }
}
