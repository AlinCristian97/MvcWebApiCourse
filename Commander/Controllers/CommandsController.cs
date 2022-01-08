using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Controllers
{
    // api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepository _repository;
        private readonly IMapper _mapper;

        public CommandsController(
            ICommanderRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/commands/
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetCommands()
        {
            var commands = _repository.GetCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }

        // GET api/commands/{id}
        [HttpGet("{id}", Name = "GetCommand")]
        public ActionResult<CommandReadDto> GetCommand(int id)
        {
            var command = _repository.GetCommand(id);

            if (command != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(command));
            }

            return NotFound();
        }

        // POST api/commands
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandWriteDto commandWriteDto)
        {
            var commandModel = _mapper.Map<Command>(commandWriteDto);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommand), new { Id = commandReadDto.Id }, commandReadDto);
        }
    }
}
