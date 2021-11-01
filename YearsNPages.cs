using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace XMLconverter
{
    class YearsNPages
    {
        public static bool CompareYears(Books book, XElement obj)
        {
            bool years = false;
            if (book.year_range == "")
                years = true;
            else
            {
                int year1 = Convert.ToInt32(book.year_range.Split('-')[0]);
                int year2 = Convert.ToInt32(book.year_range.Split('-')[1]);
                if (Convert.ToInt32(obj.Attribute("YEAR").Value) <= year2 && Convert.ToInt32(obj.Attribute("YEAR").Value) >= year1)
                    years = true;
            }
            return years;
        }

        public static bool ComparePages(Books book, XElement obj)
        {
            bool pages = false;

            if (book.numb_pages_range == "")
                pages = true;
            else
            {
                int numb1 = Convert.ToInt32(book.numb_pages_range.Split('-')[0]);
                int numb2 = Convert.ToInt32(book.numb_pages_range.Split('-')[1]);
                if (Convert.ToInt32(obj.Attribute("NUMB_PAGES").Value) <= numb2 && Convert.ToInt32(obj.Attribute("NUMB_PAGES").Value) >= numb1)
                    pages = true;
            }
            return pages;
        }

        public static bool CompareYears(Books book, XmlAttribute attribute)
        {
            bool years = false;
            if (book.year_range == "")
                years = true;
            else
            {
                int year1 = Convert.ToInt32(book.year_range.Split('-')[0]);
                int year2 = Convert.ToInt32(book.year_range.Split('-')[1]);
                if (Convert.ToInt32(attribute.Value) <= year2 && Convert.ToInt32(attribute.Value) >= year1)
                    years = true;
            }
            return years;
        }
        public static bool ComparePages(Books book, XmlAttribute attribute)
        {
            bool pages = false;
            if (book.numb_pages_range == "")
                pages = true;
            else
            {
                int numb1 = Convert.ToInt32(book.numb_pages_range.Split('-')[0]);
                int numb2 = Convert.ToInt32(book.numb_pages_range.Split('-')[1]);
                if (Convert.ToInt32(attribute.Value) <= numb2 && Convert.ToInt32(attribute.Value) >= numb1)
                    pages = true;
            }
            return pages;
        }
        public static bool CompareYears(Books book, XmlReader reader)
        {
            bool years = false;
            if (book.year_range == "")
                years = true;
            else
            {
                int year1 = Convert.ToInt32(book.year_range.Split('-')[0]);
                int year2 = Convert.ToInt32(book.year_range.Split('-')[1]);
                if (Convert.ToInt32(reader.Value) <= year2 && Convert.ToInt32(reader.Value) >= year1)
                    years = true;
            }
            return years;
        }
        public static bool ComparePages(Books book, XmlReader reader)
        {
            bool pages = false;
            if (book.numb_pages_range == "")
                pages = true;
            else
            {
                int numb1 = Convert.ToInt32(book.numb_pages_range.Split('-')[0]);
                int numb2 = Convert.ToInt32(book.numb_pages_range.Split('-')[1]);
                if (Convert.ToInt32(reader.Value) <= numb2 && Convert.ToInt32(reader.Value) >= numb1)
                    pages = true;
            }
            return pages;
        }
    }
}
