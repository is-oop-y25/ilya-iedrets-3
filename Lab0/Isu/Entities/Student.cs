namespace Isu.Entities;

public class Student
{
    private int _id;

    public Student(string firstName, string lastName, DateTime dateBirth)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentException("firstName");
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("lastName");
        }

        if (dateBirth > DateTime.Now)
        {
            throw new ArgumentException("dateBirth");
        }

        FirstName = firstName;
        LastName = lastName;
        DateBirth = dateBirth;
    }

    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Id");
            }

            _id = value;
        }
    }

    public string FirstName { get; }

    public string LastName { get; }

    public Group? Group { get; set; }

    public DateTime DateBirth { get; }
}
