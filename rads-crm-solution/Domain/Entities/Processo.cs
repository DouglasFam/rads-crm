using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Processo: BaseEntity
    {
        public int? IdCliente { get; set; }
        public int? IdAdverso { get; set; }

    }
}
