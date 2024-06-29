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

namespace LOGIN_FORM_PRESENTATION
    {
    public partial class _9_Ranking : Form
        {
       
        public _9_Ranking()
            {
            InitializeComponent();
            
            }
        private void votes()
            {
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
        private void button1_Click(object sender, EventArgs e )
            {
            votes();
            
                
             
            }

        private void _9_Ranking_Load(object sender, EventArgs e)
            {
            votes();
            }
        }
    }
