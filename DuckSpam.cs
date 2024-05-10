using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class FrogSpam
    {
        public static void frogSpam()//By Frost Lol
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
                {
     91 ,
     false,
     999999f
                });
            }
        }
    }
}
