using System;
using CommandSystem;
using Exiled.API.Features;

namespace hui
{
    [CommandHandler(typeof(ClientCommandHandler))]
    internal class damage : ICommand
    {
        public string Command => "changenickname";
        public string[] Aliases => new string[] {"cn", "changenick"};
        public string Description => "Меняет ваш уебанский никнейм";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            var player = Player.Get(sender);
            if(arguments.Count != 1)
            {
                response = "Еблан?";
                return false;
            }
            else
            {
                player.CustomName = arguments[0];
                response = "Никнейм изменён";
                return true;
            }
        }
    }
}
