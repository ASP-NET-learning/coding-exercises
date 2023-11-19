using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Razor.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brief {get; set;}
        public string Photo { get; set; }
        public string WikiUrl { get; set; }
    }
}