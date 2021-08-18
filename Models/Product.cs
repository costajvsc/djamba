using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace djamba.Models
{
    [Table("products")]
    public partial class Product
    {
        #region "Propreties"

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("title", TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [Column("price", TypeName = "decimal(5, 2)")]
        [Required]
        public Double Price { get; set; }

        [Column("slug", TypeName = "varchar")]
        [MaxLength(50)]
        [Required]
        public string Slug { get; set; }

        #endregion
    }
}