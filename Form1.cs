using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLconverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetAllBooks();
        }

        public void GetAllBooks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\projects\SecondLab\XMLconverter\XMLFile1.xml");

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("Book");

            for (int i = 0; i < childNodes.Count; i++)
            {
                XmlNode n = childNodes.Item(i);
                addItems(n);
            }
            string very_old = "1900 - 1960";
            string old = "1961 - 1990";
            string not_old = "1991 - 2005";
            string modern = "2005 - 2015";
            string recent = "2016 - 2021";

            year_cmb.Items.Add(very_old);
            year_cmb.Items.Add(old);
            year_cmb.Items.Add(not_old);
            year_cmb.Items.Add(modern);
            year_cmb.Items.Add(recent);

            string small = "0 - 70";
            string medium = "71 - 150";
            string large = "151 -300";
            string very_large = "301 - 600";

            numb_pages_cmb.Items.Add(small);
            numb_pages_cmb.Items.Add(medium);
            numb_pages_cmb.Items.Add(large);
            numb_pages_cmb.Items.Add(very_large);
        }

        private void addItems(XmlNode n)
        {
            if (!author_cmb.Items.Contains(n.Attributes["AUTHOR"].Value))
                author_cmb.Items.Add(n.Attributes["AUTHOR"].Value);

            if (!faculty_cmb.Items.Contains(n.Attributes["FACULTY"].Value))
                faculty_cmb.Items.Add(n.Attributes["FACULTY"].Value);

            if (!department_cmb.Items.Contains(n.Attributes["DEPARTMENT"].Value))
                department_cmb.Items.Add(n.Attributes["DEPARTMENT"].Value);

            if (!title_cmb.Items.Contains(n.Attributes["TITLE"].Value))
                title_cmb.Items.Add(n.Attributes["TITLE"].Value);

            if (!type_cmb.Items.Contains(n.Attributes["TYPE"].Value))
                type_cmb.Items.Add(n.Attributes["TYPE"].Value);
        }

        private void search()
        {
            Result.Text = "";
            Books book = new Books();
            try
            {
                if (author_cbx.Checked)
                    if (author_cmb.SelectedItem == null)
                    {
                        MessageBox.Show("Оберіть автора");
                        return;
                    }
                book.author = author_cmb.SelectedItem.ToString();

                if (title_cbx.Checked)
                    if (title_cmb.SelectedItem == null)
                    {
                        MessageBox.Show("Оберіть назву");
                        return;
                    }
                book.title = title_cmb.SelectedItem.ToString();

                if (year_cbx.Checked)
                    if (year_cmb.SelectedItem == null)
                    {
                        MessageBox.Show("Оберіть рік");
                        return;
                    }
                book.year_range = year_cmb.SelectedItem.ToString();

                if (type_cbx.Checked)
                    if (type_cmb.SelectedItem == null)
                    {
                        MessageBox.Show("Оберіть вид");
                        return;
                    }
                book.type = type_cmb.SelectedItem.ToString();

                if (faculty_cbx.Checked)
                    if (faculty_cmb.SelectedItem == null)
                    {
                        MessageBox.Show("Оберіть факультет");
                        return;
                    }
                book.faculty = faculty_cmb.SelectedItem.ToString();

                if (department_cbx.Checked)
                    if (department_cmb.SelectedItem == null)
                    {
                        MessageBox.Show("Оберіть кафедру");
                        return;
                    }
                book.department = department_cmb.SelectedItem.ToString();

                if (numb_pages_cbx.Checked)
                    if (numb_pages_cmb.SelectedItem == null)
                    {
                        MessageBox.Show("Оберіть обсяг");
                        return;
                    }
                book.numb_pages_range = numb_pages_cmb.SelectedItem.ToString();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Переконайтеся, що всі параметри вибрані.");
            }

            IAnalyzerXML analyzer;

            if (sax_rb.Checked)
                analyzer = new SaxAnalyzer();
            if (linq_rb.Checked)
                analyzer = new LinqAnalyzer();
            else
                analyzer = new DomAnalyzerXML();

            List<Books> results = analyzer.Search(book);
            foreach (Books b in results)
            {
                Result.Text += "Назва: " + b.title + "\n";
                Result.Text += "Автор: " + b.author + "\n";
                Result.Text += "Рік: " + b.year_range + "\n";
                Result.Text += "Обсяг: " + b.numb_pages_range + "\n";
                Result.Text += "Вид: " + b.type + "\n";
                Result.Text += "Факультет: " + b.faculty + "\n";
                Result.Text += "Кафедра: " + b.department + "\n";

                Result.Text += "\n\n\n";
            }
        }
        private void transform()
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"D:\projects\SecondLab\XMLconverter\XSLTFile1.xslt");

            string fXML = @"D:\projects\SecondLab\XMLconverter\XMLFile1.xml";
            string fHTML = @"D:\projects\SecondLab\XMLFile1.html";
            xct.Transform(fXML, fHTML);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void author_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void transform_btn_Click(object sender, EventArgs e)
        {
            transform();
            MessageBox.Show("Успішно трансформовано!");
        }

        private void dom_rb_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
