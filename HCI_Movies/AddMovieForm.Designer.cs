namespace HCI_Movies
{
    partial class AddMovieForm
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
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblPlotSummary = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRuntime = new System.Windows.Forms.TextBox();
            this.tbBudget = new System.Windows.Forms.TextBox();
            this.tbGross = new System.Windows.Forms.TextBox();
            this.tbTagline = new System.Windows.Forms.TextBox();
            this.btnPoster = new System.Windows.Forms.Button();
            this.rtbPlotSummary = new System.Windows.Forms.RichTextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.tbDirectors = new System.Windows.Forms.TextBox();
            this.lvActors = new System.Windows.Forms.ListView();
            this.lvDirectors = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddDirector = new System.Windows.Forms.Button();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lvGenres = new System.Windows.Forms.ListView();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.tbLanguages = new System.Windows.Forms.TextBox();
            this.tbGenres = new System.Windows.Forms.TextBox();
            this.lvLanguages = new System.Windows.Forms.ListView();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnAddLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPoster
            // 
            this.pbPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoster.Location = new System.Drawing.Point(40, 30);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(250, 317);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(320, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.Location = new System.Drawing.Point(320, 85);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(94, 18);
            this.lblReleaseDate.TabIndex = 2;
            this.lblReleaseDate.Text = "Release date";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuntime.Location = new System.Drawing.Point(320, 140);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(63, 18);
            this.lblRuntime.TabIndex = 3;
            this.lblRuntime.Text = "Runtime";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(320, 195);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(54, 18);
            this.lblBudget.TabIndex = 4;
            this.lblBudget.Text = "Budget";
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGross.Location = new System.Drawing.Point(320, 250);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(50, 18);
            this.lblGross.TabIndex = 5;
            this.lblGross.Text = "Gross";
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagline.Location = new System.Drawing.Point(320, 305);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(55, 18);
            this.lblTagline.TabIndex = 6;
            this.lblTagline.Text = "Tagline";
            // 
            // lblPlotSummary
            // 
            this.lblPlotSummary.AutoSize = true;
            this.lblPlotSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlotSummary.Location = new System.Drawing.Point(40, 420);
            this.lblPlotSummary.Name = "lblPlotSummary";
            this.lblPlotSummary.Size = new System.Drawing.Size(100, 18);
            this.lblPlotSummary.TabIndex = 7;
            this.lblPlotSummary.Text = "Plot summary";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(320, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 22);
            this.tbName.TabIndex = 8;
            // 
            // tbRuntime
            // 
            this.tbRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRuntime.Location = new System.Drawing.Point(320, 160);
            this.tbRuntime.Name = "tbRuntime";
            this.tbRuntime.Size = new System.Drawing.Size(180, 22);
            this.tbRuntime.TabIndex = 10;
            // 
            // tbBudget
            // 
            this.tbBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBudget.Location = new System.Drawing.Point(320, 215);
            this.tbBudget.Name = "tbBudget";
            this.tbBudget.Size = new System.Drawing.Size(180, 22);
            this.tbBudget.TabIndex = 11;
            // 
            // tbGross
            // 
            this.tbGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGross.Location = new System.Drawing.Point(320, 270);
            this.tbGross.Name = "tbGross";
            this.tbGross.Size = new System.Drawing.Size(180, 22);
            this.tbGross.TabIndex = 12;
            // 
            // tbTagline
            // 
            this.tbTagline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTagline.Location = new System.Drawing.Point(320, 325);
            this.tbTagline.Name = "tbTagline";
            this.tbTagline.Size = new System.Drawing.Size(180, 22);
            this.tbTagline.TabIndex = 13;
            // 
            // btnPoster
            // 
            this.btnPoster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoster.Location = new System.Drawing.Point(110, 355);
            this.btnPoster.Name = "btnPoster";
            this.btnPoster.Size = new System.Drawing.Size(110, 30);
            this.btnPoster.TabIndex = 14;
            this.btnPoster.Text = "Poster";
            this.btnPoster.UseVisualStyleBackColor = true;
            this.btnPoster.Click += new System.EventHandler(this.btnPoster_Click);
            // 
            // rtbPlotSummary
            // 
            this.rtbPlotSummary.Location = new System.Drawing.Point(40, 440);
            this.rtbPlotSummary.Name = "rtbPlotSummary";
            this.rtbPlotSummary.Size = new System.Drawing.Size(460, 170);
            this.rtbPlotSummary.TabIndex = 15;
            this.rtbPlotSummary.Text = "";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.Location = new System.Drawing.Point(740, 30);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(51, 18);
            this.lblActors.TabIndex = 16;
            this.lblActors.Text = "Actors";
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectors.Location = new System.Drawing.Point(740, 325);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(69, 18);
            this.lblDirectors.TabIndex = 17;
            this.lblDirectors.Text = "Directors";
            // 
            // tbActors
            // 
            this.tbActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActors.Location = new System.Drawing.Point(740, 50);
            this.tbActors.Name = "tbActors";
            this.tbActors.Size = new System.Drawing.Size(180, 22);
            this.tbActors.TabIndex = 18;
            this.tbActors.TextChanged += new System.EventHandler(this.tbActors_TextChanged);
            // 
            // tbDirectors
            // 
            this.tbDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirectors.Location = new System.Drawing.Point(740, 345);
            this.tbDirectors.Name = "tbDirectors";
            this.tbDirectors.Size = new System.Drawing.Size(180, 22);
            this.tbDirectors.TabIndex = 19;
            this.tbDirectors.TextChanged += new System.EventHandler(this.tbDirectors_TextChanged);
            // 
            // lvActors
            // 
            this.lvActors.Location = new System.Drawing.Point(740, 75);
            this.lvActors.Name = "lvActors";
            this.lvActors.Size = new System.Drawing.Size(180, 200);
            this.lvActors.TabIndex = 20;
            this.lvActors.UseCompatibleStateImageBehavior = false;
            this.lvActors.View = System.Windows.Forms.View.Details;
            this.lvActors.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvActors_ItemChecked);
            // 
            // lvDirectors
            // 
            this.lvDirectors.Location = new System.Drawing.Point(740, 370);
            this.lvDirectors.Name = "lvDirectors";
            this.lvDirectors.Size = new System.Drawing.Size(180, 200);
            this.lvDirectors.TabIndex = 21;
            this.lvDirectors.UseCompatibleStateImageBehavior = false;
            this.lvDirectors.View = System.Windows.Forms.View.Details;
            this.lvDirectors.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDirectors_ItemChecked);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(810, 620);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddDirector
            // 
            this.btnAddDirector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDirector.Location = new System.Drawing.Point(810, 580);
            this.btnAddDirector.Name = "btnAddDirector";
            this.btnAddDirector.Size = new System.Drawing.Size(110, 30);
            this.btnAddDirector.TabIndex = 23;
            this.btnAddDirector.Text = "Add director";
            this.btnAddDirector.UseVisualStyleBackColor = true;
            this.btnAddDirector.Click += new System.EventHandler(this.btnAddDirector_Click);
            // 
            // btnAddActor
            // 
            this.btnAddActor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActor.Location = new System.Drawing.Point(810, 285);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(110, 30);
            this.btnAddActor.TabIndex = 24;
            this.btnAddActor.Text = "Add actor";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReleaseDate.Location = new System.Drawing.Point(320, 105);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(180, 22);
            this.dtpReleaseDate.TabIndex = 25;
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.Location = new System.Drawing.Point(530, 30);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(57, 18);
            this.lblGenres.TabIndex = 26;
            this.lblGenres.Text = "Genres";
            // 
            // lvGenres
            // 
            this.lvGenres.Location = new System.Drawing.Point(530, 75);
            this.lvGenres.Name = "lvGenres";
            this.lvGenres.Size = new System.Drawing.Size(180, 200);
            this.lvGenres.TabIndex = 27;
            this.lvGenres.UseCompatibleStateImageBehavior = false;
            this.lvGenres.View = System.Windows.Forms.View.Details;
            this.lvGenres.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvGenres_ItemChecked);
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.Location = new System.Drawing.Point(530, 325);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(80, 18);
            this.lblLanguages.TabIndex = 28;
            this.lblLanguages.Text = "Languages";
            // 
            // tbLanguages
            // 
            this.tbLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLanguages.Location = new System.Drawing.Point(530, 345);
            this.tbLanguages.Name = "tbLanguages";
            this.tbLanguages.Size = new System.Drawing.Size(180, 22);
            this.tbLanguages.TabIndex = 29;
            this.tbLanguages.TextChanged += new System.EventHandler(this.tbLanguages_TextChanged);
            // 
            // tbGenres
            // 
            this.tbGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenres.Location = new System.Drawing.Point(530, 50);
            this.tbGenres.Name = "tbGenres";
            this.tbGenres.Size = new System.Drawing.Size(180, 22);
            this.tbGenres.TabIndex = 30;
            this.tbGenres.TextChanged += new System.EventHandler(this.tbGenres_TextChanged);
            // 
            // lvLanguages
            // 
            this.lvLanguages.Location = new System.Drawing.Point(530, 370);
            this.lvLanguages.Name = "lvLanguages";
            this.lvLanguages.Size = new System.Drawing.Size(180, 200);
            this.lvLanguages.TabIndex = 31;
            this.lvLanguages.UseCompatibleStateImageBehavior = false;
            this.lvLanguages.View = System.Windows.Forms.View.Details;
            this.lvLanguages.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvLanguages_ItemChecked);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.Location = new System.Drawing.Point(600, 285);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(110, 30);
            this.btnAddGenre.TabIndex = 32;
            this.btnAddGenre.Text = "Add genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnAddLanguage
            // 
            this.btnAddLanguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLanguage.Location = new System.Drawing.Point(600, 580);
            this.btnAddLanguage.Name = "btnAddLanguage";
            this.btnAddLanguage.Size = new System.Drawing.Size(110, 30);
            this.btnAddLanguage.TabIndex = 33;
            this.btnAddLanguage.Text = "Add language";
            this.btnAddLanguage.UseVisualStyleBackColor = true;
            this.btnAddLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 662);
            this.Controls.Add(this.btnAddLanguage);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.lvLanguages);
            this.Controls.Add(this.tbGenres);
            this.Controls.Add(this.tbLanguages);
            this.Controls.Add(this.lblLanguages);
            this.Controls.Add(this.lvGenres);
            this.Controls.Add(this.lblGenres);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.btnAddActor);
            this.Controls.Add(this.btnAddDirector);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvDirectors);
            this.Controls.Add(this.lvActors);
            this.Controls.Add(this.tbDirectors);
            this.Controls.Add(this.tbActors);
            this.Controls.Add(this.lblDirectors);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.rtbPlotSummary);
            this.Controls.Add(this.btnPoster);
            this.Controls.Add(this.tbTagline);
            this.Controls.Add(this.tbGross);
            this.Controls.Add(this.tbBudget);
            this.Controls.Add(this.tbRuntime);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPlotSummary);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbPoster);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add movie";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblPlotSummary;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRuntime;
        private System.Windows.Forms.TextBox tbBudget;
        private System.Windows.Forms.TextBox tbGross;
        private System.Windows.Forms.TextBox tbTagline;
        private System.Windows.Forms.Button btnPoster;
        private System.Windows.Forms.RichTextBox rtbPlotSummary;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.TextBox tbDirectors;
        private System.Windows.Forms.ListView lvActors;
        private System.Windows.Forms.ListView lvDirectors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddDirector;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.ListView lvGenres;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.TextBox tbLanguages;
        private System.Windows.Forms.TextBox tbGenres;
        private System.Windows.Forms.ListView lvLanguages;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnAddLanguage;
    }
}