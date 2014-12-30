using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrimeUI.UI
{
     class Display
     {
          public readonly string Name;
          public readonly Size Resolution;
          public readonly Rectangle Bounds;
          public readonly bool Primary;

          public Display(Screen s)
          {
               Name = s.DeviceName.Substring(4);
               Resolution = s.Bounds.Size;
               Primary = s.Primary;
               Bounds = s.Bounds;
          }

          public void ShowForm(Form f)
          {
               Rectangle bounds = Bounds;
               f.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
               f.ShowDialog();
          }
     }
}
