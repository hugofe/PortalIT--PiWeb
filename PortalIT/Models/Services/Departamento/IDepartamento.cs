﻿using System.Collections.Generic;
using System.Threading.Tasks;
using PortalIT.Models.Domain;

namespace PortalIT.Services.Services
{
    public interface IDepartamento
    {
        void Create(Departamento departamento);

        void Delete(int id);

        Departamento List(int id);
        Task<Departamento> ListAsync();

        void AddCurso(Curso curso, List<Curso> cursos);
        Task<Departamento> ListAsync(int id);
    }
}