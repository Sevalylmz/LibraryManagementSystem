using KütüphaneTakipPro.classlar;
using KütüphaneTakipPro.classlar.Parametreler;
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

namespace KütüphaneTakipPro
{
    /// <summary>
    /// Interaction logic for winKitapEkle.xaml
    /// </summary>
    public partial class winKitapEkle : Window
    {
        public winKitapEkle()
        {
            InitializeComponent();
        }


        private void txt_SayfaSayisi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true; 
            }
        }

        private void txt_BaskiSayisi_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text,e.Text.Length-1))
            {
                e.Handled = true; //harf girmesini engelliyor
            }
        }

        private void txt_StokAdedi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true; 
            }
        }

        private void btn_KitapEkleKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            gk.Opacity = 1;
        }

        private void btn_KitapEkleBilgi_Click(object sender, RoutedEventArgs e)
        {
            Bonus.PopupShow(popup_Bilgi);
        }

        private void btn_KitapEkle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Prm.Hata = 0;
            Prm.BilgiEkraniContent = "Kayıt İşlemi Başarılı";
            BilgiEkrani be =new BilgiEkrani();
            be.Show();
        }
    }
}
