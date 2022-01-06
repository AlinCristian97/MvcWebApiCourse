using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetCommands();
        Command GetCommand(int id);
    }
}
