using API.Model.Data;

namespace API.Source.Base.Contracts.Service
{
    public interface IHoraAgendamentoService
    {
        Task<HoraAgendamento> Create(HoraAgendamento createDTO);
        Task<HoraAgendamento> Get(int id);
        Task<List<HoraAgendamento>> List();
        Task<List<HoraAgendamento>> ListByProfissional(int? profissionalId);
        Task<HoraAgendamento> Update(HoraAgendamento updateDTO);
        Task<bool> Delete(int id);
    }
}
