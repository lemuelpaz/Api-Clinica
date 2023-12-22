using API.Model.Data;
using API.Source.Base.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoraAgendamentoController : ControllerBase
    {
        #region Constructor
        private readonly IHoraAgendamentoService _service;
        public HoraAgendamentoController(IHoraAgendamentoService service)
        {
            _service = service;
        }
        #endregion

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] HoraAgendamento createDTO)
        {
            try
            {
                var hora = await _service.Create(createDTO);
                return Ok(hora);
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
                var hora = await _service.Get(id);
                return Ok(hora);
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
                var hora = await _service.List();
                return Ok(hora);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("list/{profissionalId}")]
        public async Task<ActionResult> List(int? profissionalId)
        {
            try
            {
                var hora = await _service.ListByProfissional(profissionalId);
                return Ok(hora);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] HoraAgendamento updateDTO)
        {
            try
            {
                var hora = await _service.Update(updateDTO);
                return Ok(hora);
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
                var hora = await _service.Delete(id);
                return Ok(hora);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
