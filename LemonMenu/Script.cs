#if FIVEM
using System.Threading.Tasks;
using Script = CitizenFX.Core.BaseScript;
#elif SHVDN3
using GTA;
#endif
using System;

namespace LemonMenu
{
    /// <summary>
    /// The main script for the entire menu system.
    /// </summary>
    public class LemonMenu : Script
    {
        #region Constructors

        public LemonMenu()
        {
            Tick += OnTick;
        }

        #endregion
        
        #region Events

        #if FIVEM
        private async Task OnTick()
        #elif SHVDN3
        private void OnTick(object sender, EventArgs e)
        #endif
        {
        }

        #endregion
    }
}
