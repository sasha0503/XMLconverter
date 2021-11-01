using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Linq;

namespace XMLconverter
{
    class SaxAnalyzer : IAnalyzerXML
    {
        public List<Books> Search(Books book)
        {
            List<Books> res = new List<Books>();
            var xmlReader = new XmlTextReader(@"D:\projects\SecondLab\XMLconverter\XMLFile1.xml");
            while(xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while(xmlReader.MoveToNextAttribute())
                    {
                        string author = "";
                        string title = "";
                        string year = "";
                        string numb_pages = "";
                        string type = "";
                        string faculty = "";
                        string department = "";

                        if (xmlReader.Name.Equals("AUTHOR") && (book.author.Equals(String.Empty) || book.author.Equals(xmlReader.Value)))
                        {
                            author = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("TITLE") && (book.title.Equals(String.Empty) || book.title.Equals(xmlReader.Value)))
                            {
                                title = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("TYPE") && (book.type.Equals(String.Empty) || book.type.Equals(xmlReader.Value)))
                                {
                                    type = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("FACULTY") && (book.faculty.Equals(String.Empty) || book.faculty.Equals(xmlReader.Value)))
                                    {
                                        faculty = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();

                                        if (xmlReader.Name.Equals("DEPARTMENT") && (book.department.Equals(String.Empty) || book.department.Equals(xmlReader.Value)))
                                        {
                                            department = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();

                                            if (xmlReader.Name.Equals("YEAR") && (YearsNPages.CompareYears(book, xmlReader)))
                                            {
                                                type = xmlReader.Value;
                                                xmlReader.MoveToNextAttribute();

                                                if (xmlReader.Name.Equals("NUMB_PAGES") && (YearsNPages.ComparePages(book, xmlReader)))
                                                {
                                                    type = xmlReader.Value;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
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
                }
            }
            xmlReader.Close();
            return res;
        }
    }
}
