using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Movies
{
    public partial class AddMemberOfCastAndCrewForm : Form
    {
        public string Member { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthplace { get; set; }
        public DateTime Born { get; set; }
        public DateTime Died { get; set; }
        public bool Dead { get; set; }
        public string Bio { get; set; }
        public bool DoubleMember { get; set; }
        public string MemberImage { get; set; }

        public AddMemberOfCastAndCrewForm(string member)
        {
            Member = member;
            DoubleMember = false;
            InitializeComponent();
            Text = member.First().ToString().ToUpper() + member.Substring(1);
            if (member.Equals("actor"))
            {
                cbDoubleMember.Text = "Also a director?";
            }
            else if(member.Equals("director"))
            {
                cbDoubleMember.Text = "Also an actor?";
            }
            MemberImage = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\default.png";
            Born = DateTime.Today;
            Died = DateTime.Today;
            dtpBorn.MaxDate = DateTime.Today;
            dtpDied.MaxDate = DateTime.Today;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                MemberImage = file.FileName;
                pbImage.Image = Image.FromFile(MemberImage);
                if(MemberImage.Contains(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName))
                {
                    MemberImage = MemberImage.Substring(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Length);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if("".Equals(tbFirstName.Text))
            {
                MessageBox.Show("You have to enter first name.", "Warning", MessageBoxButtons.OK);
            }
            else if("".Equals(tbLastName.Text))
            {
                MessageBox.Show("You have to enter last name.", "Warning", MessageBoxButtons.OK);
            }
            else if ("".Equals(tbBirthplace.Text))
            {
                MessageBox.Show("You have to enter birthplace.", "Warning", MessageBoxButtons.OK);
            }
            else if ("".Equals(rtbBio.Text))
            {
                MessageBox.Show("You have to enter bio.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                FirstName = tbFirstName.Text;
                LastName = tbLastName.Text;
                Birthplace = tbBirthplace.Text;
                Born = dtpBorn.Value.Date;
                Died = dtpDied.Value.Date;
                Bio = rtbBio.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void cbDied_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDied.Checked)
            {
                Dead = true;
                dtpDied.Enabled = true;
            }
            else
            {
                Dead = false;
                dtpDied.Enabled = false;
            }
        }

        private void cbDoubleMember_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDoubleMember.Checked)
            {
                DoubleMember = true;
            }
            else
            {
                DoubleMember = false;
            }
        }

        private void AddMemberOfCastAndCrewForm_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = FirstName;
            tbLastName.Text = LastName;
            tbBirthplace.Text = Birthplace;
            dtpBorn.Value = Born;
            cbDied.Checked = Dead;
            if(Dead)
            {
                dtpDied.Enabled = true;
                dtpDied.Value = Died;
            }
            else
            {
                dtpDied.Enabled = false;
            }
            if(MemberImage.StartsWith("\\"))
            {
                MemberImage = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + MemberImage;
            }
            try
            {
                pbImage.Image = Image.FromFile(MemberImage);
            }
            catch(FileNotFoundException ex)
            {
                pbImage.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\default.png");
            }
            rtbBio.Text = Bio;
            cbDoubleMember.Checked = DoubleMember;
        }
    }
}
