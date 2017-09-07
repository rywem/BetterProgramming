namespace Commerce.Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountPercent { get; set; }

        public string LargePhotoFile { get; set; }

        public decimal? ListPrice { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string SummaryDescription { get; set; }

        public string ThumbnailFileName { get; set; }
    }
}
