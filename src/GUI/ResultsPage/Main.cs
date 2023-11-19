using XML_Manager;

namespace GUI;

public partial class ResultsPage : ContentPage
{
    private IList<Gurtok> Gurtki { get; set; }
    public ResultsPage(IList<Gurtok> gurtki)
    {
        InitializeComponent();
        Gurtki = gurtki;
        Display();
    }
}