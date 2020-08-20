using BCrypt.Net;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        MyContext myContext = new MyContext();
        public Registration()
        {
            InitializeComponent();
        }
        public void ErrorCheck()
        {
            string id = txtIdReg.Text;
            if (string.IsNullOrWhiteSpace(id) || id.Length > 4)
            {
                lblNameStatus.Content = "Id maximum 4 characters";
                btnRegister.IsEnabled = false;
                return;
            }
            lblNameStatus.Content = "";
            btnRegister.IsEnabled = true;
        }
        public void Reset()
        {
            txtIdReg.Text = "";
            txtSNameReg.Text = "";
            txtEmailReg.Text = "";
            pwConfirmReg.Password = "";
            pwReg.Password = "";
        }
        public void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var hasbcrypt = BCrypt.Net.BCrypt.HashPassword(pwReg.Password, 13);
            var regis = myContext.Suppliers.Where(I => I.Email.ToString().Contains(txtEmailReg.Text)).SingleOrDefault();
                if (regis != null)
                {
                    MessageBox.Show("Email has been registered. Please use another email.");
                    txtEmailReg.Focus();
                }
                else
                {
                    {
                        MessageBoxResult result = MessageBox.Show("Do you want to save this data?",
                            "Confirmation",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Question);
                        if (result == MessageBoxResult.Yes)
                        {
                            var input = new Supplier()
                            {
                                Name = txtSNameReg.Text,
                                Id = txtIdReg.Text,
                                Email = txtEmailReg.Text,
                                Password = hasbcrypt,
                                JoinDate = dateJoinDate.SelectedDate.Value
                            };
                            myContext.Suppliers.Add(input);
                            myContext.SaveChanges();                            
                        }
                    }
                    MessageBox.Show("You have Registered successfully.");
                    Reset();
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
            }        

        private void txtSNameReg_TextChanged(object sender, TextChangedEventArgs e)
        {
            ErrorCheck();
        }

        private void txtIdReg_TextChanged(object sender, TextChangedEventArgs e)
        {
            ErrorCheck();
        }

        private void dateJoinDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dateJoinDate.SelectedDate.Value == null)
            {
                lblNameStatus.Content = "Please enter join date";
                btnRegister.IsEnabled = false;
            }
            else
            {
                lblNameStatus.Content = "";
                btnRegister.IsEnabled = true;
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void txtEmailReg_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtEmailReg.Text.Length == 0)
            {
                lblNameStatus.Content = "Please enter an email !";
                btnRegister.IsEnabled = false;
            }
            else if (!Regex.IsMatch(txtEmailReg.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                lblNameStatus.Content = "Enter a valid email";
                txtEmailReg.Focus();
            }
            else
            {
                lblNameStatus.Content = "";
                btnRegister.IsEnabled = true;
            }
        }

        private void pwReg_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwReg.Password.Length == 0)
            {
                lblNameStatus.Content = "Please enter the password";
                btnRegister.IsEnabled = false;
                pwReg.Focus();
            }
            else
            {
                lblNameStatus.Content = "";
                btnRegister.IsEnabled = true;
            }
        }

        private void pwConfirmReg_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwConfirmReg.Password != pwReg.Password)
            {
                lblNameStatus.Content = "Confirm password must be same as password";
                btnRegister.IsEnabled = false;
                pwConfirmReg.Focus();
            }
            else
            {
                lblNameStatus.Content = "";
                btnRegister.IsEnabled = true;
            }
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
    }
}
