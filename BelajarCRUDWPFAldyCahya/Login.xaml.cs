using BelajarCRUDWPFAldyCahya.Context;
using BelajarCRUDWPFAldyCahya.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BelajarCRUDWPFAldyCahya
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        MyContext myContext = new MyContext();
        public Login()
        {
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to close this window?",
                                          "Confirmation",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
        public void Errorcheck()
        {
            string email = txtEmail.Text;
            string password = pwBox.Password;
            bool isEmail = Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", RegexOptions.IgnoreCase);
            if (string.IsNullOrEmpty(email))
            {
                lblNameStatus.Content = "Please enter your email";
                btnSubmit.IsEnabled = false;
                return;
            }
            if (isEmail == false)
            {
                lblNameStatus.Content = "Incorrect email format";
                btnSubmit.IsEnabled = false;
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                lblNameStatus.Content = "Please fill password field !";
                btnSubmit.IsEnabled = false;
                return;
            }
            lblNameStatus.Content = "";
            btnSubmit.IsEnabled = true;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Enter a valid email.");
                    txtEmail.Select(0, txtEmail.Text.Length);
                    txtEmail.Focus();
                }
                else
                {
                    var val = myContext.Suppliers.Where(x => x.Email.Contains(txtEmail.Text)).SingleOrDefault();
                    var valid = BCrypt.Net.BCrypt.Verify(pwBox.Password, val.Password);
                    if (val == null)
                    {
                        lblNameStatus.Content= "Sorry! Please enter existing email or password.";
                    }
                    else if (!valid)
                    {
                        lblNameStatus.Content="Incorrect password";
                        pwBox.Focus();
                    }
                    else
                    {
                        CheckBoxChecked();
                        string email = txtEmail.Text;
                        MainWindow main = new MainWindow();
                        main.TextBlockName.Text = email;
                        main.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }
        private void CheckBoxChecked()
        {
            if (checkBoxRememberMe.IsChecked == true)
            {
                Properties.Settings.Default.Username = txtEmail.Text;
                Properties.Settings.Default.Password = pwBox.Password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void checkBoxRememberMe_Loaded(object sender, RoutedEventArgs e)
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                txtEmail.Text = Properties.Settings.Default.Username;
                pwBox.Password = Properties.Settings.Default.Password;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }

        private void btnForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            Errorcheck();
        }

        private void pwBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Errorcheck();
        }
    }
}
