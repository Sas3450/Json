using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Adat
    {
        public List<string> nevek { get; set; }
        public List<int> korok { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = File.ReadAllText("json.json", System.Text.Encoding.Latin1);
            Console.WriteLine(fajl);
            Adat adat = JsonSerializableAttribute.Deserialize<Adat>(fajl);
            foreach (var nev in adat.nevek)
            {
                Console.WriteLine(nev);
            }

            Console.WriteLine($"{adat.nevek[0]} életkora{adat.korok[0]}");
        }
    }
}
