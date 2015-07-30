using LocalTaste.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalTaste.Mvc.Models
{
    public class SearchViewModel
    {
        public SearchViewModel()
        {
            Results = new List<Restaurant>();
        }

        public string SearchInput { get; set; }
        public IEnumerable<Restaurant> Results { get; set; }
    }
}