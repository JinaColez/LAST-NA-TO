namespace LOGIN_FORM_PRESENTATION
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridBT = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxUpdateLoginDB = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accountEditBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDeleteAcoount = new System.Windows.Forms.GroupBox();
            this.deleteUserNIdBT = new System.Windows.Forms.Button();
            this.deleteIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataEditBT = new System.Windows.Forms.Button();
            this.dataDeleteBT = new System.Windows.Forms.Button();
            this.logoutBT = new System.Windows.Forms.Button();
            this.movablePanel = new System.Windows.Forms.Panel();
            this.radBTloginDB = new System.Windows.Forms.RadioButton();
            this.radBTvotersDB = new System.Windows.Forms.RadioButton();
            this.groupBoxUpdateVotersDB = new System.Windows.Forms.GroupBox();
            this.votersIdTextBox = new System.Windows.Forms.TextBox();
            this.candidateTextBox = new System.Windows.Forms.TextBox();
            this.editVotersBT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupboxVoteDeleteDB = new System.Windows.Forms.GroupBox();
            this.removeVoteBT = new System.Windows.Forms.Button();
            this.deleteVoteTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rankingData = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxUpdateLoginDB.SuspendLayout();
            this.groupBoxDeleteAcoount.SuspendLayout();
            this.groupBoxUpdateVotersDB.SuspendLayout();
            this.groupboxVoteDeleteDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGIN_FORM_PRESENTATION.Properties.Resources.loadingScreen;
            this.pictureBox1.Location = new System.Drawing.Point(48, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridBT
            // 
            this.dataGridBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.dataGridBT.FlatAppearance.BorderSize = 0;
            this.dataGridBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridBT.ForeColor = System.Drawing.Color.White;
            this.dataGridBT.Location = new System.Drawing.Point(48, 217);
            this.dataGridBT.Name = "dataGridBT";
            this.dataGridBT.Size = new System.Drawing.Size(119, 35);
            this.dataGridBT.TabIndex = 2;
            this.dataGridBT.Text = "VIEW";
            this.dataGridBT.UseVisualStyleBackColor = false;
            this.dataGridBT.Click += new System.EventHandler(this.dataGridBT_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.dataGridView1);
            this.groupBoxData.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxData.ForeColor = System.Drawing.Color.White;
            this.groupBoxData.Location = new System.Drawing.Point(241, 92);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(550, 347);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "DATA GRID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(7, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(537, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxUpdateLoginDB
            // 
            this.groupBoxUpdateLoginDB.Controls.Add(this.idTextBox);
            this.groupBoxUpdateLoginDB.Controls.Add(this.passwordTextBox);
            this.groupBoxUpdateLoginDB.Controls.Add(this.emailTextBox);
            this.groupBoxUpdateLoginDB.Controls.Add(this.usernameTextBox);
            this.groupBoxUpdateLoginDB.Controls.Add(this.label4);
            this.groupBoxUpdateLoginDB.Controls.Add(this.accountEditBT);
            this.groupBoxUpdateLoginDB.Controls.Add(this.label3);
            this.groupBoxUpdateLoginDB.Controls.Add(this.label5);
            this.groupBoxUpdateLoginDB.Controls.Add(this.label2);
            this.groupBoxUpdateLoginDB.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUpdateLoginDB.ForeColor = System.Drawing.Color.White;
            this.groupBoxUpdateLoginDB.Location = new System.Drawing.Point(241, 92);
            this.groupBoxUpdateLoginDB.Name = "groupBoxUpdateLoginDB";
            this.groupBoxUpdateLoginDB.Size = new System.Drawing.Size(550, 347);
            this.groupBoxUpdateLoginDB.TabIndex = 3;
            this.groupBoxUpdateLoginDB.TabStop = false;
            this.groupBoxUpdateLoginDB.Text = "EDIT LOGIN";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.White;
            this.idTextBox.Location = new System.Drawing.Point(131, 58);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(268, 23);
            this.idTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(131, 236);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(268, 23);
            this.passwordTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.White;
            this.emailTextBox.Location = new System.Drawing.Point(131, 174);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(268, 23);
            this.emailTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(131, 116);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(268, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "PASSWORD";
            // 
            // accountEditBT
            // 
            this.accountEditBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.accountEditBT.FlatAppearance.BorderSize = 0;
            this.accountEditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountEditBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountEditBT.ForeColor = System.Drawing.Color.White;
            this.accountEditBT.Location = new System.Drawing.Point(131, 270);
            this.accountEditBT.Name = "accountEditBT";
            this.accountEditBT.Size = new System.Drawing.Size(268, 29);
            this.accountEditBT.TabIndex = 2;
            this.accountEditBT.Text = "EDIT";
            this.accountEditBT.UseVisualStyleBackColor = false;
            this.accountEditBT.Click += new System.EventHandler(this.accountEditBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "USERNAME";
            // 
            // groupBoxDeleteAcoount
            // 
            this.groupBoxDeleteAcoount.Controls.Add(this.deleteUserNIdBT);
            this.groupBoxDeleteAcoount.Controls.Add(this.deleteIDTextBox);
            this.groupBoxDeleteAcoount.Controls.Add(this.label6);
            this.groupBoxDeleteAcoount.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDeleteAcoount.ForeColor = System.Drawing.Color.White;
            this.groupBoxDeleteAcoount.Location = new System.Drawing.Point(241, 92);
            this.groupBoxDeleteAcoount.Name = "groupBoxDeleteAcoount";
            this.groupBoxDeleteAcoount.Size = new System.Drawing.Size(550, 347);
            this.groupBoxDeleteAcoount.TabIndex = 3;
            this.groupBoxDeleteAcoount.TabStop = false;
            this.groupBoxDeleteAcoount.Text = "DELETE ACCOUNT";
            // 
            // deleteUserNIdBT
            // 
            this.deleteUserNIdBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.deleteUserNIdBT.FlatAppearance.BorderSize = 0;
            this.deleteUserNIdBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserNIdBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserNIdBT.ForeColor = System.Drawing.Color.White;
            this.deleteUserNIdBT.Location = new System.Drawing.Point(131, 187);
            this.deleteUserNIdBT.Name = "deleteUserNIdBT";
            this.deleteUserNIdBT.Size = new System.Drawing.Size(268, 29);
            this.deleteUserNIdBT.TabIndex = 3;
            this.deleteUserNIdBT.Text = "REMOVE";
            this.deleteUserNIdBT.UseVisualStyleBackColor = false;
            this.deleteUserNIdBT.Click += new System.EventHandler(this.deleteUserNIdBT_Click);
            // 
            // deleteIDTextBox
            // 
            this.deleteIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.deleteIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteIDTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIDTextBox.ForeColor = System.Drawing.Color.White;
            this.deleteIDTextBox.Location = new System.Drawing.Point(131, 143);
            this.deleteIDTextBox.Name = "deleteIDTextBox";
            this.deleteIDTextBox.Size = new System.Drawing.Size(268, 23);
            this.deleteIDTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(385, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // dataEditBT
            // 
            this.dataEditBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.dataEditBT.FlatAppearance.BorderSize = 0;
            this.dataEditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataEditBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEditBT.ForeColor = System.Drawing.Color.White;
            this.dataEditBT.Location = new System.Drawing.Point(48, 264);
            this.dataEditBT.Name = "dataEditBT";
            this.dataEditBT.Size = new System.Drawing.Size(119, 35);
            this.dataEditBT.TabIndex = 2;
            this.dataEditBT.Text = "EDIT";
            this.dataEditBT.UseVisualStyleBackColor = false;
            this.dataEditBT.Click += new System.EventHandler(this.dataEditBT_Click);
            // 
            // dataDeleteBT
            // 
            this.dataDeleteBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.dataDeleteBT.FlatAppearance.BorderSize = 0;
            this.dataDeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataDeleteBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDeleteBT.ForeColor = System.Drawing.Color.White;
            this.dataDeleteBT.Location = new System.Drawing.Point(48, 312);
            this.dataDeleteBT.Name = "dataDeleteBT";
            this.dataDeleteBT.Size = new System.Drawing.Size(119, 35);
            this.dataDeleteBT.TabIndex = 2;
            this.dataDeleteBT.Text = "DELETE";
            this.dataDeleteBT.UseVisualStyleBackColor = false;
            this.dataDeleteBT.Click += new System.EventHandler(this.dataDeleteBT_Click);
            // 
            // logoutBT
            // 
            this.logoutBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.logoutBT.FlatAppearance.BorderSize = 0;
            this.logoutBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBT.ForeColor = System.Drawing.Color.White;
            this.logoutBT.Location = new System.Drawing.Point(48, 404);
            this.logoutBT.Name = "logoutBT";
            this.logoutBT.Size = new System.Drawing.Size(119, 35);
            this.logoutBT.TabIndex = 2;
            this.logoutBT.Text = "LOG OUT";
            this.logoutBT.UseVisualStyleBackColor = false;
            this.logoutBT.Click += new System.EventHandler(this.logoutBT_Click);
            // 
            // movablePanel
            // 
            this.movablePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.movablePanel.Location = new System.Drawing.Point(2, 3);
            this.movablePanel.Name = "movablePanel";
            this.movablePanel.Size = new System.Drawing.Size(829, 21);
            this.movablePanel.TabIndex = 16;
            this.movablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.movablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoveEvent);
            // 
            // radBTloginDB
            // 
            this.radBTloginDB.AutoSize = true;
            this.radBTloginDB.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBTloginDB.ForeColor = System.Drawing.Color.White;
            this.radBTloginDB.Location = new System.Drawing.Point(65, 155);
            this.radBTloginDB.Name = "radBTloginDB";
            this.radBTloginDB.Size = new System.Drawing.Size(85, 23);
            this.radBTloginDB.TabIndex = 17;
            this.radBTloginDB.TabStop = true;
            this.radBTloginDB.Text = "login-data";
            this.radBTloginDB.UseVisualStyleBackColor = true;
            this.radBTloginDB.CheckedChanged += new System.EventHandler(this.radBTloginDB_CheckedChanged);
            // 
            // radBTvotersDB
            // 
            this.radBTvotersDB.AutoSize = true;
            this.radBTvotersDB.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBTvotersDB.ForeColor = System.Drawing.Color.White;
            this.radBTvotersDB.Location = new System.Drawing.Point(65, 175);
            this.radBTvotersDB.Name = "radBTvotersDB";
            this.radBTvotersDB.Size = new System.Drawing.Size(93, 23);
            this.radBTvotersDB.TabIndex = 17;
            this.radBTvotersDB.TabStop = true;
            this.radBTvotersDB.Text = "voters-data";
            this.radBTvotersDB.UseVisualStyleBackColor = true;
            this.radBTvotersDB.CheckedChanged += new System.EventHandler(this.radBTvotersDB_CheckedChanged);
            // 
            // groupBoxUpdateVotersDB
            // 
            this.groupBoxUpdateVotersDB.Controls.Add(this.votersIdTextBox);
            this.groupBoxUpdateVotersDB.Controls.Add(this.candidateTextBox);
            this.groupBoxUpdateVotersDB.Controls.Add(this.editVotersBT);
            this.groupBoxUpdateVotersDB.Controls.Add(this.label9);
            this.groupBoxUpdateVotersDB.Controls.Add(this.label10);
            this.groupBoxUpdateVotersDB.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUpdateVotersDB.ForeColor = System.Drawing.Color.White;
            this.groupBoxUpdateVotersDB.Location = new System.Drawing.Point(241, 92);
            this.groupBoxUpdateVotersDB.Name = "groupBoxUpdateVotersDB";
            this.groupBoxUpdateVotersDB.Size = new System.Drawing.Size(550, 347);
            this.groupBoxUpdateVotersDB.TabIndex = 3;
            this.groupBoxUpdateVotersDB.TabStop = false;
            this.groupBoxUpdateVotersDB.Text = "EDIT VOTERS";
            // 
            // votersIdTextBox
            // 
            this.votersIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.votersIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.votersIdTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votersIdTextBox.ForeColor = System.Drawing.Color.White;
            this.votersIdTextBox.Location = new System.Drawing.Point(131, 125);
            this.votersIdTextBox.Name = "votersIdTextBox";
            this.votersIdTextBox.Size = new System.Drawing.Size(268, 23);
            this.votersIdTextBox.TabIndex = 1;
            // 
            // candidateTextBox
            // 
            this.candidateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.candidateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.candidateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.candidateTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateTextBox.ForeColor = System.Drawing.Color.White;
            this.candidateTextBox.Location = new System.Drawing.Point(131, 183);
            this.candidateTextBox.Name = "candidateTextBox";
            this.candidateTextBox.Size = new System.Drawing.Size(268, 23);
            this.candidateTextBox.TabIndex = 1;
            // 
            // editVotersBT
            // 
            this.editVotersBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.editVotersBT.FlatAppearance.BorderSize = 0;
            this.editVotersBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editVotersBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editVotersBT.ForeColor = System.Drawing.Color.White;
            this.editVotersBT.Location = new System.Drawing.Point(131, 222);
            this.editVotersBT.Name = "editVotersBT";
            this.editVotersBT.Size = new System.Drawing.Size(268, 29);
            this.editVotersBT.TabIndex = 2;
            this.editVotersBT.Text = "EDIT";
            this.editVotersBT.UseVisualStyleBackColor = false;
            this.editVotersBT.Click += new System.EventHandler(this.accountEditBT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Candidate";
            // 
            // groupboxVoteDeleteDB
            // 
            this.groupboxVoteDeleteDB.Controls.Add(this.removeVoteBT);
            this.groupboxVoteDeleteDB.Controls.Add(this.deleteVoteTextBox);
            this.groupboxVoteDeleteDB.Controls.Add(this.label7);
            this.groupboxVoteDeleteDB.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxVoteDeleteDB.ForeColor = System.Drawing.Color.White;
            this.groupboxVoteDeleteDB.Location = new System.Drawing.Point(241, 92);
            this.groupboxVoteDeleteDB.Name = "groupboxVoteDeleteDB";
            this.groupboxVoteDeleteDB.Size = new System.Drawing.Size(550, 347);
            this.groupboxVoteDeleteDB.TabIndex = 3;
            this.groupboxVoteDeleteDB.TabStop = false;
            this.groupboxVoteDeleteDB.Text = "DELETE VOTE";
            // 
            // removeVoteBT
            // 
            this.removeVoteBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.removeVoteBT.FlatAppearance.BorderSize = 0;
            this.removeVoteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeVoteBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeVoteBT.ForeColor = System.Drawing.Color.White;
            this.removeVoteBT.Location = new System.Drawing.Point(131, 187);
            this.removeVoteBT.Name = "removeVoteBT";
            this.removeVoteBT.Size = new System.Drawing.Size(268, 29);
            this.removeVoteBT.TabIndex = 3;
            this.removeVoteBT.Text = "REMOVE VOTE";
            this.removeVoteBT.UseVisualStyleBackColor = false;
            this.removeVoteBT.Click += new System.EventHandler(this.deleteUserNIdBT_Click);
            // 
            // deleteVoteTextBox
            // 
            this.deleteVoteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.deleteVoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteVoteTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteVoteTextBox.ForeColor = System.Drawing.Color.White;
            this.deleteVoteTextBox.Location = new System.Drawing.Point(131, 143);
            this.deleteVoteTextBox.Name = "deleteVoteTextBox";
            this.deleteVoteTextBox.Size = new System.Drawing.Size(268, 23);
            this.deleteVoteTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // rankingData
            // 
            this.rankingData.AutoSize = true;
            this.rankingData.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingData.ForeColor = System.Drawing.Color.White;
            this.rankingData.Location = new System.Drawing.Point(65, 134);
            this.rankingData.Name = "rankingData";
            this.rankingData.Size = new System.Drawing.Size(99, 23);
            this.rankingData.TabIndex = 17;
            this.rankingData.TabStop = true;
            this.rankingData.Text = "ranking-data";
            this.rankingData.UseVisualStyleBackColor = true;
            this.rankingData.CheckedChanged += new System.EventHandler(this.radBTloginDB_CheckedChanged);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(817, 463);
            this.Controls.Add(this.rankingData);
            this.Controls.Add(this.radBTvotersDB);
            this.Controls.Add(this.radBTloginDB);
            this.Controls.Add(this.movablePanel);
            this.Controls.Add(this.groupboxVoteDeleteDB);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBT);
            this.Controls.Add(this.dataDeleteBT);
            this.Controls.Add(this.dataEditBT);
            this.Controls.Add(this.dataGridBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDeleteAcoount);
            this.Controls.Add(this.groupBoxUpdateLoginDB);
            this.Controls.Add(this.groupBoxUpdateVotersDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "12";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxUpdateLoginDB.ResumeLayout(false);
            this.groupBoxUpdateLoginDB.PerformLayout();
            this.groupBoxDeleteAcoount.ResumeLayout(false);
            this.groupBoxDeleteAcoount.PerformLayout();
            this.groupBoxUpdateVotersDB.ResumeLayout(false);
            this.groupBoxUpdateVotersDB.PerformLayout();
            this.groupboxVoteDeleteDB.ResumeLayout(false);
            this.groupboxVoteDeleteDB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dataGridBT;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.GroupBox groupBoxUpdateLoginDB;
        private System.Windows.Forms.GroupBox groupBoxDeleteAcoount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dataEditBT;
        private System.Windows.Forms.Button dataDeleteBT;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accountEditBT;
        private System.Windows.Forms.Button logoutBT;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteUserNIdBT;
        private System.Windows.Forms.TextBox deleteIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel movablePanel;
        private System.Windows.Forms.RadioButton radBTloginDB;
        private System.Windows.Forms.RadioButton radBTvotersDB;
        private System.Windows.Forms.GroupBox groupBoxUpdateVotersDB;
        private System.Windows.Forms.TextBox votersIdTextBox;
        private System.Windows.Forms.TextBox candidateTextBox;
        private System.Windows.Forms.Button editVotersBT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupboxVoteDeleteDB;
        private System.Windows.Forms.Button removeVoteBT;
        private System.Windows.Forms.TextBox deleteVoteTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rankingData;
        }
}