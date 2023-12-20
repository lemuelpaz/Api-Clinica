using API.Model;
using API.Model.Data;
using API.Source.Base.Contracts.Repository;
using API.Source.Base.SQL;
using Microsoft.EntityFrameworkCore;

namespace API.Source.Repository
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        #region Constructor
        private readonly DataContext _context;
        public AgendamentoRepository(DataContext context)
        {
            _context = context;
        }

        #endregion

        /// <summary>
        /// Cria novo
        /// </summary>
        /// <param name="createDTO"></param>
        /// <returns></returns>
        public async Task<Agendamento> Create(Agendamento createDTO)
        {
            _context.Add(createDTO);
            await _context.SaveChangesAsync();
            return createDTO;
        }


        /// <summary>
        /// Deleta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        public async Task<bool> Delete(int id)
        {
            var getAgendamento = await _context.Agendamento.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            if (getAgendamento == null)
                throw new Exception("Agendamento não encontrado!");
            _context.Agendamento.Remove(getAgendamento);
            return await _context.SaveChangesAsync() == 1;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Agendamento> Get(int id)
        {
            var agendamento = await _context.Agendamento.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            if (agendamento == null)
                throw new Exception("Agendamento não encontrado");
            return agendamento;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <returns></returns>
        public async Task<List<Agendamento>> List()
        {
            return await _context.Agendamento
                .Include(x => x.Medico)
                .Select(a => new Agendamento
                {
                    Id = a.Id,
                    Atendimento = a.Atendimento,
                    Horario = a.Horario,
                    MedicoId = a.MedicoId,
                    Observacao = a.Observacao,
                    Paciente = a.Paciente,
                    PacienteId = a.PacienteId,
                    Medico = new Medico
                    {
                        Id = a.Medico!.Id,
                        Nome = a.Medico.Nome,
                        Cpf = a.Medico.Cpf,
                        CargoAtribuido = a.Medico.CargoAtribuido,
                        Atendimento = a.Medico.Atendimento,
                        CreatedAt = a.Medico.CreatedAt,
                        Email = a.Medico.Email,
                        Idade = a.Medico.Idade,
                        Agendamento = a.Medico.Agendamento,
                        Paciente = a.Medico.Paciente,
                        Status = a.Medico.Status,
                        Telefone = a.Medico.Telefone,
                        UpdatedAt = a.Medico.UpdatedAt
                    },
                })
                .ToListAsync();
        }

        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateDTO"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Agendamento> Update(Agendamento updateDTO)
        {
            _context.Agendamento.Update(updateDTO);
            await _context.SaveChangesAsync();
            return updateDTO;
        }
    }
}
