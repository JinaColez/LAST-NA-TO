using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LOGIN_FORM_PRESENTATION
    {
    public partial class CustomMessageBox : Form
        {
        private string message;
        public Point mouseLoc;
        int seconds = 0;
        public CustomMessageBox(string message)
            {
            this.message=message;
            InitializeComponent();
            CustomMessage.Text=message;
            CustomMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        private void CustomMessageBox_Load(object sender, EventArgs e)
            {
            seconds = 3;
            timer1.Start();
            }

       

        private void okBT_Click_1(object sender, EventArgs e)
            {
            this.Close();
            timer1.Stop();
            }



        private void timer1_Tick(object sender, EventArgs e)
            {
            Thread.Sleep(800);
            okBT.Text = seconds--.ToString()+"s to close";
            if (seconds == 0)
                {
                this.Close();
                timer1.Stop();
                }
            

            
           
            /*int setTimer;
            for (setTimer = 0; setTimer <= 100; setTimer++)
                {
                Thread.Sleep(20);
                if (setTimer == 100)
                    {
                    timer1.Stop();
                    this.Close();
                    }

                }*/
            }

        
        }
    }
