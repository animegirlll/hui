using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerAPI = Exiled.Events.Handlers.Player;
using Exiled.Events.EventArgs.Server;
using System.Collections.Generic;
using MEC;

namespace hui
{
    public class Plugin : Plugin<Config>
    {
        public bool damage;
        public override void OnDisabled()
        {
            base.OnDisabled();
        }

        public override void OnEnabled()
        {
            base.OnEnabled();
            RegisterEvent();
        }
        public void RegisterEvent()
        {
            Exiled.Events.Handlers.Server.RespawningTeam += Respawn;
        }
        public void Respawn(RespawningTeamEventArgs team)
        {
            if(damage)
            {
                Timing.RunCoroutine(RespawnCustom());
            }
        }
        public IEnumerator<float> RespawnCustom()
        {
            yield return Timing.WaitForOneFrame;
            Cassie.Clear();
            Cassie.Message("Отряд Мобильной Оперативной Группы <color=#0000ff>Эпсилон-11</color> обозначенный как <color=#FF0000>[неизвестный отряд]</color> прибыл в комплекс. \nВсему персоналу рекомендуется действовать согласно стандартным протоколам эвакуации, пока отряд МОГ не прибудет к месту назначения. Ожидают сдерживания <color=#FF0000>[ошибка подсчёта] SC̅͟P͐̅̚-о̇̌͠б̉̇̋ъ͙͂е͊̋̉к̟͂т͐̈ов <color=#ffffff00>h pitch_0.95 MtfUnit Epsilon 11 jam_050_2 designated yield_1 pitch_0.9 jam_004_2 unknown unit pitch_0.95 has entered the facility . pitch_0.5 .g5 pitch_0.95 Allremaining pitch_0.9 . jam_050_2 uncalculatedscpsleft pitch_0.8 . yield_2 pitch_0.2 jam_001_2 .g2 . </color>", false, false, true);
        }
    }
}

