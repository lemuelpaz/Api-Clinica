using API.Model.Data;

namespace API.Source.Base.Contracts.Repository
{
    public interface IAgendamentoRepository
    {
        Task<Agendamento> Create(Agendamento createDTO);
        Task<Agendamento> Get(int id);
        Task<List<Agendamento>> List();
        Task<Agendamento> Update(Agendamento updateDTO);
        Task<bool> Delete(int id);
    }
}
