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
    public partial class MemberOfCastAndCrewDetailsForm : Form
    {
        public MemberOfCastAndCrewDetailsForm(int id, string member)
        {
            InitializeComponent();
            try
            {
                using (MovieDB context = new MovieDB())
                {
                    member_of_cast_and_crew memberOfCastAndCrew = (from c in context.member_of_cast_and_crew where c.id == id select c).First();
                    lblName.MaximumSize = new Size(250, 0);
                    lblName.AutoSize = true;
                    lblName.Text = memberOfCastAndCrew.first_name + " " + memberOfCastAndCrew.last_name;
                    lblBirthplace.MaximumSize = new Size(250, 0);
                    lblBirthplace.AutoSize = true;
                    lblBirthplace.Text += memberOfCastAndCrew.birthplace;
                    lblBorn.MaximumSize = new Size(430, 0);
                    lblBorn.AutoSize = true;
                    lblBorn.Text += memberOfCastAndCrew.born.ToString("dd.MM.yyyy.");
                    string memberImage = memberOfCastAndCrew.image;
                    if (memberImage.StartsWith("\\"))
                    {
                        memberImage = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + memberImage;
                    }
                    try
                    {
                        pbImage.Image = Image.FromFile(memberImage);
                    }
                    catch (FileNotFoundException ex)
                    {
                        pbImage.Image = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\default.png");
                    }
                    rtbBio.Text = memberOfCastAndCrew.bio;

                    FillMoviesList(memberOfCastAndCrew, member);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void FillMoviesList(member_of_cast_and_crew memberOfCastAndCrew, string member)
        {
            lvMovies.Clear();
            ColumnHeader header = new ColumnHeader();
            header.Text = "";
            header.Name = "col1";
            lvMovies.Columns.Add(header);
            lvMovies.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lvMovies.HeaderStyle = ColumnHeaderStyle.None;
            HashSet<movie> movies = null;
            if("actor".Equals(member))
            {
                movies = (HashSet<movie>)memberOfCastAndCrew.actor.movies;
            }
            else
            {
                movies = (HashSet<movie>)memberOfCastAndCrew.director.movies;
            }
            foreach (var movie in movies)
            {
                var item = new ListViewItem(movie.name);
                item.Tag = movie.name;
                lvMovies.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
