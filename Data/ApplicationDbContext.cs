using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Turismo.Models;

namespace Paisajes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Turismo.Models.PaisModel> PaisModel { get; set; }
        public DbSet<Turismo.Models.CiudadModel> CiudadModel { get; set; }
        public DbSet<Turismo.Models.ProvinciaModel> ProvinciaModel { get; set; }
        public DbSet<Turismo.Models.PaisajeModel> PaisajeModel { get; set; }
    }
}
