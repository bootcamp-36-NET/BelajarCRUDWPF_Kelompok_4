using BelajarCRUDWPFAldyCahya.Context;
using BelajarCRUDWPFAldyCahya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        MyContext myContext = new MyContext();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var email = myContext.Suppliers.Where(Q => Q.Email.Contains(txtEmail.Text)).SingleOrDefault();
            if (email == null)
            {
                lblStatus.Content = "Sorry! Please enter existing email";
                txtEmail.Focus();
                return;
            }
            Guid guid = Guid.NewGuid();
            SendEmail(email.Email, guid);
            email.gId = 1;
            email.Password = BCrypt.Net.BCrypt.HashString(guid.ToString(), 12);
            myContext.SaveChanges();
            MessageBox.Show("Password has been sent to " + email.Email);

            Login login = new Login();
            Close();
            login.Show();
        }
        public void SendEmail(string email, Guid guid)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.To.Add(new MailAddress(email));
            mail.From = new MailAddress("cjdeveloper123@gmail.com", "WPF Foundation");
            mail.Subject = "Forgotten username or password ";
            mail.Body = "Dear User, <br><br>We have been reset your password to :<br><br><b>" + guid.ToString() + "</b><br><br> Thank you, <br> WPF Help Desk";
            mail.IsBodyHtml = true;

            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential("cjdeveloper123@gmail.com", "b1smillah123!");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
                
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
