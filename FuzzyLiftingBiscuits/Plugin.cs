using PulsarPluginLoader;

namespace FuzzyLiftingBiscuits
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.1.1";

        public override string Author => "Kell.Engbot, Modified by Dragon";

        public override string ShortDescription => "Biscuits get you hiGH";

        public override string Name => "FuzzyLiftingBiscuits";

        public override string HarmonyIdentifier()
        {
            return "Kell.EngBot.Pulsar.FLBs";
        }
    }
}
