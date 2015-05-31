using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RobertMarshOfficialWebsite.Models.DBModels;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RobertMarshOfficialWebsite.Models
{
    public class RobertMarshOfficialEntities : DbContext
    {
        public RobertMarshOfficialEntities() :
            base("name=RobertMarshOfficialEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
       
        public DbSet<Music> Music { get; set; }
    }
}