using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Voting : Form
    {
        const int Votecount = 1;
        const string pos = "President";
        public Voting()
            {
            InitializeComponent();

            voteBox.Items.Add("RUNNING FOR PRESIDENCY");
            voteBox.Items.Add("ERIC");
            voteBox.Items.Add("DANNY");
            voteBox.Items.Add("MARKY");
            voteBox.SelectedIndex = 0;


            voteBox.SelectedIndexChanged += voteBox_SelectedIndexChanged; 
            }

        private void VINCE_Click(object sender, EventArgs e)
        {

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
             
            }

      

        private void VOTEBTN_Click(object sender, EventArgs e)
        {
            int selectedindex = voteBox.SelectedIndex;
            switch (selectedindex)
                {
                case 0:
                     
                    break;
                case 1:
                    CD1.BringToFront();
                    break;
                case 2:
                    CD2.BringToFront();
                    break;
                case 3:
                    CD3.BringToFront();
                    break;
                }
            try
                {
                /*PORT 3307*/
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                /*PORT 3306*/
                //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
                string query = "INSERT INTO `totality`(`candidateID`, `votes`) VALUES('"+selectedindex+"','"+Votecount+"')";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                try
                    {
                    connection.Open();
                    reader = command.ExecuteReader();
                    connection.Close();
                    CustomMessageBox customMessage = new CustomMessageBox("Thanks For Voting!");
                    customMessage.ShowDialog();
                    Login_Form v7 = new Login_Form();
                    v7.Show();
                    this.Hide(); ;
 

                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            
           
        }

        private void Voting_Load(object sender, EventArgs e)
        {
             
            
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IAN_Click(object sender, EventArgs e)
        {

        }

        private void MARK_Click(object sender, EventArgs e)
        {

        }

        private void JAKE_Click(object sender, EventArgs e)
        {

        }

        private void IMOT_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            
        }
    }
}
