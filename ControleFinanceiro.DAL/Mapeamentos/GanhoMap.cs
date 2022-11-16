using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class GanhoMap : IEntityTypeConfiguration<Ganho>
    {
        public void Configure(EntityTypeBuilder<Ganho> builder)
        {
            builder.HasKey(g => g.GanhoId);
            builder.Property(g => g.Description).IsRequired().HasMaxLength(50);
            builder.Property(g => g.Price).IsRequired();
            builder.Property(g => g.Day).IsRequired();
            builder.Property(g => g.Year).IsRequired();

            builder.HasOne(g => g.Categoria).WithMany(g => g.Ganhos).HasForeignKey(g => g.CategoryId).IsRequired();
            builder.HasOne(g => g.Mes).WithMany(g => g.Ganhos).HasForeignKey(g => g.MesId).IsRequired();
            builder.HasOne(g => g.Usuario).WithMany(g => g.Ganhos).HasForeignKey(g => g.UsuarioId).IsRequired();

            builder.ToTable("Ganhos");
        }
    }
}
