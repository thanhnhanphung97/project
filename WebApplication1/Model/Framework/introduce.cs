namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class introduce
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string img { get; set; }

        public double? data { get; set; }

        [StringLength(50)]
        public string describe { get; set; }
    }
}
