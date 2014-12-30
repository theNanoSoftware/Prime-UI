using System;
using System.Threading;
using PrimeUI.UI;

namespace PrimeUI
{
     static class Program
     {
          [STAThread]
          static void Main()
          {
               UInterface.InitializeUI();
               UInterface.Show();
          }
     }
}
