using System;
using System.Collections.Generic;
using System.Text;
//File Stream
//will be used everytime you read or write a byte or an array of bytes
using System.IO;
namespace DerekBanasCSharpTut
{
    class Tut21
    {
       public static void Sample(string[] args)
        {
            string filePath = @"C:\Users\Ratul\source\repos\DerekBanasCSharpTut\DerekBanasCSharpTut\text.txt";
            FileStream fs = new FileStream(filePath, FileMode.Create);
            string randomString = "This is a random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randomString);
            fs.Write(rsByteArray, 0, rsByteArray.Length);
            //we have to read it, so chnage the file stream position back to start
            fs.Position = 0;
            byte[] readByteArray = new byte[rsByteArray.Length];
            for(int i = 0; i < readByteArray.Length; i++)
            {
                readByteArray[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine("String was: {0}", Encoding.Default.GetString(readByteArray));
            fs.Close();
            //Stream Writer
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine("This is from stream writer.");
            sw.WriteLine("This is another one from stream writer.");
            sw.Close();
            //Stream Reader
            StreamReader sr = new StreamReader(filePath);
            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st String: {0}", sr.ReadLine());
            Console.WriteLine("Last String: {0}", sr.ReadToEnd());
            sr.Close();

            //BinaryReadWrite
            string filePath2 = @"C:\Users\Ratul\source\repos\DerekBanasCSharpTut\DerekBanasCSharpTut\text.bat";
            FileInfo fi = new FileInfo(filePath2);
            BinaryWriter bw = new BinaryWriter(fi.OpenWrite());
            int myAge = 21;
            double height = 5.4;
            bw.Write(randomString);
            bw.Write(myAge);
            bw.Write(height);
            bw.Close();

            BinaryReader br = new BinaryReader(fi.OpenRead());
            Console.WriteLine("Text: {0}", br.ReadString());
            Console.WriteLine("Age: {0}", br.ReadInt32());
            Console.WriteLine("Height: {0}", br.ReadDouble());
            br.Close();
            
        }
    }
}
