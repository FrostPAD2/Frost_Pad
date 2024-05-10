using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class A_dissconect
    {
        public static void Adissconnect()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                PhotonNetwork.Disconnect();
            }
;
        }
    }
}
