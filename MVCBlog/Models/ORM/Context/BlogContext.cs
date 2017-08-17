using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVCBlog.Models.ORM.Entity;
namespace MVCBlog.Models.ORM.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
            {
           
            }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<AdminUser> AdminUsers {get;set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<SiteMenu> SiteMenus { get; set; }
    }
}