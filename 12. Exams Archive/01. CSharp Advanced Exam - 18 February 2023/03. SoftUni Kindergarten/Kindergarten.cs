using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        //PROPERTIES
        private string Name { get; set; }   
        private int Capacity { get; set; }
        private List<Child> Registry { get; set; }

        public int ChildrenCount => Registry.Count;

        //METHODS
        public bool AddChild(Child child)
        {
            if (ChildrenCount == Capacity)
            {
                return false;
            }
            Registry.Add(child);
            return true;
        }

        public bool RemoveChild(string childFullName)
        {
            string[] childNames = childFullName.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string firstName = childNames[0];
            string lastName = childNames[1];

            if (Registry.Any(c => c.FirstName == firstName && c.LastName == lastName))
            {
                int index = Registry.FindIndex(c => c.FirstName == firstName && c.LastName == lastName);
                Registry.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Child GetChild(string childFullName)
        {
            string[] childNames = childFullName.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string firstName = childNames[0];
            string lastName = childNames[1];

            if (Registry.Any(c => c.FirstName == firstName && c.LastName == lastName))
            {
                int index = Registry.FindIndex(c => c.FirstName == firstName && c.LastName == lastName);
                return Registry[index];
            }
            else
            {
                return null;
            }
        }

        public string RegistryReport()
        {
            StringBuilder children = new StringBuilder();
            children.AppendLine($"Registered children in {Name}");
            
            foreach (Child child in Registry.OrderByDescending(c => c.Age)
                .ThenBy(c => c.LastName).ThenBy(c => c.FirstName))
            {
                children.AppendLine($"Child: {child.FirstName} {child.LastName}, Age: {child.Age}, Contact info: {child.ParentName} - {child.ContactNumber}");
            }
            return children.ToString();
        }
    }
}
