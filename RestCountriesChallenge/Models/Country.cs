namespace RestCountriesChallenge
{
    public class Ara
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bre
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class BRL
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class USD
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class PHP
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class EUR
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class CapitalInfo
    {
        public List<double> latlng { get; set; }
    }

    public class Car
    {
        public List<string> signs { get; set; }
        public string side { get; set; }
    }

    public class Ces
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class CoatOfArms
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Currencies
    {
        public BRL BRL { get; set; }
        public USD USD { get; set; }
        public PHP PHP { get; set; }
        public EUR EUR { get; set; }
    }

    public class Cym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Demonyms
    {
        public Eng eng { get; set; }
        public Fra fra { get; set; }
    }

    public class Deu
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Eng
    {
        public string f { get; set; }
        public string m { get; set; }
    }

    public class Est
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
        public string alt { get; set; }
    }

    public class Fra
    {
        public string official { get; set; }
        public string common { get; set; }
        public string f { get; set; }
        public string m { get; set; }
    }

    public class Hrv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hun
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ita
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jpn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kor
    {
        public string official { get; set; }
        public string common { get; set; }
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

    public class Nld
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Per
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pol
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Por
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class PostalCode
    {
        public string format { get; set; }
        public string regex { get; set; }
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
