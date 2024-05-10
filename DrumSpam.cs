using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class DrumSpam
    {
        public static void drumSpam()//By Frost Lol
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
                {
     68 ,
     false,
     999999f
                });
            }
        }
    }
}

