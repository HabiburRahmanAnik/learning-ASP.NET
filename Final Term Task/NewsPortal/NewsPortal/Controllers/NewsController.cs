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
    public class NewsController : ApiController
    {
        [Route("api/News/all")]
        [HttpGet]
        public List<NewsModel> all()
        {
            return NewsServices.GetAll();
        }

        [Route("api/News/create")]
        [HttpPost]
        public void Create(NewsModel n)
        {
            NewsServices.Add(n);
        }

        [Route("api/news/edit")]
        [HttpPut]
        public void Edit(NewsModel n)
        {
            NewsServices.Edit(n);
        }

        [Route("api/news/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            NewsServices.Delete(id);
        }

    }
}
