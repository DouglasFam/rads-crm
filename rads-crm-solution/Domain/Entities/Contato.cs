using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Contato : BaseEntity
    {
        public int? Idcolaborador { get; set; }
        public int? Idcliente { get; set; }
        public int? Status { get; set; }
        public string Obs { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Datacontato { get; set; }
    }
}
