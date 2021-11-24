using System.Collections.Generic;

namespace ExampleAJAX.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
