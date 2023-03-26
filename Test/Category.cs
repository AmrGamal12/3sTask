using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Application.Category;
using Task_Application.Client;
using Task_Application.Dto;

namespace Test
{ [TestFixture]
    public class Category
    {

        CategoryDto request = new CategoryDto()
        {
            Name="amr",
            parentCategorysId=5,    
        };
        [Test]
        public void CreateCategory()
        {
            Boolean expextedresult = AddCategory.AddCategorys(request);
            Assert.AreEqual(true, expextedresult);

        }
    }
}
