namespace HCI_Movies
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblLoggedInUsername = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMinDuration = new System.Windows.Forms.Label();
            this.lblMaxDuration = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.tbMinDuration = new System.Windows.Forms.TextBox();
            this.tbMaxDuration = new System.Windows.Forms.TextBox();
            this.lvGenres = new System.Windows.Forms.ListView();
            this.lvActors = new System.Windows.Forms.ListView();
            this.lvDirectors = new System.Windows.Forms.ListView();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.tbDirectors = new System.Windows.Forms.TextBox();
            this.Poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pnlUser.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUser.Controls.Add(this.tbPassword);
            this.pnlUser.Controls.Add(this.textBox1);
            this.pnlUser.Controls.Add(this.label2);
            this.pnlUser.Controls.Add(this.label1);
            this.pnlUser.Controls.Add(this.lblLoggedInUsername);
            this.pnlUser.Controls.Add(this.btnLogIn);
            this.pnlUser.Controls.Add(this.btnLogOut);
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(988, 60);
            this.pnlUser.TabIndex = 2;
            // 
            // lblLoggedInUsername
            // 
            this.lblLoggedInUsername.AutoSize = true;
            this.lblLoggedInUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUsername.ForeColor = System.Drawing.Color.Black;
            this.lblLoggedInUsername.Location = new System.Drawing.Point(26, 21);
            this.lblLoggedInUsername.Name = "lblLoggedInUsername";
            this.lblLoggedInUsername.Size = new System.Drawing.Size(95, 24);
            this.lblLoggedInUsername.TabIndex = 0;
            this.lblLoggedInUsername.Text = "username";
            this.lblLoggedInUsername.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Location = new System.Drawing.Point(864, 15);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(100, 30);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(864, 15);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 30);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.btnDetails);
            this.pnlData.Controls.Add(this.dgvMovies);
            this.pnlData.Location = new System.Drawing.Point(220, 60);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(798, 604);
            this.pnlData.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
            this.btnDetails.Location = new System.Drawing.Point(654, 568);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(100, 30);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToResizeColumns = false;
            this.dgvMovies.AllowUserToResizeRows = false;
            this.dgvMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poster,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMovies.Location = new System.Drawing.Point(10, 10);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersVisible = false;
            this.dgvMovies.Size = new System.Drawing.Size(744, 552);
            this.dgvMovies.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(10, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 26);
            this.tbName.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(11, 60);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 18);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // lblMinDuration
            // 
            this.lblMinDuration.AutoSize = true;
            this.lblMinDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinDuration.ForeColor = System.Drawing.Color.Black;
            this.lblMinDuration.Location = new System.Drawing.Point(10, 110);
            this.lblMinDuration.Name = "lblMinDuration";
            this.lblMinDuration.Size = new System.Drawing.Size(89, 18);
            this.lblMinDuration.TabIndex = 0;
            this.lblMinDuration.Text = "Min duration";
            // 
            // lblMaxDuration
            // 
            this.lblMaxDuration.AutoSize = true;
            this.lblMaxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxDuration.ForeColor = System.Drawing.Color.Black;
            this.lblMaxDuration.Location = new System.Drawing.Point(10, 160);
            this.lblMaxDuration.Name = "lblMaxDuration";
            this.lblMaxDuration.Size = new System.Drawing.Size(93, 18);
            this.lblMaxDuration.TabIndex = 0;
            this.lblMaxDuration.Text = "Max duration";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.ForeColor = System.Drawing.Color.Black;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(10, 80);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(180, 28);
            this.cmbYear.TabIndex = 2;
            // 
            // tbMinDuration
            // 
            this.tbMinDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinDuration.ForeColor = System.Drawing.Color.Black;
            this.tbMinDuration.Location = new System.Drawing.Point(10, 130);
            this.tbMinDuration.Name = "tbMinDuration";
            this.tbMinDuration.Size = new System.Drawing.Size(180, 26);
            this.tbMinDuration.TabIndex = 3;
            // 
            // tbMaxDuration
            // 
            this.tbMaxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxDuration.ForeColor = System.Drawing.Color.Black;
            this.tbMaxDuration.Location = new System.Drawing.Point(10, 180);
            this.tbMaxDuration.Name = "tbMaxDuration";
            this.tbMaxDuration.Size = new System.Drawing.Size(180, 26);
            this.tbMaxDuration.TabIndex = 4;
            // 
            // lvGenres
            // 
            this.lvGenres.Location = new System.Drawing.Point(10, 230);
            this.lvGenres.Name = "lvGenres";
            this.lvGenres.Size = new System.Drawing.Size(180, 200);
            this.lvGenres.TabIndex = 5;
            this.lvGenres.UseCompatibleStateImageBehavior = false;
            // 
            // lvActors
            // 
            this.lvActors.Location = new System.Drawing.Point(10, 480);
            this.lvActors.Name = "lvActors";
            this.lvActors.Size = new System.Drawing.Size(180, 200);
            this.lvActors.TabIndex = 7;
            this.lvActors.UseCompatibleStateImageBehavior = false;
            // 
            // lvDirectors
            // 
            this.lvDirectors.Location = new System.Drawing.Point(10, 730);
            this.lvDirectors.Name = "lvDirectors";
            this.lvDirectors.Size = new System.Drawing.Size(180, 200);
            this.lvDirectors.TabIndex = 9;
            this.lvDirectors.UseCompatibleStateImageBehavior = false;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.Color.Black;
            this.lblGenres.Location = new System.Drawing.Point(10, 210);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(57, 18);
            this.lblGenres.TabIndex = 0;
            this.lblGenres.Text = "Genres";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.Black;
            this.lblActors.Location = new System.Drawing.Point(10, 430);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(51, 18);
            this.lblActors.TabIndex = 0;
            this.lblActors.Text = "Actors";
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectors.ForeColor = System.Drawing.Color.Black;
            this.lblDirectors.Location = new System.Drawing.Point(10, 680);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(73, 20);
            this.lblDirectors.TabIndex = 0;
            this.lblDirectors.Text = "Directors";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbDirectors);
            this.panel1.Controls.Add(this.lvDirectors);
            this.panel1.Controls.Add(this.lblDirectors);
            this.panel1.Controls.Add(this.tbActors);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblActors);
            this.panel1.Controls.Add(this.lvActors);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lblGenres);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lvGenres);
            this.panel1.Controls.Add(this.cmbYear);
            this.panel1.Controls.Add(this.lblMinDuration);
            this.panel1.Controls.Add(this.lblMaxDuration);
            this.panel1.Controls.Add(this.tbMaxDuration);
            this.panel1.Controls.Add(this.tbMinDuration);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(220, 610);
            this.panel1.TabIndex = 1;
            // 
            // tbActors
            // 
            this.tbActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActors.Location = new System.Drawing.Point(10, 450);
            this.tbActors.Name = "tbActors";
            this.tbActors.Size = new System.Drawing.Size(180, 22);
            this.tbActors.TabIndex = 6;
            // 
            // tbDirectors
            // 
            this.tbDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirectors.Location = new System.Drawing.Point(10, 700);
            this.tbDirectors.Name = "tbDirectors";
            this.tbDirectors.Size = new System.Drawing.Size(180, 22);
            this.tbDirectors.TabIndex = 8;
            // 
            // Poster
            // 
            this.Poster.HeaderText = "Poster";
            this.Poster.Name = "Poster";
            this.Poster.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Release date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Runtime";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "password:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(480, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(705, 23);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(140, 22);
            this.tbPassword.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlUser);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblLoggedInUsername;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblMaxDuration;
        private System.Windows.Forms.Label lblMinDuration;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tbMaxDuration;
        private System.Windows.Forms.TextBox tbMinDuration;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.ListView lvDirectors;
        private System.Windows.Forms.ListView lvActors;
        private System.Windows.Forms.ListView lvGenres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.TextBox tbDirectors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

