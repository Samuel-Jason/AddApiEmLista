using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    public class MeuObjeto : Slip
    {
        public Slip Slip { get; set; }
    }

    public class Slip
    {
        public int Id { get; set; }
        public string Advice { get; set; }
    }
}
