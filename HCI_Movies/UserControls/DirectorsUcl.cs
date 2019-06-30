using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HCI_Movies.Model;

namespace HCI_Movies.UserControls
{
    public partial class DirectorsUcl : UserControl
    {
        private static DirectorsUcl instance;

        List<director> directorsByFirstName = null;
        List<director> directorsByLastName = null;
        List<director> directorsByYearOfBirth = null;
        List<director> directorsByYearOfDeath = null;
        List<director> directorsByBirthplace = null;
        List<director> directorsByMinMovies = null;
        List<director> directorsByMaxMovies = null;

        public static DirectorsUcl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DirectorsUcl();
                }
                return instance;
            }
        }

        public DirectorsUcl()
        {
            InitializeComponent();
            FillDirectorsTable();
            FillYearOfBirthComboBox();
            FillYearOfDeathComboBox();
        }

        private void FillDirectorsTable()
        {
            dgvDirectors.Rows.Clear();
            using (MovieDB context = new MovieDB())
            {
                var directors = (from c in context.directors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                directorsByFirstName = directors;
                directorsByLastName = directors;
                directorsByYearOfBirth = directors;
                directorsByYearOfDeath = directors;
                directorsByBirthplace = directors;
                directorsByMinMovies = directors;
                directorsByMaxMovies = directors;
                foreach (var director in directors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = director
                    };
                    row.CreateCells(dgvDirectors);
                    row.SetValues(director.member_of_cast_and_crew.first_name, director.member_of_cast_and_crew.last_name,
                        director.member_of_cast_and_crew.born, "", director.member_of_cast_and_crew.died);
                    dgvDirectors.Rows.Add(row);
                }
            }
            dgvDirectors.Columns["Column3"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvDirectors.Columns["Column4"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void FillYearOfBirthComboBox()
        {
            List<Year> dataSource = new List<Year>();
            dataSource.Add(new Year() { Name = "All", Value = 0 });
            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                dataSource.Add(new Year() { Name = i.ToString(), Value = i });
            }
            cmbYearOfBirth.DataSource = dataSource;
            cmbYearOfBirth.DisplayMember = "Name";
            cmbYearOfBirth.ValueMember = "Value";
        }

        private void FillYearOfDeathComboBox()
        {
            List<Year> dataSource = new List<Year>();
            dataSource.Add(new Year() { Name = "All", Value = 0 });
            for (int i = DateTime.Now.Year; i >= 1900; i--)
            {
                dataSource.Add(new Year() { Name = i.ToString(), Value = i });
            }
            cmbYearOfDeath.DataSource = dataSource;
            cmbYearOfDeath.DisplayMember = "Name";
            cmbYearOfDeath.ValueMember = "Value";
        }

        private void AllowInt(object sender, KeyPressEventArgs e)
        {
            // allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private List<director> DirectorsIntersect()
        {
            List<director> directors = directorsByFirstName.Intersect(directorsByLastName).ToList();
            directors = directors.Intersect(directorsByYearOfBirth).ToList();
            directors = directors.Intersect(directorsByYearOfDeath).ToList();
            directors = directors.Intersect(directorsByBirthplace).ToList();
            directors = directors.Intersect(directorsByMinMovies).ToList();
            directors = directors.Intersect(directorsByMaxMovies).ToList();
            return directors;
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            using (MovieDB context = new MovieDB())
            {
                var directors = (from c in context.directors
                              where c.member_of_cast_and_crew.first_name.ToLower().StartsWith(firstName.ToLower())
                              select c).ToList();
                directorsByFirstName = directors;
                List<director> filteredDirectors = DirectorsIntersect();
                dgvDirectors.Rows.Clear();
                foreach (var director in filteredDirectors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = director
                    };
                    row.CreateCells(dgvDirectors);
                    row.SetValues(director.member_of_cast_and_crew.first_name, director.member_of_cast_and_crew.last_name,
                        director.member_of_cast_and_crew.born, "", director.member_of_cast_and_crew.died);
                    dgvDirectors.Rows.Add(row);
                }
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            string lastName = tbLastName.Text;
            using (MovieDB context = new MovieDB())
            {
                var directors = (from c in context.directors
                              where c.member_of_cast_and_crew.last_name.ToLower().StartsWith(lastName.ToLower())
                              select c).ToList();
                directorsByLastName = directors;
                List<director> filteredDirectors = DirectorsIntersect();
                dgvDirectors.Rows.Clear();
                foreach (var director in filteredDirectors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = director
                    };
                    row.CreateCells(dgvDirectors);
                    row.SetValues(director.member_of_cast_and_crew.first_name, director.member_of_cast_and_crew.last_name,
                        director.member_of_cast_and_crew.born, "", director.member_of_cast_and_crew.died);
                    dgvDirectors.Rows.Add(row);
                }
            }
        }

        private void cmbYearOfBirth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year year = (Year)cmbYearOfBirth.SelectedItem;
            using (MovieDB context = new MovieDB())
            {
                List<director> directors = null;
                if (year.Value == 0)
                {
                    directors = (from c in context.directors select c).ToList();
                }
                else
                {
                    directors = (from c in context.directors
                              where c.member_of_cast_and_crew.born.Year.Equals(year.Value)
                              select c).ToList();
                }
                directorsByYearOfBirth = directors;
                List<director> filteredDirectors = DirectorsIntersect();
                dgvDirectors.Rows.Clear();
                foreach (var director in filteredDirectors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = director
                    };
                    row.CreateCells(dgvDirectors);
                    row.SetValues(director.member_of_cast_and_crew.first_name, director.member_of_cast_and_crew.last_name,
                        director.member_of_cast_and_crew.born, "", director.member_of_cast_and_crew.died);
                    dgvDirectors.Rows.Add(row);
                }
            }
        }

        private void cmbYearOfDeath_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year year = (Year)cmbYearOfDeath.SelectedItem;
            using (MovieDB context = new MovieDB())
            {
                List<director> directors = null;
                if (year.Value == 0)
                {
                    directors = (from c in context.directors select c).ToList();
                }
                else
                {
                    directors = (from c in context.directors
                              where c.member_of_cast_and_crew.died.HasValue &&
                              c.member_of_cast_and_crew.died.Value.Year.Equals(year.Value)
                              select c).ToList();
                }
                directorsByYearOfDeath = directors;
                List<director> filteredDirectors = DirectorsIntersect();
                dgvDirectors.Rows.Clear();
                foreach (var director in filteredDirectors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = director
                    };
                    row.CreateCells(dgvDirectors);
                    row.SetValues(director.member_of_cast_and_crew.first_name, director.member_of_cast_and_crew.last_name,
                        director.member_of_cast_and_crew.born, "", director.member_of_cast_and_crew.died);
                    dgvDirectors.Rows.Add(row);
                }
            }
        }

        private void tbBirthplace_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
        }

        private void tbMinMovies_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowInt(sender, e);
        }

        private void tbMaxMovies_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowInt(sender, e);
        }

        private void tbMinMovies_TextChanged(object sender, EventArgs e)
        {
            int minMovies = -1;
            if (!tbMinMovies.Text.Equals(""))
            {
                minMovies = int.Parse(tbMinMovies.Text);
            }
            using (MovieDB context = new MovieDB())
            {
                List<director> directors = null;
                if (minMovies == -1)
                {
                    directors = (from c in context.directors select c).ToList();
                }
                else
                {
                    directors = (from c in context.directors where c.movies.Count >= minMovies select c).ToList();
                }
                directorsByMinMovies = directors;
                List<director> filteredDirectors = DirectorsIntersect();
                dgvDirectors.Rows.Clear();
                foreach (var director in filteredDirectors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = director
                    };
                    row.CreateCells(dgvDirectors);
                    row.SetValues(director.member_of_cast_and_crew.first_name, director.member_of_cast_and_crew.last_name,
                        director.member_of_cast_and_crew.born, "", director.member_of_cast_and_crew.died);
                    dgvDirectors.Rows.Add(row);
                }
            }
        }

        private void tbMaxMovies_TextChanged(object sender, EventArgs e)
        {
            int maxMovies = -1;
            if (!tbMaxMovies.Text.Equals(""))
            {
                maxMovies = int.Parse(tbMaxMovies.Text);
            }
            using (MovieDB context = new MovieDB())
            {
                List<director> directors = null;
                if (maxMovies == -1)
                {
                    directors = (from c in context.directors select c).ToList();
                }
                else
                {
                    directors = (from c in context.directors where c.movies.Count <= maxMovies select c).ToList();
                }
                directorsByMaxMovies = directors;
                List<director> filteredDirectors = DirectorsIntersect();
                dgvDirectors.Rows.Clear();
                foreach (var director in filteredDirectors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = director
                    };
                    row.CreateCells(dgvDirectors);
                    row.SetValues(director.member_of_cast_and_crew.first_name, director.member_of_cast_and_crew.last_name,
                        director.member_of_cast_and_crew.born, "", director.member_of_cast_and_crew.died);
                    dgvDirectors.Rows.Add(row);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMemberOfCastAndCrewForm addMemberOfCastAndCrew = new AddMemberOfCastAndCrewForm("director");
            if (DialogResult.OK == addMemberOfCastAndCrew.ShowDialog())
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        DateTime? died = addMemberOfCastAndCrew.Dead ? addMemberOfCastAndCrew.Died : (DateTime?)null;
                        var memberOfCastAndCrew = new member_of_cast_and_crew()
                        {
                            first_name = addMemberOfCastAndCrew.FirstName,
                            last_name = addMemberOfCastAndCrew.LastName,
                            born = addMemberOfCastAndCrew.Born,
                            died = died,
                            bio = addMemberOfCastAndCrew.Bio,
                            image = addMemberOfCastAndCrew.MemberImage
                        };
                        var director = new director()
                        {
                            member_of_cast_and_crew = memberOfCastAndCrew
                        };
                        context.directors.Add(director);
                        if (addMemberOfCastAndCrew.DoubleMember)
                        {
                            var actor = new actor()
                            {
                                member_of_cast_and_crew = memberOfCastAndCrew
                            };
                            context.actors.Add(actor);
                        }
                        context.SaveChanges();
                        FillDirectorsTable();
                        tbFirstName.Clear();
                        tbLastName.Clear();
                        cmbYearOfBirth.SelectedIndex = 0;
                        cmbYearOfDeath.SelectedIndex = 0;
                        tbBirthplace.Clear();
                        tbMinMovies.Clear();
                        tbMaxMovies.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddMemberOfCastAndCrewForm addMemberOfCastAndCrew = new AddMemberOfCastAndCrewForm("director");
            if (dgvDirectors.SelectedRows.Count > 0)
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        DataGridViewRow row = dgvDirectors.SelectedRows[0];
                        director director = (director)row.Tag;
                        addMemberOfCastAndCrew.FirstName = director.member_of_cast_and_crew.first_name;
                        addMemberOfCastAndCrew.LastName = director.member_of_cast_and_crew.last_name;
                        addMemberOfCastAndCrew.Born = director.member_of_cast_and_crew.born;
                        if (director.member_of_cast_and_crew.died.HasValue)
                        {
                            addMemberOfCastAndCrew.Dead = true;
                            addMemberOfCastAndCrew.Died = director.member_of_cast_and_crew.died.Value;
                        }
                        else
                        {
                            addMemberOfCastAndCrew.Dead = false;
                        }
                        addMemberOfCastAndCrew.MemberImage = director.member_of_cast_and_crew.image;
                        addMemberOfCastAndCrew.Bio = director.member_of_cast_and_crew.bio;
                        var actors = (from c in context.actors where c.id == director.id select c).ToList();
                        if (actors.Count > 0)
                        {
                            addMemberOfCastAndCrew.DoubleMember = true;
                        }
                        else
                        {
                            addMemberOfCastAndCrew.DoubleMember = false;
                        }

                        if (DialogResult.OK == addMemberOfCastAndCrew.ShowDialog())
                        {
                            context.directors.Attach(director);
                            director.member_of_cast_and_crew.first_name = addMemberOfCastAndCrew.FirstName;
                            director.member_of_cast_and_crew.last_name = addMemberOfCastAndCrew.LastName;
                            director.member_of_cast_and_crew.born = addMemberOfCastAndCrew.Born;
                            if (addMemberOfCastAndCrew.Dead)
                            {
                                director.member_of_cast_and_crew.died = addMemberOfCastAndCrew.Died;
                            }
                            else
                            {
                                director.member_of_cast_and_crew.died = null;
                            }
                            director.member_of_cast_and_crew.image = addMemberOfCastAndCrew.MemberImage;
                            director.member_of_cast_and_crew.bio = addMemberOfCastAndCrew.Bio;

                            if (addMemberOfCastAndCrew.DoubleMember)
                            {
                                if (actors.Count == 0)
                                {
                                    var actor = new actor()
                                    {
                                        member_of_cast_and_crew = director.member_of_cast_and_crew
                                    };
                                    context.actors.Add(actor);
                                }
                            }
                            else
                            {
                                if (actors.Count > 0)
                                {
                                    var actor = actors[0];
                                    context.actors.Remove(actor);
                                }
                            }
                            context.SaveChanges();
                            FillDirectorsTable();
                            tbFirstName.Clear();
                            tbLastName.Clear();
                            cmbYearOfBirth.SelectedIndex = 0;
                            cmbYearOfDeath.SelectedIndex = 0;
                            tbBirthplace.Clear();
                            tbMinMovies.Clear();
                            tbMaxMovies.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("You haven't chosen a director.");
            }
        }
    }
}
