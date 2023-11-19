using System.Xml;

namespace XML_Manager;

public abstract class Parser : IParser
{
    protected IList<Gurtok> Gurtki;
    public IList<Gurtok> Find(FilterOptions filters)
    {
        return Gurtki.Where(filters.ValidateGurtok).ToList();

    }

    public abstract bool Load(Stream inputstream, XmlReaderSettings settings);
}