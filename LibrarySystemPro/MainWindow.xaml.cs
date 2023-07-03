


using LibrarySystemPro.classlar;
using LibrarySystemPro.UController;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibrarySystemPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void brd_Sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uc_cagir.Uc_Ekle(Content_icerik,new ucBookList());
            //DBbaglanti.BagTest();
            //Versiyon.Content = DBbaglanti.BagDurum;
        }

        private void btn_Symbol_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

        private void btn_FullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState==WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                
            }
            else
            {
                this.WindowState = WindowState.Normal;
                
            }
        }

        //menü butons
        #region menubutonlar

        int secimdurumu;
        private void menubuton_BookList_Click_1(object sender, RoutedEventArgs e)
        {
            uc_cagir.Uc_Ekle(Content_icerik, new ucBookList());
            secimdurumu = 1;
            secilendurum();
        }
        private void menubuton_ReaderList_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu=2;
            secilendurum();
        }

        private void menubuton_EscrowList_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 3;
            secilendurum();
        }

        private void menubuton_OutOfTime_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 4;
            secilendurum();
        }

        private void menubuton_Settings_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 5;
            secilendurum();
        }

        private void menubuton_About_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 6;
            secilendurum();
        }

        //checked status
        void secilendurum()
        {
            if (secimdurumu==1)
            {
                menubuton_BookList.IsChecked = true;
            }
            else
            {
                menubuton_BookList.IsChecked=false;
            }
            if (secimdurumu == 2)
            {
                menubuton_ReaderList.IsChecked = true;
            }
            else
            {
                menubuton_ReaderList.IsChecked = false;
            }
            if (secimdurumu == 3)
            {
                menubuton_EscrowList.IsChecked = true;
            }
            else
            {
                menubuton_EscrowList.IsChecked = false;
            }
            if (secimdurumu == 4)
            {
                menubuton_OutOfTime.IsChecked = true;
            }
            else
            {
                menubuton_OutOfTime.IsChecked = false;
            }
            if (secimdurumu == 5)
            {
                menubuton_Settings.IsChecked = true;
            }
            else
            {
                menubuton_Settings.IsChecked = false;
            }
            if (secimdurumu == 6)
            {
                menubuton_About.IsChecked = true;
            }
            else
            {
                menubuton_About.IsChecked = false;
            }
        }
        #endregion
    }

}
