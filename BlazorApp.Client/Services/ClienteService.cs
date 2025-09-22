using AppBlazzor.Entities;
using System;
using System.Net.Http.Json;

namespace BlazorApp.Client.Services
{
    public class ClienteService
    {
        private List<ClienteList> listacli;

        private EmpleadoService empleadoservice;

        public ClienteService(EmpleadoService _empleadoservice)
        {
            empleadoservice = _empleadoservice;

            listacli = new List<ClienteList>();
            listacli.Add(new ClienteList { Num_Cliente = 1, Nombre_Cliente = "Loz Lizarrabal", nombre_representante = "Ximena Ayala", Limite_Cuota = 800.51});
            listacli.Add(new ClienteList { Num_Cliente = 2, Nombre_Cliente = "Menerva Algas", nombre_representante = "Max Ibarra", Limite_Cuota = 1000.51 });
        }
        public List<ClienteList> listarclientes()
        {
            return listacli;
        }
        public void eliminarCliente(int Num_Cliente)
        {
            var listaQueda = listacli.Where(p => p.Num_Cliente != Num_Cliente).ToList();
            listacli = listaQueda;
        }
        public ClienteFormCLS recuperarClientePorId(int Num_Cliente)
        {
            var obj = listacli.Where(e => e.Num_Cliente == Num_Cliente).FirstOrDefault();
            if (obj != null)
            {
                return new ClienteFormCLS
                {
                    Num_Cliente = obj.Num_Cliente,
                    Nombre_Cliente = obj.Nombre_Cliente,
                    idrepresentante = empleadoservice.obtenerIdEmpleado(obj.nombre_representante),
                    Limite_Cuota = obj.Limite_Cuota
                };
            }
            else
            {
                return new ClienteFormCLS();
            }
        }
        public void guardarCliente(ClienteFormCLS oClienteFormCLS)
        {
            int Num_Cliente = listacli.Select(p => p.Num_Cliente).Max() + 1;
            listacli.Add(new ClienteList
            {
                Num_Cliente = Num_Cliente,
                Nombre_Cliente = oClienteFormCLS.Nombre_Cliente,
                nombre_representante = empleadoservice.obtenerNombreEmpleado(oClienteFormCLS.idrepresentante),
                Limite_Cuota = oClienteFormCLS.Limite_Cuota
            });
        }

        public List<ClienteList> filtrarClientes(string nombrecliente)
        {

            List<ClienteList> e = listarclientes();
            if (nombrecliente == "")
            {
                return e;
            }
            else
            {
                List<ClienteList> listaFiltrada = e.Where(p => p.Nombre_Cliente.ToUpper().Contains(nombrecliente.ToUpper())).ToList();
                return listaFiltrada;
            }
        }
        public void actualizarCliente(ClienteFormCLS oClienteFormCLS)
        {
            var cliente = listacli.FirstOrDefault(c => c.Num_Cliente == oClienteFormCLS.Num_Cliente);
            if (cliente != null)
            {
                cliente.Nombre_Cliente = oClienteFormCLS.Nombre_Cliente;
                cliente.nombre_representante = empleadoservice.obtenerNombreEmpleado(oClienteFormCLS.idrepresentante);
                cliente.Limite_Cuota = oClienteFormCLS.Limite_Cuota;
            }
        }
    }
}