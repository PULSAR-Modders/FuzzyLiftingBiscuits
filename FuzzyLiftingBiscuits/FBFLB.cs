using HarmonyLib;

namespace FuzzyLiftingBiscuits
{
    [HarmonyPatch(typeof(PLPlayerController))]
    [HarmonyPatch("HandleMovement")]
    class FBFLB
    {
        static void Postfix(ref float ___yVel, PLPawn ___MyPawn)
        {
            ___yVel += ___MyPawn.BiscuitMadnessAmt * 0.4f;
        }
    }
}
