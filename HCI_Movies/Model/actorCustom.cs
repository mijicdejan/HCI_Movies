using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Movies.Model
{
    public partial class actor
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
            else if (obj is actor)
            {
                return ((actor)obj).id == id;
            }
            return false;
        }
    }
}
