using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAssign11.Models
{
    public class Comment
    {
        public int Id { get; set; }
       
        public string content { get; set; }
        public DateTime publicationDate { get; set; }

        public string PostId { get; set; }
    }
}