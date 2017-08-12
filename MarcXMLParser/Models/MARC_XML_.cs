namespace MarcXMLParser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MARC_XML$")]
    public partial class MARC_XML_
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string ID_Broj_Knjige { get; set; }

        public string XML { get; set; }

        public DateTime? Datum_preuzimanja { get; set; }
    }
}
