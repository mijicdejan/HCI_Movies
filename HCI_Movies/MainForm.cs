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
            if("".Equals(username))
            {
                MessageBox.Show("You have to enter username.", "Warning", MessageBoxButtons.OK);
            }
            else if("".Equals(password))
            {
                MessageBox.Show("You have to enter password.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        var users = (from c in context.users
                                     where username.Equals(c.username) &&
                                     c.active == 1
                                     select c).ToList();
                        if (users.Count == 1)
                        {
                            var user = users[0];
                            string salt = user.salt;
                            string hash = UserService.GetPasswordHash(salt, password);
                            if (hash.Equals(user.password_hash))
                            {
                                btnLogIn.Hide();
                                btnLogOut.Show();
                                lblUsername.Hide();
                                tbUsername.Hide();
                                lblPassword.Hide();
                                tbPassword.Hide();
                                lblLoggedInUsername.Text = username;
                                lblLoggedInUsername.Show();
                                MoviesUcl.Instance.LoggedIn();
                                ActorsUcl.Instance.LoggedIn();
                                DirectorsUcl.Instance.LoggedIn();
                            }
                            else
                            {
                                tbUsername.Clear();
                                tbPassword.Clear();
                                MessageBox.Show("Incorrect username or password.", "Warning", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            tbUsername.Clear();
                            tbPassword.Clear();
                            MessageBox.Show("Incorrect username or password.", "Warning", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            btnLogIn.Show();
            btnLogOut.Hide();
            lblUsername.Show();
            tbUsername.Clear();
            tbUsername.Show();
            lblPassword.Show();
            tbPassword.Clear();
            tbPassword.Show();
            lblLoggedInUsername.Hide();
            MoviesUcl.Instance.LoggedOut();
            ActorsUcl.Instance.LoggedOut();
            DirectorsUcl.Instance.LoggedOut();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            if (!pnlUserControl.Controls.Contains(MoviesUcl.Instance))
            {
                if (pnlUserControl.Controls.Contains(ActorsUcl.Instance))
                {
                    pnlUserControl.Controls.Remove(ActorsUcl.Instance);
                }
                else if (pnlUserControl.Controls.Contains(DirectorsUcl.Instance))
                {
                    pnlUserControl.Controls.Remove(DirectorsUcl.Instance);
                }
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
                if (pnlUserControl.Controls.Contains(MoviesUcl.Instance))
                {
                    pnlUserControl.Controls.Remove(MoviesUcl.Instance);
                }
                else if (pnlUserControl.Controls.Contains(DirectorsUcl.Instance))
                {
                    pnlUserControl.Controls.Remove(DirectorsUcl.Instance);
                }
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
                if (pnlUserControl.Controls.Contains(ActorsUcl.Instance))
                {
                    pnlUserControl.Controls.Remove(ActorsUcl.Instance);
                }
                else if (pnlUserControl.Controls.Contains(MoviesUcl.Instance))
                {
                    pnlUserControl.Controls.Remove(MoviesUcl.Instance);
                }
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
