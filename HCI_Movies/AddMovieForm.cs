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
        public decimal Gross { get; set; }
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
            Poster = "C:\\Users\\PC\\Desktop\\HCI\\Images\\defaultPerson.png";
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
            using (MovieDB context = new MovieDB())
            {
                lvGenres.CheckBoxes = true;
                var genres = (from c in context.genres orderby c.name select c).ToList();
                foreach (var genre in genres)
                {
                    var item = new ListViewItem(genre.name);
                    item.Tag = genre;
                    lvGenres.Items.Add(item);
                }
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
            using (MovieDB context = new MovieDB())
            {
                lvLanguages.CheckBoxes = true;
                var languages = (from c in context.languages orderby c.name select c).ToList();
                foreach (var language in languages)
                {
                    var item = new ListViewItem(language.name);
                    item.Tag = language;
                    lvLanguages.Items.Add(item);
                }
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
            using (MovieDB context = new MovieDB())
            {
                lvActors.CheckBoxes = true;
                actors = (from c in context.actors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                foreach (var actor in actors)
                {
                    var item = new ListViewItem(actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name);
                    item.Tag = actor;
                    lvActors.Items.Add(item);
                }
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
            using (MovieDB context = new MovieDB())
            {
                lvDirectors.CheckBoxes = true;
                directors = (from c in context.directors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                foreach (var director in directors)
                {
                    var item = new ListViewItem(director.member_of_cast_and_crew.first_name + " " + director.member_of_cast_and_crew.last_name);
                    item.Tag = director;
                    lvDirectors.Items.Add(item);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ("".Equals(tbName.Text))
            {
                MessageBox.Show("You have to enter movie name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if("".Equals(tbRuntime.Text))
            {
                MessageBox.Show("You have to enter runtime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ("".Equals(tbBudget.Text))
            {
                MessageBox.Show("You have to enter budget.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ("".Equals(tbTagline.Text))
            {
                MessageBox.Show("You have to enter tagline.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ("".Equals(rtbPlotSummary.Text))
            {
                MessageBox.Show("You have to enter plot summary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvGenres.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvLanguages.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one language.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvActors.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one actor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lvDirectors.CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select at least one director.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MovieName = tbName.Text;
                ReleaseDate = dtpReleaseDate.Value.Date;
                Runtime = int.Parse(tbRuntime.Text);
                Budget = decimal.Parse(tbBudget.Text);
                Gross = decimal.Parse(tbGross.Text);
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
                        FillActorsList();
                        FillDirectorsList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.StackTrace);
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
                        FillDirectorsList();
                        FillActorsList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.StackTrace);
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
            try
            {
                pbPoster.Image = Image.FromFile(Poster);
            }
            catch (FileNotFoundException ex)
            {
                // Change to default movie poster
                pbPoster.Image = Image.FromFile("C:\\Users\\PC\\Desktop\\HCI\\Images\\defaultPerson.png");
            }
            var genreItems = lvGenres.Items;
            foreach (var genre in Genres)
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
            foreach (var language in Languages)
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
            foreach(var actor in MovieActors)
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
            foreach (var director in MovieDirectors)
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
            using (MovieDB context = new MovieDB())
            {
                lvGenres.CheckBoxes = true;
                List<genre> genres = null;
                if (text.Equals(""))
                {
                    genres = (from c in context.genres orderby c.name select c).ToList();
                }
                else
                {
                    genres = (from c in context.genres
                              where c.name.ToLower().StartsWith(text.ToLower())
                              orderby c.name
                              select c).ToList();
                }
                foreach (var genre in genres)
                {
                    var item = new ListViewItem(genre.name);
                    item.Tag = genre;
                    lvGenres.Items.Add(item);
                    if (checkedGenres.Contains(genre))
                    {
                        item.Checked = true;
                    }
                }
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
            using (MovieDB context = new MovieDB())
            {
                lvLanguages.CheckBoxes = true;
                List<language> languages = null;
                if (text.Equals(""))
                {
                    languages = (from c in context.languages orderby c.name select c).ToList();
                }
                else
                {
                    languages = (from c in context.languages
                              where c.name.ToLower().StartsWith(text.ToLower())
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
            using (MovieDB context = new MovieDB())
            {
                lvActors.CheckBoxes = true;
                List<actor> actors = null;
                if (text.Equals(""))
                {
                    actors = (from c in context.actors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                }
                else
                {
                    actors = (from c in context.actors
                              where c.member_of_cast_and_crew.first_name.ToLower().Contains(text.ToLower()) ||
                              c.member_of_cast_and_crew.last_name.ToLower().Contains(text.ToLower())
                              orderby c.member_of_cast_and_crew.first_name
                              select c).ToList();
                }
                foreach (var actor in actors)
                {
                    var item = new ListViewItem(actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name);
                    item.Tag = actor.member_of_cast_and_crew;
                    lvActors.Items.Add(item);
                    if (checkedActors.Contains(actor))
                    {
                        item.Checked = true;
                    }
                }
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
            using (MovieDB context = new MovieDB())
            {
                lvDirectors.CheckBoxes = true;
                List<director> directors = null;
                if (text.Equals(""))
                {
                    directors = (from c in context.directors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                }
                else
                {
                    directors = (from c in context.directors
                                 where c.member_of_cast_and_crew.first_name.ToLower().Contains(text.ToLower()) ||
                                 c.member_of_cast_and_crew.last_name.ToLower().Contains(text.ToLower())
                                 orderby c.member_of_cast_and_crew.first_name
                                 select c).ToList();
                }
                foreach (var director in directors)
                {
                    var item = new ListViewItem(director.member_of_cast_and_crew.first_name + " " + director.member_of_cast_and_crew.last_name);
                    item.Tag = director.member_of_cast_and_crew;
                    lvDirectors.Items.Add(item);
                    if (checkedDirectors.Contains(director))
                    {
                        item.Checked = true;
                    }
                }
            }
            IsLoadedDirectors = true;
        }

        private void lvActors_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedActors)
            {
                if (e.Item.Checked)
                {
                    checkedActors.Add(((member_of_cast_and_crew)(e.Item as ListViewItem).Tag).actor);
                }
                else
                {
                    checkedActors.Remove(((member_of_cast_and_crew)(e.Item as ListViewItem).Tag).actor);
                }
            }
        }

        private void lvDirectors_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedDirectors)
            {
                if (e.Item.Checked)
                {
                    checkedDirectors.Add(((member_of_cast_and_crew)(e.Item as ListViewItem).Tag).director);
                }
                else
                {
                    checkedDirectors.Remove(((member_of_cast_and_crew)(e.Item as ListViewItem).Tag).director);
                }
            }
        }

        private void lvGenres_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedGenres)
            {
                if (e.Item.Checked)
                {
                    checkedGenres.Add((genre)(e.Item as ListViewItem).Tag);
                }
                else
                {
                    checkedGenres.Remove((genre)(e.Item as ListViewItem).Tag);
                }
            }
        }

        private void lvLanguages_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (IsLoadedLanguages)
            {
                if (e.Item.Checked)
                {
                    checkedLanguages.Add((language)(e.Item as ListViewItem).Tag);
                }
                else
                {
                    checkedLanguages.Remove((language)(e.Item as ListViewItem).Tag);
                }
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            AddGenreForm addGenreForm = new AddGenreForm();
            if(DialogResult.OK == addGenreForm.ShowDialog())
            {
                using (MovieDB context = new MovieDB())
                {
                    var genre = new genre()
                    {
                        name = addGenreForm.GenreName
                    };
                    context.genres.Add(genre);
                    context.SaveChanges();
                    FillGenresList();
                    var genreItems = lvGenres.Items;
                    foreach (var checkedGenre in checkedGenres.ToList())
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
                    // Change content of all genre list views
                }
            }
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            AddLanguageForm addLanguageForm = new AddLanguageForm();
            if (DialogResult.OK == addLanguageForm.ShowDialog())
            {
                using (MovieDB context = new MovieDB())
                {
                    var language = new language()
                    {
                        name = addLanguageForm.LanguageName
                    };
                    context.languages.Add(language);
                    context.SaveChanges();
                    FillLanguagesList();
                    var languageItems = lvLanguages.Items;
                    foreach (var checkedLanguage in checkedLanguages.ToList())
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
                    // Change content of all language list views
                }
            }
        }
    }
}
