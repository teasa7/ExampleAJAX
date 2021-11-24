namespace ExampleAJAX.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int IDCountry { get; set; }
        public Country Country { get; set; }
    }
}
