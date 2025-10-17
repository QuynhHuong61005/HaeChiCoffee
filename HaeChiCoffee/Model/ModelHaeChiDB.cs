using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HaeChiCoffee.Model
{
    public partial class ModelHaeChiDB : DbContext
    {
        public ModelHaeChiDB()
            : base("name=ModelHaeChiDB")
        {
        }

        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
