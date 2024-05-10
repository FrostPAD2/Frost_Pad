using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.XR;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class TAG_ALL
    {
        public static void TagAll()//By:Gkong on discord
        {
            bool flag;
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out flag);
            bool flag2 = flag;
            bool flag3 = flag2;
            if (flag3)
            {
                foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerListOthers)
                {
                    bool flag4 = player.UserId != PhotonNetwork.LocalPlayer.UserId;
                    bool flag5 = flag4;
                    if (flag5)
                    {
                        foreach (GorillaTagManager gorillaTagManager in GameObject.FindObjectsOfType<GorillaTagManager>())
                        {
                            bool flag6 = !gorillaTagManager.currentInfected.Contains(player);
                            bool flag7 = flag6;
                            if (flag7)
                            {
                                GorillaTagger.Instance.rigidbody.transform.position = GorillaGameManager.instance.FindPlayerVRRig(player).headMesh.transform.position;
                                GorillaTagger.Instance.rightHandTransform.transform.position = GorillaGameManager.instance.FindPlayerVRRig(player).headMesh.transform.position;
                                GorillaTagger.Instance.leftHandTransform.transform.position = GorillaGameManager.instance.FindPlayerVRRig(player).headMesh.transform.position;
                            }
                        }
                    }
                }
            }
        }
    }
}
