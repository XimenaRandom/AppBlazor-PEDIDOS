using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazzor.Entities
{
    public class EmpleadoList
    {
        public int Num_Empleado { get; set; }
        public string Nombre_Completo { get; set; } = null!;
        public int Edad { get; set; }
        public string Cargo { get; set; } = null!;
        public DateTime FechaContrato { get; set; }
        public double Cuota { get; set; }
        public int Ventas { get; set; }
        
        public int Operaciones { get; set; }
    }
}
