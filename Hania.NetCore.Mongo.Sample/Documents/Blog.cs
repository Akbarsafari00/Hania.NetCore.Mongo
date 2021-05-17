using Hania.NetCore.Mongo.Abstracts;
using Hania.NetCore.Mongo.Attributes;
using Hania.NetCore.Mongo.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tradiger.Microservice.User.Common;

namespace Hania.NetCore.Mongo.Sample.Documents
{
    [Collection("Blog")]
    public class Blog: Document
    {
    }

    public class BlogRespository : MongoRepository<Blog>, IBlogRespository
    {
        public BlogRespository(IMongoDbSettings settings) : base(settings)
        {
        }
    }

    public interface IBlogRespository:IMongoRepository<Blog>
    {
    }
}
