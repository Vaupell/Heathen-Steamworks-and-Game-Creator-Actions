namespace GameCreator.Core
{
    using System;
    using UnityEngine;
    using GameCreator.Variables;
    using HeathenEngineering.SteamApi.Foundation;

#if UNITY_EDITOR
    using UnityEditor;
#endif

    [AddComponentMenu("")]
    public class UpdateSteamStatValue : IAction
    {

        public SteamIntStatData StatToUpdate;
        public NumberProperty MVStatTime = new NumberProperty(0.0f);

        private void Start()
        {

        }

        public void UpdateMyStat(int NewIntValue)
        {
            StatToUpdate.SetIntStat(NewIntValue);
        }

#if UNITY_EDITOR
        public static new string NAME = "MVT/Heathen/Update Steam Stat";
#endif
    }
}
