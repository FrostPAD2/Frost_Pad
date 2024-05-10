using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frost_Safe_Paid.Mods
{
    internal class Scream
    {
        public static void scream()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
                {
     75,
     false,
     999999f
                });

            }
        }
    }
}
    

