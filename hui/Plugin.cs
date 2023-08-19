using System;
using System.Collections.Generic;
using System.Text;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using PluginAPI;
using Exiled.API.Interfaces;

namespace hui
{
    public class Plugin : Plugin<Config>
    {
        public override void OnEnabled()
        {
            RegisterEvents();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            base.OnDisabled();
        }
        public void RegisterEvents()
        {
        }
        void Respawn()
        {

        }
    }
}
