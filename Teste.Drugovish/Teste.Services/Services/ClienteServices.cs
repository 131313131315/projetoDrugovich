using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Teste.Domain.Dtos.Cliente;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;
using Teste.Domain.Interfaces.Services.Cliente;

namespace Teste.Services.Services
{
    public class ClienteServices : IClienteServices
    {

        private readonly IUnitOfWork<Cliente> _unitOfWork;

        private readonly IMapper _mapper;

        public ClienteServices(IUnitOfWork<Cliente> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var result = await _unitOfWork.Repository.DeleteAsync(id);
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<ClienteDto>> GetAll()
        {

            var retorno = new List<ClienteDto>();

            var cliente = await _unitOfWork.Repository.GetDataSet().Include(c => c.Grupo).ToListAsync();

            foreach (var item in cliente)
            {
                retorno.Add(new ClienteDto
                {
                    DataFundacao = item.DataFundacao,
                    NomeGrupo = item.Grupo.Nome,
                    Nome = item.Nome,
                    Cnpj = item.Cnpj,
                    Id = item.Id,
                });
            }

            return retorno;
        }

        public async Task<bool> Post(ClienteDto cliente)
        {
            try
            {                
                var result = await _unitOfWork.Repository.InsertAsync(_mapper.Map<Cliente>(cliente));
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public async Task<bool> Put(ClienteDto cliente)
        {
            try
            {                
                var result = await _unitOfWork.Repository.UpdateAsync(_mapper.Map<Cliente>(cliente));
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


    }
}
