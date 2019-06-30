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
    public partial class MoviesUcl : UserControl
    {
        private static MoviesUcl instance;

        List<movie> moviesByName = null;
        List<movie> moviesByYear = null;
        List<movie> moviesByMinDuration = null;
        List<movie> moviesByMaxDuration = null;
        List<movie> moviesByGenres = null;
        List<movie> moviesByActors = null;
        List<movie> moviesByDirectors = null;

        bool IsLoadedActors = true;
        bool IsLoadedDirectors = true;
        List<actor> checkedActors = new List<actor>();
        List<director> checkedDirectors = new List<director>();

        public static MoviesUcl Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MoviesUcl();
                }
                return instance;
            }
        }

        protected MoviesUcl()
        {
            InitializeComponent();
            FillMoviesTable();
            FillGenresList();
            FillActorsList();
            FillDirectorsList();
            FillYearComboBox();
        }

        private void FillMoviesTable()
        {
            dgvMovies.Rows.Clear();
            using (MovieDB context = new MovieDB())
            {
                var movies = (from c in context.movies orderby c.name select c).ToList();
                moviesByActors = movies;
                moviesByDirectors = movies;
                moviesByGenres = movies;
                moviesByMaxDuration = movies;
                moviesByMinDuration = movies;
                moviesByName = movies;
                moviesByYear = movies;
                foreach (var movie in movies)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = movie
                    };
                    row.CreateCells(dgvMovies);
                    var genres = movie.genres;
                    string s = "";
                    foreach (var genre in genres)
                    {
                        s += genre.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                    dgvMovies.Rows.Add(row);
                }
                dgvMovies.Columns["Column2"].DefaultCellStyle.Format = "dd.MM.yyyy";
            
            }
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
                var genres = (from c in context.genres select c).ToList();
                foreach (var genre in genres)
                {
                    var item = new ListViewItem(genre.name);
                    item.Tag = genre;
                    lvGenres.Items.Add(item);
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
                var actors = (from c in context.actors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                foreach (var actor in actors)
                {
                    var item = new ListViewItem(actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name);
                    item.Tag = actor.member_of_cast_and_crew;
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
                var directors = (from c in context.directors orderby c.member_of_cast_and_crew.first_name select c).ToList();
                foreach (var director in directors)
                {
                    var item = new ListViewItem(director.member_of_cast_and_crew.first_name + " " + director.member_of_cast_and_crew.last_name);
                    item.Tag = director.member_of_cast_and_crew;
                    lvDirectors.Items.Add(item);
                }
            }
        }

        private void FillYearComboBox()
        {
            List<Year> dataSource = new List<Year>();
            dataSource.Add(new Year() { Name = "All", Value = 0 });
            for (int i = DateTime.Now.Year; i >= 1932; i--)
            {
                dataSource.Add(new Year() { Name = i.ToString(), Value = i });
            }
            cmbYear.DataSource = dataSource;
            cmbYear.DisplayMember = "Name";
            cmbYear.ValueMember = "Value";
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

        private List<movie> MovieIntersect()
        {
            List<movie> movies = moviesByActors.Intersect(moviesByDirectors).ToList();
            movies = movies.Intersect(moviesByGenres).ToList();
            movies = movies.Intersect(moviesByMaxDuration).ToList();
            movies = movies.Intersect(moviesByMinDuration).ToList();
            movies = movies.Intersect(moviesByName).ToList();
            movies = movies.Intersect(moviesByYear).ToList();
            movies.Sort((m1, m2) =>
            {
                return m1.name.CompareTo(m2.name);
            });
            return movies;
        }

        private void lvGenres_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            var selectedTags = lvGenres.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag);
            using (MovieDB context = new MovieDB())
            {
                var movies = (from c in context.movies select c).ToList();
                moviesByGenres = new List<movie>();
                foreach (var movie in movies)
                {
                    var genres = movie.genres;
                    HashSet<string> movieGenres = new HashSet<string>();
                    foreach (var genre in genres)
                    {
                        movieGenres.Add(genre.name);
                    }
                    HashSet<string> selectedGenres = new HashSet<string>();
                    foreach (var genre in selectedTags)
                    {
                        selectedGenres.Add(((genre)genre).name);
                    }
                    if (movieGenres.IsSupersetOf(selectedGenres))
                    {
                        if (!moviesByGenres.Contains(movie))
                        {
                            moviesByGenres.Add(movie);
                        }
                    }
                }
                List<movie> filteredMovies = MovieIntersect();
                dgvMovies.Rows.Clear();
                foreach (var movie in filteredMovies)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = movie
                    };
                    row.CreateCells(dgvMovies);
                    var m = (from c in context.movies where c.id == movie.id select c).ToList()[0];
                    var allGenres = (from c in context.genres select c).ToList();
                    var genres = new List<genre>();
                    foreach (var genre in allGenres)
                    {
                        if (m.genres.Contains(genre))
                        {
                            genres.Add(genre);
                        }
                    }
                    string s = "";
                    foreach (var genre in genres)
                    {
                        s += genre.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                    dgvMovies.Rows.Add(row);
                }
            }
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
                var selectedTags = lvActors.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag);
                using (MovieDB context = new MovieDB())
                {
                    var movies = (from c in context.movies select c).ToList();
                    moviesByActors = new List<movie>();
                    foreach (var movie in movies)
                    {
                        context.movies.Attach(movie);
                        var actors = movie.actors;
                        HashSet<int> movieActors = new HashSet<int>();
                        foreach (var actor in actors)
                        {
                            movieActors.Add(actor.id);
                        }
                        HashSet<int> selectedActors = new HashSet<int>();
                        foreach (var actor in selectedTags)
                        {
                            selectedActors.Add(((member_of_cast_and_crew)actor).id);
                        }
                        if (movieActors.IsSupersetOf(selectedActors))
                        {
                            if (!moviesByActors.Contains(movie))
                            {
                                moviesByActors.Add(movie);
                            }
                        }
                    }
                    List<movie> filteredMovies = MovieIntersect();
                    dgvMovies.Rows.Clear();
                    foreach (var movie in filteredMovies)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = movie
                        };
                        row.CreateCells(dgvMovies);
                        var genres = movie.genres;
                        string s = "";
                        foreach (var genre in genres)
                        {
                            s += genre.name;
                            s += ", ";
                        }
                        s = s.Substring(0, s.Length - 2);
                        row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                        dgvMovies.Rows.Add(row);
                    }
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
                var selectedTags = lvDirectors.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag);
                using (MovieDB context = new MovieDB())
                {
                    var movies = (from c in context.movies select c).ToList();
                    moviesByDirectors = new List<movie>();
                    foreach (var movie in movies)
                    {
                        context.movies.Attach(movie);
                        var directors = movie.directors;
                        HashSet<int> movieDirectors = new HashSet<int>();
                        foreach (var director in directors)
                        {
                            movieDirectors.Add(director.id);
                        }
                        HashSet<int> selectedDirectors = new HashSet<int>();
                        foreach (var director in selectedTags)
                        {
                            selectedDirectors.Add(((member_of_cast_and_crew)director).id);
                        }
                        if (movieDirectors.IsSupersetOf(selectedDirectors))
                        {
                            if (!moviesByDirectors.Contains(movie))
                            {
                                moviesByDirectors.Add(movie);
                            }
                        }
                    }
                    List<movie> filteredMovies = MovieIntersect();
                    dgvMovies.Rows.Clear();
                    foreach (var movie in filteredMovies)
                    {
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = movie
                        };
                        row.CreateCells(dgvMovies);
                        var m = (from c in context.movies where c.id == movie.id select c).ToList()[0];
                        var allGenres = (from c in context.genres select c).ToList();
                        var genres = new List<genre>();
                        foreach (var genre in allGenres)
                        {
                            if (m.genres.Contains(genre))
                            {
                                genres.Add(genre);
                            }
                        }
                        string s = "";
                        foreach (var genre in genres)
                        {
                            s += genre.name;
                            s += ", ";
                        }
                        s = s.Substring(0, s.Length - 2);
                        row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                        dgvMovies.Rows.Add(row);
                    }
                }
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            if (DialogResult.OK == addMovieForm.ShowDialog())
            {
                try
                {
                    using (MovieDB context = new MovieDB())
                    {
                        var movie = new movie()
                        {
                            name = addMovieForm.MovieName,
                            release_date = addMovieForm.ReleaseDate,
                            runtime = addMovieForm.Runtime,
                            budget = addMovieForm.Budget,
                            gross = addMovieForm.Gross,
                            tagline = addMovieForm.Tagline,
                            plot_summary = addMovieForm.PlotSummary,
                            poster = addMovieForm.Poster,
                        };
                        context.movies.Add(movie);
                        var genres = addMovieForm.Genres;
                        foreach (var genre in genres)
                        {
                            context.genres.Attach(genre);
                            movie.genres.Add(genre);
                        }
                        var languages = addMovieForm.Languages;
                        foreach (var language in languages)
                        {
                            context.languages.Attach(language);
                            movie.languages.Add(language);
                        }
                        var actors = addMovieForm.MovieActors;
                        foreach (var actor in actors)
                        {
                            context.actors.Attach(actor);
                            movie.actors.Add(actor);
                        }
                        var directors = addMovieForm.MovieDirectors;
                        foreach (var director in directors)
                        {
                            context.directors.Attach(director);
                            movie.directors.Add(director);
                        }
                        context.SaveChanges();
                        FillMoviesTable();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            string name = tbName.Text;
            using (MovieDB context = new MovieDB())
            {
                var movies = (from c in context.movies where c.name.ToLower().Contains(name.ToLower()) select c).ToList();
                moviesByName = movies;
                List<movie> filteredMovies = MovieIntersect();
                dgvMovies.Rows.Clear();
                foreach (var movie in filteredMovies)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = movie
                    };
                    row.CreateCells(dgvMovies);
                    var m = (from c in context.movies where c.id == movie.id select c).ToList()[0];
                    var allGenres = (from c in context.genres select c).ToList();
                    var genres = new List<genre>();
                    foreach (var genre in allGenres)
                    {
                        if (m.genres.Contains(genre))
                        {
                            genres.Add(genre);
                        }
                    }
                    string s = "";
                    foreach (var genre in genres)
                    {
                        s += genre.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                    dgvMovies.Rows.Add(row);
                }
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year year = (Year)cmbYear.SelectedItem;
            using (MovieDB context = new MovieDB())
            {
                List<movie> movies = null;
                if (year.Value == 0)
                {
                    movies = (from c in context.movies select c).ToList();
                }
                else
                {
                    movies = (from c in context.movies where c.release_date.Year == year.Value select c).ToList();
                }
                moviesByYear = movies;
                List<movie> filteredMovies = MovieIntersect();
                dgvMovies.Rows.Clear();
                foreach (var movie in filteredMovies)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = movie
                    };
                    row.CreateCells(dgvMovies);
                    var m = (from c in context.movies where c.id == movie.id select c).ToList()[0];
                    var allGenres = (from c in context.genres select c).ToList();
                    var genres = new List<genre>();
                    foreach (var genre in allGenres)
                    {
                        if (m.genres.Contains(genre))
                        {
                            genres.Add(genre);
                        }
                    }
                    string s = "";
                    foreach (var genre in genres)
                    {
                        s += genre.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                    dgvMovies.Rows.Add(row);
                }
            }
        }

        private void tbMinDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowInt(sender, e);
        }

        private void tbMaxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowInt(sender, e);
        }

        private void tbMinDuration_TextChanged(object sender, EventArgs e)
        {
            int minDuration = -1;
            if (!tbMinDuration.Text.Equals(""))
            {
                minDuration = int.Parse(tbMinDuration.Text);
            }
            using (MovieDB context = new MovieDB())
            {
                List<movie> movies = null;
                if (minDuration == -1)
                {
                    movies = (from c in context.movies select c).ToList();
                }
                else
                {
                    movies = (from c in context.movies where c.runtime >= minDuration select c).ToList();
                }
                moviesByMinDuration = movies;
                List<movie> filteredMovies = MovieIntersect();
                dgvMovies.Rows.Clear();
                foreach (var movie in filteredMovies)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = movie
                    };
                    row.CreateCells(dgvMovies);
                    var m = (from c in context.movies where c.id == movie.id select c).ToList()[0];
                    var allGenres = (from c in context.genres select c).ToList();
                    var genres = new List<genre>();
                    foreach (var genre in allGenres)
                    {
                        if (m.genres.Contains(genre))
                        {
                            genres.Add(genre);
                        }
                    }
                    string s = "";
                    foreach (var genre in genres)
                    {
                        s += genre.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                    dgvMovies.Rows.Add(row);
                }
            }
        }

        private void tbMaxDuration_TextChanged(object sender, EventArgs e)
        {
            int maxDuration = -1;
            if (!tbMaxDuration.Text.Equals(""))
            {
                maxDuration = int.Parse(tbMaxDuration.Text);
            }
            using (MovieDB context = new MovieDB())
            {
                List<movie> movies = null;
                if (maxDuration == -1)
                {
                    movies = (from c in context.movies select c).ToList();
                }
                else
                {
                    movies = (from c in context.movies where c.runtime <= maxDuration select c).ToList();
                }
                moviesByMaxDuration = movies;
                List<movie> filteredMovies = MovieIntersect();
                dgvMovies.Rows.Clear();
                foreach (var movie in filteredMovies)
                {
                    DataGridViewRow row = new DataGridViewRow()
                    {
                        Tag = movie
                    };
                    row.CreateCells(dgvMovies);
                    var m = (from c in context.movies where c.id == movie.id select c).ToList()[0];
                    var allGenres = (from c in context.genres select c).ToList();
                    var genres = new List<genre>();
                    foreach (var genre in allGenres)
                    {
                        if (m.genres.Contains(genre))
                        {
                            genres.Add(genre);
                        }
                    }
                    string s = "";
                    foreach (var genre in genres)
                    {
                        s += genre.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    row.SetValues(movie.name, movie.release_date, movie.runtime, s);
                    dgvMovies.Rows.Add(row);
                }
            }
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
                              orderby c.member_of_cast_and_crew.first_name select c).ToList();
                }
                foreach (var actor in actors)
                {
                    var item = new ListViewItem(actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name);
                    item.Tag = actor.member_of_cast_and_crew;
                    lvActors.Items.Add(item);
                    if(checkedActors.Contains(actor))
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
                                 orderby c.member_of_cast_and_crew.first_name select c).ToList();
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

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm();
            if (dgvMovies.SelectedRows.Count > 0)
            {
                /*try
                {*/
                using (MovieDB context = new MovieDB())
                {
                    DataGridViewRow row = dgvMovies.SelectedRows[0];
                    movie movie = (movie)row.Tag;
                    addMovieForm.MovieName = movie.name;
                    addMovieForm.Runtime = movie.runtime;
                    addMovieForm.ReleaseDate = movie.release_date;
                    addMovieForm.Budget = movie.budget;
                    addMovieForm.Gross = (decimal)movie.gross;
                    addMovieForm.Tagline = movie.tagline;
                    addMovieForm.PlotSummary = movie.plot_summary;
                    addMovieForm.Poster = movie.poster;

                    var newMovie = (from c in context.movies where c.id == movie.id select c).ToList()[0];
                    var genres = newMovie.genres;
                    List<genre> genresList = new List<genre>();
                    foreach (var genre in genres)
                    {
                        genresList.Add(genre);
                    }
                    addMovieForm.Genres = genresList;

                    var languages = newMovie.languages;
                    List<language> languagesList = new List<language>();
                    foreach(var language in languages)
                    {
                        languagesList.Add(language);
                    }
                    addMovieForm.Languages = languagesList;

                    var actors = newMovie.actors;
                    List<actor> actorsList = new List<actor>();
                    foreach (var actor in actors)
                    {
                        actorsList.Add(actor);
                    }
                    addMovieForm.MovieActors = actorsList;

                    var directors = newMovie.directors;
                    List<director> directorsList = new List<director>();
                    foreach (var director in directors)
                    {
                        directorsList.Add(director);
                    }
                    addMovieForm.MovieDirectors = directorsList;
                    if (DialogResult.OK == addMovieForm.ShowDialog())
                    {
                        context.movies.Attach(newMovie);
                        newMovie.name = addMovieForm.MovieName;
                        newMovie.release_date = addMovieForm.ReleaseDate;
                        newMovie.runtime = addMovieForm.Runtime;
                        newMovie.budget = addMovieForm.Budget;
                        newMovie.gross = addMovieForm.Gross;
                        newMovie.tagline = addMovieForm.Tagline;
                        newMovie.plot_summary = addMovieForm.PlotSummary;
                        newMovie.poster = addMovieForm.Poster;
                        newMovie.genres.Clear();
                        var genresUpdate = addMovieForm.Genres;
                        foreach (var genre in genresUpdate)
                        {
                            var newGenre = (from c in context.genres where c.id == genre.id select c).ToList()[0];
                            newMovie.genres.Add(newGenre);
                        }
                        var languagesUpdate = addMovieForm.Languages;
                        foreach (var language in languagesUpdate)
                        {
                            var newLanguage = (from c in context.languages where c.id == language.id select c).ToList()[0];
                            newMovie.languages.Add(newLanguage);
                        }
                        newMovie.actors.Clear();
                        var actorsUpdate = addMovieForm.MovieActors;
                        foreach (var actor in actorsUpdate)
                        {
                            var newActor = (from c in context.actors where c.id == actor.id select c).ToList()[0];
                            newMovie.actors.Add(newActor);
                        }
                        newMovie.directors.Clear();
                        var directorsUpdate = addMovieForm.MovieDirectors;
                        foreach (var director in directorsUpdate)
                        {
                            var newDirector = (from c in context.directors where c.id == director.id select c).ToList()[0];
                            newMovie.directors.Add(newDirector);
                        }
                        context.SaveChanges();
                        FillMoviesTable();
                        // Add every clear for filters, and show all movies in table
                    }
                }
                /*}
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.StackTrace);
                }*/
            }
            else
            {
                MessageBox.Show("You haven't chosen a movie.");
            }
        }
    }
}
