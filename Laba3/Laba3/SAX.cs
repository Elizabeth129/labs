using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Laba3
{
    public class SAX : ISearch
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
        struct Node
        {
            public string id;
            public string PIP;
            public string faculty;
            public string department;
            public List<string> publication;
        }
        public static bool Contains(List<string> list, string pattern)
        {
            if (pattern == null) return false;
            foreach (string text in list)
                if (text != null && text.Contains(pattern)) return true;
            return false;
        }
        private void Add(List<Node> ans, Node cur, Items items)
        {
            //items.faculty = UpperCaseFirst(items.faculty);
            //items.department = UpperCaseFirst(items.department);
            if ((Contains(cur.publication, items.publication) || items.publication == "") &&
                                    (cur.PIP == items.PIP || items.PIP == "") &&
                                    (cur.id == items.id || items.id == "") &&
                                    (cur.faculty.Contains(items.faculty) || items.faculty == "") &&
                                    (cur.department.Contains(items.department) || items.department == "") 
                                   
                                   )
                ans.Add(cur);
        }
        public StringBuilder Search(Items items)
        {
            StringBuilder result = new StringBuilder();
            var xmlReader = new XmlTextReader(getFilePath(@"D:\2 курс 1 сем\OOP\Laba3\Laba3\bin\Debug\ScientificPublicDatabase.xml"));
            List<Node> ans = new List<Node>();
            Node cur = new Node
            {
                PIP = "",
                publication = new List<string>(),
                
            };
            string temp = "";
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.XmlDeclaration: break;
                    case XmlNodeType.Comment: break;
                    case XmlNodeType.Element:
                        temp = xmlReader.Name;
                        if (temp == "ScientificPublic")
                        {
                            if (cur.PIP != "")
                            {
                                Add(ans, cur, items);
                                cur = new Node
                                {
                                    PIP = "",
                                    publication = new List<string>(),
                                   
                                };
                            }
                        }
                        break;
                    case XmlNodeType.Text:
                        switch (temp)
                        {
                            case "PIP":
                                cur.PIP = xmlReader.Value;
                                break;
                            case "faculty":
                                cur.faculty = xmlReader.Value;
                                break;
                           
                            case "department":
                                cur.department = xmlReader.Value;
                                break;
                            case "publication":
                                cur.publication.Add(xmlReader.Value);
                                break;
                            default:
                                break;
                        }
                        break;
                }
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        temp = xmlReader.Name;
                        if (temp == "PIP") cur.PIP = xmlReader.Value;
                    }
                }
            }
            Add(ans, cur, items);
            xmlReader.Close();
            foreach (var elem in ans)
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
                foreach (string publication in publications)
                    result.AppendLine($"\t\t{publication}");
                
            }
            return result;
        }
    }
}