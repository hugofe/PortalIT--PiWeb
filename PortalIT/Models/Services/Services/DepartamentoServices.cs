using PortalIT.Data;
using PortalIT.Models.Domain;
using PortalIT.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalIT.Models.Services.Services
{
    public class DepartamentoServices : IDepartamento
    {
        private readonly ApplicationDbContext _context;

        public DepartamentoServices(ApplicationDbContext context)
        {
            context = _context;
        }
        public void AddCurso(Curso curso)
        {
            _context.Add(curso);
            _context.SaveChanges();
            
        }

        public void Create(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Departamento List(int id)
        {
            throw new NotImplementedException();
        }
        public IList<Departamento> ListAll()
        {
            return _context.Departamento.ToList();
        }

        public Departamento Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
