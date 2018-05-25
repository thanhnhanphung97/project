namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int id { get; set; }

        public int idList { get; set; }

        [Required]
        [StringLength(1000)]
        public string Doc { get; set; }

        [Required]
        [StringLength(300)]
        public string ListDoc { get; set; }
    }
}
