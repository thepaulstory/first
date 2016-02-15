using System.Linq;
using System.Web.Mvc;
using PaulStoryCylanceCodingTest.Data;
using PaulStoryCylanceCodingTest.Web.Models;

namespace PaulStoryCylanceCodingTest.Web.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return Products();
        }

        public ActionResult Products()
        {
            var unit = new ApplicationUnit();
            var products = unit.Products.GetAll();
            var suppliers = unit.Suppliers.GetAll();

            //This requires some knowledge of the data and how they joine
            //Should move to Business Layer
            var models = products
                .Join(
                suppliers,
                p => p.SupplierID,
                s => s.SupplierID,
                (p, s) =>
                new ProductViewModel()
                {
                    ProductName = p.ProductName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    ReorderLevel = p.ReorderLevel,
                    Discontinued = p.Discontinued,
                    SupplierCompanyName = s.CompanyName
                }
           );

            ViewBag.Items = models;

            return View(models);
        }
    }
}