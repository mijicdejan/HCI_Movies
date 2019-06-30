using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Movies.Model
{
    public partial class genre
    {
        public override int GetHashCode()
        {
            return id;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj is genre)
            {
                return ((genre)obj).id == id;
            }
            return false;
        }
    }
}
