using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repository;
using API.Models;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using API.Controllers.Requests;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaerktoejskasseController : ControllerBase
    {
        private readonly IVaerkToejsKasseRepository _repository;
        private readonly IMapper _mapper;

        public VaerktoejskasseController(IVaerkToejsKasseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET: api/<ToolboxController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Vaerktoejskasse>>> Get()
        {
            var result = await _repository.GetAll();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // GET api/<ToolboxController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Vaerktoejskasse>> GetById(int id)
        {
            var result = await _repository.GetById(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }

        // POST api/<ToolboxController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody] VaerktoejsKasseRequest vaerktoejskasseRequest)
        {

            var model = _mapper.Map<Vaerktoejskasse>(vaerktoejskasseRequest);

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

        // PUT api/<ToolboxController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Put([FromBody] VaerktoejsKasseRequest vaerktoejskasseRequest)
        {

            var model = _mapper.Map<Vaerktoejskasse>(vaerktoejskasseRequest);

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

        // DELETE api/<ToolboxController>/5
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
