namespace MarcXMLParser.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Parsed_Data
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string leader { get; set; }

        [StringLength(250)]
        public string controlfield_003 { get; set; }

        [StringLength(250)]
        public string controlfield_005 { get; set; }

        [StringLength(250)]
        public string controlfield_008 { get; set; }

        [StringLength(250)]
        public string datafield_020_a { get; set; }

        [StringLength(250)]
        public string datafield_022_a { get; set; }

        [StringLength(250)]
        public string datafield_035_a { get; set; }

        [StringLength(250)]
        public string datafield_040_a { get; set; }

        [StringLength(250)]
        public string datafield_040_b { get; set; }

        [StringLength(250)]
        public string datafield_040_c { get; set; }

        [StringLength(250)]
        public string datafield_040_d { get; set; }

        [StringLength(250)]
        public string datafield_040_e { get; set; }

        [StringLength(250)]
        public string datafield_041_a { get; set; }

        [StringLength(250)]
        public string datafield_041_h { get; set; }

        [StringLength(250)]
        public string datafield_044_a { get; set; }

        [StringLength(250)]
        public string datafield_080_a { get; set; }

        [StringLength(250)]
        public string datafield_100_4 { get; set; }

        [StringLength(250)]
        public string datafield_100_a { get; set; }

        [StringLength(250)]
        public string datafield_110_a { get; set; }

        [StringLength(250)]
        public string datafield_110_c { get; set; }

        [StringLength(250)]
        public string datafield_245_a { get; set; }

        [StringLength(250)]
        public string datafield_245_b { get; set; }

        [StringLength(250)]
        public string datafield_245_c { get; set; }

        [StringLength(250)]
        public string datafield_245_n { get; set; }

        [StringLength(250)]
        public string datafield_245_p { get; set; }

        [StringLength(250)]
        public string datafield_260_a { get; set; }

        [StringLength(250)]
        public string datafield_260_b { get; set; }

        [StringLength(250)]
        public string datafield_260_c { get; set; }

        [StringLength(250)]
        public string datafield_300_a { get; set; }

        [StringLength(250)]
        public string datafield_300_b { get; set; }

        [StringLength(250)]
        public string datafield_300_c { get; set; }

        [StringLength(250)]
        public string datafield_310_a { get; set; }

        [StringLength(250)]
        public string datafield_362_a { get; set; }

        [StringLength(250)]
        public string datafield_440_a { get; set; }

        [StringLength(250)]
        public string datafield_440_v { get; set; }

        [StringLength(250)]
        public string datafield_490_a { get; set; }

        [StringLength(250)]
        public string datafield_490_v { get; set; }

        [StringLength(250)]
        public string datafield_500_a { get; set; }

        [StringLength(250)]
        public string datafield_504_a { get; set; }

        [StringLength(250)]
        public string datafield_505_a { get; set; }

        [StringLength(250)]
        public string datafield_520_a { get; set; }

        [StringLength(250)]
        public string datafield_546_a { get; set; }

        [StringLength(250)]
        public string datafield_550_a { get; set; }

        [StringLength(250)]
        public string datafield_555_a { get; set; }

        [StringLength(250)]
        public string datafield_653_a { get; set; }

        [StringLength(250)]
        public string datafield_700_4 { get; set; }

        [StringLength(250)]
        public string datafield_700_9 { get; set; }

        [StringLength(250)]
        public string datafield_700_a { get; set; }

        [StringLength(250)]
        public string datafield_740_a { get; set; }

        [StringLength(250)]
        public string datafield_776_t { get; set; }

        [StringLength(250)]
        public string datafield_776_x { get; set; }

        [StringLength(250)]
        public string datafield_780_t { get; set; }

        [StringLength(250)]
        public string datafield_780_x { get; set; }

        [StringLength(250)]
        public string datafield_830_a { get; set; }

        [StringLength(250)]
        public string datafield_830_n { get; set; }

        [StringLength(250)]
        public string datafield_830_p { get; set; }

        [StringLength(250)]
        public string datafield_830_v { get; set; }

        [StringLength(250)]
        public string datafield_856_u { get; set; }

        [StringLength(250)]
        public string datafield_856_z { get; set; }

        [StringLength(250)]
        public string datafield_942_6 { get; set; }

        [StringLength(250)]
        public string datafield_942_b { get; set; }

        [StringLength(250)]
        public string datafield_942_c { get; set; }

        [StringLength(250)]
        public string datafield_942_d { get; set; }

        [StringLength(250)]
        public string datafield_942_h { get; set; }

        [StringLength(250)]
        public string datafield_942_i { get; set; }

        [StringLength(250)]
        public string datafield_942_t { get; set; }

        [StringLength(250)]
        public string datafield_942_u { get; set; }

        [StringLength(250)]
        public string datafield_952_0 { get; set; }

        [StringLength(250)]
        public string datafield_952_1 { get; set; }

        [StringLength(250)]
        public string datafield_952_4 { get; set; }

        [StringLength(250)]
        public string datafield_952_6 { get; set; }

        [StringLength(250)]
        public string datafield_952_7 { get; set; }

        [StringLength(250)]
        public string datafield_952_8 { get; set; }

        [StringLength(250)]
        public string datafield_952_9 { get; set; }

        [StringLength(250)]
        public string datafield_952_a { get; set; }

        [StringLength(250)]
        public string datafield_952_b { get; set; }

        [StringLength(250)]
        public string datafield_952_c { get; set; }

        [StringLength(250)]
        public string datafield_952_d { get; set; }

        [StringLength(250)]
        public string datafield_952_e { get; set; }

        [StringLength(250)]
        public string datafield_952_g { get; set; }

        [StringLength(250)]
        public string datafield_952_h { get; set; }

        [StringLength(250)]
        public string datafield_952_i { get; set; }

        [StringLength(250)]
        public string datafield_952_l { get; set; }

        [StringLength(250)]
        public string datafield_952_m { get; set; }

        [StringLength(250)]
        public string datafield_952_o { get; set; }

        [StringLength(250)]
        public string datafield_952_p { get; set; }

        [StringLength(250)]
        public string datafield_952_q { get; set; }

        [StringLength(250)]
        public string datafield_952_r { get; set; }

        [StringLength(250)]
        public string datafield_952_s { get; set; }

        [StringLength(250)]
        public string datafield_952_t { get; set; }

        [StringLength(250)]
        public string datafield_952_v { get; set; }

        [StringLength(250)]
        public string datafield_952_w { get; set; }

        [StringLength(250)]
        public string datafield_952_y { get; set; }

        [StringLength(250)]
        public string datafield_952_z { get; set; }

        [StringLength(250)]
        public string datafield_991_a { get; set; }

        [StringLength(250)]
        public string datafield_992_a { get; set; }

        [StringLength(250)]
        public string datafield_992_b { get; set; }

        [StringLength(250)]
        public string datafield_992_c { get; set; }

        [StringLength(250)]
        public string datafield_992_d { get; set; }

        [StringLength(250)]
        public string datafield_992_e { get; set; }

        [StringLength(250)]
        public string datafield_999_c { get; set; }

        [StringLength(250)]
        public string datafield_999_d { get; set; }
    }
}
