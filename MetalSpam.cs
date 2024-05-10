using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class MetalSpam
    {
        public static void metalSpam()//By Frost Lol
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
                {
     18,
     false,
     999999f
                });

            }
        }
    }
}
