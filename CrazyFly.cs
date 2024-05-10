using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class CrazyFly
    {
        public static void crazyFly()//By frost
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                GorillaLocomotion.Player.Instance.transform.position +=
                    GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 55f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector4.zero;
            }
        }
    }
}
