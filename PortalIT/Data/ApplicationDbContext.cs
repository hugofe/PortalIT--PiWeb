using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortalIT.Models.Domain;

namespace PortalIT.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PortalIT.Models.Domain.Aluno> Aluno { get; set; }
        public DbSet<PortalIT.Models.Domain.Departamento> Departamento { get; set; }
        public DbSet<PortalIT.Models.Domain.Curso> Curso { get; set; }
        
    }
}
