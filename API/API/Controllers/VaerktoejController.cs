using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Repository;
using API.Models;
using API.Controllers.Requests;
using AutoMapper;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaerktoejController : ControllerBase
    {

        private readonly IVaerkToejRepository _repository;
        private readonly IMapper _mapper;

        public VaerktoejController(IVaerkToejRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: Vearktoej
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Vaerktoej>>> Get()
        {
            var result = await _repository.GetAll();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // GET: Vearktoej/Details/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Vaerktoej>> GetById(int id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        // GET: Vearktoej/Create
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody] VaerkToejRequest vaerktoejRequest)
        {

            var model = _mapper.Map<Vaerktoej>(vaerktoejRequest);

            try
            {
                await _repository.Add(model);
            }
            catch
            {
                return BadRequest();
            }

            return Ok();

        }

        // POST: Vearktoej/Create
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Put([FromBody] VaerkToejRequest vaerktoejRequest)
        {

            var model = _mapper.Map<Vaerktoej>(vaerktoejRequest);

            try
            {
                await _repository.Update(model);
            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }

        // GET: Vearktoej/Edit/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _repository.Remove(id);
            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
