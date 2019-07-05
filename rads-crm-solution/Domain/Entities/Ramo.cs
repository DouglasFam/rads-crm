using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Ramo : BaseEntity
    {
        public Ramo()
        {
            Adverso = new HashSet<Adverso>();
        }

        public string Nome { get; set; }

        public virtual ICollection<Adverso> Adverso { get; set; }
    }
}
