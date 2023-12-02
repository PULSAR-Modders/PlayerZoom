using HarmonyLib;
using System.Reflection;

namespace PlayerZoom
{
    [HarmonyPatch(typeof(PLCameraMode_LocalPawn), "GetFOV")]
    internal class CameraMode_LocalPawn
    {
        private static MethodInfo getButtonMethod = PLInput.Instance.GetType().GetMethod("GetButton", BindingFlags.NonPublic | BindingFlags.Instance, null, new System.Type[] { typeof(string), typeof(PLInputAction) }, null);
        static void Postfix(ref float __result)
        {
            if ((bool)getButtonMethod.Invoke(PLInput.Instance, new object[] { "playerzoom", null }))
            {
                __result /= Config.zoomLevel.Value;
            }
        }
    }
}
