using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Xsl;

namespace Laba3
{
    public class Transform
    {
        public static void Transf()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            string f1 = getFilePath(@"D:\2 курс 1 сем\OOP\Laba3\Laba3\bin\Debug\input.xsl");
            xslt.Load(f1);
            // Виконання перетворення і виведення результатів у файл.
            string f2 = getFilePath(@"D:\2 курс 1 сем\OOP\Laba3\Laba3\bin\Debug\ScientificPublicDatabase.xml");
            string f3 = getFilePath(@"D:\2 курс 1 сем\OOP\Laba3\Laba3\bin\Debug\ScientificPublicDatabase.html");
            xslt.Transform(f2, f3);
        }
        private static string getFilePath(string fileName)
        {
            return Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.Desktop), fileName);
        }
    }
}
