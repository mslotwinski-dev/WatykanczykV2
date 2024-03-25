namespace Watykanczyk.Boot;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watykanczyk.Audio;
using Watykanczyk.Events;
  
class App {
  private Event Event = new Event();


  public void Init() {


    Audio.Play();

    while (true) {
      
      Event.RandomEvent();

      Thread.Sleep(5000);
    }

  }
}