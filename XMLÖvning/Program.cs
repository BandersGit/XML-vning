using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer gunSerializer = new XmlSerializer (typeof(Gun));


            Gun smg = new Gun();

            System.Console.WriteLine("Name your gun!");
            smg.name = Console.ReadLine();

            System.Console.WriteLine("Now set it's damage");
            smg.dmg = Console.ReadLine();

            System.Console.WriteLine("Finally, you need to set it's reload speed");
            smg.reloadSpeed = Console.ReadLine();


            FileStream file = File.Open(@"gun.xml", FileMode.OpenOrCreate);

            gunSerializer.Serialize(file, smg);

            file.Close();
        }
    }
}
