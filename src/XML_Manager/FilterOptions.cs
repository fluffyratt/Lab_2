namespace XML_Manager;

public struct FilterOptions
{
    public string Title { get; set; }

    public string Faculty { get; set; }

    public string Department { get; set; }

    public string Leader { get; set; }

    public string Starosta { get; set; }

    public string Schedule { get; set; }

    public FilterOptions()
    {
        Title = "";
        Department = "";
        Faculty = "";
        Leader = "";
        Starosta = "";
        Schedule = "";
    }

    public readonly bool ValidateGurtok(Gurtok gurtok)
    {
        var title = gurtok.Title.ToLower().Contains(Title.ToLower());
        var department = gurtok.Department.ToLower().Contains(Department.ToLower());
        var faculty = gurtok.Faculty.ToLower().Contains(Faculty.ToLower());
        var schedule = (gurtok.Schedule.Day + " " + gurtok.Schedule.Time).ToLower().Contains(Schedule.ToLower());
        var starosta = (gurtok.Starosta.FirstName + " " + gurtok.Starosta.LastName).ToLower().Contains(Starosta.ToLower());
        var leader = (gurtok.Leader.FirstName + " " + gurtok.Leader.LastName).ToLower().Contains(Leader.ToLower());

        return title && department && faculty && schedule && starosta && leader;
    }
}
