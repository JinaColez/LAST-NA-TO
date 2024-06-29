namespace LOGIN_FORM_PRESENTATION
    {
    partial class CustomMessageBox
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.CustomMessage = new System.Windows.Forms.Label();
            this.movablePanel = new System.Windows.Forms.Panel();
            this.okBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CustomMessage
            // 
            this.CustomMessage.AutoSize = true;
            this.CustomMessage.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomMessage.ForeColor = System.Drawing.Color.White;
            this.CustomMessage.Location = new System.Drawing.Point(149, 44);
            this.CustomMessage.Name = "CustomMessage";
            this.CustomMessage.Size = new System.Drawing.Size(123, 23);
            this.CustomMessage.TabIndex = 0;
            this.CustomMessage.Text = "CustomMessage";
            this.CustomMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movablePanel
            // 
            this.movablePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.movablePanel.Location = new System.Drawing.Point(1, 0);
            this.movablePanel.Name = "movablePanel";
            this.movablePanel.Size = new System.Drawing.Size(444, 19);
            this.movablePanel.TabIndex = 16;
            this.movablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.movablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoveEvent);
            // 
            // okBT
            // 
            this.okBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.okBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBT.FlatAppearance.BorderSize = 0;
            this.okBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBT.ForeColor = System.Drawing.Color.White;
            this.okBT.Location = new System.Drawing.Point(141, 70);
            this.okBT.Name = "okBT";
            this.okBT.Size = new System.Drawing.Size(140, 29);
            this.okBT.TabIndex = 18;
            this.okBT.Text = "OK";
            this.okBT.UseVisualStyleBackColor = false;
            this.okBT.Click += new System.EventHandler(this.okBT_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(443, 111);
            this.Controls.Add(this.okBT);
            this.Controls.Add(this.CustomMessage);
            this.Controls.Add(this.movablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label CustomMessage;
        private System.Windows.Forms.Panel movablePanel;
        private System.Windows.Forms.Button okBT;
        private System.Windows.Forms.Timer timer1;
        }
    }