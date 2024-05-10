using System;
using System.Collections.Generic;
using System.Text;

namespace Frost_Safe_Paid.Mods
{
    internal class BreakAudio
    {
        public static void breakaudio()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
                {
     18,83,91,68,69,
     false,
     999999f
                });

            }
        }
    }
}

 
