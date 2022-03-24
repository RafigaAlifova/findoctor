using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace findoctor.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public int PatientId { get; set; }
    }
}
