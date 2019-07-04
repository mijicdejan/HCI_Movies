namespace HCI_Movies.UserControls
{
    partial class MoviesUcl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lvLanguages = new System.Windows.Forms.ListView();
            this.tbLanguages = new System.Windows.Forms.TextBox();
            this.lblLanguages = new System.Windows.Forms.Label();
            this.tbDirectors = new System.Windows.Forms.TextBox();
            this.lvDirectors = new System.Windows.Forms.ListView();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.lvActors = new System.Windows.Forms.ListView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lvGenres = new System.Windows.Forms.ListView();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblMinDuration = new System.Windows.Forms.Label();
            this.lblMaxDuration = new System.Windows.Forms.Label();
            this.tbMaxDuration = new System.Windows.Forms.TextBox();
            this.tbMinDuration = new System.Windows.Forms.TextBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFilter.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFilter.AutoScroll = true;
            this.pnlFilter.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lvLanguages);
            this.pnlFilter.Controls.Add(this.tbLanguages);
            this.pnlFilter.Controls.Add(this.lblLanguages);
            this.pnlFilter.Controls.Add(this.tbDirectors);
            this.pnlFilter.Controls.Add(this.lvDirectors);
            this.pnlFilter.Controls.Add(this.lblDirectors);
            this.pnlFilter.Controls.Add(this.tbActors);
            this.pnlFilter.Controls.Add(this.lblName);
            this.pnlFilter.Controls.Add(this.lblActors);
            this.pnlFilter.Controls.Add(this.lvActors);
            this.pnlFilter.Controls.Add(this.tbName);
            this.pnlFilter.Controls.Add(this.lblGenres);
            this.pnlFilter.Controls.Add(this.lblYear);
            this.pnlFilter.Controls.Add(this.lvGenres);
            this.pnlFilter.Controls.Add(this.cmbYear);
            this.pnlFilter.Controls.Add(this.lblMinDuration);
            this.pnlFilter.Controls.Add(this.lblMaxDuration);
            this.pnlFilter.Controls.Add(this.tbMaxDuration);
            this.pnlFilter.Controls.Add(this.tbMinDuration);
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlFilter.Size = new System.Drawing.Size(220, 570);
            this.pnlFilter.TabIndex = 0;
            // 
            // lvLanguages
            // 
            this.lvLanguages.Location = new System.Drawing.Point(10, 480);
            this.lvLanguages.Name = "lvLanguages";
            this.lvLanguages.Size = new System.Drawing.Size(180, 200);
            this.lvLanguages.TabIndex = 7;
            this.lvLanguages.UseCompatibleStateImageBehavior = false;
            this.lvLanguages.View = System.Windows.Forms.View.Details;
            this.lvLanguages.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvLanguages_ItemChecked);
            // 
            // tbLanguages
            // 
            this.tbLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLanguages.Location = new System.Drawing.Point(10, 450);
            this.tbLanguages.Name = "tbLanguages";
            this.tbLanguages.Size = new System.Drawing.Size(180, 22);
            this.tbLanguages.TabIndex = 6;
            this.tbLanguages.TextChanged += new System.EventHandler(this.tbLanguages_TextChanged);
            // 
            // lblLanguages
            // 
            this.lblLanguages.AutoSize = true;
            this.lblLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.Location = new System.Drawing.Point(10, 430);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(80, 18);
            this.lblLanguages.TabIndex = 10;
            this.lblLanguages.Text = "Languages";
            // 
            // tbDirectors
            // 
            this.tbDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirectors.Location = new System.Drawing.Point(10, 950);
            this.tbDirectors.Name = "tbDirectors";
            this.tbDirectors.Size = new System.Drawing.Size(180, 22);
            this.tbDirectors.TabIndex = 10;
            this.tbDirectors.TextChanged += new System.EventHandler(this.tbDirectors_TextChanged);
            // 
            // lvDirectors
            // 
            this.lvDirectors.Location = new System.Drawing.Point(10, 980);
            this.lvDirectors.Name = "lvDirectors";
            this.lvDirectors.Size = new System.Drawing.Size(180, 200);
            this.lvDirectors.TabIndex = 11;
            this.lvDirectors.UseCompatibleStateImageBehavior = false;
            this.lvDirectors.View = System.Windows.Forms.View.Details;
            this.lvDirectors.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDirectors_ItemChecked);
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectors.ForeColor = System.Drawing.Color.Black;
            this.lblDirectors.Location = new System.Drawing.Point(10, 930);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(73, 20);
            this.lblDirectors.TabIndex = 0;
            this.lblDirectors.Text = "Directors";
            // 
            // tbActors
            // 
            this.tbActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActors.Location = new System.Drawing.Point(10, 700);
            this.tbActors.Name = "tbActors";
            this.tbActors.Size = new System.Drawing.Size(180, 22);
            this.tbActors.TabIndex = 8;
            this.tbActors.TextChanged += new System.EventHandler(this.tbActors_TextChanged);
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
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.Black;
            this.lblActors.Location = new System.Drawing.Point(10, 680);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(51, 18);
            this.lblActors.TabIndex = 0;
            this.lblActors.Text = "Actors";
            // 
            // lvActors
            // 
            this.lvActors.Location = new System.Drawing.Point(10, 730);
            this.lvActors.Name = "lvActors";
            this.lvActors.Size = new System.Drawing.Size(180, 200);
            this.lvActors.TabIndex = 9;
            this.lvActors.UseCompatibleStateImageBehavior = false;
            this.lvActors.View = System.Windows.Forms.View.Details;
            this.lvActors.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvActors_ItemChecked);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(10, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 26);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
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
            // lvGenres
            // 
            this.lvGenres.Location = new System.Drawing.Point(10, 230);
            this.lvGenres.Name = "lvGenres";
            this.lvGenres.Size = new System.Drawing.Size(180, 200);
            this.lvGenres.TabIndex = 5;
            this.lvGenres.UseCompatibleStateImageBehavior = false;
            this.lvGenres.View = System.Windows.Forms.View.Details;
            this.lvGenres.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvGenres_ItemChecked);
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
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
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
            // tbMaxDuration
            // 
            this.tbMaxDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxDuration.ForeColor = System.Drawing.Color.Black;
            this.tbMaxDuration.Location = new System.Drawing.Point(10, 180);
            this.tbMaxDuration.Name = "tbMaxDuration";
            this.tbMaxDuration.Size = new System.Drawing.Size(180, 26);
            this.tbMaxDuration.TabIndex = 4;
            this.tbMaxDuration.TextChanged += new System.EventHandler(this.tbMaxDuration_TextChanged);
            this.tbMaxDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxDuration_KeyPress);
            // 
            // tbMinDuration
            // 
            this.tbMinDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinDuration.ForeColor = System.Drawing.Color.Black;
            this.tbMinDuration.Location = new System.Drawing.Point(10, 130);
            this.tbMinDuration.Name = "tbMinDuration";
            this.tbMinDuration.Size = new System.Drawing.Size(180, 26);
            this.tbMinDuration.TabIndex = 3;
            this.tbMinDuration.TextChanged += new System.EventHandler(this.tbMinDuration_TextChanged);
            this.tbMinDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinDuration_KeyPress);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.btnDelete);
            this.pnlData.Controls.Add(this.btnEditMovie);
            this.pnlData.Controls.Add(this.btnAddMovie);
            this.pnlData.Controls.Add(this.btnDetails);
            this.pnlData.Controls.Add(this.dgvMovies);
            this.pnlData.Location = new System.Drawing.Point(220, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(798, 570);
            this.pnlData.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(654, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMovie.ForeColor = System.Drawing.Color.Black;
            this.btnEditMovie.Location = new System.Drawing.Point(548, 528);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(100, 30);
            this.btnEditMovie.TabIndex = 2;
            this.btnEditMovie.Text = "Edit";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Visible = false;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(442, 528);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(100, 30);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Visible = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
            this.btnDetails.Location = new System.Drawing.Point(654, 528);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(100, 30);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Genres});
            this.dgvMovies.Location = new System.Drawing.Point(10, 10);
            this.dgvMovies.MultiSelect = false;
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMovies.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(744, 512);
            this.dgvMovies.TabIndex = 4;
            this.dgvMovies.TabStop = false;
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
            // Genres
            // 
            this.Genres.HeaderText = "Genres";
            this.Genres.Name = "Genres";
            this.Genres.ReadOnly = true;
            // 
            // MoviesUcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlFilter);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MoviesUcl";
            this.Size = new System.Drawing.Size(1020, 570);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox tbDirectors;
        private System.Windows.Forms.ListView lvDirectors;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.ListView lvActors;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ListView lvGenres;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblMinDuration;
        private System.Windows.Forms.Label lblMaxDuration;
        private System.Windows.Forms.TextBox tbMaxDuration;
        private System.Windows.Forms.TextBox tbMinDuration;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genres;
        private System.Windows.Forms.TextBox tbLanguages;
        private System.Windows.Forms.Label lblLanguages;
        private System.Windows.Forms.ListView lvLanguages;
        private System.Windows.Forms.Button btnDelete;
    }
}
