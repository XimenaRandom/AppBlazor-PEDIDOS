using AppBlazzor.Entities; 
namespace BlazorApp.Client.Services
{
    public class EmpleadoService
    {
        private List<EmpleadoList> lista;

        private TipoDepartamentoService tipodepartamentoservice;
        private TipoDirectorService tipodirectorservice;
        public EmpleadoService(TipoDepartamentoService _tipodepartmentoservice, TipoDirectorService _tipodirevtorservice)
        {
            tipodepartamentoservice = _tipodepartmentoservice;
            tipodirectorservice = _tipodirevtorservice;

            lista = new List<EmpleadoList>();
            lista.Add(new EmpleadoList {Num_Empleado = 1, Nombre_Completo = "Ximena Ayala", Edad = 21, Cargo = "Diseñadora", FechaContrato = new DateTime(2023, 4, 3, 21, 40, 0), Cuota = 30, Ventas = 60, nombretipodepartamento = "La Paz", nombretipodirector = "Chismena Pollo" });
            lista.Add(new EmpleadoList { Num_Empleado = 2, Nombre_Completo = "Max Ibarra", Edad = 18, Cargo = "Contador", FechaContrato = new DateTime(2025, 8, 25, 16, 40, 0), Cuota = 20, Ventas = 40, nombretipodepartamento = "Pando" ,nombretipodirector = "Menerva Alga",  });
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
            var obj = lista.Where(e => e.Num_Empleado == Num_Empleado).FirstOrDefault();
            if(obj != null)
            {
                return new EmpleadoFormCLS
                { 
                    Num_Empleado = obj.Num_Empleado, Nombre_Completo = obj.Nombre_Completo, Edad = obj.Edad, Cargo = obj.Cargo, FechaContrato = obj.FechaContrato, Cuota = obj.Cuota, Ventas = obj.Ventas,
                    idtipodepartamento = tipodepartamentoservice.obtenerIdTipoDepartamento(obj.nombretipodepartamento),
                    idtipodirector = tipodirectorservice.obtenerIdTipoDirector(obj.nombretipodirector)               
                }; 
            }
            else
            {
                return new EmpleadoFormCLS();
            }
        }
        public void guardarEmpleado(EmpleadoFormCLS oEmpleadoFormCLS)
        {
            int Num_Empleado = lista.Select(p => p.Num_Empleado).Max() + 1;
            lista.Add(new EmpleadoList {
                Num_Empleado = Num_Empleado,
                Nombre_Completo = oEmpleadoFormCLS.Nombre_Completo,
                Edad = oEmpleadoFormCLS.Edad, Cargo= oEmpleadoFormCLS.Cargo,
                FechaContrato = oEmpleadoFormCLS.FechaContrato,
                Cuota= oEmpleadoFormCLS.Cuota, Ventas= oEmpleadoFormCLS.Ventas
                ,nombretipodepartamento = tipodepartamentoservice.obtenerNombreTipoDepartamento(oEmpleadoFormCLS.idtipodepartamento), 
                nombretipodirector = tipodirectorservice.obtenerNombreTipoDirector(oEmpleadoFormCLS.idtipodirector),
            }); 
        }

        public List<EmpleadoList> filtrarEmpleados(string nombreempleado)
        {

            List<EmpleadoList> e = listarempleados();
            if (nombreempleado == "")
            {
                return e;
            }
            else
            {
                List<EmpleadoList> listaFiltrada = e.Where(p => p.Nombre_Completo.ToUpper().Contains(nombreempleado.ToUpper())).ToList();
                return listaFiltrada;
            }
        }

    }
}
