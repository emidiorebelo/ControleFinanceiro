using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Cartao
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string Banner { get; set; }
        public string Number { get; set; }
        public double Limit { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}
