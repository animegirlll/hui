using System;
using System.Collections.Generic;
using CommandSystem;
using Exiled.API.Features;
using MEC;

namespace hui
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    internal class damage : ICommand
    {
        public string Command => "damage";
        public string[] Aliases => new string[] { };
        public string Description => "Нахуй ломает системы все нахуй комплекса";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Готово ебать";
            return true;
        }
        public IEnumerator<float> Activation()
        {
            Cassie.Message("<color=#FF0000> Внимание! </color> Системам комплекса нанесены критические <color=#FF0000> п̀̿̐о̓̀͡в̄̄͡р̿̓͟еж̜̒͞д̮̀е̙̃͠ния! <color=#ffffff00>h pitch_0.9 Attention . Facility systems have critical jam_004_4 damage pitch_0.3 . jam_004_2 .g1 .g2 </color>", false, false, true);
            while (Cassie.IsSpeaking)
            {
                yield return Timing.WaitForOneFrame;
            }
            var plug = Plugin<>;
        }
    }
}
