using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Anti_Lemming
    {
        public static void antiLemming()//By Frost!
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (!vrrig.isOfflineVRRig && vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAD"))
                {
                    PhotonNetwork.Disconnect();
                    NotifiLib.SendNotification("<color=red>[ANTI-MODERATOR]</color> Frost Just Saved You <3.");
                }
            }
        }
    }
}
