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
    public partial class AddLanguageForm : Form
    {
        public string LanguageName { get; set; }

        public AddLanguageForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!"".Equals(tbName.Text))
            {
                LanguageName = tbName.Text.First().ToString().ToUpper() + tbName.Text.Substring(1).ToLower();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You have to enter language name.");
            }
        }
    }
}
