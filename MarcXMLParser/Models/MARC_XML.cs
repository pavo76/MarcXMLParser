namespace MarcXMLParser.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MARC_XML : DbContext
    {
        public MARC_XML()
            : base("name=MARC_XML")
        {
        }

        public virtual DbSet<MARC_XML_> MARC_XML_ { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<MarcXMLParser.Models.tbl_Parsed_Data> tbl_Parsed_Data { get; set; }
    }
}
