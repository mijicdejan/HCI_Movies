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
    public partial class ActorsUcl : UserControl
    {
        private static ActorsUcl instance;

        List<actor> actorsByFirstName = null;
        List<actor> actorsByLastName = null;
        List<actor> actorsByYearOfBirth = null;
        List<actor> actorsByYearOfDeath = null;
        List<actor> actorsByBirthplace = null;
        List<actor> actorsByMinMovies = null;
        List<actor> actorsByMaxMovies = null;

        public static ActorsUcl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ActorsUcl();
                }
                return instance;
            }
        }

        protected ActorsUcl()
        {
            InitializeComponent();
            FillActorsTable();
            FillYearOfBirthComboBox();
            FillYearOfDeathComboBox();
        }

        private void FillActorsTable()
        {
            try
            {
                dgvActors.Rows.Clear();
                using (MovieDB context = new MovieDB())
                {
                    var actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    actorsByFirstName = actors;
                    actorsByLastName = actors;
                    actorsByYearOfBirth = actors;
                    actorsByYearOfDeath = actors;
                    actorsByBirthplace = actors;
                    actorsByMinMovies = actors;
                    actorsByMaxMovies = actors;
                    foreach (var actor in actors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
                    }
                }
                dgvActors.Columns["Column3"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dgvActors.Columns["Column4"].DefaultCellStyle.Format = "dd.MM.yyyy";
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

        private List<actor> ActorsIntersect()
        {
            List<actor> actors = actorsByFirstName.Intersect(actorsByLastName).ToList();
            actors = actors.Intersect(actorsByYearOfBirth).ToList();
            actors = actors.Intersect(actorsByYearOfDeath).ToList();
            actors = actors.Intersect(actorsByBirthplace).ToList();
            actors = actors.Intersect(actorsByMinMovies).ToList();
            actors = actors.Intersect(actorsByMaxMovies).ToList();
            return actors;
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string firstName = tbFirstName.Text;
                using (MovieDB context = new MovieDB())
                {
                    var actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.first_name.ToLower().StartsWith(firstName.ToLower()) &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    actorsByFirstName = actors;
                    List<actor> filteredActors = ActorsIntersect();
                    dgvActors.Rows.Clear();
                    foreach (var actor in filteredActors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
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
                    var actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.last_name.ToLower().StartsWith(lastName.ToLower()) &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    actorsByLastName = actors;
                    List<actor> filteredActors = ActorsIntersect();
                    dgvActors.Rows.Clear();
                    foreach (var actor in filteredActors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
                    }
                }
            }
            catch(Exception ex)
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
                    List<actor> actors = null;
                    if (year.Value == 0)
                    {
                        actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    else
                    {
                        actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.born.Year.Equals(year.Value) &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    actorsByYearOfBirth = actors;
                    List<actor> filteredActors = ActorsIntersect();
                    dgvActors.Rows.Clear();
                    foreach (var actor in filteredActors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
                    }
                }
            }
            catch(Exception ex)
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
                    List<actor> actors = null;
                    if (year.Value == 0)
                    {
                        actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    else
                    {
                        actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.died.HasValue &&
                                  c.member_of_cast_and_crew.died.Value.Year.Equals(year.Value) &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    actorsByYearOfDeath = actors;
                    List<actor> filteredActors = ActorsIntersect();
                    dgvActors.Rows.Clear();
                    foreach (var actor in filteredActors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
                    }
                }
            }
            catch(Exception ex)
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
                    var actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.birthplace.ToLower().Contains(birthplace.ToLower()) &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    actorsByLastName = actors;
                    List<actor> filteredActors = ActorsIntersect();
                    dgvActors.Rows.Clear();
                    foreach (var actor in filteredActors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
                    }
                }
            }
            catch(Exception ex)
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
                    List<actor> actors = null;
                    if (minMovies == -1)
                    {
                        actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    else
                    {
                        actors = (from c in context.actors
                                  where c.movies.Count >= minMovies &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    actorsByMinMovies = actors;
                    List<actor> filteredActors = ActorsIntersect();
                    dgvActors.Rows.Clear();
                    foreach (var actor in filteredActors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
                    }
                }
            }
            catch(Exception ex)
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
                    List<actor> actors = null;
                    if (maxMovies == -1)
                    {
                        actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    else
                    {
                        actors = (from c in context.actors
                                  where c.movies.Count <= maxMovies &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    actorsByMaxMovies = actors;
                    List<actor> filteredActors = ActorsIntersect();
                    dgvActors.Rows.Clear();
                    foreach (var actor in filteredActors)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = actor
                        };
                        row.CreateCells(dgvActors);
                        row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                            actor.member_of_cast_and_crew.born, actor.member_of_cast_and_crew.birthplace,
                            actor.member_of_cast_and_crew.died);
                        dgvActors.Rows.Add(row);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMemberOfCastAndCrewForm addMemberOfCastAndCrew = new AddMemberOfCastAndCrewForm("actor");
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
                        var actor = new actor()
                        {
                            member_of_cast_and_crew = memberOfCastAndCrew
                        };
                        context.actors.Add(actor);
                        if (addMemberOfCastAndCrew.DoubleMember)
                        {
                            var director = new director()
                            {
                                member_of_cast_and_crew = memberOfCastAndCrew
                            };
                            context.directors.Add(director);
                        }
                        context.SaveChanges();
                        RefreshTableAndFilters();
                        DirectorsUcl.Instance.RefreshTableAndFilters();
                        MoviesUcl.Instance.RefreshTableAndFilters();
                        MessageBox.Show("Actor successfully added.", "Success", MessageBoxButtons.OK);

                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddMemberOfCastAndCrewForm addMemberOfCastAndCrew = new AddMemberOfCastAndCrewForm("actor");
            if(dgvActors.SelectedRows.Count > 0)
            {
                try
                {
                    using(MovieDB context = new MovieDB())
                    {
                        DataGridViewRow row = dgvActors.SelectedRows[0];
                        actor actor = (actor)row.Tag;
                        addMemberOfCastAndCrew.FirstName = actor.member_of_cast_and_crew.first_name;
                        addMemberOfCastAndCrew.LastName = actor.member_of_cast_and_crew.last_name;
                        addMemberOfCastAndCrew.Birthplace = actor.member_of_cast_and_crew.birthplace;
                        addMemberOfCastAndCrew.Born = actor.member_of_cast_and_crew.born;
                        if(actor.member_of_cast_and_crew.died.HasValue)
                        {
                            addMemberOfCastAndCrew.Dead = true;
                            addMemberOfCastAndCrew.Died = actor.member_of_cast_and_crew.died.Value;
                        }
                        else
                        {
                            addMemberOfCastAndCrew.Dead = false;
                        }
                        addMemberOfCastAndCrew.MemberImage = actor.member_of_cast_and_crew.image;
                        addMemberOfCastAndCrew.Bio = actor.member_of_cast_and_crew.bio;
                        var directors = (from c in context.directors
                                         where c.id == actor.id &&
                                         c.member_of_cast_and_crew.active == 1
                                         select c).ToList();
                        if(directors.Count > 0)
                        {
                            addMemberOfCastAndCrew.DoubleMember = true;
                        }
                        else
                        {
                            addMemberOfCastAndCrew.DoubleMember = false;
                        }

                        if(DialogResult.OK == addMemberOfCastAndCrew.ShowDialog())
                        {
                            context.actors.Attach(actor);
                            actor.member_of_cast_and_crew.first_name = addMemberOfCastAndCrew.FirstName;
                            actor.member_of_cast_and_crew.last_name = addMemberOfCastAndCrew.LastName;
                            actor.member_of_cast_and_crew.birthplace = addMemberOfCastAndCrew.Birthplace;
                            actor.member_of_cast_and_crew.born = addMemberOfCastAndCrew.Born;
                            if(addMemberOfCastAndCrew.Dead)
                            {
                                actor.member_of_cast_and_crew.died = addMemberOfCastAndCrew.Died;
                            }
                            else
                            {
                                actor.member_of_cast_and_crew.died = null;
                            }
                            actor.member_of_cast_and_crew.image = addMemberOfCastAndCrew.MemberImage;
                            actor.member_of_cast_and_crew.bio = addMemberOfCastAndCrew.Bio;

                            if (addMemberOfCastAndCrew.DoubleMember)
                            {
                                if(directors.Count == 0)
                                {
                                    var director = new director()
                                    {
                                        member_of_cast_and_crew = actor.member_of_cast_and_crew
                                    };
                                    context.directors.Add(director);
                                }
                            }
                            else
                            {
                                if(directors.Count > 0)
                                {
                                    var director = directors[0];
                                    context.directors.Remove(director);
                                }
                            }
                            context.SaveChanges();
                            RefreshTableAndFilters();
                            DirectorsUcl.Instance.RefreshTableAndFilters();
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
                MessageBox.Show("You haven't chosen an actor.", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvActors.SelectedRows.Count > 0)
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        DataGridViewRow row = dgvActors.SelectedRows[0];
                        actor actor = (actor)row.Tag;
                        if (MessageBox.Show("Are you sure you want to delete actor: " + actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name + "?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            context.actors.Attach(actor);
                            actor.member_of_cast_and_crew.active = 0;
                            context.SaveChanges();
                            RefreshTableAndFilters();
                            DirectorsUcl.Instance.RefreshTableAndFilters();
                            MoviesUcl.Instance.RefreshTableAndFilters();
                            MessageBox.Show("Actor successfully deleted.", "Success", MessageBoxButtons.OK);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("You haven't chosen an actor.", "Warning", MessageBoxButtons.OK);
            }
        }

        public void RefreshTableAndFilters()
        {
            FillActorsTable();
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
            if(dgvActors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvActors.SelectedRows[0];
                actor actor = (actor)row.Tag;
                MemberOfCastAndCrewDetailsForm memberOfCastAndCrewDetailsForm = new MemberOfCastAndCrewDetailsForm(actor.id, "actor");
                memberOfCastAndCrewDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You haven't chosen an actor.", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
