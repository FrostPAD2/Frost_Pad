using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class TurkeySpam
    {
        public static void turkeySpam()//By Frost Lol
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
                {
     83 ,
     false,
     999999f
                });
            }
        }
    }
}
    
