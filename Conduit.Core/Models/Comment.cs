using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conduit.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Body { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public User Author { get; set; }

        public Article Article { get; set; }
    }
}