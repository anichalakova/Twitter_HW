using System;
using System.Collections.Generic;

using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Twitter.Data;
using Twitter.Data.Migrations;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Twitter.Data.TwitterDbContext, Configuration>());
            using (var db = new TwitterDbContext())
            {
                Console.WriteLine(db.Users.FirstOrDefault().Username);
            }
        }
    }
}
