using System;

namespace Vehicle_Security
{
    public class Command_Factory
    {
        private Camera _camera;
        private Terminal _terminal;

        public Command_Factory(Camera camera, Terminal terminal)
        {
            _camera = camera;
            _terminal = terminal;
        }

        public Command_Format CreateCommands()
        {
            Command_Format commands = new Command_Format();

            CommandDRCM commandDRCM 
                = new CommandDRCM(_camera, _terminal);
            commands.Put(commandDRCM.GetName(), commandDRCM);

            CommandHDCM commandHDCM 
                = new CommandHDCM(_camera, _terminal);
            commands.Put(commandHDCM.GetName(), commandHDCM);

            CommandTRNKCM commandTRNKCM 
                = new CommandTRNKCM(_camera, _terminal);
            commands.Put(commandTRNKCM.GetName(), commandTRNKCM);

            ShowHelpCommand showHelp
                = new ShowHelpCommand(commands, _terminal);
            commands.Put(showHelp.GetName(),showHelp);


            return commands;
        }
    }
}