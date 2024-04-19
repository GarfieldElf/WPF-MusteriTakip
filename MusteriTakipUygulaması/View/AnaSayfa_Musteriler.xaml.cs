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
using MusteriTakipUygulaması.Model;

namespace MusteriTakipUygulaması.View
{
    /// <summary>
    /// AnaSayfa_Musteriler.xaml etkileşim mantığı
    /// </summary>
    public partial class AnaSayfa_Musteriler : Window
    {
        public AnaSayfa_Musteriler()
        {
            InitializeComponent();
            MusteriDataAccess MDA = new MusteriDataAccess();
            MDA.MusteriGetir();

        }


    }
}
