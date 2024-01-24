using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private bool CheckFields()
        {
            bool valid = true;
            lbl_error1.Content = string.Empty;
            lbl_error2.Content = string.Empty;
            lbl_error3.Content = string.Empty;
            lbl_error4.Content = string.Empty;
            lbl_error5.Content = string.Empty;
            if (txtbox_username.Text == "")
            {
                lbl_error1.Content += "*Username is empty\n";
                valid = false;
            }
            if (txtbox_email.Text == "")
            {
                lbl_error2.Content += "*E-mail is empty\n";
                valid = false;
            }
            if (txtbox_password.Text == "")
            {
                lbl_error3.Content += "*Password is empty\n";
                valid = false;
            }
            if (txtbox_confirmpassword.Text == "")
            {
                lbl_error4.Content += "*Confirm password is empty\n";
                valid = false;
            }
            if (textbox_policy.IsChecked != true)
            {
                lbl_error5.Content += "*You have to read and accept the Privacy Policy\n";
                valid = false;
            }
            return valid;
        }
        private void btn_createaccount_Click(object sender, RoutedEventArgs e)
        {
            if (CheckFields())
            {
                if (CheckPass())
                {
                    MessageBox.Show("Account created successfully!");
                }
            }
        }

        private bool CheckPass()
        {
            if (txtbox_password.Text != txtbox_confirmpassword.Text)
            {
                lbl_error6.Content += "*Passwords do not match";
                return false;
            }
            return true;
        }
    }
}