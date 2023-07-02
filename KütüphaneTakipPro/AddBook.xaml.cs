using LibrarySystemPro.classlar;
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

namespace LibrarySystemPro
{
    /// <summary>
    /// Interaction logic for winKitapEkle.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public AddBook()
        {
            InitializeComponent();
        }


        private void txt_Page_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true; 
            }
        }

       

        private void txt_InStock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true; 
            }
        }

       

       
       

       

       

        private void btn_AddBook1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Prm.Error = 0;
            Prm.InformationScreenContent = "Transaction successful";
            InformationScreen be = new InformationScreen();
            be.Show();
        }

       

        private void txt_Piecee_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true; //harf girmesini engelliyor
            }
        }

        private void btn_AddBookClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow gk = (MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            gk.Opacity = 1;
        }

        private void btn_AddBookInformation_Click(object sender, RoutedEventArgs e)
        {
            Bonus.PopupShow(popup_Bilgi);
        }
    }
}
