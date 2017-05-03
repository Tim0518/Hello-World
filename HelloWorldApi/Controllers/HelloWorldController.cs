using HelloWorld.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class HelloWorldController : ApiController
    {
        private readonly IRepository _IRepository;
        //Constructor method to Dependency Injection
        public HelloWorldController(IRepository Repository)
        {
            _IRepository = Repository;
        }
        public string Get()
        {
            string text = _IRepository.get();
            return text;
        }
    }
}
