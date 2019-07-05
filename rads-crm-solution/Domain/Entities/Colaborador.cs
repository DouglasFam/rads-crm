using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Colaborador : BaseEntity
    {
        public Colaborador()
        {
            Adverso = new HashSet<Adverso>();
        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public byte? Status { get; set; }
        public byte? Adm { get; set; }

        public virtual ICollection<Adverso> Adverso { get; set; }
    }
}
