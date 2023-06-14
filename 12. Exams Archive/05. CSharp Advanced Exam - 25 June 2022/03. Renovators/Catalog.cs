using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        //Properties
        public List<Renovator> Renovators { get; set; }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count => Renovators.Count;

        //Constructor
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }

        //Methods
        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if (Count == NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            
            Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            bool isRemoved = Renovators.Remove(Renovators.Find(r => r.Name == name));
            return isRemoved;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            return this.Renovators.RemoveAll(r => r.Type == type);
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = Renovators.Find(r => r.Name == name);
            if (renovator != null)
            {
                renovator.Hired = true;
                return renovator;
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            return Renovators.Where(r => r.Days >= days).ToList();
        }

        public string Report()
        {
            return $"Renovators available for Project {this.Project}:" +
               Environment.NewLine +
               string.Join(Environment.NewLine, this.Renovators.FindAll(r => !r.Hired));
        }
    }
}