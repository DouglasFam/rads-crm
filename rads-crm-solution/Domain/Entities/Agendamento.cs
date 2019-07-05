using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Agendamento : BaseEntity
    {
        public int? Idcliente { get; set; }
        public DateTime? Data { get; set; }
        public int? Idcolcad { get; set; }
        public int? Tipo { get; set; }
    }
}
