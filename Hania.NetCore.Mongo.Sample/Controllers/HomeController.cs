using Hania.NetCore.Mongo.Sample.Documents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hania.NetCore.Mongo.Sample.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IBlogRespository _blogRepository;

        public HomeController(IBlogRespository blogRepository)
        {
            _blogRepository = blogRepository;
            _blogRepository.InsertOne(new Blog());
        }


    [HttpGet]
    public   IEnumerable<Blog> GetBlogs()
        {
            return _blogRepository.FilterBy(x => true);
        }
    }
}
