namespace Watykanczyk.Windows;

using Watykanczyk.Memes;

partial class Window {
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }


  private void InitializeComponent() {
    this.components = new System.ComponentModel.Container();
    this.SuspendLayout();

    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
    this.BackgroundImage = Meme.New();
    this.ClientSize = new System.Drawing.Size(450, 300);
    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    this.Text = "Zostłeś spapieżowany";

  }

}
