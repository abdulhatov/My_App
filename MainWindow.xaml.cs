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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           //List<User> users = db.Users.ToList();
           string str = "";
            //foreach (User user in users)
           // {
            //    str += "Login"+user.Login+" | ";
            //}
            //textExample.Text = str;
        }

      
        public void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                string login = textBoxLogin.Text.Trim();
                string pass = PasswordBox.Password.Trim();
                string pass2 = PasswordBox2.Password.Trim();
                string email = textBoxEmail.Text.Trim().ToLower();


                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                PasswordBox.ToolTip = "";
                PasswordBox.Background = Brushes.Transparent;
                PasswordBox2.ToolTip = "";
                PasswordBox2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                ;
                textExample.Text = login;
                MessageBox.Show("OK!");


                db.Users.Add(new() { Email = email, Login = login, Pass = pass });
                db.SaveChanges();
                try
                {
                 
                }
                catch (Exception exception)
                {
                    textExample.Text = exception.Message;
                }
                

            }

             
            
        }

    }
}
