using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrimeUI
{
     class Display
     {
          public readonly string Name;
          public readonly Size Resolution;
          public readonly bool Primary;

          public Display(Screen s)
          {
               Name = s.DeviceName.Substring(4);
               Resolution = s.Bounds.Size;
               Primary = s.Primary;
          }
     }
}
