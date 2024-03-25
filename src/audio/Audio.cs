namespace Watykanczyk.Audio;

using System.Media;
using System.Runtime.InteropServices;
using Watykanczyk.Properties;

class Audio {
  public static void Play() {
    new Thread(() => {
      SoundPlayer player = new SoundPlayer(Resources.Music);
      player.PlayLooping();
    }).Start();
  }
}