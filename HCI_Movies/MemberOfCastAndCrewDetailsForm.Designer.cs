namespace HCI_Movies
{
    partial class MemberOfCastAndCrewDetailsForm
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthplace = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lblDied = new System.Windows.Forms.Label();
            this.lblBorn = new System.Windows.Forms.Label();
            this.lvMovies = new System.Windows.Forms.ListView();
            this.rtbBio = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(60, 40);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(250, 350);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(340, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblBirthplace
            // 
            this.lblBirthplace.AutoSize = true;
            this.lblBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthplace.Location = new System.Drawing.Point(342, 100);
            this.lblBirthplace.Name = "lblBirthplace";
            this.lblBirthplace.Size = new System.Drawing.Size(81, 18);
            this.lblBirthplace.TabIndex = 0;
            this.lblBirthplace.Text = "Birthplace: ";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovies.Location = new System.Drawing.Point(342, 220);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(64, 18);
            this.lblMovies.TabIndex = 0;
            this.lblMovies.Text = "Movies: ";
            // 
            // lblDied
            // 
            this.lblDied.AutoSize = true;
            this.lblDied.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDied.Location = new System.Drawing.Point(342, 180);
            this.lblDied.Name = "lblDied";
            this.lblDied.Size = new System.Drawing.Size(46, 18);
            this.lblDied.TabIndex = 0;
            this.lblDied.Text = "Died: ";
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorn.Location = new System.Drawing.Point(342, 140);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(48, 18);
            this.lblBorn.TabIndex = 0;
            this.lblBorn.Text = "Born: ";
            // 
            // lvMovies
            // 
            this.lvMovies.Location = new System.Drawing.Point(345, 240);
            this.lvMovies.Name = "lvMovies";
            this.lvMovies.Size = new System.Drawing.Size(265, 150);
            this.lvMovies.TabIndex = 0;
            this.lvMovies.TabStop = false;
            this.lvMovies.UseCompatibleStateImageBehavior = false;
            this.lvMovies.View = System.Windows.Forms.View.Details;
            // 
            // rtbBio
            // 
            this.rtbBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBio.Location = new System.Drawing.Point(60, 413);
            this.rtbBio.Name = "rtbBio";
            this.rtbBio.ReadOnly = true;
            this.rtbBio.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbBio.Size = new System.Drawing.Size(550, 180);
            this.rtbBio.TabIndex = 1;
            this.rtbBio.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(500, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MemberOfCastAndCrewDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 662);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbBio);
            this.Controls.Add(this.lvMovies);
            this.Controls.Add(this.lblBorn);
            this.Controls.Add(this.lblDied);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lblBirthplace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbImage);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MemberOfCastAndCrewDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthplace;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblDied;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.ListView lvMovies;
        private System.Windows.Forms.RichTextBox rtbBio;
        private System.Windows.Forms.Button btnClose;
    }
}