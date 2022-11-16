﻿namespace ControleFinanceiro.BLL.Models
{
    public class Despesa
    {
        public int ExpenseId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CardId { get; set; }
        public Cartao Cartao { get; set; }
        public int CategoryId { get; set; }
        public Categoria Categoria { get; set; }
        public int Day { get; set; }
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        public int Year { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}