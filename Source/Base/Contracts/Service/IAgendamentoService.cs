using API.Model.Data;

namespace API.Source.Base.Contracts.Service
{
    public interface IAgendamentoService
    {
        Task<Agendamento> Create(Agendamento createDTO);
        Task<Agendamento> Get(int id);
        Task<List<Agendamento>> List();
        Task<Agendamento> Update(Agendamento updateDTO);
        Task<bool> Delete(int id);
    }
}
