using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Dtos.Cliente;
using Teste.Domain.Dtos.Grupo;

namespace Teste.Domain.Interfaces.Services.Grupo
{
    public interface IGrupoServices
    {
        Task<IEnumerable<GrupoDto>> GetAll();
        Task<bool> Post(GrupoDto grupo);
        Task<bool> Put(GrupoDto grupo);
        Task<bool> Delete(int id);
    }
}
