namespace WebMitilShop.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int? CategoryId { get; set; }

        public decimal? ProductPrice { get; set; }

        public decimal? ProductDiscount { get; set; }

        [StringLength(300)]
        public string ProductPhoto { get; set; }

        public int? SizeId { get; set; }

        public int? ColorId { get; set; }

        public bool? IsTrendy { get; set; }

        public bool? IsArrived { get; set; }

        public virtual Category Category { get; set; }

        public virtual Color Color { get; set; }

        public virtual Size Size { get; set; }
    }
}
