using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Program
    {
        public static void Main()
        {
            GameSettingsD i_GameSettingForm = new GameSettingsD();
            i_GameSettingForm.ShowDialog(); // open settings dialog
        }
    }
}
