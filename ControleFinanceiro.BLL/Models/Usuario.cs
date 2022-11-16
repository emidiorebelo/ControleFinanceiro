using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ControleFinanceiro.BLL.Models
{
    public class Usuario : IdentityUser<string>
    {
        public string UsuarioCPF { get; set; }
        public string Profession { get; set; }
        public byte[] photo { get; set; }
        public virtual ICollection<Cartao> Cartoes { get; set; }
        public virtual ICollection<Ganho> Ganhos { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }

    }
}