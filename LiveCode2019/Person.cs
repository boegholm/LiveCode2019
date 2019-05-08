using System;

namespace LiveCode2019
{
    class Person  : Object
    {
        public Person()
        {
            Console.WriteLine("Ny person!");
        }
        public Person SetNavn(string navn)
        {
            this.Navn = navn;
            return this;
        }

        public Person SetAlder(int alder)
        {
            Alder = alder;
            return this;
        }

        public string Navn { get; set; }
        public string Efternavn { get; set; }

        public int Alder { get; set; }

        public override string ToString()
        {
            return $"{Navn} {Efternavn} ({Alder})";
        }
    }
}