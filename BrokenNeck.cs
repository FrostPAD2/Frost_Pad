using System;
using System.Collections.Generic;
using System.Text;

namespace Frost_Safe_Paid.Mods
{
    internal class BrokenNeck
    {
        public static void brokenNeck()//By frost for Frost paid
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 90f;
        }

    }
}
