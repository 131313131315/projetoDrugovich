using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Teste.Domain.Dtos.Grupo;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;
using Teste.Domain.Interfaces.Services.Grupo;

namespace Teste.Services.Services
{
    public class GrupoServices : IGrupoServices
    {
        private readonly IUnitOfWork<Grupo> _unitOfWork;
        private readonly IUnitOfWork<Cliente> _unitOfWorkCliente;
        private readonly IMapper _mapper;

        public GrupoServices(IUnitOfWork<Grupo> unitOfWork, IMapper mapper, IUnitOfWork<Cliente> unitOfWorkCliente)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _unitOfWorkCliente = unitOfWorkCliente;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var retorno = _unitOfWorkCliente.Repository.GetDataSet().Where(c => c.GrupoId == id).FirstOrDefaultAsync();

                if (retorno != null)
                {
                    await _unitOfWork.Repository.DeleteAsync(id);
                    return true;
                }
                else
                {
                    return false;
                }                
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<GrupoDto>> GetAll()
        {
            var grupo = await _unitOfWork.Repository.SelectAsync();
            return _mapper.Map<IEnumerable<GrupoDto>>(grupo);
        }

        public async Task<bool> Post(GrupoDto grupo)
        {
            try
            {                
                var result = await _unitOfWork.Repository.InsertAsync(_mapper.Map<Grupo>(grupo));
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<bool> Put(GrupoDto grupo)
        {
            try
            {                
                var result = await _unitOfWork.Repository.UpdateAsync(_mapper.Map<Grupo>(grupo));
                return true;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
