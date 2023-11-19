namespace XML_Manager;

public class Gurtok
{
    public class Person
    {
        public Person()
        {
            FirstName = "";
            LastName = "";
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class Date
    {
        public string Day { get; set; }
        public string Time { get; set; }

        public Date()
        {
            Day = "";
            Time = "";
        }
    }
    public Gurtok()
    {
        Title = "";
        Faculty = "";
        Department = "";
        Leader = new();
        Schedule = new();
        Starosta = new();
    }
    public string Title { get; set; }

    public string Faculty { get; set; }

    public string Department { get; set; }

    public Person Leader { get; set; }

    public Person Starosta { get; set; }

    public Date Schedule { get; set; }
}
