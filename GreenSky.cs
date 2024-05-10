using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class GreenSky
    {
        public static void greenSky()//ngl this took me a min lol
        {
            Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
            SkyObject.material.color = Color.green;
        }
    }
}
