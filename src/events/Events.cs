namespace Watykanczyk.Events;

using Watykanczyk.Windows;

class Event {
  public void RandomEvent() {
    NewWindow();
  }

  [STAThread]
  private void NewWindow() {
    ApplicationConfiguration.Initialize();

    Thread thread = new Thread(() => {
      Application.Run(new Window());
    });
    
    thread.SetApartmentState(ApartmentState.STA);
    thread.Start();
  }
}