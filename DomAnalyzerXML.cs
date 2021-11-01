using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace XMLconverter
{
    class DomAnalyzerXML : IAnalyzerXML
    {
        public List<Books> Search(Books book)
        {
            List<Books> res = new List<Books>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\projects\SecondLab\XMLconverter\XMLFile1.xml");

            XmlNode node = doc.DocumentElement;
            foreach(XmlNode n in node.ChildNodes)
            {
                string author = "";
                string title = "";
                string year = "";
                string numb_pages = "";
                string type = "";
                string faculty = "";
                string department = "";
                foreach(XmlAttribute attribute in n.Attributes)
                {
                    if (attribute.Name.Equals("AUTHOR") && (attribute.Value.Equals(book.author) || book.author.Equals(String.Empty)))
                        author = attribute.Value;
                    if (attribute.Name.Equals("TITLE") && (attribute.Value.Equals(book.title) || book.title.Equals(String.Empty)))
                        title = attribute.Value;
                    if (attribute.Name.Equals("TYPE") && (attribute.Value.Equals(book.type) || book.type.Equals(String.Empty)))
                        type = attribute.Value;
                    if (attribute.Name.Equals("FACULTY") && (attribute.Value.Equals(book.faculty) || book.faculty.Equals(String.Empty)))
                        faculty = attribute.Value;
                    if (attribute.Name.Equals("DEPARTMENT") && (attribute.Value.Equals(book.department) || book.department.Equals(String.Empty)))
                        department = attribute.Value;
                    if (attribute.Name.Equals("YEAR") && YearsNPages.CompareYears(book, attribute))
                        year = attribute.Value;
                    if (attribute.Name.Equals("NUMB_PAGES") && YearsNPages.ComparePages(book, attribute))
                        numb_pages = attribute.Value;
                }
                if (author != "" && title != "" && year != "" && numb_pages != "" && type != "" && faculty != "" && department != "")
                {
                    Books myBook = new Books();
                    myBook.author = author;
                    myBook.year_range = year;
                    myBook.title = title;
                    myBook.numb_pages_range = numb_pages;
                    myBook.faculty = faculty;
                    myBook.department = department;
                    myBook.type = type;

                    res.Add(myBook);
                }
            }
            return res;
        }
    }
}
