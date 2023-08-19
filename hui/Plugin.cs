using Exiled.API.Features;

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
            Exiled.Events.Handlers.Player.Spawned += Respawn;
            Exiled.Events.Handlers.Warhead.Detonated += Detonate;
        }
        void Respawn(Exiled.Events.EventArgs.Player.SpawnedEventArgs player)
        {
            if(player.Player.Role == PlayerRoles.RoleTypeId.Scientist)
            {
                player.Player.SetAmmo(Exiled.API.Enums.AmmoType.Nato9, 100);
                player.Player.AddItem(ItemType.SCP500);
                player.Player.Health = 500;
            }
        }
        void Detonate()
        {
            foreach(Player player in Player.List)
            {
                player.Kill("☢️☢️☢️☢️");
            }
        }
    }
}
