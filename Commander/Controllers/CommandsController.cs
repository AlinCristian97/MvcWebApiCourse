using Commander.Data;
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

        public CommandsController(ICommanderRepository repository)
        {
            _repository = repository;
        }

        // GET api/commands/
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommands()
        {
            var commands = _repository.GetCommands();

            return Ok(commands);
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommand(int id)
        {
            var command = _repository.GetCommand(id);

            return Ok(command);
        }
    }
}
