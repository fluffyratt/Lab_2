using System.Xml;
using System.Xml.Linq;

namespace XML_Manager;

public class LINQParser : Parser
{
    public LINQParser()
    {
        Gurtki = new List<Gurtok>();
    }

    public override bool Load(Stream inputStream, XmlReaderSettings settings)
    {
        XDocument document;
        using var reader = XmlReader.Create(inputStream, settings);
        try
        {
            Gurtki.Clear();
            document = XDocument.Load(reader);
            if (document == null)
            {
                return true;
            }
            var result = from gurtok in document.Descendants("Gurtok")
                         select
            new Gurtok
            {
                Title = gurtok.Element("Title")?.Value ?? "",
                Faculty = gurtok.Element("Faculty")?.Value ?? "",
                Department = gurtok.Element("Department")?.Value ?? "",
                Schedule = new Gurtok.Date
                {
                    Day = gurtok.Element("Schedule")?.Element("day")?.Value ?? "",
                    Time = gurtok.Element("Schedule")?.Element("time")?.Value ?? ""
                },
                Leader = new Gurtok.Person
                {
                    FirstName = gurtok.Element("Leader")?.Element("FirstName")?.Value ?? "",
                    LastName = gurtok.Element("Leader")?.Element("LastName")?.Value ?? ""
                },
                Starosta = new Gurtok.Person
                {
                    FirstName = gurtok.Element("Starosta")?.Element("FirstName")?.Value ?? "",
                    LastName = gurtok.Element("Starosta")?.Element("LastName")?.Value ?? ""
                }
            };
            foreach (var gurtok in result)
            {
                Gurtki.Add(gurtok);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
}
