using System.Xml.Linq;

var xdoc = new XDocument(new XElement("MyContacts",
    new XElement("Contact",
        new XAttribute("TelephoneNumber", "+380936769984"),
        new XElement("Name", "John J. Miller"))));
xdoc.Save(@"TelephoneBook.xml");

Console.WriteLine("The file has been updated!");