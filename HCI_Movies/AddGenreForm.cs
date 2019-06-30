using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Movies
{
    public partial class AddGenreForm : Form
    {
        public string GenreName { get; set; }

        public AddGenreForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!"".Equals(tbName.Text))
            {
                GenreName = tbName.Text.ToLower();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You have to enter genre name.");
            }
        }
    }
}
