using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.XR;
using UnityEngine;

namespace Frost_Safe_Paid.Mods
{
    internal class Breackaudiogun
    {
        public static void BreakAudiogun()//By Frost
        {
            RaycastHit GunHit;
            GameObject PointerObj;
            bool Rgrip = ControllerInputPoller.GripFloat(XRNode.RightHand) == 1f;
            bool Rtrigger = ControllerInputPoller.TriggerFloat(XRNode.RightHand) == 1f;
            Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, GorillaLocomotion.Player.Instance.rightControllerTransform.forward, out GunHit);
            if (Rgrip)
            {
                PointerObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                PointerObj.transform.position = GunHit.point;
                PointerObj.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                GameObject.Destroy(PointerObj.GetComponent<Collider>());
                GameObject.Destroy(PointerObj.GetComponent<Rigidbody>());
                PointerObj.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                GameObject.Destroy(PointerObj, Time.deltaTime);

                if (Rtrigger)
                {
                    {
                        if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                        {
                            GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
                            {
     18,83,91,68,69,
     false,
     999999f
                            });

                        }
                    }
                }
                if (!Rtrigger)
                {

                }
            }
            if (!Rgrip)
            {

            }
        }
    }
}
