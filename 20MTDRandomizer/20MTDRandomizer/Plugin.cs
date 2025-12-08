using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace _20MTDRandomizer;

[BepInPlugin("com.oig.20MTDRandomizer", "randomizer", "1.0.0")]
[BepInProcess("MinutesTillDawn.exe")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;

        try
        {
            Harmony.CreateAndPatchAll(typeof(Patch.GetPowerupPoolPatch));
        }
        catch (System.Exception e)
        {
            Logger.LogError($"an error occurred during plugin randomizer initialization: {e.Message}");
        }

        Logger.LogInfo($"Plugin randomizer is loaded!");
    }

    private void OnDestroy()
    {
        Harmony.UnpatchAll();
    }
}
