namespace Vehicle_Security
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Text;

    public class Command_Format
    {
        private Dictionary<String, CommandBase> _MenuCommands 
            = new Dictionary<String, CommandBase>();
        
        public Command_Format() {}

        public List<CommandBase> AsList()
        {
            List<CommandBase> commands = new List<CommandBase>();
            commands.AddRange(_MenuCommands.Values);
            return commands;
        }

        public CommandBase Get(string name)
        {
            CommandBase result = null;
            if (_MenuCommands.ContainsKey(name))
            {
                result = _MenuCommands[name];
            }
            return result;
        }

        public void Put(string name, CommandBase command)
        {
            if (!_MenuCommands.ContainsKey(name))
            {
                _MenuCommands[name] = command;
            }
        }
        
    }

}