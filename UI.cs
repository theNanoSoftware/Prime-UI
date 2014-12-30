using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeUI
{
     static class UI
     {
          private static Form _form;

          public static void InitializeWindow()
          {
               _form = new Form();
               _form.FormBorderStyle = FormBorderStyle.None;
               _form.WindowState = FormWindowState.Maximized;
          }

          public static void Show()
          {
               _form.ShowDialog();
          }

          public static void Close()
          {
               _form.Close();
          }

          public static void AddControl(Control c)
          {
               if (_form != null)
                    _form.Controls.Add(c);
          }
     }
}
