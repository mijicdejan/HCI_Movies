using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCI_Movies.Model;
using HCI_Movies.UserControls;

namespace HCI_Movies
{
    public partial class MainForm : Form
    {
        private Button PressedButton;

        public MainForm()
        {
            InitializeComponent();
            SetMoviesUclFirst();
        }

        private void SetMoviesUclFirst()
        {
            if(!pnlUserControl.Controls.Contains(MoviesUcl.Instance))
            {
                pnlUserControl.Controls.Add(MoviesUcl.Instance);
                MoviesUcl.Instance.Dock = DockStyle.Fill;
                MoviesUcl.Instance.BringToFront();
            }
            else
            {
                MoviesUcl.Instance.BringToFront();
            }
            btnMovies.BackColor = Color.WhiteSmoke;
            PressedButton = btnMovies;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                using(MovieDB context = new MovieDB())
                {
                    var users = (from c in context.users
                                where username.Equals(c.username) &&
                                password.Equals(c.password_hash)
                                select c).ToList();
                    if(users.Count == 1)
                    {
                        btnLogIn.Hide();
                        btnLogOut.Show();
                    }
                    else
                    {
                        tbUsername.Clear();
                        tbPassword.Clear();
                        errorProvider.SetError(tbUsername, "Ne postoji uneseno korisničko ime.");
                        errorProvider.SetError(tbPassword, "Ne postoji uneseno korisničko ime.");
                    }
                }
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbUsername, "Niste unijeli korisničko ime.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbUsername, null);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbPassword, "Niste unijeli lozinku.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbPassword, null);
            }
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            if (!pnlUserControl.Controls.Contains(MoviesUcl.Instance))
            {
                pnlUserControl.Controls.Add(MoviesUcl.Instance);
                MoviesUcl.Instance.Dock = DockStyle.Fill;
                MoviesUcl.Instance.BringToFront();
            }
            else
            {
                MoviesUcl.Instance.BringToFront();
            }
            PressedButton.BackColor = Color.White;
            btnMovies.BackColor = Color.WhiteSmoke;
            PressedButton = btnMovies;
        }

        private void btnActors_Click(object sender, EventArgs e)
        {
            if (!pnlUserControl.Controls.Contains(ActorsUcl.Instance))
            {
                pnlUserControl.Controls.Add(ActorsUcl.Instance);
                ActorsUcl.Instance.Dock = DockStyle.Fill;
                ActorsUcl.Instance.BringToFront();
            }
            else
            {
                ActorsUcl.Instance.BringToFront();
            }
            PressedButton.BackColor = Color.White;
            btnActors.BackColor = Color.WhiteSmoke;
            PressedButton = btnActors;
        }

        private void btnDirectors_Click(object sender, EventArgs e)
        {
            if (!pnlUserControl.Controls.Contains(DirectorsUcl.Instance))
            {
                pnlUserControl.Controls.Add(DirectorsUcl.Instance);
                DirectorsUcl.Instance.Dock = DockStyle.Fill;
                DirectorsUcl.Instance.BringToFront();
            }
            else
            {
                DirectorsUcl.Instance.BringToFront();
            }
            PressedButton.BackColor = Color.White;
            btnDirectors.BackColor = Color.WhiteSmoke;
            PressedButton = btnDirectors;
        }
    }
}
