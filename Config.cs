using PulsarModLoader;

namespace PlayerZoom
{
    internal class Config
    {
        public static SaveValue<float> zoomLevel = new SaveValue<float>("player zoom level", 3f);
    }
}
