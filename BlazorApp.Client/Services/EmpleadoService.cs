using AppBlazzor.Entities; 
namespace BlazorApp.Client.Services
{
    public class EmpleadoService
    {
        private List<EmpleadoList> lista;
        public EmpleadoService()
        {
            lista = new List<EmpleadoList>();
            lista.Add(new EmpleadoList {Num_Empleado = 1, Nombre_Completo = "Ximena Ayala", Edad = 21, Cargo = "Diseñadora", FechaContrato = new DateTime(2023, 4, 3, 21, 40, 0), Cuota = 30, Ventas = 60 });
            lista.Add(new EmpleadoList { Num_Empleado = 2, Nombre_Completo = "Max Ibarra", Edad = 18, Cargo = "Contador", FechaContrato = new DateTime(2025, 8, 25, 16, 40, 0), Cuota = 20, Ventas = 40 });
        }
        public List<EmpleadoList> listarempleados()
        {
            return lista; 
        }
        public void eliminarEmpleado(int Num_Empleado)
        {
            var listaQueda = lista.Where(p => p.Num_Empleado != Num_Empleado).ToList();
            lista = listaQueda;
        }
        public EmpleadoFormCLS recuperarEmpleadoPorId(int Num_Empleado)
        {
            var obj = lista.Where(p => p.Num_Empleado == Num_Empleado).FirstOrDefault();
            if(obj != null)
            {
                return new EmpleadoFormCLS { Num_Empleado = obj.Num_Empleado, Nombre_Completo = obj.Nombre_Completo, Edad = obj.Edad, Cargo = obj.Cargo, FechaContrato = obj.FechaContrato, Cuota = obj.Cuota, Ventas = obj.Ventas }; 
            }
            else
            {
                return new EmpleadoFormCLS();
            }
        }
        public void guardarEmpleado(EmpleadoFormCLS oEmpleadoFormCLS)
        {
            lista.Add(new EmpleadoList { Num_Empleado = oEmpleadoFormCLS.Num_Empleado, Nombre_Completo = oEmpleadoFormCLS.Nombre_Completo, Edad = oEmpleadoFormCLS.Edad, Cargo= oEmpleadoFormCLS.Cargo, FechaContrato = oEmpleadoFormCLS.FechaContrato, Cuota= oEmpleadoFormCLS.Cuota, Ventas= oEmpleadoFormCLS.Ventas }); 
        }

    }
}
