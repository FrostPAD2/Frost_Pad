using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class KeepOn
    {
        public static void Kepponplz()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/motd").GetComponent<UnityEngine.UI.Text>().text = "Frost Safe Client";



            GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/UI/motd/motdtext").GetComponent<UnityEngine.UI.Text>().text = "Thanks For Using Frost Safe Cleint, this client is made too be used in Modded lobbys. ANY BANS OUTSIDE OF MODDED LOBBYS ARE NOT OUR FAULT.if u are banned while in a modded lobby please let us know in the discord.";
        }
    }
}
