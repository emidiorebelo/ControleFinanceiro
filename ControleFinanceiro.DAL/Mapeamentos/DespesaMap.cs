using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class DespesaMap : IEntityTypeConfiguration<Despesa>
    {
        public void Configure(EntityTypeBuilder<Despesa> builder)
        {
            builder.HasKey(d => d.ExpenseId);
            builder.Property(d => d.Description).IsRequired().HasMaxLength(50);
            builder.Property(d => d.Price).IsRequired();
            builder.Property(d => d.Day).IsRequired();
            builder.Property(d => d.Year).IsRequired();

            builder.HasOne(d => d.Cartao).WithMany(d => d.Despesas).HasForeignKey(d => d.ExpenseId).IsRequired();
            builder.HasOne(d => d.Categoria).WithMany(d => d.Despesas).HasForeignKey(d => d.CategoryId).IsRequired();
            builder.HasOne(d => d.Mes).WithMany(d => d.Despesas).HasForeignKey(d => d.MesId).IsRequired();
            builder.HasOne(d => d.Usuario).WithMany(d => d.Despesas).HasForeignKey(d => d.UsuarioId).IsRequired();

            builder.ToTable("Despesas");
        }
    }
}
