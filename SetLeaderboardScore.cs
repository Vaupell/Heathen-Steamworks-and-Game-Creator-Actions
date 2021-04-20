namespace GameCreator.Core
{
    using System;
    using UnityEngine;
    using GameCreator.Variables;
    using HeathenEngineering.SteamAPI;
    using Steamworks;

#if UNITY_EDITOR
    using UnityEditor;
#endif

    [AddComponentMenu("")]
    public class SetLeaderboardScore : IAction
    {

        public LeaderboardObject Leaderboard;
        public NumberProperty MVStatTime = new NumberProperty(0.0f);

        private void Start()
        {

        }

        public void UpdateMyStat(int value)
        {
            Leaderboard.UploadScore(value, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest);
        }

#if UNITY_EDITOR
        public static new string NAME = "MVT/Heathen/Set Leaderboard Score";
#endif
    }
}
