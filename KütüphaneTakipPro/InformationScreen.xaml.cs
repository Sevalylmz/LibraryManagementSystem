using LibrarySystemPro.classlar.Parametreler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LibrarySystemPro
{
    /// <summary>
    /// Interaction logic for BilgiEkrani.xaml
    /// </summary>
    public partial class InformationScreen : Window
    {
        public InformationScreen()
        {
            InitializeComponent();
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;

            Hata();


        }

        void Hata()
        {
            if (Prm.Error == 0)
            {
                Yes_InformationScreen.Visibility = Visibility.Visible;
                No_InformationScreen.Visibility = Visibility.Hidden;
                img_Yes.Visibility = Visibility.Visible;
                img_No.Visibility = Visibility.Hidden;
                Information_Content.Content = Prm.InformationScreenContent;
                InformationScreen_Header.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF134187"));
                Information_Content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF134187"));

            }
            else
            {
                Yes_InformationScreen.Visibility = Visibility.Hidden;
                No_InformationScreen.Visibility = Visibility.Visible;
                img_Yes.Visibility = Visibility.Hidden;
                img_No.Visibility = Visibility.Visible;
                Information_Content.Content = Prm.InformationScreenContent;
                InformationScreen_Header.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF4CAF50"));
                Information_Content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF4CAF50"));
            }


            ///  7 saniye sonra kapan

            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(7)
            };

            timer.Tick += delegate (object sender, EventArgs e)
            {
                ((DispatcherTimer)timer).Stop();
                if (this.ShowActivated) this.Close();
            };

            timer.Start();
            }

        private void btn_InformationScreen_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }
