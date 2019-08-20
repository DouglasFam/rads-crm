using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.ModelView
{
    public class ContatoViewModel
    {
        public int idcolaborador { get; set; }
        public int idcliente { get; set; }
        public int status { get; set; }
        public string obs { get; set; }
        public DateTime data { get; set; }
        public DateTime datacontato { get; set; }
    }
}
