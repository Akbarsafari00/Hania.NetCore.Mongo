
# Hania.NetCore.Mongo

[![Build status](https://ci.appveyor.com/api/projects/status/q261l3sbokafmx1o/branch/master?svg=true)](https://www.nuget.org/packages/Hania.NetCore.Mongo/)
[![NuGet](http://img.shields.io/nuget/v/HHania.NetCore.Mongo.svg)](https://www.nuget.org/packages/Hania.NetCore.Mongo/)
[![Author](https://img.shields.io/badge/Author-Akbar%20Ahmadi%20Saray-brightgreen.svg)](https://www.nuget.org/packages/Hania.NetCore.Mongo/)
[![Linkdin](https://img.shields.io/badge/Linkdin-Akbar%20Ahmadi%20Saray-orange.svg)](https://www.linkedin.com/in/akbar-ahmadi-saray-5a5b9016b/)


### What is Hania.NetCore.Mongo?

Mongo Helper Library, which simply supports Repository Pattern in .Net Core 3.1 or above

### Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [Hania.NetCore.Mongo](https://www.nuget.org/packages/Hania.NetCore.Mongo/) from the package manager console:

```
PM> Install-Package Hania.NetCore.Mongo
```


## How do I get started?

### Initialize Mongo Connection
1 - First of all you need to add `mongo` section to `appsettings.json` file:

```json
{
    "mongo": {
        "Host": "mongodb://test:test2020@mongo_test:27017",
        "Database": "TestDb"
    },
```


- Host : Mongo Server URI Address
- Database : Databae Name

2 - Next we need to add our library to Net Core services
```csharp
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
        
    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
         services.AddHaniaMongoDB();
    }
}
```

------------

### Document
You Should be user `Document` Class for Entity Inheritance  

And you should User `Collection` Attribute For Collection Configuration

```csharp
[Collection(collectionName:"Blog")]
public class Blog : Document
{
    public string Title { get; set; }
    public string Content { get; set; }
}
```

### Repository
You can Inject IMongoRepository<TDocument> in your service and use it .


```csharp
using Hania.NetCore.Mongo.Abstracts;
using Hania.NetCore.Mongo.Sample.Documents;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Hania.NetCore.Mongo.Sample.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMongoRepository<Blog> _blogRepository;

        public HomeController(IMongoRepository<Blog> blogRepository)
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

```

### Custom Repository
You Can Create your custom repository and use it .

``` csharp
namespace Hania.NetCore.Mongo.Sample
{
    public interface IBlogRespository:IMongoRepository<Blog>
    {
    }
    
    public class BlogRespository : MongoRepository<Blog>, IBlogRespository
    {
        public BlogRespository(IMongoDbSettings settings) : base(settings)
        {
        }
        public Blog FindByTitle(string title)
        {
            var filter = Builders<Blog>.Filter.Eq(doc => doc.Title, title);
            return _collection.Find(filter).SingleOrDefault();
        }
    } 
{
```

