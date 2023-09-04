using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAssign11.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime publicationDate { get; set; }
        public string author { get; set; }
    }
}