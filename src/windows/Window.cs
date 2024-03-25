namespace Watykanczyk.Windows;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Runtime.InteropServices;

public partial class Window : Form {
  public Window() {

    Random random = new Random();
    int x = random.Next(0, 1270);
    int y = random.Next(0, 920);
    this.StartPosition = FormStartPosition.Manual;
    this.Location = new Point(x, y);

    this.ShowInTaskbar = false;
    this.TopMost = true;

    InitializeComponent();
  }

  protected override CreateParams CreateParams {
    get {
      var cp = base.CreateParams;
      cp.ExStyle |= 0x80;
      return cp;
    }
  }
}
