using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length - 1; i++) 
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    // Compare people[i] and people[j] using the provided comparison delegate
                    if (comparison(people[i], people[j]) > 0)
                    {
                        //Swap people[i] and people[j] if they are in the wrong order
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                        // people [0] = Alice
                        // people [0] = Bob
                        // people [0] = Charlie
                    }
                }
            }
        }
    }
}
