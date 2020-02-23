using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Laba3
{
    public class LINQ : ISearch
    {

        public static string UpperCaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        private static string getFilePath(string fileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
        }
        private bool Contains(List<XElement> list, string pattern)
        {
            foreach (var elem in list)
                if (elem.Value.Contains(pattern)) return true;
            return false;
        }
        public StringBuilder Search(Items items)
        {
            StringBuilder result = new StringBuilder();
            XDocument xDoc = XDocument.Load(getFilePath(@"D:\2 курс 1 сем\OOP\Laba3\Laba3\bin\Debug\ScientificPublicDatabase.xml"));
            
            //items.faculty = UpperCaseFirst(items.faculty);
            //items.department = UpperCaseFirst(items.department);
            var linqResult = from publ in xDoc.Descendants("ScientificPublic")
                             where
                                 (publ.Element("PIP").Value == items.PIP || items.PIP == "") &&
                                 (publ.Element("faculty").Value.Contains(items.faculty) || items.faculty == "") &&
                                 (publ.Element("department").Value.Contains(items.department) || items.department == "") &&
                                 (Contains(publ.Descendants("publication").ToList(), items.publication) || items.publication == "")
                             select new
                             {
                                 PIP = publ.Element("PIP").Value,
                                 faculty = publ.Element("faculty").Value,
                                 department = publ.Element("department").Value,
                                 publication = publ.Descendants("publication").ToList()
                             };

            foreach (var elem in linqResult)
            {
                string nodePIP = elem.PIP;
                string nodeFaculty = elem.faculty;
                string nodeDepartment = elem.department;
                var publications = elem.publication;
                result.AppendLine();
                result.AppendLine($"{nodePIP}");
                result.AppendLine($"\tФакультет: {nodeFaculty}");
                result.AppendLine($"\tКафедра: {nodeDepartment}");
                result.AppendLine($"\tПублікації: ");
                foreach (XElement publication in publications)
                    result.AppendLine($"\t\t{publication.Value}");
            }
            return result;
        }
    }
}
