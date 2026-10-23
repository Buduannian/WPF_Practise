using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Study
{
    internal class LoginVM:INotifyPropertyChanged
    {
        MainWindow _main1;
        public LoginVM(MainWindow main1)
        {
            _main1 = main1;
        }
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

   

        public string  UserName
        {
            get { return LoginM.UserName; }
            set
            {
                LoginM.UserName = value;
                RaisePropertyCahnged("UserName");
            }
        }

        public string Password
        {
            get { return LoginM.Password; }
            set
            {
                LoginM.Password = value;
                RaisePropertyCahnged("Password");
            }
        }

        void LoginFun()
        {
            if (UserName == "wpf" && Password == "123")
            {
                Index index = new Index();
                index.Show();

                _main1.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
                UserName = "";
                Password = "";


            }
        }
        bool CanLoginExecute()
        {
            return true;
        }
        public ICommand LoginAction
        {
            get
            {
                return new RelayCommand(LoginFun, CanLoginExecute);
            }
        }
    }
}
