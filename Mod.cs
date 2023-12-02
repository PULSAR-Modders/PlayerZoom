using PulsarModLoader;
using PulsarModLoader.Keybinds;

namespace PlayerZoom
{
    public class Mod : PulsarMod, IKeybind
    {
        public static Mod Instance { get; private set; }

        public Mod()
        {
            Instance = this;
        }

        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Provides a keybind to zoom in";

        public override string Name => "Player Zoom";

        public override string ModID => "playerzoom";

        public override string HarmonyIdentifier()
        {
            return "id107.playerzoom";
        }

        public void RegisterBinds(KeybindManager manager)
        {
            manager.NewBind("Zoom Player", "playerzoom", "Basics", "MOUSE2");
        }
    }
}
