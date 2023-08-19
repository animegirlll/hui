using System;
using CommandSystem;
using Exiled.API.Features;

namespace hui
{
    [CommandHandler(typeof(ClientCommandHandler))]
    internal class damage : ICommand
    {
        public string Command => "changeinfo";
        public string[] Aliases => new string[] {"ci"};
        public string Description => "Меняет информацию об игровом персонаже";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            var player = Player.Get(sender);
            if(arguments.Count == 0)
            {
                player.CustomName = null;
            }
            else
            {
                string name = arguments[0];
                for(int i = 1; i < arguments.Count; i++)
                {
                    name += " " + arguments[i];
                }
                player.CustomName = name;
            }
            response = "Информация изменена";
            return true;
        }
    }
}
