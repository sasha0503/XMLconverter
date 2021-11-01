using System;
using System.Collections.Generic;
using System.Text;

namespace XMLconverter
{
    interface IAnalyzerXML
    {
        List<Books> Search(Books book);
    }
}