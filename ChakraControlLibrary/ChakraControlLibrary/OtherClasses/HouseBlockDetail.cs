using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChakraControlLibrary
{
    public class HouseBlockDetail : ObservableObject
    {
        private HouseEnum house;
        public HouseEnum House
        {
            get { return house; }
            set { house = value;}
        }

        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; RaisePropertyChanged(nameof(IsChecked)); }
        }

        public virtual ICommand HouseCommand { get { return new RelayCommand(OnHouseCommand); } }

        public virtual void OnHouseCommand()
        {
            
        }
    }
}