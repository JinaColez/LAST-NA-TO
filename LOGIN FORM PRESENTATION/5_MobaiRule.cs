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
    public partial class MobaiRule : Form
    {
        public Point mouseLoc;
        public MobaiRule()
        {
            InitializeComponent();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
             
            this.Close();
        }

        private void MobaiRule_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MobaiRule_Load(object sender, EventArgs e)
            {
            continueVoteButt.Enabled= false;
            continueVoteButt.BackColor = Color.FromArgb(77,83,91);
            }
        private void MouseDownEvent(object sender, MouseEventArgs e)
            {
            mouseLoc = new Point(-e.X, -e.Y);
            }
        private void MouseMoveEvent(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
                {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePose;

                }
            }

        private void continueVoteButt_Click(object sender, EventArgs e)
            {
            Voting votePage = new Voting();
            votePage.Show();
            this.Hide();



            }

        private void agreeCheckBox_CheckedChanged(object sender, EventArgs e)
            {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && agreeCheckBox.Checked == true)
                {
                continueVoteButt.Enabled =  true;
                continueVoteButt.BackColor = Color.FromArgb(77, 101, 240);
                
                }
            else
                {
                continueVoteButt.Enabled =  false;
                continueVoteButt.BackColor = Color.FromArgb(77, 83, 91);
                /*continueVoteButt.BackColor = Color.FromArgb(59, 73, 156);*/
                }
            }

        private void movablePanel_Paint(object sender, PaintEventArgs e)
            {

            }

        

        
        }
}
