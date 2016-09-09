using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebmanAPI
{
    class webmanapi
    {

        /// <summary>
        /// Class By @FxckingCoder
        /// Check the below link for updates to this class
        /// Thanks for all the support :D
        /// http://www.GitHub.com/FxckingCoder
        /// </summary>
        
        private WebClient c = new WebClient();

        #region Ps3 On - Off
        /// <summary>
        /// Restarts the current ps3
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Restart(string ip)
        {
            return c.DownloadString($"http://{ip}/restart.ps3");
        }

        /// <summary>
        /// Turns off current ps3
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Shutdown(string ip)
        {
            return c.DownloadString($"http://{ip}/shutdown.ps3");
        }
        #endregion

        #region Disc Games
        /// <summary>
        /// Ejects current game
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Eject(string ip)
        {
            return c.DownloadString($"http://{ip}/eject.ps3");
        }

        /// <summary>
        /// Inserts a disc
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Inject(string ip)
        {
            return c.DownloadString($"http://{ip}/inject.ps3");
        }
        #endregion

        #region Digital Games
        /// <summary>
        /// Unmount current game
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Unmount(string ip)
        {
            return c.DownloadString($"http://{ip}/mount.ps3/unmount");
        }

        /// <summary>
        /// External game data
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3External(string ip)
        {
            return c.DownloadString($"http://{ip}/extgd.ps3");
        }

        /// <summary>
        /// Refresh game files
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Refresh(string ip)
        {
            return c.DownloadString($"http://{ip}/refresh.ps3");
        }
        #endregion

        #region Set idps & psid
        /// <summary>
        /// Set idps
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change idps in lv2 memory at system startup</param>
        /// <returns></returns>
        public string ps3SetIdps1(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?idps1={id}");
        }

        /// <summary>
        /// Set idps2
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change idps2 in lv2 memory at system startup</param>
        /// <returns></returns>
        public string ps3SetIdps2(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?idps2={id}");
        }

        /// <summary>
        /// Set psid
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change psid in lv2 memory at system startup</param>
        /// <returns></returns>
        public string ps3SetPsid1(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?psid1={id}");
        }

        /// <summary>
        /// Set psid2
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="id">Change psid2 in lv2 memory at system startup</param>
        /// <returns></returns>
        public string ps3SetPsid2(string ip, string id)
        {
            return c.DownloadString($"http://{ip}/setidps.ps3mapi?psid2={id}");
        }
        #endregion

        #region Ring Buzzers
        /// <summary>
        /// Single beep
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Single(string ip)
        {
            return c.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=1");
        }

        /// <summary>
        /// Double beep
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Double(string ip)
        {
            return c.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=2");
        }

        /// <summary>
        /// Triple beep
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3Triple(string ip)
        {
            return c.DownloadString($"http://{ip}/buzzer.ps3mapi?mode=3");
        }
        #endregion

        #region Led Colors
        /// <summary>
        /// Change ps3 led to red
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3RedLed(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?color=0");
        }

        /// <summary>
        /// Change ps3 led to green
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3GreenLed(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?color=1");
        }

        /// <summary>
        /// Change ps3 led to yellow
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3YellowLed(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?color=2");
        }
        #endregion

        #region Led Modes
        /// <summary>
        /// Ps3 led off
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3LedOff(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=0");
        }

        /// <summary>
        /// Ps3 led on
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3LedOn(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=1");
        }

        /// <summary>
        /// Makes ps3 led blink fast
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3LedBlinkFast(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=2");
        }

        /// <summary>
        /// Makes ps3 led blink slowly
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <returns></returns>
        public string ps3LedBlinkSlow(string ip)
        {
            return c.DownloadString($"http://{ip}/led.ps3mapi?mode=3");
        }
        #endregion

        #region Mount HDD Game
        /// <summary>
        /// Mount a game from your HDD
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="region">games region code Example- blus00000 or bles00000</param>
        /// <param name="game">name of the game you want to mount - must be spelled correctly with a space between each word Example - 'Grand Theft Auto V' or 'Call of Duty Black Ops II'</param>
        /// <returns></returns>
        public string ps3MountGame(string ip, string region, string game)
        {
            return c.DownloadString($"http://{ip}/mount.ps3/dev_hdd0/GAMES/{region}-[{game}]");
        }
        #endregion

        #region Notify Message
        /// <summary>
        /// Custom notify message
        /// </summary>
        /// <param name="ip">ps3 local ip</param>
        /// <param name="message">notify message</param>
        /// <returns></returns>
        public string ps3Notify(string ip, string message)
        {
            return c.DownloadString($"http://{ip}/notify.ps3mapi?msg={message}");
        }
        #endregion
    }
}

