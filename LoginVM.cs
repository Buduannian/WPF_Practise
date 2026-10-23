using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Study
{
    internal class LoginVM:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyCahnged(string propertyNAme)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyNAme));
            }
        }

        private LoginModel _LoginM;
        public LoginModel LoginM
        {
            get
            {
                if (_LoginM == null)
                    _LoginM = new LoginModel();
                return _LoginM;
                
            }
            set
            {
                _LoginM = value;
                RaisePropertyCahnged("LoginM");
            }
        }
        

    }
}
