using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipUygulaması.Model
{
    public class Musteri : INotifyPropertyChanged
    {
        private int _musteriNo;
        private string _musteriAdi = string.Empty;
        private string _musteriSoyadi = string.Empty;
        private string _musteriTel = string.Empty;
        private string _musteriEposta = string.Empty;


        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }

        }

        public string MusteriAdi
        {
            get { return _musteriAdi; }
            set
            {
                _musteriAdi = value;
                OnPropertyChanged("MusteriAdi");
            }
        }

        public string MusteriSoyadi
        {
            get { return _musteriSoyadi; }
            set
            {
                _musteriSoyadi = value;
                OnPropertyChanged("MusteriSoyadi");
            }
        }

        public string MusteriTel
        {
            get { return _musteriTel; }
            set
            {
                _musteriTel = value;
                OnPropertyChanged("MusteriTel");
            }
        }

        public string MusteriEposta
        {
            get { return _musteriEposta; }
            set
            {
                _musteriEposta = value;
                OnPropertyChanged("MusteriEposta");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
