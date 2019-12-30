using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WebCrawler
{
    [DebuggerDisplay("{Model},{Price}")]
    class Car
    {
        public string Model { get; set; }
        public string Price { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }



    }
}
