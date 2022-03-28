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
    public class UpdateSteamFloatStatValue : IAction
    {

        public FloatStatObject StatToUpdate;
        public NumberProperty MVStatTime = new NumberProperty(0.0f);

        private void Start()
        {

        }

        public void UpdateMyStat(float value)
        {
            StatToUpdate.Value = value;
        }

#if UNITY_EDITOR
        public static new string NAME = "MVT/Heathen/Update Steam Float Stat";
#endif
    }
}
