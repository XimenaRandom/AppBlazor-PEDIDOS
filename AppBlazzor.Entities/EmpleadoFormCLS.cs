using System.ComponentModel.DataAnnotations;

namespace AppBlazzor.Entities
{
    public class EmpleadoFormCLS
    {
        [Required (ErrorMessage = "El Numero es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser positivo")]
        public int Num_Empleado { get; set; }
        [Required(ErrorMessage = "El Nombre es requerido")]
        public string Nombre_Completo { get; set; } = null!;
        [Required(ErrorMessage = "La edad es reuquerida")]
        [Range(18, int.MaxValue, ErrorMessage = "Debe ser mayor de edad")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "El Cargo es requerido")]
        
        public string Cargo { get; set; } = null!;
        [Required (ErrorMessage = "La Fecha es requerido")]
        public DateTime FechaContrato { get; set; }
        [Required(ErrorMessage = "La Cuota es requerido")]
        public double Cuota { get; set; }
        [Required(ErrorMessage = "El numero de ventas es requerido")]
        public int Ventas { get; set; }

        [Range(1,int.MaxValue, ErrorMessage = "Debe seleccionar una sucursal")]
        public int idtipodepartamento { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un director")]
        public int idtipodirector { get; set; }
    }
}
