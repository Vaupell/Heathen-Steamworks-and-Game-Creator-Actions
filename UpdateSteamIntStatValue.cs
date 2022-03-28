namespace GameCreator.Core
{
    using System;
    using UnityEngine;
    using GameCreator.Variables;
    using HeathenEngineering.SteamworksIntegration;

#if UNITY_EDITOR
    using UnityEditor;
#endif

    [AddComponentMenu("")]
    public class UpdateSteamIntStatValue : IAction
    {

        public IntStatObject StatToUpdate;
        public NumberProperty MVStatTime = new NumberProperty(0.0f);

        private void Start()
        {

        }

        public void UpdateMyStat(int value)
        {
            StatToUpdate.Value = value;
        }

#if UNITY_EDITOR
        public static new string NAME = "MVT/Heathen/Update Steam Int Stat";
#endif
    }
}
