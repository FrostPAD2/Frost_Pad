using System;
using System.Collections.Generic;
using System.Text;

namespace Frost_Safe_Paid.Mods
{
    internal class Fixhead
    {
        public static void FixHead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x = 0f;
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 0f;
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 0f;
        }
    }
}
