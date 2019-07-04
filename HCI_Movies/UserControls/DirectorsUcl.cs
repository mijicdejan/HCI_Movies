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
            try
            {
                dgvDirectors.Rows.Clear();
                using (MovieDB context = new MovieDB())
                {
                    var directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
                dgvDirectors.Columns["Column3"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dgvDirectors.Columns["Column4"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
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

        public void LoggedIn()
        {
            btnAdd.Show();
            btnEdit.Show();
            btnDelete.Show();
            btnDetails.Hide();
        }

        public void LoggedOut()
        {
            btnAdd.Hide();
            btnEdit.Hide();
            btnDelete.Hide();
            btnDetails.Show();
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
            try
            {
                string firstName = tbFirstName.Text;
                using (MovieDB context = new MovieDB())
                {
                    var directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.first_name.ToLower().StartsWith(firstName.ToLower()) &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lastName = tbLastName.Text;
                using (MovieDB context = new MovieDB())
                {
                    var directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.last_name.ToLower().StartsWith(lastName.ToLower()) &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void cmbYearOfBirth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Year year = (Year)cmbYearOfBirth.SelectedItem;
                using (MovieDB context = new MovieDB())
                {
                    List<director> directors = null;
                    if (year.Value == 0)
                    {
                        directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
                    }
                    else
                    {
                        directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.born.Year.Equals(year.Value) &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void cmbYearOfDeath_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Year year = (Year)cmbYearOfDeath.SelectedItem;
                using (MovieDB context = new MovieDB())
                {
                    List<director> directors = null;
                    if (year.Value == 0)
                    {
                        directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
                    }
                    else
                    {
                        directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.died.HasValue &&
                                     c.member_of_cast_and_crew.died.Value.Year.Equals(year.Value) &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void tbBirthplace_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string birthplace = tbBirthplace.Text;
                using (MovieDB context = new MovieDB())
                {
                    var directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.birthplace.ToLower().StartsWith(birthplace.ToLower()) &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
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
            try
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
                        directors = (from c in context.directors
                                     where
         c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
                    }
                    else
                    {
                        directors = (from c in context.directors
                                     where c.movies.Count >= minMovies &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void tbMaxMovies_TextChanged(object sender, EventArgs e)
        {
            try
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
                        directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
                    }
                    else
                    {
                        directors = (from c in context.directors
                                     where c.movies.Count <= maxMovies &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
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
                            director.member_of_cast_and_crew.born, director.member_of_cast_and_crew.birthplace,
                            director.member_of_cast_and_crew.died);
                        dgvDirectors.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
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
                            birthplace = addMemberOfCastAndCrew.Birthplace,
                            born = addMemberOfCastAndCrew.Born,
                            died = died,
                            bio = addMemberOfCastAndCrew.Bio,
                            image = addMemberOfCastAndCrew.MemberImage,
                            active = 1
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
                        RefreshTableAndFilters();
                        ActorsUcl.Instance.RefreshTableAndFilters();
                        MoviesUcl.Instance.RefreshTableAndFilters();
                        MessageBox.Show("Director successfully added.", "Success", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
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
                        addMemberOfCastAndCrew.Birthplace = director.member_of_cast_and_crew.birthplace;
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
                        var actors = (from c in context.actors
                                      where c.id == director.id &&
                                      c.member_of_cast_and_crew.active == 1
                                      select c).ToList();
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
                            director.member_of_cast_and_crew.birthplace = addMemberOfCastAndCrew.Birthplace;
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
                            RefreshTableAndFilters();
                            ActorsUcl.Instance.RefreshTableAndFilters();
                            MoviesUcl.Instance.RefreshTableAndFilters();
                            MessageBox.Show("Changes successfully saved.", "Success", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("You haven't chosen a director.", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDirectors.SelectedRows.Count > 0)
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        DataGridViewRow row = dgvDirectors.SelectedRows[0];
                        director director = (director)row.Tag;
                        if (MessageBox.Show("Are you sure you want to delete director: " + director.member_of_cast_and_crew.first_name + " " + director.member_of_cast_and_crew.last_name + "?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            context.directors.Attach(director);
                            director.member_of_cast_and_crew.active = 0;
                            context.SaveChanges();
                            RefreshTableAndFilters();
                            ActorsUcl.Instance.RefreshTableAndFilters();
                            MoviesUcl.Instance.RefreshTableAndFilters();
                            MessageBox.Show("Director successfully deleted.", "Success", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("You haven't chosen a director.", "Warning", MessageBoxButtons.OK);
            }
        }

        public void RefreshTableAndFilters()
        {
            FillDirectorsTable();
            tbFirstName.Clear();
            tbLastName.Clear();
            cmbYearOfBirth.SelectedIndex = 0;
            cmbYearOfDeath.SelectedIndex = 0;
            tbBirthplace.Clear();
            tbMinMovies.Clear();
            tbMaxMovies.Clear();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvDirectors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDirectors.SelectedRows[0];
                director director = (director)row.Tag;
                MemberOfCastAndCrewDetailsForm memberOfCastAndCrewDetailsForm = new MemberOfCastAndCrewDetailsForm(director.id, "director");
                memberOfCastAndCrewDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You haven't chosen a director.", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
