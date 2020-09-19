using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ClientsController : ApiController
    {
        private static List<Clients> Clients = new List<Clients>();

        public List<Clients> Get()
        {
            return Clients;
        }

        public void Post(string name)
        {
            if (!string.IsNullOrEmpty(name))
                Clients.Add(new Clients(name));
        }

        public void Delete(string name)
        {
            Clients.RemoveAt(Clients.IndexOf(Clients.First(x => x.name.Equals(name))));
        }
    }
}
