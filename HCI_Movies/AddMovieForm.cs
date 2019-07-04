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
using HCI_Movies.Model;
using HCI_Movies.UserControls;

namespace HCI_Movies
{
    public partial class AddMovieForm : Form
    {
        List<actor> actors = null;
        List<director> directors = null;

        public string MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Runtime { get; set; }
        public decimal Budget { get; set; }
        public decimal? Gross { get; set; }
        public string Tagline { get; set; }
        public string PlotSummary { get; set; }
        public List<genre> Genres { get; set; }
        public List<language> Languages { get; set; }
        public List<actor> MovieActors { get; set; }
        public List<director> MovieDirectors { get; set; }
        public string Poster { get; set; }

        bool IsLoadedGenres = true;
        bool IsLoadedLanguages = true;
        bool IsLoadedActors = true;
        bool IsLoadedDirectors = true;
        List<genre> checkedGenres = new List<genre>();
        List<language> checkedLanguages = new List<language>();
        List<actor> checkedActors = new List<actor>();
        List<director> checkedDirectors = new List<director>();

        public AddMovieForm()
        {
            InitializeComponent();
            FillGenresList();
            FillLanguagesList();
            FillActorsList();
            FillDirectorsList();
            ReleaseDate = DateTime.Today;
            Poster = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Posters\\default.png";
            Genres = new List<genre>();
            Languages = new List<language>();
            MovieActors = new List<actor>();
            MovieDirectors = new List<director>();
        }

