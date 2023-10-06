using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Enum;

namespace Teste.Domain.Dtos.Gerente
{
    public class GerenteDto
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public NivelGerente Nivel { get; set; }
    }
}
