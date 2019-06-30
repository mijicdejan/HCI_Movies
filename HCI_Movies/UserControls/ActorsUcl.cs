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
            dgvActors.Rows.Clear();
            using(MovieDB context = new MovieDB())
            {
                var actors = (from c in context.actors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                actorsByFirstName = actors;
                actorsByLastName = actors;
                actorsByYearOfBirth = actors;
                actorsByYearOfDeath = actors;
                actorsByBirthplace = actors;
                actorsByMinMovies = actors;
                actorsByMaxMovies = actors;
                foreach(var actor in actors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = actor
                    };
                    row.CreateCells(dgvActors);
                    row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                        actor.member_of_cast_and_crew.born, "", actor.member_of_cast_and_crew.died);
                    dgvActors.Rows.Add(row);
                }
            }
            dgvActors.Columns["Column3"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvActors.Columns["Column4"].DefaultCellStyle.Format = "dd.MM.yyyy";
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
            string firstName = tbFirstName.Text;
            using(MovieDB context = new MovieDB())
            {
                var actors = (from c in context.actors
                              where c.member_of_cast_and_crew.first_name.ToLower().StartsWith(firstName.ToLower())
                              select c).ToList();
                actorsByFirstName = actors;
                List<actor> filteredActors = ActorsIntersect();
                dgvActors.Rows.Clear();
                foreach(var actor in filteredActors)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = actor
                    };
                    row.CreateCells(dgvActors);
                    row.SetValues(actor.member_of_cast_and_crew.first_name, actor.member_of_cast_and_crew.last_name,
                        actor.member_of_cast_and_crew.born, "", actor.member_of_cast_and_crew.died);
                    dgvActors.Rows.Add(row);
                }
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            string lastName = tbLastName.Text;
            using (MovieDB context = new MovieDB())
            {
                var actors = (from c in context.actors
                              where c.member_of_cast_and_crew.last_name.ToLower().StartsWith(lastName.ToLower())
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
                        actor.member_of_cast_and_crew.born, "", actor.member_of_cast_and_crew.died);
                    dgvActors.Rows.Add(row);
                }
            }
        }

        private void cmbYearOfBirth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year year = (Year)cmbYearOfBirth.SelectedItem;
            using(MovieDB context = new MovieDB())
            {
                List<actor> actors = null;
                if(year.Value == 0)
                {
                    actors = (from c in context.actors select c).ToList();
                }
                else
                {
                    actors = (from c in context.actors
                              where c.member_of_cast_and_crew.born.Year.Equals(year.Value)
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
                        actor.member_of_cast_and_crew.born, "", actor.member_of_cast_and_crew.died);
                    dgvActors.Rows.Add(row);
                }
            }
        }

        private void cmbYearOfDeath_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year year = (Year)cmbYearOfDeath.SelectedItem;
            using (MovieDB context = new MovieDB())
            {
                List<actor> actors = null;
                if (year.Value == 0)
                {
                    actors = (from c in context.actors select c).ToList();
                }
                else
                {
                    actors = (from c in context.actors
                              where c.member_of_cast_and_crew.died.HasValue &&
                              c.member_of_cast_and_crew.died.Value.Year.Equals(year.Value)
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
                        actor.member_of_cast_and_crew.born, "", actor.member_of_cast_and_crew.died);
                    dgvActors.Rows.Add(row);
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
            if(!tbMinMovies.Text.Equals(""))
            {
                minMovies = int.Parse(tbMinMovies.Text);
            }
            using(MovieDB context = new MovieDB())
            {
                List<actor> actors = null;
                if(minMovies == -1)
                {
                    actors = (from c in context.actors select c).ToList();
                }
                else
                {
                    actors = (from c in context.actors where c.movies.Count >= minMovies select c).ToList();
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
                        actor.member_of_cast_and_crew.born, "", actor.member_of_cast_and_crew.died);
                    dgvActors.Rows.Add(row);
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
                List<actor> actors = null;
                if (maxMovies == -1)
                {
                    actors = (from c in context.actors select c).ToList();
                }
                else
                {
                    actors = (from c in context.actors where c.movies.Count <= maxMovies select c).ToList();
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
                        actor.member_of_cast_and_crew.born, "", actor.member_of_cast_and_crew.died);
                    dgvActors.Rows.Add(row);
                }
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
                            born = addMemberOfCastAndCrew.Born,
                            died = died,
                            bio = addMemberOfCastAndCrew.Bio,
                            image = addMemberOfCastAndCrew.MemberImage
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
                        FillActorsTable();
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
                        var directors = (from c in context.directors where c.id == actor.id select c).ToList();
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
                            FillActorsTable();
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
                MessageBox.Show("You haven't chosen an actor.");
            }
        }
    }
}
