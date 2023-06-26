


using KütüphaneTakipPro.classlar;
using KütüphaneTakipPro.UKontroller;
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

namespace KütüphaneTakipPro
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

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void brd_Sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uc_cagir.Uc_Ekle(Content_icerik,new ucKitapListesi());
            //DBbaglanti.BagTest();
            //Versiyon.Content = DBbaglanti.BagDurum;
        }

        private void btn_SimgeDurumu_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

        private void btn_TamEkran_Click(object sender, RoutedEventArgs e)
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
        private void menubuton_kitaplistesi_Click_1(object sender, RoutedEventArgs e)
        {
            uc_cagir.Uc_Ekle(Content_icerik, new ucKitapListesi());
            secimdurumu = 1;
            secilendurum();
        }
        private void menubuton_okuyuculistesi_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu=2;
            secilendurum();
        }

        private void menubuton_emanetlistesi_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 3;
            secilendurum();
        }

        private void menubuton_zamanidolanlar_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 4;
            secilendurum();
        }

        private void menubuton_ayarlar_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 5;
            secilendurum();
        }

        private void menubuton_hakkinda_Click(object sender, RoutedEventArgs e)
        {
            secimdurumu = 6;
            secilendurum();
        }

        //checked status
        void secilendurum()
        {
            if (secimdurumu==1)
            {
                menubuton_kitaplistesi.IsChecked = true;
            }
            else
            {
                menubuton_kitaplistesi.IsChecked=false;
            }
            if (secimdurumu == 2)
            {
                menubuton_okuyuculistesi.IsChecked = true;
            }
            else
            {
                menubuton_okuyuculistesi.IsChecked = false;
            }
            if (secimdurumu == 3)
            {
                menubuton_emanetlistesi.IsChecked = true;
            }
            else
            {
                menubuton_emanetlistesi.IsChecked = false;
            }
            if (secimdurumu == 4)
            {
                menubuton_zamanidolanlar.IsChecked = true;
            }
            else
            {
                menubuton_zamanidolanlar.IsChecked = false;
            }
            if (secimdurumu == 5)
            {
                menubuton_ayarlar.IsChecked = true;
            }
            else
            {
                menubuton_ayarlar.IsChecked = false;
            }
            if (secimdurumu == 6)
            {
                menubuton_hakkinda.IsChecked = true;
            }
            else
            {
                menubuton_hakkinda.IsChecked = false;
            }
        }
        #endregion
    }

}
