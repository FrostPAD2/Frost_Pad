﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class ResetFPS
    {
        public static void FixFPS()//By Frost
        {
            QualitySettings.globalTextureMipmapLimit = 1;
        }

    }
}
