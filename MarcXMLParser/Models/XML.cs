namespace MarcXMLParser.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class XML : DbContext
    {
        public XML()
            : base("name=XML")
        {
        }

        public virtual DbSet<MARC_XML> MARC_XML { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
