﻿using Biblioteca_padrao;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Gestao_de_Entregas.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        }

        public DbSet<EntregaUrgente> EntregaUrgente { get; set; }
        public DbSet<Coleta> Coleta { get; set; }
        public DbSet<Falta> Falta { get; set; }
        public DbSet<FaltaStatus> FaltaStatus { get; set; }
        public DbSet<ColetaStatus> ColetaStatus { get; set; }
        public DbSet<EntregaUrgenteStatus> EntregaUrgenteStatus { get; set; }

        public DbSet<HorasFuncionario> HorasFuncionarios { get; private set; }

        /// <summary>
        /// Representação da tabela funcionario no banco de dados.
        /// </summary>
        public DbSet<Funcionario> Funcionario { get; private set; }

        /// <summary>
        /// Representação da tabela Banco de Horas no banco de dados.
        /// </summary>
        public DbSet<BancoDeHoras> BancoDeHoras { get; private set; }
    }
}