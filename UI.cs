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
          private static Display[] _availableDisplays;
          public static Display[] AvailableDisplays {
               get { return _availableDisplays; }
          }
          public static Display PrimaryDisplay
          {
               get { return _availableDisplays.FirstOrDefault(item => item.Primary); }
          }

          public static void InitializeUI()
          {
               _form = new Form {FormBorderStyle = FormBorderStyle.None, WindowState = FormWindowState.Maximized};
               _availableDisplays = Screen.AllScreens.Select(screen => new Display(screen)).ToArray();
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
