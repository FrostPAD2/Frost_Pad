using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class NormalSky
    {
        public static void normalSky()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>().material.shader = Shader.Find("Gorilla/DayNightLerpSkyMaterial");
        }

    }
}
