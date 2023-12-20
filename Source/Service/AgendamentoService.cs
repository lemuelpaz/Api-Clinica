using API.Model.Data;
using API.Source.Base.Contracts.Repository;
using API.Source.Base.Contracts.Service;

namespace API.Source.Service
{
    public class AgendamentoService : IAgendamentoService
    {

        #region Constructor
        private readonly IAgendamentoRepository _repository;
        public AgendamentoService(IAgendamentoRepository repository)
        {
            _repository = repository;
        }
        #endregion

        public async Task<Agendamento> Create(Agendamento createDTO)
        {
            return await _repository.Create(createDTO);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<Agendamento> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<List<Agendamento>> List()
        {
            return await _repository.List();
        }

        public async Task<Agendamento> Update(Agendamento updateDTO)
        {
            return await _repository.Update(updateDTO);
        }
    }
}
