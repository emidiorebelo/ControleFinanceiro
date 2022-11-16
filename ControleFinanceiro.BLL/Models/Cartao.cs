using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Cartao
    {
        public int CartaoId { get; set; }
        public string CartaoNome { get; set; }
        public string CartaoBandeira { get; set; }
        public string CartaoNumero { get; set; }
        public double CartaoLimite { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }
    }
}
