using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LOGIN_FORM_PRESENTATION
{
    public partial class RegistrationForm : Form
    {
        public Point mouseLoc;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
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
                mousePose.Offset(mouseLoc.X,mouseLoc.Y);
                Location = mousePose;
                }
            }

        private void goBackButt_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }
      
      
      

        private void haveAccountLabel_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            try
                {
                /*PORT 3307*/
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                /*PORT 3306*/
                //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
                string query = "insert into login (email ,username, password ) values('"+emailRegistration.Text+"', '"+usernameRegistration.Text+"', '"+passwordRegistration.Text+"')";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                if (passwordRegistration.Text == passwordRegistration.Text)
                    { 
                    try
                        {
                        connection.Open();
                        reader = command.ExecuteReader();
                        connection.Close();
                        Login_Form login = new Login_Form();
                        login.Show();
                        CustomMessageBox customMessage = new CustomMessageBox("Account Created");
                        customMessage.ShowDialog();

                        this.Hide();

                        }
                    catch (Exception ex)
                        {
                        MessageBox.Show(ex.Message);
                        }
                    }
                else
                    {
                    CustomMessageBox customMessage = new CustomMessageBox("Password Doesn't Match");
                    customMessage.ShowDialog();
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }



            }

        

        private void hidePassBt_Click(object sender, EventArgs e)
            {
            if (passwordRegistration.PasswordChar == '*')
                {
                showPassBt.BringToFront();
                passwordRegistration.PasswordChar = '\0';
                }
            }

        private void showPassBt_Click(object sender, EventArgs e)
            {
            if (passwordRegistration.PasswordChar == '\0')
                {
                hidePassBt.BringToFront();
                passwordRegistration.PasswordChar = '*';
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
        }
}
