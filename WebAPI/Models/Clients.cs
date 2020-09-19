using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Clients
    {
        public string name { get; set; }

        public Clients(string name)
        {
            this.name = name;
        }
    }
}