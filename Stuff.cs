using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Frost_Safe_Paid.Mods
{
    internal class Stuff
    {
        private static float projDebounceType;
        private static float projDebounce;

        //By IIDK not my code. you can get it from the pinned message or my message i give full credit to IIDK for making this
        public static void BetaFireProjectile(string projectileName, Vector3 position, Vector3 velocity, Color color, bool noDelay = false)
        {
            if (Time.time > projDebounce)
            {
                Vector3 startpos = position;
                Vector3 charvel = velocity;

                Vector3 oldVel = GorillaTagger.Instance.GetComponent<Rigidbody>().velocity;
                GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = charvel;
                SnowballThrowable fart = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/shoulder.R/upper_arm.R/forearm.R/hand.R/palm.01.R/TransferrableItemRightHand/SnowballRightAnchor").transform.Find("LMACF.").GetComponent<SnowballThrowable>();
                Vector3 oldPos = fart.transform.position;
                fart.randomizeColor = true;
                GorillaTagger.Instance.offlineVRRig.SetThrowableProjectileColor(false, color);
                fart.transform.position = startpos;
                fart.projectilePrefab.tag = projectileName;
                fart.OnRelease(null, null);
                try
                {
                    // RPCProtection();
                }
                catch { /*Skibidi*/ }
                GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = oldVel;
                fart.transform.position = oldPos;
                fart.randomizeColor = false;
                fart.projectilePrefab.tag = "SnowballProjectile";
                if (projDebounceType > 0f && !noDelay)
                {
                    projDebounce = Time.time + projDebounceType;
                }
            }
        }
    }
}

internal class Stuff
{
    public static void PISS()
    {
        if (ControllerInputPoller.instance.rightGrab)
        {
            Vector3 position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position + new Vector3(0.1f, 1f, 0.1f);
            Vector3 velocity = GorillaLocomotion.Player.Instance.bodyCollider.transform.forward * Time.deltaTime * 145f;
            BetaFireProjectile("Deadshot", position, velocity, new Color32(255, 204, 0, byte.MaxValue), false);
        }

    }

    private static void BetaFireProjectile(string v1, Vector3 position, Vector3 velocity, Color32 color32, bool v2)
    {
        throw new NotImplementedException();
    }
}


