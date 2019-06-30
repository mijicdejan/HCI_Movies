using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Movies.Model
{
    public partial class language
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
            else if (obj is language)
            {
                return ((language)obj).id == id;
            }
            return false;
        }
    }
}
