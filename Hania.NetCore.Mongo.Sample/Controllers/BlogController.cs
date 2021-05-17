using Hania.NetCore.Mongo.Abstracts;
using Hania.NetCore.Mongo.Sample.Documents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hania.NetCore.Mongo.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : MongoCrudController<Blog>
    {
        public BlogController(IMongoRepository<Blog> repository) : base(repository)
        {
        }
    }
}
