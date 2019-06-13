using PortalIT.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalIT.Models.ViewModel
{
    public class HomeViewModel
    {
        public List<Aluno> Aluno { get; set; }
        public List<Departamento> Departamento { get; set; }
    }
}
