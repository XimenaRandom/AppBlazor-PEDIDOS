using AppBlazzor.Entities;

namespace BlazorApp.Client.Services
{
    public class TipoDepartamentoService
    {
        private List<TipoDepartamentoCLS> listadep;

        public TipoDepartamentoService() {
            listadep = new List<TipoDepartamentoCLS>();

            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 1, nombretipodepartamento = "La Paz" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 2, nombretipodepartamento = "Oruro" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 3, nombretipodepartamento = "Cochabamba" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 4, nombretipodepartamento = "Potosi" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 5, nombretipodepartamento = "Tarija" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 6, nombretipodepartamento = "Pando" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 7, nombretipodepartamento = "Beni" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 8, nombretipodepartamento = "Santa Cruz" });
            listadep.Add(new TipoDepartamentoCLS() { idtipodepartamento = 9, nombretipodepartamento = "Sucre" });
        }

        public List<TipoDepartamentoCLS> listarTipoDepartamento()
        {
            return listadep;
        }

        public int obtenerIdTipoDepartamento(string nombretipodepartamento)
        {
            var obj = listadep.Where(p => p.nombretipodepartamento == nombretipodepartamento).FirstOrDefault();
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.idtipodepartamento;
            }
        }

        public string obtenerNombreTipoDepartamento(int idtipodepartamento)
        {
            var obj = listadep.Where(p => p.idtipodepartamento == idtipodepartamento).FirstOrDefault();
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.nombretipodepartamento;
            }
        }
    }
}
