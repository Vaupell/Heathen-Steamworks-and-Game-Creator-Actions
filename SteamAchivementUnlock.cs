namespace GameCreator.Core
{
    using System;
	using UnityEngine;
	using GameCreator.Variables;
	using HeathenEngineering.SteamworksIntegration;

	[AddComponentMenu("")]
	public class SteamAchivementUnlock :  IAction
	{
		public AchievementObject SteamAchievementToUnlock;


		public override bool InstantExecute(GameObject invoker, IAction[] actions, int index)
		{
			// Debug.Log(SteamAchievementToUnlock);
			SteamAchievementToUnlock.Unlock();

			return true;
		}


		#if UNITY_EDITOR
		public static new string NAME = "MVT/Heathen/Unlock Steam Achivement";
		#endif
	}
}
