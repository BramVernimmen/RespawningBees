using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace RespawningBees
{
    [BepInPlugin("Pro192.uch.RespawningBees", "Respawning Bees", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
