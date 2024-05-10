using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Tracers
    {
        public static void tracers()//Codded By Frost
        {
            if (PhotonNetwork.InLobby || PhotonNetwork.InRoom)
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    bool flag2 = !vrrig.isOfflineVRRig;
                    if (flag2)
                    {
                        GameObject gameObject = new GameObject("Line");
                        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
                        lineRenderer.startColor = (lineRenderer.endColor = Color.blue);
                        lineRenderer.startWidth = (lineRenderer.endWidth = 0.01f);
                        lineRenderer.positionCount = 2;
                        lineRenderer.SetPositions(new Vector3[]
                        {
             GorillaLocomotion.Player.Instance.rightControllerTransform.position,
             vrrig.transform.position
                        });
                        lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
                        UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                    }
                }
            }
        }
    }
}
