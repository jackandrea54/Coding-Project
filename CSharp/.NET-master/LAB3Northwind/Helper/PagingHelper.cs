using System;

namespace LAB3Northwind.Helper
{
    public class PagingHelper
    {
        public int CurrentPage { get; set; }
        public int CountPage { get; set; }

        public Func<int?, string> UrlLink { get; set; }
    }
}
