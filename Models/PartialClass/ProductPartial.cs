using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace w04a.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Display(Name = "Product Name")]
        [nameLimit(3, ErrorMessage = "Product name should not exceed 3 words.")]
        public object ProductName { get; set; }

        [Required(ErrorMessage = "Unit Price is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public object UnitPrice { get; set; }

        //[UIHint("_CategoryDropDownList")]
        [UIHint("CategoryDropDownList")]
        [Display(Name = "Category")]
        public object CategoryID { get; set; }

        //[UIHint("_SupplierDropDownList")]
        [UIHint("SupplierDropDownList")]
        [Display(Name = "Supplier")]
        public object SupplierID { get; set; }

        [ScaffoldColumn(false)]
        public string QuantityPerUnit { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsInStock { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsOnOrder { get; set; }

        [ScaffoldColumn(false)]
        public object ReorderLevel { get; set; }

        [ScaffoldColumn(false)]
        public bool Discontinued { get; set; }

    }
}