using LE_ONGJIANGCO.Data;
using LE_ONGJIANGCO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Xml;
using System.Xml.Schema;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Xml.Linq;


namespace LE_ONGJIANGCO.Controllers
{
    public class ProductController : Controller
    {
        
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _xmlFilePath;

        public ProductController(IWebHostEnvironment webHostEnvironment)
        {

            _webHostEnvironment = webHostEnvironment;
            _xmlFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Schemas", "Products.xml");
        }
        public IActionResult ProductsView()
        {
            var products = ReadProductsFromXml();
            return View(products);
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                var products = ReadProductsFromXml();
                product.Id = products.Count + 1;
                products.Add(product);
                WriteProductsToXml(products);
                return RedirectToAction("ProductsView");
            }
            return View(product);
        }
        private List<Products> ReadProductsFromXml()
        {
            if (!System.IO.File.Exists(_xmlFilePath))
            {
                return new List<Products>();

            }
            XDocument xmlDoc = XDocument.Load(_xmlFilePath);
            return xmlDoc.Descendants("Product").Select(p => new Products
            {
                Id = int.Parse(p.Element("Id")?.Value),
                Name = p.Element("Name")?.Value,
                Price = decimal.Parse(p.Element("Price")?.Value),
            }).ToList();
        }

        private void WriteProductsToXml(List<Products> products)
        {
            string directoryPath = Path.GetDirectoryName(_xmlFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            XDocument xmlDoc = new XDocument(
                new XElement("Products",
                products.Select(p =>
                    new XElement("Product",
                         new XElement("Id", p.Id),
                         new XElement("Name", p.Name),
                         new XElement("Price", p.Price)

                   )
                 )
               )
            );
            try
            {
                xmlDoc.Save(_xmlFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing XML file: " + ex.Message);
            }
        }
       

       

       

    }
}
