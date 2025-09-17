using AppBlazzor.Entities;

namespace BlazorApp.Client.Services
{
    public class TipoDirectorService
    {
        private List<TipoDirectorCLS> listadir;
        public TipoDirectorService()
        {
            listadir = new List<TipoDirectorCLS>();

            listadir.Add(new TipoDirectorCLS() { idtipodirector = 1, nombretipodirector = "Mocos Ayale" });
            listadir.Add(new TipoDirectorCLS() { idtipodirector = 2, nombretipodirector = "Chismena Pollo" });
            listadir.Add(new TipoDirectorCLS() { idtipodirector = 3, nombretipodirector = "Lix Larrazabal" });
            listadir.Add(new TipoDirectorCLS() { idtipodirector = 4, nombretipodirector = "Menerva Alga" });
            listadir.Add(new TipoDirectorCLS() { idtipodirector = 5, nombretipodirector = "Dedos Portudo" });
        }

        public List<TipoDirectorCLS> listarTipoDirector()
        {
            return listadir;
        }

        public int obtenerIdTipoDirector(string nombretipodirector)
        {
            var obj = listadir.Where(p => p.nombretipodirector == nombretipodirector).FirstOrDefault();
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.idtipodirector;
            }
        }

        public string obtenerNombreTipoDirector(int idtipodirector)
        {
            var obj = listadir.Where(p => p.idtipodirector == idtipodirector).FirstOrDefault();
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.nombretipodirector;
            }
        }
    }
}
