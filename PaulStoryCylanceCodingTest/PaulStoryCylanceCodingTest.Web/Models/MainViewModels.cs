using System;

namespace PaulStoryCylanceCodingTest.Web.Models
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public Int16 UnitsOnOrder { get; set; }
        public Int16 ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string SupplierCompanyName { get; set; }
    }
}