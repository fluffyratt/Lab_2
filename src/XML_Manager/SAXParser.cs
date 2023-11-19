using System.Xml;

namespace XML_Manager;

public class SAXParser : Parser
{
    public SAXParser()
    {
        Gurtki = new List<Gurtok>();
    }

    public override bool Load(Stream inputStream, XmlReaderSettings settings)
    {
        Gurtki.Clear();
        try
        {
            var reader = XmlReader.Create(inputStream, settings);
            while (reader.Read())
            {
                if (!(reader.NodeType == XmlNodeType.Element && reader.Name == "Gurtok"))
                {
                    continue;
                }

                var gurtok = new Gurtok();
                SkipToText(reader);
                gurtok.Title = reader.Value;
                SkipToText(reader);
                gurtok.Faculty = reader.Value;
                SkipToText(reader);
                gurtok.Department = reader.Value;
                SkipToText(reader);
                gurtok.Schedule.Day = reader.Value;
                SkipToText(reader);
                gurtok.Schedule.Time = reader.Value;
                SkipToText(reader);
                gurtok.Leader.FirstName = reader.Value;
                SkipToText(reader);
                gurtok.Leader.LastName = reader.Value;
                SkipToText(reader);
                gurtok.Starosta.FirstName = reader.Value;
                SkipToText(reader);
                gurtok.Starosta.LastName = reader.Value;

                Gurtki.Add(gurtok);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    private static void SkipToText(XmlReader reader)
    {
        do
        {
            if (!reader.Read())
            {
                throw new Exception();
            }
        } while (reader.NodeType != XmlNodeType.Text);
    }
}
