using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class CartaoMap : IEntityTypeConfiguration<Cartao>
    {
        public void Configure(EntityTypeBuilder<Cartao> builder)
        {
            builder.HasKey(c => c.CardId);
            builder.Property(c => c.CardName).IsRequired().HasMaxLength(20);
            builder.HasIndex(c => c.CardName).IsUnique();
            builder.Property(c => c.Banner).IsRequired().HasMaxLength(15);
            builder.Property(c => c.Number).IsRequired().HasMaxLength(30);
            builder.HasIndex(c => c.Number).IsUnique();
            builder.Property(c => c.Limit).IsRequired();

            builder.HasOne(c => c.Usuario).WithMany(c => c.Cartoes).HasForeignKey(c => c.UsuarioId).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(c => c.Despesas).WithOne(c => c.Cartao);

            builder.ToTable("Cartoes");
        }
    }
}
