using System.Runtime.InteropServices;
using UCS.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace UCS.App.Persistencia.AppRepositorio
{
    public class RepositorioSistemaIngresoPersonal : IRepositorioSistemaIngresoPersonal
    {
        private readonly AppContext _appContext;

        public RepositorioSistemaIngresoPersonal(AppContext appContext)
        {
            _appContext = appContext;
        }

        public SistemaIngresoPersonal AddSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteSistemaIngresoPersonal(int idSistemaIngresoPersonal)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SistemaIngresoPersonal> GetAllSistemaIngresoPersonal()
        {
            throw new System.NotImplementedException();
        }

        public SistemaIngresoPersonal GetSistemaIngresoPersonal(int idSistemaIngresoPersonal)
        {
            throw new System.NotImplementedException();
        }

        public SistemaIngresoPersonal UpdateSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal)
        {
            throw new System.NotImplementedException();
        }
    }
}