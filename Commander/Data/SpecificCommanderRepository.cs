using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SpecificCommanderRepository : ICommanderRepository
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public Command GetCommand(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "Boil an egg",
                Line = "Boil water",
                Platform = "Kettle & Pan"
            };
        }

        public IEnumerable<Command> GetCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg1", Line = "Boil water1", Platform = "Kettle & Pan1" },
                new Command { Id = 1, HowTo = "Boil an egg2", Line = "Boil water2", Platform = "Kettle & Pan2" },
                new Command { Id = 2, HowTo = "Boil an egg3", Line = "Boil water3", Platform = "Kettle & Pan3" },
                new Command { Id = 3, HowTo = "Boil an egg4", Line = "Boil water4", Platform = "Kettle & Pan4" },
            };

            return commands;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
