using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace LibrarySystemPro.classlar
{
    public class Bonus
    {
        
        public static void PopupShow(Popup popup)
        {
            popup.IsOpen = true;
            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(4)
            };

            timer.Tick += delegate (object sender, EventArgs e)
            {
                ((DispatcherTimer)timer).Stop();
                if (popup.IsOpen)
                {
                    popup.IsOpen = false;
                }
            };
            timer.Start();

        }
    }
}
