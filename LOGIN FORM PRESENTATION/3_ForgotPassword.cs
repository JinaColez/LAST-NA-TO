using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class ForgotPassword : Form
    {
        public Point mouseLoc;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
            {

            }
        private void emailLabel_Click(object sender, EventArgs e)
        {

        }
        private void mouseDownEvent(object sender, MouseEventArgs e)
            {
            mouseLoc = new Point(-e.X, -e.Y);
            }

        private void mouseMoveEvent(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
                {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePose;

                }
            }

        private void backButt_Click(object sender, EventArgs e)
            {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
            }

        private void escapeButt_Click(object sender, EventArgs e)
            {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
            }

        private void changepasswordButt_Click(object sender, EventArgs e)
            {
            try
                {
                /*PORT 3307*/
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                /*PORT 3306*/
                //string conn = " datasource=localhost;database=login;port=3306;username=root;password =; ";
                string query = "UPDATE `login` SET  `password`='"+newpasswordBox.Text+"' WHERE `email` = '"+emailBox.Text+"' ";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                    {
                    CustomMessageBox customMessage = new CustomMessageBox("Password Changed");
                    customMessage.ShowDialog();
                    Login_Form login = new Login_Form();
                    login.Show();
                    this.Hide();
                    }
                else if (newpasswordBox.Text != confirmpasswordBox.Text)
                    {
                    CustomMessageBox customMessage = new CustomMessageBox("Password Doesn't Match");
                    customMessage.ShowDialog();
                    newpasswordBox.Clear();
                    confirmpasswordBox.Clear();
                    }
                else
                    {
                    CustomMessageBox customMessage = new CustomMessageBox("Email not found ");
                    customMessage.ShowDialog();
                    }
                 
                connection.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            }

        private void hidePassBt_Click(object sender, EventArgs e)
            {
            if (newpasswordBox.PasswordChar == '*' || confirmpasswordBox.PasswordChar == '*')
                {
                showPassBt.BringToFront();
                newpasswordBox.PasswordChar = '\0';
                }

            }
       

        private void showPassBt_Click(object sender, EventArgs e)
            {
            if (newpasswordBox.PasswordChar == '\0')
                {
                hidePassBt.BringToFront();
                newpasswordBox.PasswordChar = '*';
                }
            }
        private void confirmpassHideBT_Click(object sender, EventArgs e)
            {
            if (confirmpasswordBox.PasswordChar == '*')
                {
                confirmpassShowBT.BringToFront();
                confirmpasswordBox.PasswordChar = '\0';
                }

            }
        private void confirmpassShowBT_Click(object sender, EventArgs e)
            {
            if (confirmpasswordBox.PasswordChar == '\0')
                {
                confirmpassHideBT.BringToFront();
                confirmpasswordBox.PasswordChar = '*';
                }
            }


     

       

        }
}
