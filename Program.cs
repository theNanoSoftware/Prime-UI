﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeUI
{
     static class Program
     {
          [STAThread]
          static void Main()
          {
               UI.InitializeWindow();
               UI.Show();
               UI.Close();
          }
     }
}
