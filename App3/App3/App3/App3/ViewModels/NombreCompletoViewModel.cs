using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App3.ViewModels
{
    public class NombreCompletoViewModel : BaseViewModel
    {
        private string _nombre;
        private string _appP;
        private string _appM;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(NombreCompleto));

            }
        }
        public string AppP
        {
            get => _appP;
            set
            {
                if (string.Equals(_appP, value)) return;
                _appP = value;
                OnPropertyChanged(nameof(AppP));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        public string AppM
        {
            get => _appM;
            set
            {
                if (string.Equals(_appM, value)) return;
                _appM = value;
                OnPropertyChanged(nameof(AppM));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
            public string NombreCompleto => $"{Nombre} {AppP} {AppM}";
    }
}
