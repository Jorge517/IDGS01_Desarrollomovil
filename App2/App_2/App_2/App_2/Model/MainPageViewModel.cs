using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace App_2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _nombre;

        public MainPageViewModel()
        {
            _nombre = "Holi";
        }
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre,value)) return;
                _nombre = value;
                RaisePropertyChange(nameof(Nombre));
                RaisePropertyChange(nameof(SinUpdate));

            }
        }

        public string SinUpdate
        {
            get => _nombre;
        }
        }
    }
