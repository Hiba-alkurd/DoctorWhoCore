using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorWho
{
    public class Author
    {
        public int AuthorId { get; set; }
        public String AuthorName { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}
