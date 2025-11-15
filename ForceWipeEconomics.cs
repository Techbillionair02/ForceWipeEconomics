using Oxide.Core.Plugins;
using System;

namespace Oxide.Plugins
{
    [Info("ForceWipeEconomics", "GaryG", "1.0.0")]
    public class ForceWipeEconomics : CovalencePlugin
    {
        [PluginReference] private Plugin Economics;

        private bool wipedThisBoot = false;

        private void OnServerInitialized()
        {
            if (Economics == null)
            {
                PrintWarning("Economics plugin not found — cannot wipe balances.");
                return;
            }

            if (IsForceWipeDay() && !wipedThisBoot)
            {
                PrintWarning("FORCE WIPE detected — wiping all Economics balances...");
                Economics.Call("WipeBalance");
                wipedThisBoot = true;
            }
        }

        private bool IsForceWipeDay()
        {
            DateTime now = DateTime.UtcNow;

            // Force wipe = first Thursday of each month
            if (now.Day > 7) return false;
            if (now.DayOfWeek != DayOfWeek.Thursday) return false;

            return true;
        }
    }
}
