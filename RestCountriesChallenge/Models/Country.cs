namespace RestCountriesChallenge.Models
{
    public class BRL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Currencies
    {
        public BRL BRL { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
        public string alt { get; set; }
    }

    public class Languages
    {
        public string por { get; set; }
    }

    public class Maps
    {
        public string googleMaps { get; set; }
        public string openStreetMaps { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public NativeName nativeName { get; set; }
    }

    public class NativeName
    {
        public Por por { get; set; }
    }

    public class Por
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Country
    {
        public Name name { get; set; }
        public string cca2 { get; set; }
        public string ccn3 { get; set; }
        public string cca3 { get; set; }
        public string cioc { get; set; }
        public Currencies currencies { get; set; }
        public List<string> capital { get; set; }
        public Languages languages { get; set; }
        public List<string> borders { get; set; }
        public string flag { get; set; }
        public Maps maps { get; set; }
        public int population { get; set; }
        public List<string> timezones { get; set; }
        public Flags flags { get; set; }
    }
}
