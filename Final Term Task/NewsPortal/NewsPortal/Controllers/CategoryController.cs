using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class CategoryController : ApiController
    {
        [Route("api/Category/All")]
        [HttpGet]
        public List<CategoryModel> Get()
        {
            return CategoryServices.Get();
        }

        [Route("api/category/add")]
        [HttpPost]
        public void Add(CategoryModel c)
        {
            CategoryServices.Add(c);
        }

        [Route("api/category/edit")]
        [HttpPut]
        public void Edit(CategoryModel c)
        {
            CategoryServices.Edit(c);
        }

        [Route("api/category/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            CategoryServices.Delete(id);
        }

        
    }
}
