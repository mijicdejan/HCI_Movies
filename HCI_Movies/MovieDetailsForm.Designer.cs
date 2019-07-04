namespace HCI_Movies
{
    partial class MovieDetailsForm
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
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.lblPlotSummary = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblDirectedBy = new System.Windows.Forms.Label();
            this.lvDirectors = new System.Windows.Forms.ListView();
            this.lblCast = new System.Windows.Forms.Label();
            this.lvActors = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPoster
            // 
            this.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoster.Location = new System.Drawing.Point(60, 40);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(250, 317);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 1;
            this.pbPoster.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(330, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(332, 100);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(102, 18);
            this.lblReleaseDate.TabIndex = 0;
            this.lblReleaseDate.Text = "Release date: ";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.Location = new System.Drawing.Point(332, 260);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(65, 18);
            this.lblGenres.TabIndex = 0;
            this.lblGenres.Text = "Genres: ";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(332, 220);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(58, 18);
            this.lblGross.TabIndex = 0;
            this.lblGross.Text = "Gross: ";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(332, 180);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(62, 18);
            this.lblBudget.TabIndex = 0;
            this.lblBudget.Text = "Budget: ";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuntime.Location = new System.Drawing.Point(332, 140);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(71, 18);
            this.lblRuntime.TabIndex = 0;
            this.lblRuntime.Text = "Runtime: ";
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.Location = new System.Drawing.Point(332, 300);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(88, 18);
            this.lblLanguages.TabIndex = 0;
            this.lblLanguages.Text = "Languages: ";
            // 
            // lblPlotSummary
            // 
            this.lblPlotSummary.AutoSize = true;
            this.lblPlotSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotSummary.Location = new System.Drawing.Point(60, 430);
            this.lblPlotSummary.Name = "lblPlotSummary";
            this.lblPlotSummary.Size = new System.Drawing.Size(100, 18);
            this.lblPlotSummary.TabIndex = 0;
            this.lblPlotSummary.Text = "Plot summary";
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.Location = new System.Drawing.Point(60, 390);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(55, 18);
            this.lblTagline.TabIndex = 0;
            this.lblTagline.Text = "Tagline";
            // 
            // lblDirectedBy
            // 
            this.lblDirectedBy.AutoSize = true;
            this.lblDirectedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectedBy.Location = new System.Drawing.Point(332, 340);
            this.lblDirectedBy.Name = "lblDirectedBy";
            this.lblDirectedBy.Size = new System.Drawing.Size(86, 18);
            this.lblDirectedBy.TabIndex = 0;
            this.lblDirectedBy.Text = "Directed by:";
            // 
            // lvDirectors
            // 
            this.lvDirectors.Location = new System.Drawing.Point(335, 360);
            this.lvDirectors.Name = "lvDirectors";
            this.lvDirectors.Size = new System.Drawing.Size(200, 236);
            this.lvDirectors.TabIndex = 0;
            this.lvDirectors.TabStop = false;
            this.lvDirectors.UseCompatibleStateImageBehavior = false;
            this.lvDirectors.View = System.Windows.Forms.View.Details;
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCast.Location = new System.Drawing.Point(560, 340);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(43, 18);
            this.lblCast.TabIndex = 0;
            this.lblCast.Text = "Cast:";
            // 
            // lvActors
            // 
            this.lvActors.Location = new System.Drawing.Point(563, 360);
            this.lvActors.Name = "lvActors";
            this.lvActors.Size = new System.Drawing.Size(200, 236);
            this.lvActors.TabIndex = 0;
            this.lvActors.TabStop = false;
            this.lvActors.UseCompatibleStateImageBehavior = false;
            this.lvActors.View = System.Windows.Forms.View.Details;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(653, 602);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MovieDetailsForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(814, 662);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvActors);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.lvDirectors);
            this.Controls.Add(this.lblDirectedBy);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblPlotSummary);
            this.Controls.Add(this.lblLanguages);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPoster);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MovieDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.Label lblPlotSummary;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblDirectedBy;
        private System.Windows.Forms.ListView lvDirectors;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.ListView lvActors;
        private System.Windows.Forms.Button btnClose;
    }
}