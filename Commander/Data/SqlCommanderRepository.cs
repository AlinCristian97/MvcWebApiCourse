using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepository : ICommanderRepository
    {
        public Command GetCommand(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetCommands()
        {
            throw new NotImplementedException();
        }
    }
}
