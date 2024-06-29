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

namespace LOGIN_FORM_PRESENTATION
{

    public partial class _8_Voting : Form
    {
        const int Votecount = 1;
        const string pos = "Secretary";
        public _8_Voting()
        {
            InitializeComponent();
            voteBox.Items.Add("MARICE");
            voteBox.Items.Add("TIMAR");
            voteBox.Items.Add("VIC");
            voteBox.Items.Add("JEFF");
            voteBox.SelectedIndex = 0;

            voteBox.SelectedIndexChanged += voteBox_SelectedIndexChanged;
            
        }

        private void _8_Voting_Load(object sender, EventArgs e)
        {
            voteBox.SelectedIndex = 0;

            }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void VOTEBTN_Click(object sender, EventArgs e)
        {
            int selectedindex = voteBox.SelectedIndex;
            switch (selectedindex)
                {
                case 8:
                    CD1.BringToFront();
                    break;
                case 9:
                    CD2.BringToFront();
                    break;
                case 10:
                    CD3.BringToFront();
                    break;
                case 11:
                    CD3.BringToFront();
                    break;


                }
            try
            {
                /*PORT 3307*/
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                /*PORT 3306*/
                //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
                string query = "INSERT INTO `totality`(`candidateID`, `votes`) VALUES(  '"+selectedindex+"', '"+Votecount+"')";
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
                    this.Hide();


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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
