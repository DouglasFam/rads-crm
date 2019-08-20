using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.ModelView
{
    public class AgendamentoViewModel
    {

        public int idcliente { get; set; }
        public  DateTime data { get; set; }
        public int idcolcad { get; set; }
        public int tipo { get; set; }
    }
}
