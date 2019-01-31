﻿using System.Windows.Forms;

namespace GitUIPluginInterfaces
{
    public interface ISettingControlBinding
    {
        /// <summary>
        /// Creates a control to be placed on FormSettings to edit this setting value
        /// Control should take care of scalability and resizability of its sub-controls
        /// </summary>
        Control GetControl();

        /// <summary>
        /// Loads setting value from settings to Control
        /// </summary>
        void LoadSetting(ISettingsSource settings, IGitModule gitModule);

        /// <summary>
        /// Saves value from Control to settings
        /// </summary>
        void SaveSetting(ISettingsSource settings, IGitModule gitModule);

        /// <summary>
        /// returns caption associated with this control or null if the control layouts
        /// the caption by itself
        /// </summary>
        string Caption();

        ISetting GetSetting();
    }
}
