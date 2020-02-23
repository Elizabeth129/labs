using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), @"D:\2 курс 1 сем\OOP\Laba3\Laba3\bin\Debug\ScientificPublicDatabase.xml"));
            string xpath = "/ScientificPublicDatabase/ScientificPublic";
            Items item = new Items();
            var elem = xDoc.SelectNodes(xpath);
            StringBuilder result = new StringBuilder();
            foreach (XmlNode node in elem)
            {
                string nodePIP = node.SelectSingleNode("descendant::PIP").InnerText.ToString();
                this.comboBox1.Items.AddRange(new string[] { nodePIP } );

                           }
          //  this.comboBox1.Items.AddRange(new string[] { "Номіровський Дмитро Анатолійович", "Макушенко Ігор Анатолійович", "Молодцов Олександр Ілліч", "Станжицький Олександр Миколайович" });
           
            this.comboBox4.Items.AddRange(new string[] { "DOM", "SAX", "LINQ to XML" });
            comboBox4.Text = "DOM";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Items item = new Items();
            if (checkBoxPIP.Checked == true) item.PIP = comboBox1.Text.ToString();
            if (checkBoxFaculty.Checked == true) item.faculty = textBox1.Text.ToString();
            if (checkBoxDep.Checked == true) item.department = textBox2.Text.ToString();
            
            string method = comboBox4.Text.ToString();
            StringBuilder sb = SearchButton(item, method);
            var s = sb.ToString().Split('\n');
            foreach (string st in s)
                listBox1.Items.Add(st.ToString());
        }
        public static StringBuilder SearchButton(Items item, string method)
        {
            Find Finder = new Find();
            if (method == "DOM") Finder.Searching = new DOM();
            else if (method == "SAX") Finder.Searching = new SAX();
            else Finder.Searching = new LINQ();
            return Finder.Search(item);
        }

        private void CheckBoxFaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFaculty.Checked == true) textBox1.ReadOnly = false;
            if (!checkBoxFaculty.Checked) { textBox1.ReadOnly = true; textBox1.Text = ""; }
        }

        private void CheckBoxPIP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPIP.Checked == true)
            {
                comboBox1.Enabled = true;
                comboBox1.Text = "";
            }
            else comboBox1.Enabled = false;
        }

        private void CheckBoxDep_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDep.Checked == true) textBox2.ReadOnly = false;
            if (!checkBoxDep.Checked) { textBox2.ReadOnly = true; textBox2.Text = ""; }
        }
        class Find
        {
            public Find()
            {
            }

            public ISearch Searching { get; set; }
            public StringBuilder Search(Items items)
            {
                return Searching.Search(items);
            }
        }

        private void ButtonToHTML_Click(object sender, EventArgs e)
        {
            Transform.Transf();
        }
    }
    interface ISearch
    {

        StringBuilder Search(Items items);
    }
}
