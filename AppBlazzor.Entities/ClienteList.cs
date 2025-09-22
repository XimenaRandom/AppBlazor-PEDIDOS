using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazzor.Entities
{
    public class ClienteList
    {
        public int Num_Cliente { get; set; }
        public string Nombre_Cliente { get; set; } = string.Empty;
        public string nombre_representante { get; set; } = string.Empty;
        public double Limite_Cuota { get; set; }
    }
}
