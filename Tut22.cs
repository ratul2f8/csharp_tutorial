using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Data.SqlTypes;

namespace DerekBanasCSharpTut
{
    class Tut22
    {
        public static void Sample(string[] args)
        {
            Animal22 bower = new Animal22("Bower", 45, 25);
            Stream stream = File.Open("AnimData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, bower);
            bower = null;
            stream.Close();
            stream = File.Open("AnimData.dat", FileMode.Open);
            bower = (Animal22)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine($"{bower.Name} has Height of :{bower.Height} and " +
                $"Weight of : {bower.Weight} ");
            //xml serializer
            //make a change
            bower.Height = 80;
            string filePath = @"C:\Users\Ratul\source\repos\DerekBanasCSharpTut\DerekBanasCSharpTut\animal.xml";
            XmlSerializer xmlSrlzr = new XmlSerializer(typeof(Animal22));
            using (TextWriter tw  = new StreamWriter(filePath))
            {
                xmlSrlzr.Serialize(tw, bower);
            }
            bower = null;
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal22));
            TextReader reader = new StreamReader(filePath);
            object obj = deserializer.Deserialize(reader);
            bower = (Animal22)obj;
            reader.Close();
            Console.WriteLine(bower.ToString());
            //saving list of objects
            List<Animal22> theAnimals = new List<Animal22>
            {
                new Animal22("Mario", 60, 30),
                new Animal22("Luigi", 55, 24),
                new Animal22("Peach", 60, 30)
            };
            string filePath2 = @"C:\Users\Ratul\source\repos\DerekBanasCSharpTut\DerekBanasCSharpTut\theAnimals.xml";
            using (Stream fs = new FileStream(filePath2, FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal22>));
                serializer2.Serialize(fs, theAnimals);
            }
            theAnimals = null;
            using(FileStream fs2 = File.OpenRead(filePath2))
            {
                XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal22>));
                theAnimals = (List<Animal22>)serializer3.Deserialize(fs2);
            }
            foreach( Animal22 anim in theAnimals)
            {
                Console.WriteLine(anim.ToString());
            }

        }
    }
}
