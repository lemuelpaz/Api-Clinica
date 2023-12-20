using API.Model.Data;
using API.Source.Base.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        #region Constructor
        private readonly IAgendamentoService _service;
        public AgendamentoController(IAgendamentoService service)
        {
            _service = service;
        }
        #endregion

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Agendamento createDTO)
        {
            try
            {
                var agendamento = await _service.Create(createDTO);
                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var agendamento = await _service.Get(id);
                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("list")]
        public async Task<ActionResult> List()
        {
            try
            {
                var agendamento = await _service.List();
                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Agendamento updateDTO)
        {
            try
            {
                var agendamento = await _service.Update(updateDTO);
                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var agendamento = await _service.Delete(id);
                return Ok(agendamento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
