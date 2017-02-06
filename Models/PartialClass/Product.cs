using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace w04a.Models.PartialClass
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData
    {


        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Product Name")]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public object ProductName { get; set; }

        [UIHint("_SupplierDropDownList")]
        [Display(Name = "Supplier")]
        public object SupplierID { get; set; }

        [UIHint("_CategoryDropDownList")]
        [Display(Name = "Category")]
        public object CategoryID { get; set; }

        [Required(ErrorMessage = "Unit price is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public object UnitPrice { get; set; }

    }
}