using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Registry = new List<Child>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public List<Child> Registry { get; set; }

        public int ChildrenCount => this.Registry.Count;

        public bool AddChild(Child child)
        {
            if (this.ChildrenCount == this.Capacity)
            {
                return false;
            }
            this.Registry.Add(child);
            return true;
        }

        public bool RemoveChild(string fullName) =>
            this.Registry.Remove(this.Registry.FirstOrDefault(x => x.FirstName == fullName.Split(" ")[0] && x.LastName == fullName.Split(" ")[1]));

        public Child GetChild(string childFullName) => this.Registry.FirstOrDefault(x => x.FirstName == childFullName.Split(" ")[0] && x.LastName == childFullName.Split(" ")[1]);
        public string RegistryReport()
        {
            var sortedChildren = this.Registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Registered children in {this.Name}:");

            foreach (var child in sortedChildren)
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
