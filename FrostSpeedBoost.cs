using System;
using System.Collections.Generic;
using System.Text;

namespace Frost_Safe_Paid.Mods
{
    internal class FrostSpeedBoost
    {
        public static void FrostSpeedboost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 5.7f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 5.7f;
        }
    }
}
