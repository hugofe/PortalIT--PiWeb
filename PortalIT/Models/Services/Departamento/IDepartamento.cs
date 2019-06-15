using System.Collections.Generic;
using System.Threading.Tasks;
using PortalIT.Models.Domain;

namespace PortalIT.Services.Services
{
    public interface IDepartamento
    {
        void Create(Departamento departamento);

        void Delete(int id);

        Departamento List(int id);
        IList<Departamento> ListAll();

        Departamento Update(int id);

        void AddCurso(Curso curso);
    }
}
