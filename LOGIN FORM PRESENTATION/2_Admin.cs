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
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Admin : Form
    {
        public Point mouseLoc;
        public Admin()
        {
            InitializeComponent();
        }
        private void gridview1()
            {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            /*PORT 3307*/
            string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
            /*PORT 3306*/
            ///string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand("select * from login", con);
            try
                {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        private void gridview2()
            {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            /*PORT 3307*/
            string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
            /*PORT 3306*/
            //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand("select * from votes", con);
            try
                {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        private void gridview3()
            {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
            string query = "SELECT c.name, c.pos, COUNT(v.id) as vote_count " +
                                   "FROM candidacy c " +
                                   "LEFT JOIN totality v ON c.id = v.candidateID " +
                                   "GROUP BY c.id";

            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
                {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
        private void login_data_edit()
            {
            try
                {
                /*PORT 3307*/
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                /*PORT 3306*/
                //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
                string query = "UPDATE `login` SET `username`='"+usernameTextBox.Text+"',`email`='"+emailTextBox.Text+"',`password`='"+passwordTextBox.Text+"' WHERE `id` = '"+idTextBox.Text+"' ";
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, myConn);
                MySqlDataReader reader;
                try
                    {
                    myConn.Open();
                    reader = cmd.ExecuteReader();
                    CustomMessageBox customMessage = new CustomMessageBox("Account Edited");
                    customMessage.Show();
                    myConn.Close();
                    }
                catch (Exception ex)
                    {
                    CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                    customMessage.Show();
                    }
                }
            catch (Exception ex)
                {
                CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                customMessage.Show();
                }
            }

        private void voters_data_edit()
            {
            try
                {
                /*PORT 3307*/
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                /*PORT 3306*/
                //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
                string query = "UPDATE `votes SET `candidate`='"+candidateTextBox.Text+"'  WHERE `id` = '"+votersIdTextBox.Text+"' ";
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, myConn);
                MySqlDataReader reader;
                try
                    {
                    myConn.Open();
                    reader = cmd.ExecuteReader();
                    CustomMessageBox customMessage = new CustomMessageBox("Vote Edited");
                    customMessage.Show();
                    myConn.Close();
                    }
                catch (Exception ex)
                    {
                    CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                    customMessage.Show();
                    }
                }
            catch (Exception ex)
                {
                CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                customMessage.Show();
                }
            }

        private void login_data_delete()
            {

            /*PORT 3307*/
            string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
            /*PORT 3306*/
            //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
            string query = "DELETE FROM login WHERE id ='"+deleteIDTextBox.Text+"' ";
            MySqlConnection myConn = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader reader;
            try
                {
                myConn.Open();
                reader = cmd.ExecuteReader();
                CustomMessageBox customMessage = new CustomMessageBox("Account Deleted");
                customMessage.Show();
                myConn.Close();
                }
            catch (Exception ex)
                {
                CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                customMessage.Show();
                }
            }

        private void voters_data_delete()
            {
            /*PORT 3307*/
            string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
            /*PORT 3306*/
            //string conn = "datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=; ";
            string query = "DELETE FROM votes WHERE id ='"+deleteVoteTextBox.Text+"' ";
            MySqlConnection myConn = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataReader reader;
            try
                {
                myConn.Open();
                reader = cmd.ExecuteReader();
                CustomMessageBox customMessage = new CustomMessageBox("Vote voided");
                customMessage.Show();
                myConn.Close();
                }
            catch (Exception ex)
                {
                CustomMessageBox customMessage = new CustomMessageBox(ex.Message);
                customMessage.Show();
                }
            }
        private void Admin_Load(object sender, EventArgs e)
            {
            gridview1();
            gridview2();
            gridview3();
            groupBoxData.Visible = false;
            groupBoxDeleteAcoount.Visible = false;
            groupboxVoteDeleteDB.Visible = false;
            groupBoxUpdateLoginDB.Visible = false;
            groupBoxUpdateVotersDB.Visible = false;

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
        private void radBTloginDB_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void radBTvotersDB_CheckedChanged(object sender, EventArgs e)
            {

             
            }

        private void dataGridBT_Click(object sender, EventArgs e)
            {
            if (radBTloginDB.Checked)
                {
                gridview1();
                groupBoxData.Show();
                groupBoxData.BringToFront();
                groupBoxData.Visible = true;
                }
            else if(radBTvotersDB.Checked)
                {
                gridview2();
                groupBoxData.Show();
                groupBoxData.Text = "VOTES GRID";
                groupBoxData.BringToFront();
                groupBoxData.Visible = true;
                }
            else
                {
                gridview3();
                groupBoxData.Show();
                groupBoxData.Text = "RANKING GRID";
                groupBoxData.BringToFront();
                groupBoxData.Visible = true;
                }
             /* THIS IS TO REFRESH THE GRID VIEW*/

            }

        private void dataEditBT_Click(object sender, EventArgs e)
            {
            if (radBTloginDB.Checked)
                {
                groupBoxUpdateLoginDB.Show();
                groupBoxUpdateLoginDB.BringToFront();
                groupBoxUpdateLoginDB.Visible = true;
                }
            else if(radBTvotersDB.Checked)
                {
                groupBoxUpdateVotersDB.Show();
                groupBoxUpdateVotersDB.BringToFront();
                groupBoxUpdateVotersDB.Visible = true;
                }
            }

        
        private void dataDeleteBT_Click(object sender, EventArgs e)
            {
            if (radBTloginDB.Checked)
                {
                groupBoxDeleteAcoount.Show();
                groupBoxDeleteAcoount.BringToFront();
                groupBoxDeleteAcoount.Visible = true;
                }
            else if (radBTvotersDB.Checked)
                {
                groupboxVoteDeleteDB.Show();
                groupboxVoteDeleteDB.BringToFront();
                groupboxVoteDeleteDB.Visible = true;
                }
            }


        /*ACCOUNT EDIT GROUP BOX*/
        private void accountEditBT_Click(object sender, EventArgs e)
            {
            if (radBTloginDB.Checked)
                {
                login_data_edit();
                }
            else
                {
                voters_data_edit();
                }
        }

        private void deleteUserNIdBT_Click(object sender, EventArgs e)
            {
            if (radBTloginDB.Checked)
                {
                login_data_delete();
                }
            else
                {
                voters_data_delete();
                }
            }

        private void logoutBT_Click(object sender, EventArgs e)
            {
            Login_Form backtoLogin = new Login_Form();
            backtoLogin.Show();
            this.Hide();
            }


        }
}
