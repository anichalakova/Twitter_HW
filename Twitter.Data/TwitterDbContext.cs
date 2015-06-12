using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Models;

namespace Twitter.Data
{
    public class TwitterDbContext : DbContext
    {
        public TwitterDbContext() : base("TwitterDb")
        {
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Twitt> Twitts { get; set; }
        public IDbSet<Message> Messages { get; set; }


    }
}
