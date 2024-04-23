using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MusteriTakipUygulaması.Model;

namespace MusteriTakipUygulaması.ViewModel
{
    public class MusteriViewModel
    {
        public ObservableCollection<Musteri>? Musteriler { get; set; }
        private MusteriDataAccess MDA { get; set; }

        public MusteriViewModel()
        {
            MDA = new MusteriDataAccess();
            Musteriler = new ObservableCollection<Musteri>(MDA.mda);
            //Musteriler.CollectionChanged += Musteriler_CollectionChanged;       // Event Handler for change in collection
        }


    }

}