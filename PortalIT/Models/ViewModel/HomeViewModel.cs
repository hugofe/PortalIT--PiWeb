using PortalIT.Data;
using PortalIT.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalIT.Models.ViewModel
{
     public class HomeViewModel
    {
        public List<Curso> curso { get; set; }
        public List<Departamento> departamento { get; set; }

        private readonly ApplicationDbContext _context;

        public HomeViewModel(ApplicationDbContext _context)
        {
            var context = _context;
        }
        public List<Curso> ListAll()
        {
            return _context.Curso.ToList();
        }
    }
}
