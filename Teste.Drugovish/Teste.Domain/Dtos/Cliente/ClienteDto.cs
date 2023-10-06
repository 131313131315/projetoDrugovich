using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Dtos.Grupo;

namespace Teste.Domain.Dtos.Cliente
{
    public class ClienteDto : BaseEntity
    {
        public string? Cnpj { get; set; }
        public string? Nome { get; set; }
        public DateTime DataFundacao { get; set; }
        public int? GrupoId { get; set; }
        public string? NomeGrupo { get; set; }

    }
}
