using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string? Cnpj { get; set; }
        public string? Nome { get; set; }
        public DateTime DataFundacao { get; set; }
        public Grupo Grupo { get; set; }
        public int? GrupoId { get; set; }


        

    }
}