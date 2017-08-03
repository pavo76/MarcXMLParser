namespace MarcXMLParser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MARC_XML
    {
        public int ID { get; set; }

        public int? ID_Broj_Knjige { get; set; }

        [Required]
        public string XML { get; set; }

        public DateTime Datum_preuzimanja { get; set; }
    }
}
