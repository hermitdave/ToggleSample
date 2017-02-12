using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ToggleSample
{
    public class MainViewModel : ViewModelBase
    {
        private bool? toggle1;
        private bool? toggle2;

        private RelayCommand toggleCommand = null;

        public MainViewModel()
        {
            this.Toggle1 = true;
            this.Toggle2 = !this.Toggle1;
        }
        
        public bool? Toggle1
        {
            get { return toggle1; }
            set
            {
                this.Set(ref this.toggle1, value);
            }
        }

        public bool? Toggle2
        {
            get { return toggle2; }
            set
            {
                this.Set(ref this.toggle2, value);
            }
        }

        public RelayCommand ToggleCommand => toggleCommand ?? (toggleCommand = new RelayCommand(() =>
        {
            this.Toggle2 = this.Toggle1;
            this.Toggle1 = !this.Toggle1;
        }));
    }
}
