using System;
using System.Collections.Generic;
using System.Text;

namespace Frost_Safe_Paid.Mods
{
    internal class UpsaidDownHead
    {
        public static void UpsideDownHead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
        }
    }
}
