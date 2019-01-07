using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProPedia.Models
{
    public class Article
    {
        public int ID{ get; set; }

        [Display(Name="Name")]
        public string IdUser { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

    }
    /*public class ArticleDbContext : DbContext
    {
        public ArticleDbContext() : base("DefaultConnection") { }
        public DbSet<Article> Articles { get; set; }
    }
    */
}