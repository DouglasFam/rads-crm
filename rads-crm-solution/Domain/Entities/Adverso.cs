using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Adverso : BaseEntity
    {
        public string Nome { get; set; }
        public int? IdRamo { get; set; }
        public int? Idcolcad { get; set; }

        public virtual Ramo IdRamoNavigation { get; set; }
        public virtual Colaborador IdcolcadNavigation { get; set; }
    }
}
