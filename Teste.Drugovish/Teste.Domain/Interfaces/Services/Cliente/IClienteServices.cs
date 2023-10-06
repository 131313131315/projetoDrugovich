using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Dtos.Cliente;

namespace Teste.Domain.Interfaces.Services.Cliente
{
    public interface IClienteServices
    {        
        Task<IEnumerable<ClienteDto>> GetAll();
        Task<bool> Post(ClienteDto cliente);
        Task<bool> Put(ClienteDto cliente);
        Task<bool> Delete(int id);
    }
}
