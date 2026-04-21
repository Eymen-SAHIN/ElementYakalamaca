using static ElementYakalamaca.Data.Elements;

namespace ElementYakalamaca.Data
{
    public class ElementService
    {


        private List<Element> elements = new()
{
    new Element { AtomicNumber = 1, Symbol = "H",  Name = "Hidrojen" },
    new Element { AtomicNumber = 2, Symbol = "He", Name = "Helyum" },
    new Element { AtomicNumber = 3, Symbol = "Li", Name = "Lityum" },
    new Element { AtomicNumber = 4, Symbol = "Be", Name = "Berilyum" },
    new Element { AtomicNumber = 5, Symbol = "B",  Name = "Bor" },
    new Element { AtomicNumber = 6, Symbol = "C",  Name = "Karbon" },
    new Element { AtomicNumber = 7, Symbol = "N",  Name = "Azot" },
    new Element { AtomicNumber = 8, Symbol = "O",  Name = "Oksijen" },
    new Element { AtomicNumber = 9, Symbol = "F",  Name = "Flor" },
    new Element { AtomicNumber = 10, Symbol = "Ne", Name = "Neon" },
    new Element { AtomicNumber = 11, Symbol = "Na", Name = "Sodyum" },
    new Element { AtomicNumber = 12, Symbol = "Mg", Name = "Magnezyum" },
    new Element { AtomicNumber = 13, Symbol = "Al", Name = "Alüminyum" },
    new Element { AtomicNumber = 14, Symbol = "Si", Name = "Silisyum" },
    new Element { AtomicNumber = 15, Symbol = "P",  Name = "Fosfor" },
    new Element { AtomicNumber = 16, Symbol = "S",  Name = "Kükürt" },
    new Element { AtomicNumber = 17, Symbol = "Cl", Name = "Klor" },
    new Element { AtomicNumber = 18, Symbol = "Ar", Name = "Argon" },
    new Element { AtomicNumber = 19, Symbol = "K",  Name = "Potasyum" },
    new Element { AtomicNumber = 20, Symbol = "Ca", Name = "Kalsiyum" },
    new Element { AtomicNumber = 21, Symbol = "Sc", Name = "Skandiyum" },
    new Element { AtomicNumber = 22, Symbol = "Ti", Name = "Titanyum" }
};


        public Element GetRandomElement()
        {
            var rand = new Random();
            return elements[rand.Next(elements.Count)];
        }

        public List<Element> GetOptions(Element correct)
        {
            var rand = new Random();
            var options = elements.OrderBy(x => rand.Next()).Take(3).ToList();
            options.Add(correct);
            return options.OrderBy(x => rand.Next()).ToList();
        }
    }

}

