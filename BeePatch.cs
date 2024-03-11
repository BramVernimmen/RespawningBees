using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace RespawningBees
{
    [HarmonyPatch(typeof(BeeSwarm), "Disappear")]
    public class BeePatch
    {
        [HarmonyPostfix]
        public static void DisappearPostFix(BeeSwarm __instance)
        {
            var logSource = new ManualLogSource("RespawnableBeeHive");
            BepInEx.Logging.Logger.Sources.Add(logSource);
            logSource.LogInfo("Swarm has disappeared");
            __instance.HomeHive.Reset();
        }
    }
}
