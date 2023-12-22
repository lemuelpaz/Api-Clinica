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
            return await _context.Agendamento.ToListAsync();
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
