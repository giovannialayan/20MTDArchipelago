using System.Collections.Generic;
using UnityEngine;
using flanne;
using HarmonyLib;

namespace _20MTDRandomizer.Patch;

[HarmonyPatch(typeof(PowerupGenerator), "GetPowerupPool")]
class GetPowerupPoolPatch
{
    private static void Postfix(ref List<PowerupPoolItem> __result)
    {
        //replace __result with powerups from archipelago world
        Debug.Log("GetPowerupPoolPatch Postfix called");
    }
}