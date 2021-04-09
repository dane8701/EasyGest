using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace EASYGEST.Models
{
    public partial class DbRegisterModel : DbContext
    {
        public DbRegisterModel()
            : base("name=DbRegisterModel")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Users> Users { get; set; }
    }
}