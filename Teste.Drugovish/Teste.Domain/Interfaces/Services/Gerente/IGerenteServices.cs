using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Dtos.Cliente;
using Teste.Domain.Dtos.Gerente;

namespace Teste.Domain.Interfaces.Services.Gerente
{


    public interface IGerenteServices
    {
        Task<IEnumerable<GerenteDto>> GetAll();
        Task<GerenteDto> Login(string nome);
    }
}
