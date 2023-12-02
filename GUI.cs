using static UnityEngine.GUILayout;
using PulsarModLoader.CustomGUI;
using UnityEngine;

namespace PlayerZoom
{
    internal class GUI : ModSettingsMenu
    {
        public override string Name()
        {
            return Mod.Instance.Name;
        }

        public override void Draw()
        {
            Config.zoomLevel.Value = Mathf.Round(HorizontalSlider(Config.zoomLevel.Value, 1f, 10f)*10)/10;
            Label($"Zoom level: {Config.zoomLevel.Value}");
        }
    }
}
