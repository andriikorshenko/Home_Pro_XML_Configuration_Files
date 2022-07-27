using System.Xml.Linq;

XDocument xDoc = XDocument.Load(@"C:\Users\Admin\Desktop\Pro\Home_005\Task_006\bin\Debug\net6.0\TelephoneBook.xml");

var telephoneNumbers = xDoc.Element("MyContacts")?
    .Elements("Contact")
    .Select(x => new
    {
        telephoneNumber = x.Attribute("TelephoneNumber")?.Value
    });

if (telephoneNumbers is not null)
{
    foreach (var item in telephoneNumbers)
    {
        Console.WriteLine(item.telephoneNumber);
    }
}