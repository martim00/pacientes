using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacientes
{
    public class CommandManager
    {
        private Dictionary<String, IAction> commands = new Dictionary<string, IAction>();

        public void ActivateCommand(String commandId)
        {
            if (!commands.ContainsKey(commandId))
                throw new Exception("cant find command with id " + commandId);

            commands[commandId].Activate();
        }

        public void AddCommand(IAction command)
        {
            var commandId = command.GetType().Name;

            if (commands.ContainsKey(commandId))
                throw new Exception("command with id already registered:" + commandId);

            commands.Add(commandId, command);
        }
    }
}
