using System.Reflection;
using HarmonyLib;
using Marsey.Config;
using Marsey.Handbreak;
using Marsey.Misc;
using Marsey.Stealthsey;

namespace Marsey.GameAssembly.Patches;

public static class DiscordRPC
{
    public static void Disable()
    {
        if (!MarseyConf.KillRPC) return;
        
        MarseyLogger.Log(MarseyLogger.LogType.DEBG, "DiscordRPC", "Disabling.");

        Helpers.PatchMethod(
            Helpers.TypeFromQualifiedName("Robust.Client.Utility.DiscordRichPresence"),
            "Initialize",
            typeof(DiscordRPC),
            "Skip",
            HarmonyPatchType.Prefix
            );
    }

    private static bool Skip() => false;
}