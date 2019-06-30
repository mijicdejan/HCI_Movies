﻿namespace HCI_Movies.UserControls
{
    partial class ActorsUcl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbMaxMovies = new System.Windows.Forms.TextBox();
            this.tbMinMovies = new System.Windows.Forms.TextBox();
            this.lblMinMovies = new System.Windows.Forms.Label();
            this.lblMaxMovies = new System.Windows.Forms.Label();
            this.lblBirthplace = new System.Windows.Forms.Label();
            this.cmbYearOfDeath = new System.Windows.Forms.ComboBox();
            this.tbBirthplace = new System.Windows.Forms.TextBox();
            this.lblYearOfDeath = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblYearOfBirth = new System.Windows.Forms.Label();
            this.cmbYearOfBirth = new System.Windows.Forms.ComboBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFilter.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFilter.AutoScroll = true;
            this.pnlFilter.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.tbLastName);
            this.pnlFilter.Controls.Add(this.lblLastName);
            this.pnlFilter.Controls.Add(this.tbMaxMovies);
            this.pnlFilter.Controls.Add(this.tbMinMovies);
            this.pnlFilter.Controls.Add(this.lblMinMovies);
            this.pnlFilter.Controls.Add(this.lblMaxMovies);
            this.pnlFilter.Controls.Add(this.lblBirthplace);
            this.pnlFilter.Controls.Add(this.cmbYearOfDeath);
            this.pnlFilter.Controls.Add(this.tbBirthplace);
            this.pnlFilter.Controls.Add(this.lblYearOfDeath);
            this.pnlFilter.Controls.Add(this.lblFirstName);
            this.pnlFilter.Controls.Add(this.tbFirstName);
            this.pnlFilter.Controls.Add(this.lblYearOfBirth);
            this.pnlFilter.Controls.Add(this.cmbYearOfBirth);
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlFilter.Size = new System.Drawing.Size(220, 570);
            this.pnlFilter.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(10, 80);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(180, 26);
            this.tbLastName.TabIndex = 10;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(10, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 18);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last name";
            // 
            // tbMaxMovies
            // 
            this.tbMaxMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxMovies.Location = new System.Drawing.Point(10, 330);
            this.tbMaxMovies.Name = "tbMaxMovies";
            this.tbMaxMovies.Size = new System.Drawing.Size(180, 26);
            this.tbMaxMovies.TabIndex = 4;
            this.tbMaxMovies.TextChanged += new System.EventHandler(this.tbMaxMovies_TextChanged);
            this.tbMaxMovies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMaxMovies_KeyPress);
            // 
            // tbMinMovies
            // 
            this.tbMinMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinMovies.Location = new System.Drawing.Point(10, 280);
            this.tbMinMovies.Name = "tbMinMovies";
            this.tbMinMovies.Size = new System.Drawing.Size(180, 26);
            this.tbMinMovies.TabIndex = 4;
            this.tbMinMovies.TextChanged += new System.EventHandler(this.tbMinMovies_TextChanged);
            this.tbMinMovies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinMovies_KeyPress);
            // 
            // lblMinMovies
            // 
            this.lblMinMovies.AutoSize = true;
            this.lblMinMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinMovies.Location = new System.Drawing.Point(10, 260);
            this.lblMinMovies.Name = "lblMinMovies";
            this.lblMinMovies.Size = new System.Drawing.Size(84, 18);
            this.lblMinMovies.TabIndex = 4;
            this.lblMinMovies.Text = "Min movies";
            // 
            // lblMaxMovies
            // 
            this.lblMaxMovies.AutoSize = true;
            this.lblMaxMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxMovies.Location = new System.Drawing.Point(10, 310);
            this.lblMaxMovies.Name = "lblMaxMovies";
            this.lblMaxMovies.Size = new System.Drawing.Size(88, 18);
            this.lblMaxMovies.TabIndex = 5;
            this.lblMaxMovies.Text = "Max movies";
            // 
            // lblBirthplace
            // 
            this.lblBirthplace.AutoSize = true;
            this.lblBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthplace.Location = new System.Drawing.Point(10, 210);
            this.lblBirthplace.Name = "lblBirthplace";
            this.lblBirthplace.Size = new System.Drawing.Size(73, 18);
            this.lblBirthplace.TabIndex = 8;
            this.lblBirthplace.Text = "Birthplace";
            // 
            // cmbYearOfDeath
            // 
            this.cmbYearOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearOfDeath.FormattingEnabled = true;
            this.cmbYearOfDeath.Location = new System.Drawing.Point(10, 180);
            this.cmbYearOfDeath.Name = "cmbYearOfDeath";
            this.cmbYearOfDeath.Size = new System.Drawing.Size(180, 28);
            this.cmbYearOfDeath.TabIndex = 7;
            this.cmbYearOfDeath.SelectedIndexChanged += new System.EventHandler(this.cmbYearOfDeath_SelectedIndexChanged);
            // 
            // tbBirthplace
            // 
            this.tbBirthplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBirthplace.Location = new System.Drawing.Point(10, 230);
            this.tbBirthplace.Name = "tbBirthplace";
            this.tbBirthplace.Size = new System.Drawing.Size(180, 26);
            this.tbBirthplace.TabIndex = 6;
            this.tbBirthplace.TextChanged += new System.EventHandler(this.tbBirthplace_TextChanged);
            // 
            // lblYearOfDeath
            // 
            this.lblYearOfDeath.AutoSize = true;
            this.lblYearOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearOfDeath.Location = new System.Drawing.Point(10, 160);
            this.lblYearOfDeath.Name = "lblYearOfDeath";
            this.lblYearOfDeath.Size = new System.Drawing.Size(95, 18);
            this.lblYearOfDeath.TabIndex = 5;
            this.lblYearOfDeath.Text = "Year of death";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(10, 10);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Frist name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(10, 30);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(180, 26);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // lblYearOfBirth
            // 
            this.lblYearOfBirth.AutoSize = true;
            this.lblYearOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lblYearOfBirth.Location = new System.Drawing.Point(10, 110);
            this.lblYearOfBirth.Name = "lblYearOfBirth";
            this.lblYearOfBirth.Size = new System.Drawing.Size(87, 18);
            this.lblYearOfBirth.TabIndex = 0;
            this.lblYearOfBirth.Text = "Year of birth";
            // 
            // cmbYearOfBirth
            // 
            this.cmbYearOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearOfBirth.ForeColor = System.Drawing.Color.Black;
            this.cmbYearOfBirth.FormattingEnabled = true;
            this.cmbYearOfBirth.Location = new System.Drawing.Point(10, 130);
            this.cmbYearOfBirth.Name = "cmbYearOfBirth";
            this.cmbYearOfBirth.Size = new System.Drawing.Size(180, 28);
            this.cmbYearOfBirth.TabIndex = 2;
            this.cmbYearOfBirth.SelectedIndexChanged += new System.EventHandler(this.cmbYearOfBirth_SelectedIndexChanged);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.btnEdit);
            this.pnlData.Controls.Add(this.btnAdd);
            this.pnlData.Controls.Add(this.btnDetails);
            this.pnlData.Controls.Add(this.dgvActors);
            this.pnlData.Location = new System.Drawing.Point(220, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(798, 570);
            this.pnlData.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(442, 528);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(548, 528);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // dgvActors
            // 
            this.dgvActors.AllowUserToAddRows = false;
            this.dgvActors.AllowUserToDeleteRows = false;
            this.dgvActors.AllowUserToResizeColumns = false;
            this.dgvActors.AllowUserToResizeRows = false;
            this.dgvActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActors.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvActors.Location = new System.Drawing.Point(10, 10);
            this.dgvActors.MultiSelect = false;
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.ReadOnly = true;
            this.dgvActors.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvActors.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActors.Size = new System.Drawing.Size(744, 512);
            this.dgvActors.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Born";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Birthplace";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Died";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ActorsUcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlFilter);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ActorsUcl";
            this.Size = new System.Drawing.Size(1020, 570);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblYearOfBirth;
        private System.Windows.Forms.ComboBox cmbYearOfBirth;
        private System.Windows.Forms.Label lblYearOfDeath;
        private System.Windows.Forms.TextBox tbBirthplace;
        private System.Windows.Forms.ComboBox cmbYearOfDeath;
        private System.Windows.Forms.Label lblBirthplace;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblMaxMovies;
        private System.Windows.Forms.Label lblMinMovies;
        private System.Windows.Forms.TextBox tbMinMovies;
        private System.Windows.Forms.TextBox tbMaxMovies;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbLastName;
    }
}
