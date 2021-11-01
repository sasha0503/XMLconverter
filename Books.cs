using System;
using System.Collections.Generic;
using System.Text;

namespace XMLconverter
{
    class Books
    {
        public Books()
        {
            author = "";
            title = "";
            year_range = "";
            numb_pages_range = "";
            type = "";
            faculty = "";
            department = "";
        }
        public string author { get; set; }
        public string title { get; set; }
        public string year_range { get; set; }
        public string numb_pages_range { get; set; }
        public string type { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
    }
}
