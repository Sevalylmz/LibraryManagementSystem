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

namespace LibrarySystemPro.UController
{
    /// <summary>
    /// Interaction logic for ucKitapListesi.xaml
    /// </summary>
    public partial class ucBookList : UserControl
    {
        public ucBookList()
        {
            InitializeComponent();
        }
        MainWindow gk=(MainWindow)Application.Current.Windows.OfType<Window>().SingleOrDefault(x=>x.IsActive);

        private void btn_AddBook_Click(object sender, RoutedEventArgs e)
        {
            AddBook add = new AddBook();
            add.Owner = gk;
            gk.Opacity = 0.3; //görüntü şeffaflaştı
            add.ShowDialog();
        }
    }
}
