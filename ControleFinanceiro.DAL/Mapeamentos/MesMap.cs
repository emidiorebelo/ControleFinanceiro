using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.MesId);
            builder.Property(m => m.MesNome).IsRequired().HasMaxLength(20);
            builder.HasIndex(m => m.MesNome).IsUnique();

            builder.HasMany(m => m.Despesas).WithOne(m => m.Mes);
            builder.HasMany(m => m.Ganhos).WithOne(m => m.Mes);

            builder.HasData(
                new Mes
                {
                    MesId = 1,
                    MesNome = "Janeiro"
                },
                new Mes
                {
                    MesId = 2,
                    MesNome = "Fevereiro"
                },
                new Mes
                {
                    MesId = 3,
                    MesNome = "Março"
                },
                new Mes
                {
                    MesId = 4,
                    MesNome = "Arbil"
                }, new Mes
                {
                    MesId = 5,
                    MesNome = "Maio"
                },
                new Mes
                {
                    MesId = 6,
                    MesNome = "Junho"
                },
                new Mes
                {
                    MesId = 7,
                    MesNome = "Julho"
                },
                new Mes
                {
                    MesId = 8,
                    MesNome = "Agosto"
                },
                new Mes
                {
                    MesId = 9,
                    MesNome = "Setembro"
                },
                new Mes
                {
                    MesId = 10,
                    MesNome = "Outubro"
                },
                new Mes
                {
                    MesId = 11,
                    MesNome = "Novembro"
                },
                new Mes
                {
                    MesId = 12,
                    MesNome = "Dezembro"
                });

            builder.ToTable("Meses");
        }
    }
}
