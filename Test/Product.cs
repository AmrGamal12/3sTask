using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_Application.Dto;
using NUnit.Framework;
using Task_Application.Product;
using Assert = NUnit.Framework.Assert;

namespace Test
{
    [TestFixture]
    public  class Product
    {
        ProductDto request = new ProductDto()
        {
            Name = "fady",
            Price = 11,
            Availablequantity = 11,
            Quantitylimit = 11,
            /*Image = "fady"*/
            briefdescription = "fady",
        };
        [Test]
        public void addproducttest()
        {
           
            
            Boolean expextedresult = CreateProduct.AddProduct(request);
            Assert.AreEqual(false, expextedresult);
        }
    }
}