        private void FillGenresList()
        {
            lvGenres.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvGenres.Columns.Add(header);
            lvGenres.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvGenres.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvGenres.CheckBoxes = true;
                    var genres = (from c in context.genres where c.active == 1 orderby c.name select c).ToList();
                    foreach (var genre in genres)
                    {
                        var item = new ListViewItem(genre.name);
                        item.Tag = genre;
                        lvGenres.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void FillLanguagesList()
        {
            lvLanguages.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvLanguages.Columns.Add(header);
            lvLanguages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvLanguages.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvLanguages.CheckBoxes = true;
                    var languages = (from c in context.languages where c.active == 1 orderby c.name select c).ToList();
                    foreach (var language in languages)
                    {
                        var item = new ListViewItem(language.name);
                        item.Tag = language;
                        lvLanguages.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void FillActorsList()
        {
            lvActors.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvActors.Columns.Add(header);
            lvActors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvActors.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvActors.CheckBoxes = true;
                    actors = (from c in context.actors
                              where c.member_of_cast_and_crew.active == 1
                              orderby c.member_of_cast_and_crew.first_name
                              select c).ToList();
                    foreach (var actor in actors)
                    {
                        var item = new ListViewItem(actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name);
                        item.Tag = actor;
                        lvActors.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void FillDirectorsList()
        {
            lvDirectors.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvDirectors.Columns.Add(header);
            lvDirectors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvDirectors.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvDirectors.CheckBoxes = true;
                    directors = (from c in context.directors
                                 where c.member_of_cast_and_crew.active == 1
                                 orderby c.member_of_cast_and_crew.first_name
                                 select c).ToList();
                    foreach (var director in directors)
                    {
                        var item = new ListViewItem(director.member_of_cast_and_crew.first_name + " " + director.member_of_cast_and_crew.last_name);
                        item.Tag = director;
                        lvDirectors.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void AllowDecimal(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.' && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
            if(e.KeyChar == '.' && (sender as TextBox).Text.LastIndexOf('.') > 0)
            {
                e.Handled = true;
                return;
            }
            // allows 0-9 and backspace
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbName.Text))
            {
                MessageBox.Show("You have to enter movie name.", "Warning", MessageBoxButtons.OK);
            }
            else if("".Equals(tbRuntime.Text))
            {
                MessageBox.Show("You have to enter runtime.", "Warning", MessageBoxButtons.OK);
            }
            else if ("".Equals(tbBudget.Text))
            {
                MessageBox.Show("You have to enter budget.", "Warning", MessageBoxButtons.OK);
            }
            else if ("".Equals(tbTagline.Text))
            {
                MessageBox.Show("You have to enter tagline.", "Warning", MessageBoxButtons.OK);
            }
            else if ("".Equals(rtbPlotSummary.Text))
            {
                MessageBox.Show("You have to enter plot summary.", "Warning", MessageBoxButtons.OK);
            }
            else if (lvGenres.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one genre.", "Warning", MessageBoxButtons.OK);
            }
            else if (lvLanguages.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one language.", "Warning", MessageBoxButtons.OK);
            }
            else if (lvActors.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one actor.", "Warning", MessageBoxButtons.OK);
            }
            else if (lvDirectors.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one director.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                MovieName = tbName.Text;
                ReleaseDate = dtpReleaseDate.Value.Date;
                Runtime = int.Parse(tbRuntime.Text);
                Budget = decimal.Parse(tbBudget.Text);
                if ("".Equals(tbGross.Text))
                {
                    Gross = null;
                }
                else
                {
                    Gross = decimal.Parse(tbGross.Text);
                }
                Tagline = tbTagline.Text;
                PlotSummary = rtbPlotSummary.Text;
                var selectedTags = lvGenres.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag);
                Genres = new List<genre>();
                foreach (var genre in selectedTags)
                {
                    Genres.Add((genre)genre);
                }
                selectedTags = lvLanguages.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag);
                Languages = new List<language>();
                foreach (var language in selectedTags)
                {
                    Languages.Add((language)language);
                }
                selectedTags = lvActors.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag);
                MovieActors = new List<actor>();
                foreach(var actor in selectedTags)
                {
                    MovieActors.Add((actor)actor);
                }
                selectedTags = lvDirectors.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag);
                MovieDirectors = new List<director>();
                foreach(var director in selectedTags)
                {
                    MovieDirectors.Add((director)director);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnPoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                Poster = file.FileName;
                pbPoster.Image = Image.FromFile(Poster);
                if (Poster.Contains(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName))
                {
                    Poster = Poster.Substring(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Length);
                }
            }
        }

        private void btnAddActor_Click(object sender, EventArgs e)
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
                        FillActorsList();
                        var actorItems = lvActors.Items;
                        foreach (var checkedActor in MovieActors.ToList())
                        {
                            foreach (var item in actorItems)
                            {
                                actor actorItem = (actor)(item as ListViewItem).Tag;
                                if (actorItem.id == checkedActor.id)
                                {
                                    (item as ListViewItem).Checked = true;
                                }
                            }
                        }
                        FillDirectorsList();
                        var directorItems = lvDirectors.Items;
                        foreach (var checkedDirector in MovieDirectors.ToList())
                        {
                            foreach (var item in directorItems)
                            {
                                director directorItem = (director)(item as ListViewItem).Tag;
                                if (directorItem.id == checkedDirector.id)
                                {
                                    (item as ListViewItem).Checked = true;
                                }
                            }
                        }
                        MoviesUcl.Instance.RefreshTableAndFilters();
                        ActorsUcl.Instance.RefreshTableAndFilters();
                        DirectorsUcl.Instance.RefreshTableAndFilters();
                        MessageBox.Show("Actor successfully added.", "Success", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void btnAddDirector_Click(object sender, EventArgs e)
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
                        FillDirectorsList();
                        var directorItems = lvDirectors.Items;
                        foreach (var checkedDirector in MovieDirectors.ToList())
                        {
                            foreach (var item in directorItems)
                            {
                                director directorItem = (director)(item as ListViewItem).Tag;
                                if (directorItem.id == checkedDirector.id)
                                {
                                    (item as ListViewItem).Checked = true;
                                }
                            }
                        }
                        FillActorsList();
                        var actorItems = lvActors.Items;
                        foreach (var checkedActor in MovieActors.ToList())
                        {
                            foreach (var item in actorItems)
                            {
                                actor actorItem = (actor)(item as ListViewItem).Tag;
                                if (actorItem.id == checkedActor.id)
                                {
                                    (item as ListViewItem).Checked = true;
                                }
                            }
                        }
                        MoviesUcl.Instance.RefreshTableAndFilters();
                        ActorsUcl.Instance.RefreshTableAndFilters();
                        DirectorsUcl.Instance.RefreshTableAndFilters();
                        MessageBox.Show("Director successfully added.", "Success", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            tbName.Text = MovieName;
            tbRuntime.Text = Runtime == 0 ? "" : Runtime.ToString();
            dtpReleaseDate.Value = ReleaseDate;
            tbBudget.Text = Budget == 0 ? "" : Budget.ToString();
            tbGross.Text = Gross == 0 ? "" : Gross.ToString();
            tbTagline.Text = Tagline;
            rtbPlotSummary.Text = PlotSummary;
            if (Poster.StartsWith("\\"))
            {
                Poster = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Poster;
            }
            try
            {
                pbPoster.Image = Image.FromFile(Poster);
            }
            catch (FileNotFoundException ex)
            {
                pbPoster.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Posters\\default.png");
            }
            var genreItems = lvGenres.Items;
            foreach (var genre in Genres.ToList())
            {
                foreach (var item in genreItems)
                {
                    genre genreItem = (genre)(item as ListViewItem).Tag;
                    if (genreItem.id == genre.id)
                    {
                        (item as ListViewItem).Checked = true;
                    }
                }
                checkedGenres.Add(genre);
            }
            var languageItems = lvLanguages.Items;
            foreach (var language in Languages.ToList())
            {
                foreach (var item in languageItems)
                {
                    language languageItem = (language)(item as ListViewItem).Tag;
                    if (languageItem.id == language.id)
                    {
                        (item as ListViewItem).Checked = true;
                    }
                }
                checkedLanguages.Add(language);
            }
            var actorItems = lvActors.Items;
            foreach(var actor in MovieActors.ToList())
            {
                foreach(var item in actorItems)
                {
                    actor actorItem = (actor)(item as ListViewItem).Tag;
                    if(actorItem.id == actor.id)
                    {
                        (item as ListViewItem).Checked = true;
                    }
                }
                checkedActors.Add(actor);
            }
            var directorItems = lvDirectors.Items;
            foreach (var director in MovieDirectors.ToList())
            {
                foreach (var item in directorItems)
                {
                    director directorItem = (director)(item as ListViewItem).Tag;
                    if (directorItem.id == director.id)
                    {
                        (item as ListViewItem).Checked = true;
                    }
                }
                checkedDirectors.Add(director);
            }
        }

        private void tbGenres_TextChanged(object sender, EventArgs e)
        {
            IsLoadedGenres = false;
            string text = tbGenres.Text;
            lvGenres.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvGenres.Columns.Add(header);
            lvGenres.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvGenres.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvGenres.CheckBoxes = true;
                    List<genre> genres = null;
                    if (text.Equals(""))
                    {
                        genres = (from c in context.genres where c.active == 1 orderby c.name select c).ToList();
                    }
                    else
                    {
                        genres = (from c in context.genres
                                  where c.name.ToLower().StartsWith(text.ToLower()) && c.active == 1
                                  orderby c.name
                                  select c).ToList();
                    }
                    foreach (var genre in genres)
                    {
                        var item = new ListViewItem(genre.name);
                        item.Tag = genre;
                        lvGenres.Items.Add(item);
                        if (Genres.Contains(genre))
                        {
                            item.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            IsLoadedGenres = true;
        }

        private void tbLanguages_TextChanged(object sender, EventArgs e)
        {
            IsLoadedLanguages = false;
            string text = tbLanguages.Text;
            lvLanguages.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvLanguages.Columns.Add(header);
            lvLanguages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvLanguages.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvLanguages.CheckBoxes = true;
                    List<language> languages = null;
                    if (text.Equals(""))
                    {
                        languages = (from c in context.languages where c.active == 1 orderby c.name select c).ToList();
                    }
                    else
                    {
                        languages = (from c in context.languages
                                     where c.name.ToLower().StartsWith(text.ToLower()) && c.active == 1
                                     orderby c.name
                                     select c).ToList();
                    }
                    foreach (var language in languages)
                    {
                        var item = new ListViewItem(language.name);
                        item.Tag = language;
                        lvLanguages.Items.Add(item);
                        if (checkedLanguages.Contains(language))
                        {
                            item.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            IsLoadedLanguages = true;
        }

        private void tbActors_TextChanged(object sender, EventArgs e)
        {
            IsLoadedActors = false;
            string text = tbActors.Text;
            lvActors.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvActors.Columns.Add(header);
            lvActors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvActors.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvActors.CheckBoxes = true;
                    List<actor> actors = null;
                    if (text.Equals(""))
                    {
                        actors = (from c in context.actors
                                  where c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    else
                    {
                        actors = (from c in context.actors
                                  where (c.member_of_cast_and_crew.first_name.ToLower().Contains(text.ToLower()) ||
                                  c.member_of_cast_and_crew.last_name.ToLower().Contains(text.ToLower())) &&
                                  c.member_of_cast_and_crew.active == 1
                                  orderby c.member_of_cast_and_crew.first_name
                                  select c).ToList();
                    }
                    foreach (var actor in actors)
                    {
                        var item = new ListViewItem(actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name);
                        item.Tag = actor;
                        lvActors.Items.Add(item);
                        if (MovieActors.Contains(actor))
                        {
                            item.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            IsLoadedActors = true;
        }

        private void tbDirectors_TextChanged(object sender, EventArgs e)
        {
            IsLoadedDirectors = false;
            string text = tbDirectors.Text;
            lvDirectors.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvDirectors.Columns.Add(header);
            lvDirectors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvDirectors.HeaderStyle = ColumnHeaderStyle.None;
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    lvDirectors.CheckBoxes = true;
                    List<director> directors = null;
                    if (text.Equals(""))
                    {
                        directors = (from c in context.directors
                                     where c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
                    }
                    else
                    {
                        directors = (from c in context.directors
                                     where (c.member_of_cast_and_crew.first_name.ToLower().Contains(text.ToLower()) ||
                                     c.member_of_cast_and_crew.last_name.ToLower().Contains(text.ToLower())) &&
                                     c.member_of_cast_and_crew.active == 1
                                     orderby c.member_of_cast_and_crew.first_name
                                     select c).ToList();
                    }
                    foreach (var director in directors)
                    {
                        var item = new ListViewItem(director.member_of_cast_and_crew.first_name + " " + director.member_of_cast_and_crew.last_name);
                        item.Tag = director;
                        lvDirectors.Items.Add(item);
                        if (MovieDirectors.Contains(director))
                        {
                            item.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            IsLoadedDirectors = true;
        }

        private void lvActors_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedActors)
            {
                if (e.Item.Checked)
                {
                    MovieActors.Add((actor)(e.Item as ListViewItem).Tag);
                    checkedActors.Add(((actor)(e.Item as ListViewItem).Tag));
                }
                else
                {
                    MovieActors.Remove((actor)(e.Item as ListViewItem).Tag);
                    checkedActors.Remove((actor)(e.Item as ListViewItem).Tag);
                }
            }
        }

        private void lvDirectors_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedDirectors)
            {
                if (e.Item.Checked)
                {
                    MovieDirectors.Add((director)(e.Item as ListViewItem).Tag);
                    checkedDirectors.Add((director)(e.Item as ListViewItem).Tag);
                }
                else
                {
                    MovieDirectors.Remove((director)(e.Item as ListViewItem).Tag);
                    checkedDirectors.Remove((director)(e.Item as ListViewItem).Tag);
                }
            }
        }

        private void lvGenres_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedGenres)
            {
                if (e.Item.Checked)
                {
                    Genres.Add((genre)(e.Item as ListViewItem).Tag);
                    checkedGenres.Add((genre)(e.Item as ListViewItem).Tag);
                }
                else
                {
                    checkedGenres.Add((genre)(e.Item as ListViewItem).Tag);
                    Genres.Remove((genre)(e.Item as ListViewItem).Tag);
                }
            }
        }

        private void lvLanguages_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedLanguages)
            {
                if (e.Item.Checked)
                {
                    Languages.Add((language)(e.Item as ListViewItem).Tag);
                    checkedLanguages.Add((language)(e.Item as ListViewItem).Tag);
                }
                else
                {
                    Languages.Remove((language)(e.Item as ListViewItem).Tag);
                    checkedLanguages.Remove((language)(e.Item as ListViewItem).Tag);
                }
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            AddGenreForm addGenreForm = new AddGenreForm();
            if(DialogResult.OK == addGenreForm.ShowDialog())
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        var genre = new genre()
                        {
                            name = addGenreForm.GenreName,
                            active = 1
                        };
                        context.genres.Add(genre);
                        context.SaveChanges();
                        FillGenresList();
                        var genreItems = lvGenres.Items;
                        foreach (var checkedGenre in Genres.ToList())
                        {
                            foreach (var item in genreItems)
                            {
                                genre genreItem = (genre)(item as ListViewItem).Tag;
                                if (genreItem.id == checkedGenre.id)
                                {
                                    (item as ListViewItem).Checked = true;
                                }
                            }
                        }
                        MoviesUcl.Instance.RefreshTableAndFilters();
                        ActorsUcl.Instance.RefreshTableAndFilters();
                        DirectorsUcl.Instance.RefreshTableAndFilters();
                        MessageBox.Show("Genre successfully added.", "Success", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            AddLanguageForm addLanguageForm = new AddLanguageForm();
            if (DialogResult.OK == addLanguageForm.ShowDialog())
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        var language = new language()
                        {
                            name = addLanguageForm.LanguageName,
                            active = 1
                        };
                        context.languages.Add(language);
                        context.SaveChanges();
                        FillLanguagesList();
                        var languageItems = lvLanguages.Items;
                        foreach (var checkedLanguage in Languages.ToList())
                        {
                            foreach (var item in languageItems)
                            {
                                language languageItem = (language)(item as ListViewItem).Tag;
                                if (languageItem.id == checkedLanguage.id)
                                {
                                    (item as ListViewItem).Checked = true;
                                }
                            }
                        }
                        MoviesUcl.Instance.RefreshTableAndFilters();
                        ActorsUcl.Instance.RefreshTableAndFilters();
                        DirectorsUcl.Instance.RefreshTableAndFilters();
                        MessageBox.Show("Language successfully added.", "Success", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        private void tbBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimal(sender, e);
        }

        private void tbGross_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowDecimal(sender, e);
        }
    }
}
