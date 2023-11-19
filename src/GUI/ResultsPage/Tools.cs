using XML_Manager;

namespace GUI;

public partial class ResultsPage
{
    public void Display()
    {
        for (int i = 1; i <= Gurtki.Count; i++)
        {
            DisplayResult(Gurtki[i - 1], i);
        }
    }

    private void CreateLabel(int row, int column, string text)
    {
        var label = new Label
        {
            Text = text,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };
        grid.SetRow(label, row);
        grid.SetColumn(label, column);
        grid.Children.Add(label);
    }

    private void DisplayResult(Gurtok gurtok, int row)
    {
        grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
        CreateLabel(row, 0, gurtok.Title);
        CreateLabel(row, 1, gurtok.Faculty);
        CreateLabel(row, 2, gurtok.Department);
        CreateLabel(row, 3, gurtok.Schedule.Day + ", " + gurtok.Schedule.Time);
        CreateLabel(row, 4, gurtok.Leader.FirstName + " " + gurtok.Leader.LastName);
        CreateLabel(row, 5, gurtok.Starosta.FirstName + " " + gurtok.Starosta.LastName);
    }
}