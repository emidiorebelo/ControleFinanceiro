using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ControleFinanceiro.BLL.Models
{
    public class Usuario : IdentityUser<string>
    {
        public string UsuarioCPF { get; set; }
        public string UsuarioProfissao { get; set; }
        public byte[] UsuarioFoto { get; set; }
        public virtual ICollection<Cartao> Cartoes { get; set; }
        public virtual ICollection<Ganho> Ganhos { get; set; }
        public virtual ICollection<Despesa> Despesas { get; set; }

    }
}