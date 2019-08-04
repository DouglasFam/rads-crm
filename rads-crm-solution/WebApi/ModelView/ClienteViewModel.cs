using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.ModelView
{
    public class ClienteViewModel
    {
        [Required]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Ender { get; set; }
        public int? Indicacao { get; set; }
        public string Cargo { get; set; }
        public int? Idcolcad { get; set; }
        public DateTime? Datacadastro { get; set; }
        public DateTime? Datainiempresa { get; set; }
        public DateTime? Datafinalempresa { get; set; }
        public string Email { get; set; }
    }
}
