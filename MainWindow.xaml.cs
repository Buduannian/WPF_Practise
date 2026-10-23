using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPF_Study
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //LoginModel loginModel;
        LoginVM loginVM;
        public MainWindow()
        {
            //loginModel = new LoginModel();
            
            InitializeComponent();
            loginVM = new LoginVM();
            //loginVM.LoginM.Password = "777";
            //loginVM.LoginM.UserName = "987";
            //同步上下文
            this.DataContext = loginVM;
        }
        



        //public string UserName { get; set; }
        //public string Password { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string username = txtUserName.Text;
            //string password = txtPassword.Text;

            if (loginVM.LoginM.UserName == "wpf" && loginVM.LoginM.Password == "123")
            {
                Index index = new Index();
                index.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
                loginVM.LoginM.UserName = "";
                loginVM.LoginM.Password = "";
                loginVM.LoginM = loginVM.LoginM;

            }
        }
    }

}
