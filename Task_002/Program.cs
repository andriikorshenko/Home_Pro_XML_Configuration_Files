using System.Xml;

XmlDocument xDoc = new XmlDocument();
xDoc.Load(@"C:\Users\Admin\Desktop\Pro\Home_005\Task_006\bin\Debug\net6.0\TelephoneBook.xml");

XmlElement? xRoot = xDoc.DocumentElement;
if (xRoot != null)
{
    foreach (XmlElement xNode in xRoot)
    {
        XmlNode? attr = xNode.Attributes.GetNamedItem("TelephoneNumber");
        Console.WriteLine("Telephone number : " + attr?.Value);

        foreach (XmlElement childNode in xNode.ChildNodes)
        {
            if (childNode.Name == "Name")
            {
                Console.WriteLine($"Name : " + childNode.InnerText);
            }
        }
    }
}