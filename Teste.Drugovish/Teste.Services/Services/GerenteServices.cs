using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Teste.Domain.Dtos.Gerente;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;
using Teste.Domain.Interfaces.Services.Gerente;

namespace Teste.Services.Services
{
    public class GerenteServices : IGerenteServices
    {

        private readonly IUnitOfWork<Gerente> _unitOfWork;

        private readonly IMapper _mapper;

        public GerenteServices(IUnitOfWork<Gerente> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<IEnumerable<GerenteDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<GerenteDto> Login(string nome)
        {            
            var retorno = await _unitOfWork.Repository.GetDataSet().Where(c => c.Nome == nome).FirstOrDefaultAsync();

            if (retorno != null)
            {
                return _mapper.Map<GerenteDto>(retorno);
            }
            throw new Exception("usernone");
        }
    }
}
