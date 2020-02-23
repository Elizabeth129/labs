using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Laba3
{
    public class DOM : ISearch
    {
        private static string getFilePath(string fileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
        }
        public StringBuilder Search(Items items)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(getFilePath(@"D:\2 курс 1 сем\OOP\Laba3\Laba3\bin\Debug\ScientificPublicDatabase.xml"));
            string xpath = "/ScientificPublicDatabase/ScientificPublic";
            //items.faculty = UpperCaseFirst(items.faculty);
            //items.department = UpperCaseFirst(items.department);
            if (items.id != "") xpath += $"[@id={items.id}]";
            if (items.PIP != "") xpath += $"[PIP[contains(text(), '{items.PIP}')]]";
            if (items.faculty != "") xpath += $"[faculty[contains(text(),'{items.faculty}')]]";
            if (items.department != "") xpath += $"[department[contains(text(), '{items.department}')]]";
            if (items.publication != "") xpath += $"[publication[contains(text(),'{items.publication}')]]";
           
            var elem = xDoc.SelectNodes(xpath);
            StringBuilder result = new StringBuilder();
            foreach (XmlNode node in elem)
            {
                string nodePIP = node.SelectSingleNode("descendant::PIP").InnerText.ToString();
                string nodeFaculty = node.SelectSingleNode("faculty").InnerText.ToString();
                string nodeDepartment = node.SelectSingleNode("department").InnerText.ToString();
                var publications = node.SelectNodes("publication");
              
                result.AppendLine();
                result.AppendLine($"{nodePIP}");
                result.AppendLine($"\tФакультет: {nodeFaculty}");
                result.AppendLine($"\tКафедра: {nodeDepartment}");
                result.AppendLine($"\tПублікації: ");
                //MessageBox.Show("Ok");
                foreach (XmlNode publ in publications)
                {
                    result.AppendLine($"\t\t{publ.InnerText.ToString()}");
                   
                }
               
            }
            return result;
        }
        public static string UpperCaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
