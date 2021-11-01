using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Linq;
using System.Xml.Linq;

namespace XMLconverter
{
    class LinqAnalyzer : IAnalyzerXML
    {
        public List<Books> Search(Books book)
        {
            List<Books> res = new List<Books>();
            var doc = XDocument.Load(@"D:\projects\SecondLab\XMLconverter\XMLFile1.xml");
            var result = from obj in doc.Descendants("Book")
                         where
                         (
                         (obj.Attribute("AUTHOR").Value.Equals(book.author) || book.author.Equals(String.Empty)) &&
                         (obj.Attribute("TITLE").Value.Equals(book.title) || book.title.Equals(String.Empty)) &&
                         (obj.Attribute("TYPE").Value.Equals(book.type) || book.type.Equals(String.Empty)) &&
                         (obj.Attribute("FACULTY").Value.Equals(book.faculty) || book.faculty.Equals(String.Empty)) &&
                         (obj.Attribute("DEPARTMENT").Value.Equals(book.department) || book.department.Equals(String.Empty)) &&
                         (YearsNPages.ComparePages(book, obj)) &&
                         (YearsNPages.CompareYears(book, obj))
                         )
                         select new
                         {
                             author = (string)obj.Attribute("AUTHOR"),
                             title = (string)obj.Attribute("TITLE"),
                             type = (string)obj.Attribute("TYPE"),
                             faculty = (string)obj.Attribute("FACULTY"),
                             department = (string)obj.Attribute("DEPARTMENT"),
                             year = (string)obj.Attribute("YEAR"),
                             num_pages = (string)obj.Attribute("NUMB_PAGES")
                         };
            foreach(var n in result)
            {
                Books myBook = new Books();
                myBook.author = n.author;
                myBook.title = n.title;
                myBook.type = n.type;
                myBook.faculty = n.faculty;
                myBook.department = n.department;
                myBook.year_range = n.year;
                myBook.numb_pages_range = n.num_pages;

                res.Add(myBook);
            }

            return res;
        }
    }
}
