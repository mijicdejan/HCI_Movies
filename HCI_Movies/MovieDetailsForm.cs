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
using System.IO;

namespace HCI_Movies
{
    public partial class MovieDetailsForm : Form
    {
        public MovieDetailsForm(int id)
        {
            InitializeComponent();
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    var movie = (from c in context.movies where c.id == id select c).First();
                    lblName.MaximumSize = new Size(430, 0);
                    lblName.AutoSize = true;
                    lblName.Text = movie.name;
                    lblReleaseDate.MaximumSize = new Size(430, 0);
                    lblReleaseDate.AutoSize = true;
                    lblReleaseDate.Text += movie.release_date.ToString("dd.MM.yyyy");
                    lblRuntime.MaximumSize = new Size(430, 0);
                    lblRuntime.AutoSize = true;
                    lblRuntime.Text += movie.runtime + " min";
                    lblBudget.MaximumSize = new Size(430, 0);
                    lblBudget.AutoSize = true;
                    lblBudget.Text += movie.budget + "$";
                    lblGross.MaximumSize = new Size(430, 0);
                    lblGross.AutoSize = true;
                    lblGross.Text += movie.gross.HasValue ? movie.gross.Value + "$" : "unknown";
                    lblTagline.MaximumSize = new Size(250, 0);
                    lblTagline.AutoSize = true;
                    lblTagline.Text = movie.tagline;
                    lblPlotSummary.MaximumSize = new Size(250, 0);
                    lblPlotSummary.AutoSize = true;
                    lblPlotSummary.Text = movie.plot_summary;
                    string poster = movie.poster;
                    if (poster.StartsWith("\\"))
                    {
                        poster = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + poster;
                    }
                    try
                    {
                        pbPoster.Image = Image.FromFile(poster);
                    }
                    catch (FileNotFoundException ex)
                    {
                        pbPoster.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Posters\\default.png");
                    }
                    string s = "";
                    foreach (var genre in movie.genres)
                    {
                        s += genre.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    lblGenres.MaximumSize = new Size(430, 0);
                    lblGenres.AutoSize = true;
                    lblGenres.Text += s;
                    s = "";
                    foreach (var language in movie.languages)
                    {
                        s += language.name;
                        s += ", ";
                    }
                    s = s.Substring(0, s.Length - 2);
                    lblLanguages.MaximumSize = new Size(430, 0);
                    lblLanguages.AutoSize = true;
                    lblLanguages.Text += s;

                    FillActorsList(movie);
                    FillDirectorsList(movie);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void FillActorsList(movie movie)
        {
            lvActors.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvActors.Columns.Add(header);
            lvActors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvActors.HeaderStyle = ColumnHeaderStyle.None;
            var actors = movie.actors;
            foreach (var actor in actors)
            {
                var item = new ListViewItem(actor.member_of_cast_and_crew.first_name + " " + actor.member_of_cast_and_crew.last_name);
                item.Tag = actor.member_of_cast_and_crew;
                lvActors.Items.Add(item);
            }
        }

        private void FillDirectorsList(movie movie)
        {
            lvDirectors.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvDirectors.Columns.Add(header);
            lvDirectors.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvDirectors.HeaderStyle = ColumnHeaderStyle.None;
            var directors = movie.directors;
            foreach (var director in directors)
            {
                var item = new ListViewItem(director.member_of_cast_and_crew.first_name + " " + director.member_of_cast_and_crew.last_name);
                item.Tag = director.member_of_cast_and_crew;
                lvDirectors.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
