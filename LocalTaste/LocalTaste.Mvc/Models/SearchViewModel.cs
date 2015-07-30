using LocalTaste.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalTaste.Mvc.Models
{
    public class SearchViewModel
    {
        public string SearchInput { get; set; }
        public List<Restaurant> Results { get; set; }
    }
}