namespace DefiningClasses;

public class Family
{
	private List<Person> people;

    public Family()
    {
        this.people = new();
    }

    public List<Person> People
	{
		get { return people; }
		set { people = value; }
	}

    public void AddMember(Person person)
	{
		people.Add(person);
	}

    public Person GetOldestMember()
    {
		Person oldestMember = people.MaxBy(member => member.Age);
		return oldestMember;
    }
}
