using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(GillaModMenu.Main), "GillaModMenu", "1.0.0", "Author")]
[assembly: MelonGame("com.playgilla", "Gilla")]

namespace GillaModMenu
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("GillaModMenu has loaded successfully!");
        }

        public override void OnUpdate()
        {
            // Put your mod menu toggle keys or cheat logic here
            if (Input.GetKeyDown(KeyCode.F1))
            {
                LoggerInstance.Msg("F1 pressed: Mod menu toggled!");
            }
        }
    }
}
