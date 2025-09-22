using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazzor.Entities
{
    public class ClienteFormCLS
    {
        //numero empleado
        [Required(ErrorMessage = "El Numero es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser positivo")]
        public int Num_Cliente { get; set; }

        //nombre completo
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Nombre_Cliente { get; set; } = null!;

        //representante
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un representante")]
        public int idrepresentante { get; set; }

        //cuota 
        [Required(ErrorMessage = "La Cuota es requerido")]
        public double Limite_Cuota { get; set; }

    }
}
