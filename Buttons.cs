using Frost_Safe_Paid.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = " Join Discord", method =() => Discord.JoinDiscord(), toolTip = "Join for More Updates. UND", isTogglable = false },
                new ButtonInfo { buttonText = " SpeedBoost", method =() => SpeedBoost.speedboost(), toolTip = "Gives you a lil speed boost. UND", isTogglable = true},
                new ButtonInfo { buttonText = " LoudHandTaps", method =() => LoudHandTap.LoudHandTaps(), toolTip = "Makes Your Hand Taps REALLY Loud. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Join Random", method =() => JoinRandom.joinrandom(), toolTip = "Auto Connects You Too A Room. UND", isTogglable = true},
                new ButtonInfo { buttonText = "MetalSpam", method =() => MetalSpam.metalSpam(), toolTip = "B On Controller. UND", isTogglable = true},
                new ButtonInfo { buttonText = "NoTagFreeze", method =() => NoTagFreeze.Notagfreeze(), toolTip = "No Tag Freeze. UND", isTogglable = true},
                new ButtonInfo { buttonText = "Tracers", method =() => Tracers.tracers(), toolTip = "Still A Bit Buggy. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "GreenSky", method =() => GreenSky.greenSky(), toolTip = "Makes The Sky Green. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "NormalSky", method =() => NormalSky.normalSky(), toolTip = "Makes The Sky Normal. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "PlatForms", method =() => PLATFORMS.PlatformsMod(), toolTip = "PlatForms. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "Anti Lemming", method =() => Anti_Lemming.antiLemming(), toolTip = "HEHEHE. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "Normal Handtaps", method =() => NormalHandTaps.normalHandTaps(), toolTip = "Normal HandTaps. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "FpsBoost", method =() => FpsBoost.LilFpsBoost(), toolTip = "Fps Boost. UND", isTogglable = true},
                  new ButtonInfo { buttonText = "ResetFPS", method =() => ResetFPS.FixFPS(), toolTip = "Normal Fps. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "CrazyFly", method =() => CrazyFly.crazyFly(), toolTip = "Crazy fly. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "FrogSpam", method =() => FrogSpam.frogSpam(), toolTip = "frog spammer. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "TurkeySpam", method =() => TurkeySpam.turkeySpam(), toolTip = "Turkey spammer. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "DrumSpam", method =() => DrumSpam.drumSpam(), toolTip = "Drum spammer. UND", isTogglable = true},
                 new ButtonInfo { buttonText = "JumpBoost", method =() => SuperJump.Superjump(), toolTip = "Super Jump. UND", isTogglable = true},
                   new ButtonInfo { buttonText = "upsidedown Head", method =() => UpsaidDownHead.UpsideDownHead(), toolTip = "Puts Your Head Upside Down. UND", isTogglable = true},
                    new ButtonInfo { buttonText = "Broken Neck", method =() => BrokenNeck.brokenNeck(), toolTip = "Broken Neck. UND", isTogglable = true},
                    new ButtonInfo { buttonText = "Fix Head", method =() => Fixhead.FixHead(), toolTip = "Fixes head. UND", isTogglable = true},
                    new ButtonInfo { buttonText = "FrostSpeedBoost", method =() => FrostSpeedBoost.FrostSpeedboost(), toolTip = "Hehehehehehehe. UND", isTogglable = true},
                    new ButtonInfo { buttonText = "Scream", method =() => Scream.scream(), toolTip = "Playes A High Pitch Audio. UND", isTogglable = true},

            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
                new ButtonInfo { buttonText = "Keep On", method =() => KeepOn.Kepponplz(), isTogglable = false, toolTip = "Motd Text."},
                new ButtonInfo { buttonText = "RandomNoti", method =() => RandomNoti.RandomNoti1(), toolTip = "Randokm notification. UND", isTogglable = false},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
