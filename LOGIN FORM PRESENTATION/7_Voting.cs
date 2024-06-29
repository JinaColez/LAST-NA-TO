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
    public partial class _7_Voting : Form
    {
        const int Votecount = 1;
        const string pos = "Vice President";
        public _7_Voting()
        {
            InitializeComponent();
            voteBox.Items.Add("JOSH");
            voteBox.Items.Add("BARD");
            voteBox.Items.Add("WELL");
            voteBox.Items.Add("DAN");
            
            voteBox.SelectedIndexChanged += voteBox_SelectedIndexChanged;
        }

        private void _7_Voting_Load(object sender, EventArgs e)
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
                case 4:
                    CD1.BringToFront();
                    break;
                case 5:
                    CD2.BringToFront();
                    break;
                case 6:
                    CD3.BringToFront();
                    break;
                case 7:
                    CD4.BringToFront();
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
                    CustomMessageBox customMessage = new CustomMessageBox("Voted");
                    customMessage.ShowDialog();
                    _8_Voting v7 = new _8_Voting(); 
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
    }

}
