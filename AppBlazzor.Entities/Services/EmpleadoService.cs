using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazzor.Entities.Services
{
    public class EmpleadoService
    {
        private List<EmpleadoList> lista;

        public EmpleadoService()
        {
            lista = new List<EmpleadoList>();
            lista.Add(new EmpleadoList { Num_Empleado = 1, Nombre_Completo = "Juan Perez", Edad = 30, Cargo = "Gerente", FechaContrato = new DateTime(2020, 1, 15), Cuota = 5000.00, Ventas = 150, Operaciones = 75 });
            lista.Add(new EmpleadoList { Num_Empleado = 2, Nombre_Completo = "Maria Gomez", Edad = 28, Cargo = "Asistente", FechaContrato = new DateTime(2021, 3, 22), Cuota = 3000.00, Ventas = 100, Operaciones = 50 });
            
        
        }
        public List<EmpleadoList> ListarEmpleados()
        {
            return lista;
        }

        
    }
}
