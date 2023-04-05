namespace Vehicle_Security
{
    
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Camera camera = new Camera();
            Terminal _terminal = new Terminal();
            
            Command_Factory factory = new Command_Factory(camera, _terminal);
            Command_Format commands = factory.CreateCommands();
            
            commands.Get("").Execute();
            while (true)
            {
                string name = _terminal.ReadString("VS> ");
                commands.Get(name).Execute();     
            }
        }

    }
}