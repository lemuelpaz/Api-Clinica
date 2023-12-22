using API.Model.Data;
using API.Source.Base.Contracts.Repository;
using API.Source.Base.Contracts.Service;

namespace API.Source.Service
{
    public class HoraAgendamentoService : IHoraAgendamentoService
    {

        #region Constructor
        private readonly IHoraAgendamentoRepository _repository;
        public HoraAgendamentoService(IHoraAgendamentoRepository repository)
        {
            _repository = repository;
        }
        #endregion

        public async Task<HoraAgendamento> Create(HoraAgendamento createDTO)
        {
            return await _repository.Create(createDTO);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.Delete(id);
        }

        public async Task<HoraAgendamento> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<List<HoraAgendamento>> List()
        {
            return await _repository.List();
        }

        public async Task<List<HoraAgendamento>> ListByProfissional(int? profissionalId)
        {
            return await _repository.ListByProfissional(profissionalId);
        }

        public async Task<HoraAgendamento> Update(HoraAgendamento updateDTO)
        {
            return await _repository.Update(updateDTO);
        }
    }
}
